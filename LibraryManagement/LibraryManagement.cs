using System;
using System.Data.SQLite;
using System.Data.Entity;

namespace LibraryManagement
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			DatabaseManager db = new DatabaseManager ();
			ConsoleUtilities.DrawConsoleBorder ();
			Console.Title = "Library Management System";
			ConsoleUtilities.WriteTitle ("SRINATH E-LIBRARY");
			Console.WriteLine ("\n\n\n");
			ConsoleUtilities.WriteLineWithIndent ("Select your Choice ...");
			ConsoleUtilities.WriteLineWithIndent ("1-> Login");
			ConsoleUtilities.WriteLineWithIndent ("2-> Register");
			ConsoleUtilities.WriteLineWithIndent ("3-> About Us\n");
			ConsoleUtilities.WriteLineWithIndent ("4-> Exit");

			byte choice = Convert.ToByte (Console.ReadLine ());

			switch (choice) {
			case 1:
				var login = new Login ();

				break;
			case 2:
				break;
			case 3:
				break;
			case 4:
				Environment.Exit (0);
				break;
			}
		}
	}
}
