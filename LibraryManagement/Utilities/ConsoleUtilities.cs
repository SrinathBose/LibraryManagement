using System;

namespace LibraryManagement
{
	public static class ConsoleUtilities
	{
		/// <summary>
		/// Draw Cconsole border 
		/// </summary>
		public static void DrawConsoleBorder()
		{
			int x = Console.LargestWindowWidth;
			for (int i = 0; i < x; i++) {
				Console.Write ("*");
			}

			x = Console.LargestWindowWidth;
			for (int i = 0; i < x; i++) {
				Console.SetCursorPosition (0+i, Console.LargestWindowHeight-1);
				Console.Write ("*");
			}

			x = Console.LargestWindowHeight;
			for (int i = 0; i < x; i++) {
				Console.SetCursorPosition (Console.WindowWidth-1, Console.WindowTop+i);
				Console.WriteLine ("*");
			}
			Console.SetCursorPosition (0,0);

			x = Console.LargestWindowHeight;
			for (int i = 0; i < x-1; i++) {
				Console.WriteLine ("*");
			}

			Console.SetCursorPosition (Console.WindowWidth/2, Console.WindowTop+2);
		}

		/// <summary>
		/// Write a given text in center of the screen.
		/// </summary>
		/// <param name="text">Text.</param>
		public static void WriteLineInCenter(string text)
		{
			Console.SetCursorPosition ((Console.WindowWidth-text.Length)/2, Console.CursorTop);
			Console.WriteLine (text);
		}

		public static void WriteLineWithIndent(string text)
		{
			Console.WriteLine ("\t\t\t" + text);
		}

		public static void WriteTitle(string text)
		{
			WriteTitleDesign (text.Length);
			WriteLineInCenter (text);
			WriteTitleDesign (text.Length);
		}

		private static void WriteTitleDesign(int length)
		{
			Console.SetCursorPosition ((Console.WindowWidth-length)/2, Console.CursorTop);

			while (length-- > 0)
				Console.Write ("~");

			Console.WriteLine ();
		}
	}
}