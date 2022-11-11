
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
            this.LeftListbox = new System.Windows.Forms.ListBox();
            this.TopTextBox = new System.Windows.Forms.TextBox();
            this.BottomTextBox = new System.Windows.Forms.TextBox();
            this.TopLbl = new System.Windows.Forms.Label();
            this.BottomLbl = new System.Windows.Forms.Label();
            this.BottomButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LeftListbox
            // 
            this.LeftListbox.FormattingEnabled = true;
            this.LeftListbox.Location = new System.Drawing.Point(12, 18);
            this.LeftListbox.Name = "LeftListbox";
            this.LeftListbox.Size = new System.Drawing.Size(236, 316);
            this.LeftListbox.TabIndex = 0;
            // 
            // TopTextBox
            // 
            this.TopTextBox.Location = new System.Drawing.Point(358, 18);
            this.TopTextBox.Name = "TopTextBox";
            this.TopTextBox.Size = new System.Drawing.Size(205, 20);
            this.TopTextBox.TabIndex = 1;
            // 
            // BottomTextBox
            // 
            this.BottomTextBox.Location = new System.Drawing.Point(358, 44);
            this.BottomTextBox.Name = "BottomTextBox";
            this.BottomTextBox.Size = new System.Drawing.Size(205, 20);
            this.BottomTextBox.TabIndex = 2;
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
            this.BottomButton.Click += new System.EventHandler(this.BottomButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 347);
            this.Controls.Add(this.BottomButton);
            this.Controls.Add(this.BottomLbl);
            this.Controls.Add(this.TopLbl);
            this.Controls.Add(this.BottomTextBox);
            this.Controls.Add(this.TopTextBox);
            this.Controls.Add(this.LeftListbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LeftListbox;
        private System.Windows.Forms.TextBox TopTextBox;
        private System.Windows.Forms.TextBox BottomTextBox;
        private System.Windows.Forms.Label TopLbl;
        private System.Windows.Forms.Label BottomLbl;
        private System.Windows.Forms.Button BottomButton;
    }
}

