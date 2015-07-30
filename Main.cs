using System;
using Gtk;

namespace monostarter
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			string s = "asdsa";
			Application.Run ();
		}
	}
}
