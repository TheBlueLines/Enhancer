namespace Enhancer
{
	public class Config
	{
		public static string configPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\config.cfg";
		public static string qemu = "C:\\Program Files\\qemu\\qemu-system-x86_64.exe";
		public static string nasm = "C:\\Program Files\\NASM\\nasm.exe";
		public static void LoadConfig()
		{
			if (File.Exists(configPath))
			{
				foreach (string raw in File.ReadLines(configPath))
				{
					string line = Crimp(raw);
					if (!line.StartsWith('#') && line.Contains("="))
					{
						string[] temp = line.Split('=');
						if (temp[0] == "qemu" && temp[1].StartsWith('\"') && temp[1].EndsWith('\"'))
						{
							qemu = temp[1][1..][..^1];
						}
						else if (temp[0] == "nasm" && temp[1].StartsWith('\"') && temp[1].EndsWith('\"'))
						{
							nasm = temp[1][1..][..^1];
						}
					}
				}
				return;
			}
			SaveConfig();
			LoadConfig();
		}
		public static void SaveConfig()
		{
			string[] lines = new string[] { "# TTMC Enhancer Config File", "# Created on: " + DateTime.Now, "", $"qemu = \"{qemu}\"", $"nasm = \"{nasm}\"" };
			File.WriteAllLines(configPath, lines);
		}
		public static string Crimp(string text)
		{
			string resp = string.Empty;
			bool allow = false;
			for (int i = 0; i < text.Length; i++)
			{
				if (text[i] != ' ' || allow)
				{
					if (text[i] == '\"')
					{
						allow = !allow;
					}
					resp += text[i];
				}
			}
			return resp;
		}
	}
}