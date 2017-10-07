using System;

namespace LibraryManagement
{
	public class Login
	{
		public Login ()
		{
			Console.Clear ();
			ConsoleUtilities.DrawConsoleBorder ();
			ConsoleUtilities.WriteTitle ("LOGIN");
			StartLogin ();
		}

		void StartLogin ()
		{
		//	throw new NotImplementedException ();
		}

		void ValidateUser()
		{
			
		}

		void GetUser()
		{
			string username, password;

			ConsoleUtilities.WriteLineWithIndent ("Enter the username : ");
			username = Console.ReadLine ();
			ConsoleUtilities.WriteLineWithIndent ("Enter the password : ");
			password = Console.ReadLine ();
		}
	}
}

