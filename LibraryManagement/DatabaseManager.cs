using System;
using System.IO;
using System.Data.SQLite;
using System.Data.Entity;

namespace LibraryManagement
{
	public class DatabaseManager
	{
		SQLiteConnection _connection;
		SQLiteCommand _command;

		public DatabaseManager()
		{
			CreateDatabase ();
		}
		void CreateDatabase()
		{
			string workingPath = Directory.GetCurrentDirectory ();
			string sqlitePath = Path.Combine (workingPath, "LibraryManagement.sqlite");

			if(!File.Exists (sqlitePath))
			{

				_connection = new SQLiteConnection ("Data Source="+sqlitePath+";version=3;");
				//_connection.Open ();
			}
		}
	}
}