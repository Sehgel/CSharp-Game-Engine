using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace CSharp_Game_Engine
{
    public partial class Main : Form
    {
        private Game game;
        private GraphicsCore graphics;
        private Console console;
        public Main()
        {
            InitializeComponent();
            this.Location = new Point(Screen.AllScreens[0].Bounds.Width / 2 - this.Size.Width / 2, 0);
            console = new Console(this);
            console.Show();

            graphics = new GraphicsCore(this);
            game = new Game();
        }
    }
}
