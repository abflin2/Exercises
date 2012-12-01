using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsGame1
{
	public partial class formMain : Form
	{
		public IntPtr getDrawSurface()
		{
			return pctSurface.Handle;
		}

		public formMain()
		{
			InitializeComponent();
		}


		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
