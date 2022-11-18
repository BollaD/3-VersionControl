
namespace LINQ_Ramen
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
            this.filterBox = new System.Windows.Forms.TextBox();
            this.countryList = new System.Windows.Forms.ListBox();
            this.RamenDGW = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RamenDGW)).BeginInit();
            this.SuspendLayout();
            // 
            // filterBox
            // 
            this.filterBox.Location = new System.Drawing.Point(13, 13);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(192, 20);
            this.filterBox.TabIndex = 0;
            this.filterBox.TextChanged += new System.EventHandler(this.filterBox_TextChanged);
            // 
            // countryList
            // 
            this.countryList.FormattingEnabled = true;
            this.countryList.Location = new System.Drawing.Point(13, 44);
            this.countryList.Name = "countryList";
            this.countryList.Size = new System.Drawing.Size(192, 394);
            this.countryList.TabIndex = 1;
            this.countryList.SelectedIndexChanged += new System.EventHandler(this.countryList_SelectedIndexChanged);
            // 
            // RamenDGW
            // 
            this.RamenDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RamenDGW.Location = new System.Drawing.Point(212, 44);
            this.RamenDGW.Name = "RamenDGW";
            this.RamenDGW.Size = new System.Drawing.Size(576, 394);
            this.RamenDGW.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RamenDGW);
            this.Controls.Add(this.countryList);
            this.Controls.Add(this.filterBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RamenDGW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filterBox;
        private System.Windows.Forms.ListBox countryList;
        private System.Windows.Forms.DataGridView RamenDGW;
    }
}

