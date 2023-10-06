namespace Enhancer
{
	internal static class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			Config.LoadConfig();
			ApplicationConfiguration.Initialize();
			Application.Run(new Form1(args.Length > 0 ? args[0] : null));
		}
	}
}