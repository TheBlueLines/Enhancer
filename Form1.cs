using Debris;
using System.Diagnostics;

namespace Enhancer
{
	public partial class Form1 : Form
	{
		private bool good = true;
		private string? path = null;
		private List<string> files = new();
		private int? nzx = null;
		public Form1(string? path = null)
		{
			this.path = path;
			InitializeComponent();
			LoadFile(path);
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
		public void LoadFile(string? path = null)
		{
			nzx = null;
			text.Enabled = false;
			minus.Enabled = false;
			list.Items.Clear();
			files.Clear();
			if (!string.IsNullOrEmpty(path) && File.Exists(path))
			{
				Text = $"Enhancer [{Path.GetFileName(path)}]";
				byte[] file = Engine.Unzip(File.ReadAllBytes(path));
				byte[][] temp = Engine.DeserializeByteArray(file);
				foreach (byte[] value in temp)
				{
					string[] tmp = Engine.DeserializeStringArray(value);
					list.Items.Add(tmp[0]);
					files.Add(tmp[1]);
				}
			}
		}
		private void DataReceived(object sender, DataReceivedEventArgs e)
		{
			if (!string.IsNullOrEmpty(e.Data))
			{
				good = false;
				int x = e.Data.LastIndexOf(Path.DirectorySeparatorChar);
				string tmp = e.Data[(x + 1)..];
				MessageBox.Show(tmp, "Compile Error");
			}
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
			if (File.Exists(ttmc) && good)
			{
				Process process = new();
				process.StartInfo = new()
				{
					FileName = Config.qemu,
					Arguments = "-drive format=raw,file=\"" + ttmc + "\"",
					WorkingDirectory = Directory.GetCurrentDirectory()
				};
				process.Start();
				process.WaitForExit();
				process.Dispose();
			}
		}
		private void Basic(object? sender, KeyEventArgs e)
		{
			if (sender != null && e.Modifiers == Keys.Control)
			{
				if (e.KeyCode == Keys.S)
				{
					SaveFile(path);
				}
				else if (e.KeyCode == Keys.O)
				{
					openToolStripMenuItem_Click(sender, e);
				}
				else if (e.KeyCode == Keys.B)
				{
					buildToolStripMenuItem_Click(sender, e);
				}
				else if (e.KeyCode == Keys.F5)
				{
					buildToolStripMenuItem_Click(sender, e);
					StartQemu();
				}
			}
		}
		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult resp = openFileDialog1.ShowDialog();
			if (resp == DialogResult.OK)
			{
				string? temp = Path.GetDirectoryName(openFileDialog1.FileName);
				if (!string.IsNullOrEmpty(temp))
				{
					path = openFileDialog1.FileName;
					Directory.SetCurrentDirectory(temp);
					LoadFile(path);
				}
			}
		}
		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFile(path);
		}
		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFile();
		}
		private void SaveFile(string? fileName = null)
		{
			if (nzx != null)
			{
				files[nzx.Value] = text.Text;
			}
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
			if (string.IsNullOrEmpty(fileName))
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
		}
		private void buildToolStripMenuItem_Click(object sender, EventArgs e)
		{
			good = true;
			List<byte> os = new();
			SaveFile(path);
			Directory.CreateDirectory(Path.GetTempPath() + "Enhancer\\Source");
			Directory.CreateDirectory(Path.GetTempPath() + "Enhancer\\Binaries");
			for (int i = 0; i < list.Items.Count; i++)
			{
				File.WriteAllText(Path.Combine(Path.GetTempPath(), "Enhancer\\Source\\") + list.Items[i] + ".asm", files[i]);
				Process process = new();
				process.StartInfo = new ProcessStartInfo() { CreateNoWindow = true, WindowStyle = ProcessWindowStyle.Hidden };
				process.StartInfo.FileName = Config.nasm;
				process.StartInfo.Arguments = "-f bin \"" + Path.Combine(Path.GetTempPath(), "Enhancer\\Source\\") + list.Items[i] + ".asm\" -o \"" + Path.Combine(Path.GetTempPath(), "Enhancer\\Binaries\\") + list.Items[i] + ".bin\"";
				process.EnableRaisingEvents = true;
				process.OutputDataReceived += new DataReceivedEventHandler(DataReceived);
				process.ErrorDataReceived += new DataReceivedEventHandler(DataReceived);
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.RedirectStandardError = true;
				process.Start();
				process.BeginErrorReadLine();
				process.BeginOutputReadLine();
				process.WaitForExit();
				process.Dispose();
				byte[] raw = File.ReadAllBytes(Path.Combine(Path.GetTempPath(), "Enhancer\\Binaries\\") + list.Items[i] + ".bin");
				byte[] data = Filler(raw);
				if (os.Count == 0)
				{
					if (raw.Length <= 510)
					{
						data[510] = 0x55;
						data[511] = 0xaa;
					}
					else
					{
						MessageBox.Show("Boot sector is too big", "General Error");
						good = false;
						return;
					}
				}
				os.AddRange(data);
			}
			Directory.Delete(Path.GetTempPath() + "Enhancer", true);
			File.WriteAllBytes(Path.GetFileNameWithoutExtension(path) + ".iso", os.ToArray());
		}
		private void configToolStripMenuItem_Click(object sender, EventArgs e)
		{
			EditConfig editConfig = new();
			editConfig.ShowDialog();
		}
	}
}