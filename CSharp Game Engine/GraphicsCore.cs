using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Game_Engine
{
    public class GraphicsCore
    {
        public static GraphicsCore Instance;

        private Panel panel;
        public BufferedGraphics buffer;
        public BufferedGraphicsContext BufferedGraphicsContext = new BufferedGraphicsContext();

        public GraphicsCore(Form form)
        {
            Instance = this;
            BufferedGraphicsContext = BufferedGraphicsManager.Current;
            buffer = BufferedGraphicsContext.Allocate(form.CreateGraphics(), form.ClientRectangle);
        }

        public void DrawBitMap(Bitmap _bitmap, Vector _position)
        {
            PointF v = new PointF(_position.X,_position.Y);
            buffer.Graphics.DrawImage(_bitmap,v);
        }

        private void AddControl(Control control)
        {
            try
            {
                panel.Invoke((MethodInvoker)delegate
                {
                    panel.Controls.Add(control);
                });

            }
            catch
            {

            }
        }

    }
}
