namespace CsharpSolutions.Exercises.Task21
{
    partial class Communication
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
            this.ping = new System.Windows.Forms.Button();
            this.ip = new System.Windows.Forms.TextBox();
            this.log = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ping
            // 
            this.ping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ping.Location = new System.Drawing.Point(195, 12);
            this.ping.Name = "ping";
            this.ping.Size = new System.Drawing.Size(50, 29);
            this.ping.TabIndex = 0;
            this.ping.Text = "Ping!";
            this.ping.UseVisualStyleBackColor = true;
            this.ping.Click += new System.EventHandler(this.ping_Click);
            // 
            // ip
            // 
            this.ip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip.Location = new System.Drawing.Point(12, 12);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(177, 29);
            this.ip.TabIndex = 1;
            this.ip.Text = "132.199.99.246";
            // 
            // log
            // 
            this.log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log.Location = new System.Drawing.Point(12, 47);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(233, 34);
            this.log.TabIndex = 2;
            // 
            // Communication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 93);
            this.Controls.Add(this.log);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.ping);
            this.Name = "Communication";
            this.Text = "Communication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ping;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.TextBox log;
    }
}