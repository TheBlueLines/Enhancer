namespace Enhancer
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Form1 form1 = new();
			if (args.Length > 0)
			{
				form1.path = args[0];
			}
			form1.LoadFile();
			Application.Run(form1);
		}
	}
}