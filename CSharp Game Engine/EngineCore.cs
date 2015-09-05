using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Game_Engine
{
    public abstract class EngineCore
    {
        [DllImport("kernel32.dll")]
        public static extern long GetTickCount();

        private const float FPS_TARGET = 60;

        private Thread mainThread;

        public EngineCore()
        {
            mainThread = new Thread(MainLoop);
        }
        public void Start()
        {
            mainThread.Start();
        }
        private float GetCurrentTime()
        {
            return Process.GetCurrentProcess().TotalProcessorTime.Milliseconds;
        }
        private void MainLoop()
        {
            float previous = GetTickCount();
            float acumulator = 0;
            while (true)
            {
                float currentTime = GetTickCount();
                float timeThisFrame = currentTime - previous;
                previous = currentTime;
                acumulator += timeThisFrame;
                
                while (acumulator >= (1/FPS_TARGET*1000))
                {
                    Update();
                    Render();
                    acumulator -= (1 / FPS_TARGET* 1000);
                    Time.time += timeThisFrame;
                    Time.deltaTime = 1 / timeThisFrame;

                }
            }
        }

        public abstract void Update();
        public abstract void Render();

    }
}
