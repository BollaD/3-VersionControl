
namespace UserMaintenance
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TopLbl = new System.Windows.Forms.Label();
            this.BottomLbl = new System.Windows.Forms.Label();
            this.BottomButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(236, 316);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(358, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(358, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(205, 20);
            this.textBox2.TabIndex = 2;
            // 
            // TopLbl
            // 
            this.TopLbl.AutoSize = true;
            this.TopLbl.Location = new System.Drawing.Point(282, 21);
            this.TopLbl.Name = "TopLbl";
            this.TopLbl.Size = new System.Drawing.Size(35, 13);
            this.TopLbl.TabIndex = 3;
            this.TopLbl.Text = "label1";
            // 
            // BottomLbl
            // 
            this.BottomLbl.AutoSize = true;
            this.BottomLbl.Location = new System.Drawing.Point(282, 47);
            this.BottomLbl.Name = "BottomLbl";
            this.BottomLbl.Size = new System.Drawing.Size(35, 13);
            this.BottomLbl.TabIndex = 4;
            this.BottomLbl.Text = "label2";
            // 
            // BottomButton
            // 
            this.BottomButton.Location = new System.Drawing.Point(285, 83);
            this.BottomButton.Name = "BottomButton";
            this.BottomButton.Size = new System.Drawing.Size(278, 29);
            this.BottomButton.TabIndex = 5;
            this.BottomButton.Text = "button1";
            this.BottomButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 347);
            this.Controls.Add(this.BottomButton);
            this.Controls.Add(this.BottomLbl);
            this.Controls.Add(this.TopLbl);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label TopLbl;
        private System.Windows.Forms.Label BottomLbl;
        private System.Windows.Forms.Button BottomButton;
    }
}

