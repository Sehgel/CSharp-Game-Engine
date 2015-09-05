using CSharp_Game_Engine.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Game_Engine
{
    public struct Sprite
    {
        public Bitmap image;
        public Vector position;

        public Sprite(Bitmap _image, Vector _point)
        {
            image = _image;
            position = _point;
        }
    }
    public class Game : EngineCore
    {

        private Sprite spt;
        public Game()
        {
            spt.image = Resources.hitler;
            spt.position = new Vector(0, GraphicsCore.Instance.buffer.Graphics.VisibleClipBounds.Height/2);
            Start();
            Vector v = new Vector(75,1.5f) + new Vector(100,1.5f);
        }

        public override void Update()
        {
            spt.position.X += 0.1f;
            //spt.position.Y = (float)Math.Cos((double)spt.position.X);
        }
        public override void Render()
        {
            GraphicsCore.Instance.buffer.Graphics.Clear(Color.Coral);
            GraphicsCore.Instance.DrawBitMap(spt.image, spt.position);
            GraphicsCore.Instance.buffer.Render();
        }

        private Color GerRandomColor()
        {
            Random randomGen = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[randomGen.Next(names.Length)];
            Color randomColor = Color.FromKnownColor(randomColorName);
            return randomColor;

        }
    }
}
