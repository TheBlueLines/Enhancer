using Debris;
using System.Diagnostics;

namespace Enhancer
{
	public partial class Form1 : Form
	{
		public string? path = null;
		private List<string> files = new();
		private int? nzx = null;
		public Form1()
		{
			InitializeComponent();
			plus.Enabled = true;
		}
		private void plus_Click(object sender, EventArgs e)
		{
			Name x = new();
			x.ShowDialog();
			if (!string.IsNullOrEmpty(x.txt))
			{
				if (!list.Items.Contains(x.txt))
				{
					list.Items.Add(x.txt);
					files.Add(string.Empty);
				}
			}
		}
		private void minus_Click(object sender, EventArgs e)
		{
			text.Enabled = false;
			minus.Enabled = false;
			int index = list.SelectedIndex;
			if (index >= 0)
			{
				files.RemoveAt(index);
				list.Items.RemoveAt(index);
			}
		}
		private void list_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool check = list.SelectedIndex >= 0;
			text.Enabled = check;
			minus.Enabled = check;
			if (check)
			{
				if (nzx != null)
				{
					files[nzx.Value] = text.Text;
				}
				nzx = list.SelectedIndex;
				text.Text = files[nzx.Value];
			}
		}
		private void save_Click(object sender, EventArgs e)
		{
			List<byte[]> bytes = new();
			for (int i = 0; i < list.Items.Count; i++)
			{
				string? name = list.Items[i].ToString();
				string data = files[i];
				if (!string.IsNullOrEmpty(name))
				{
					string[] tmp = { name, data };
					bytes.Add(Engine.SerializeStringArray(tmp));
				}
			}
			byte[] file = Engine.SerializeByteArray(bytes.ToArray());
			if (string.IsNullOrEmpty(path))
			{
				DialogResult resp = saveFileDialog1.ShowDialog();
				if (resp == DialogResult.OK)
				{
					path = saveFileDialog1.FileName;
				}
			}
			if (!string.IsNullOrEmpty(path))
			{
				File.WriteAllBytes(path, Engine.Zip(file));
			}
		}
		private void load_Click(object sender, EventArgs e)
		{
			DialogResult resp = openFileDialog1.ShowDialog();
			if (resp == DialogResult.OK)
			{
				path = openFileDialog1.FileName;
				LoadFile();
			}
		}
		public void LoadFile()
		{
			list.Items.Clear();
			files.Clear();
			if (File.Exists(path))
			{
				byte[] file = Engine.Unzip(File.ReadAllBytes(path));
				byte[][] temp = Engine.DeserializeByteArray(file);
				foreach (byte[] value in temp)
				{
					string[] tmp = Engine.DeserializeStringArray(value);
					files.Add(tmp[1]);
					list.Items.Add(tmp[0]);
				}
			}
		}
		private void build_Click(object sender, EventArgs e)
		{
			build.Enabled = false;
			List<byte> os = new();
			save_Click(sender, e);
			Directory.CreateDirectory(Path.GetTempPath() + "Enhancer\\Source");
			Directory.CreateDirectory(Path.GetTempPath() + "Enhancer\\Binaries");
			for (int i = 0; i < list.Items.Count; i++)
			{
				File.WriteAllText(Path.Combine(Path.GetTempPath(), "Enhancer\\Source\\") + list.Items[i] + ".asm", files[i]);
				Process process = new();
				process.StartInfo = new ProcessStartInfo() { FileName = "nasm", Arguments = "-f bin \"" + Path.Combine(Path.GetTempPath(), "Enhancer\\Source\\") + list.Items[i] + ".asm\" -o \"" + Path.Combine(Path.GetTempPath(), "Enhancer\\Binaries\\") + list.Items[i] + ".bin\"", CreateNoWindow = true, WindowStyle = ProcessWindowStyle.Hidden };
				process.Start();
				process.WaitForExit();
				process.Dispose();
				byte[] data = File.ReadAllBytes(Path.Combine(Path.GetTempPath(), "Enhancer\\Binaries\\") + list.Items[i] + ".bin");
				if (os.Count == 0)
				{
					data[510] = 0x55;
					data[511] = 0xaa;
				}
				os.AddRange(Filler(data));
			}
			Directory.Delete(Path.GetTempPath() + "Enhancer", true);
			File.WriteAllBytes(Path.GetFileNameWithoutExtension(path) + ".iso", os.ToArray());
			build.Enabled = true;
		}
		private byte[] Filler(byte[] data)
		{
			List<byte> bytes = new();
			bytes.AddRange(data);
			while (bytes.Count % 512 != 0)
			{
				bytes.Add(0x00);
			}
			return bytes.ToArray();
		}
	}
}