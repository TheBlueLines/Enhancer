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
			foreach (Control ctrl in Controls)
			{
				ctrl.KeyDown += new KeyEventHandler(Basic);
			}
			KeyDown += new KeyEventHandler(Basic);
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
			save.Enabled = false;
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
					string? temp = Path.GetDirectoryName(saveFileDialog1.FileName);
					if (!string.IsNullOrEmpty(temp))
					{
						path = saveFileDialog1.FileName;
						Directory.SetCurrentDirectory(temp);
					}
				}
			}
			if (!string.IsNullOrEmpty(path))
			{
				File.WriteAllBytes(path, Engine.Zip(file));
			}
			save.Enabled = true;
		}
		private void load_Click(object sender, EventArgs e)
		{
			load.Enabled = false;
			DialogResult resp = openFileDialog1.ShowDialog();
			if (resp == DialogResult.OK)
			{
				string? temp = Path.GetDirectoryName(openFileDialog1.FileName);
				if (!string.IsNullOrEmpty(temp))
				{
					path = openFileDialog1.FileName;
					Directory.SetCurrentDirectory(temp);
					LoadFile();
				}
			}
			load.Enabled = true;
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
		private void StartQemu()
		{
			string ttmc = Path.GetFileNameWithoutExtension(path) + ".iso";
			if (File.Exists(ttmc))
			{
				Process process = new();
				process.StartInfo = new() { FileName = "qemu-system-x86_64", Arguments = "-drive format=raw,file=\"" + ttmc + "\"", WorkingDirectory = Directory.GetCurrentDirectory() };
				process.Start();
				process.WaitForExit();
				process.Dispose();
			}
		}
		private void Basic(object? sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.Control)
			{
				if (e.KeyCode == Keys.S)
				{
					save_Click(sender, e);
				}
				else if (e.KeyCode == Keys.O)
				{
					load_Click(sender, e);
				}
				else if (e.KeyCode == Keys.B)
				{
					build_Click(sender, e);
				}
				else if (e.KeyCode == Keys.F5)
				{
					build_Click(sender, e);
					StartQemu();
				}
			}
		}
	}
}