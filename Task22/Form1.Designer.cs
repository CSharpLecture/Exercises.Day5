namespace CsharpSolutions.Exercises.Task22
{
    partial class Form1
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.store = new System.Windows.Forms.Button();
            this.listB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.result = new System.Windows.Forms.ListBox();
            this.operation = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(500, 375);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.store);
            this.tabPage1.Controls.Add(this.listB);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.listA);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(492, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Input";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // store
            // 
            this.store.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.store.Location = new System.Drawing.Point(3, 302);
            this.store.Name = "store";
            this.store.Size = new System.Drawing.Size(486, 44);
            this.store.TabIndex = 4;
            this.store.Text = "Store";
            this.store.UseVisualStyleBackColor = true;
            this.store.Click += new System.EventHandler(this.store_Click);
            // 
            // listB
            // 
            this.listB.Dock = System.Windows.Forms.DockStyle.Top;
            this.listB.Location = new System.Drawing.Point(3, 49);
            this.listB.Name = "listB";
            this.listB.Size = new System.Drawing.Size(486, 20);
            this.listB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "List B:";
            // 
            // listA
            // 
            this.listA.Dock = System.Windows.Forms.DockStyle.Top;
            this.listA.Location = new System.Drawing.Point(3, 16);
            this.listA.Name = "listA";
            this.listA.Size = new System.Drawing.Size(486, 20);
            this.listA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "List A:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.result);
            this.tabPage2.Controls.Add(this.operation);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(492, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Output";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            this.result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.result.FormattingEnabled = true;
            this.result.Location = new System.Drawing.Point(3, 24);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(486, 322);
            this.result.TabIndex = 1;
            // 
            // operation
            // 
            this.operation.Dock = System.Windows.Forms.DockStyle.Top;
            this.operation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operation.FormattingEnabled = true;
            this.operation.Location = new System.Drawing.Point(3, 3);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(486, 21);
            this.operation.TabIndex = 0;
            this.operation.SelectedIndexChanged += new System.EventHandler(this.operation_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 375);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Math tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button store;
        private System.Windows.Forms.TextBox listB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox listA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox result;
        private System.Windows.Forms.ComboBox operation;
    }
}

