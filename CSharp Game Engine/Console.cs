using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Game_Engine
{
    public partial class Console : Form
    {
        static public Console Instance;
        public Console(Form parent)
        {
            Instance = this;
            InitializeComponent();
            this.Location = new Point(parent.Location.X, parent.Location.Y + parent.Height);
            this.Size = new Size(parent.Width, this.Size.Height);
        }
        static public void SendMessage(string message, object sender)
        {
            if (Instance != null)
            {
                Instance.consoleLog.Invoke((MethodInvoker)delegate
                {
                    Instance.consoleLog.AppendText(message+"\n");
                });
            }
        }
        static public void ClearConsole()
        {
            if (Instance != null)
            {
                Instance.consoleLog.Invoke((MethodInvoker)delegate
                {
                    Instance.consoleLog.Text = "";
                });
            }
        }
        private void consoleSendBtn_Click(object sender, EventArgs e)
        {
            if (consoleTextBox.Text != "")
                consoleLog.AppendText(consoleTextBox.Text+"\n");
        }
        private void Console_Load(object sender, EventArgs e)
        {
        }
    }
}