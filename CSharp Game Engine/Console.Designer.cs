namespace CSharp_Game_Engine
{
    partial class Console
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.consoleLog = new System.Windows.Forms.TextBox();
            this.consoleTextBox = new System.Windows.Forms.TextBox();
            this.consoleSendBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // consoleLog
            // 
            this.consoleLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleLog.BackColor = System.Drawing.SystemColors.ControlDark;
            this.consoleLog.Location = new System.Drawing.Point(1, 1);
            this.consoleLog.Multiline = true;
            this.consoleLog.Name = "consoleLog";
            this.consoleLog.ReadOnly = true;
            this.consoleLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleLog.Size = new System.Drawing.Size(912, 249);
            this.consoleLog.TabIndex = 0;
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleTextBox.Location = new System.Drawing.Point(1, 251);
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.Size = new System.Drawing.Size(829, 20);
            this.consoleTextBox.TabIndex = 1;
            // 
            // consoleSendBtn
            // 
            this.consoleSendBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleSendBtn.Location = new System.Drawing.Point(831, 250);
            this.consoleSendBtn.Name = "consoleSendBtn";
            this.consoleSendBtn.Size = new System.Drawing.Size(82, 22);
            this.consoleSendBtn.TabIndex = 2;
            this.consoleSendBtn.Text = "Send";
            this.consoleSendBtn.UseVisualStyleBackColor = true;
            this.consoleSendBtn.Click += new System.EventHandler(this.consoleSendBtn_Click);
            // 
            // Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 272);
            this.ControlBox = false;
            this.Controls.Add(this.consoleSendBtn);
            this.Controls.Add(this.consoleTextBox);
            this.Controls.Add(this.consoleLog);
            this.Name = "Console";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Debug Console";
            this.Load += new System.EventHandler(this.Console_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox consoleLog;
        private System.Windows.Forms.TextBox consoleTextBox;
        private System.Windows.Forms.Button consoleSendBtn;
    }
}