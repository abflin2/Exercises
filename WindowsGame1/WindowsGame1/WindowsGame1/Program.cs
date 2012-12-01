using System;
using System.Windows.Forms;
using Microsoft.Xna.Framework.Graphics;

namespace WindowsGame1
{
#if WINDOWS
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
		static void Main(string[] args)
		{
					  formMain form = new formMain();
					  form.Show();
					  Game1 game = new Game1(form.getDrawSurface());
					  game.Run();            
		}
    }
#endif
}

