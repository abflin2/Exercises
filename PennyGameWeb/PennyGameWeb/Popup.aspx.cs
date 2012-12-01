using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using Microsoft.Xna.Framework.Media;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace PennyGameWeb
{
	public partial class Popup : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		System.Web.UI.WebControls.Label lbl = new System.Web.UI.WebControls.Label();
		static Game1 game = new Game1();

		delegate void CallXNADelegate(Game1 windows);
		private void updateXNAWindow(Game1 windows)
		{
			if (System.Windows.Forms.Control.FromHandle(game.Window.Handle).InvokeRequired)
			{
				CallXNADelegate del = new CallXNADelegate(updateXNAWindow);
				System.Windows.Forms.Control.FromHandle(game.Window.Handle).Invoke(del, new object[] { windows });
			}
			else
			{
				windows.Run();
			}
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			updateXNAWindow(game);
		}
	}

	public class Game1 : Microsoft.Xna.Framework.Game
	{
		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;

		public Game1()
		{
			graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
		}

		protected override void Initialize()
		{
			base.Initialize();
		}

		protected override void LoadContent()
		{
			spriteBatch = new SpriteBatch(GraphicsDevice);
		}

		protected override void UnloadContent()
		{
			Application.ExitThread();
		}

		protected override void Update(GameTime gameTime)
		{
			base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.CornflowerBlue);
			base.Draw(gameTime);
		}

		protected override void EndRun()
		{
			base.EndRun();
			Application.ExitThread();
		}
	}
}