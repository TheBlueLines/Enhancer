namespace Enhancer
{
	public partial class Name : Form
	{
		public string? txt = null;
		public Name()
		{
			InitializeComponent();
		}
		private void SaveAndExit()
		{
			txt = text.Text;
			Close();
		}
		private void create_Click(object sender, EventArgs e)
		{
			SaveAndExit();
		}
		private void text_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				SaveAndExit();
			}
		}
	}
}