namespace Enhancer
{
	public partial class EditConfig : Form
	{
		public EditConfig()
		{
			InitializeComponent();
			qemu.Text = Config.qemu;
			nasm.Text = Config.nasm;
		}
		private void ok_Click(object sender, EventArgs e)
		{
			Config.qemu = qemu.Text;
			Config.nasm = nasm.Text;
			Close();
		}
		private void cancel_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void qemuBrowse_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				qemu.Text = openFileDialog1.FileName;
			}
		}
		private void nasmBrowse_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				nasm.Text = openFileDialog1.FileName;
			}
		}
	}
}