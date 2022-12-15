
namespace VaP_Portfolio
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
            this.Tick_DGW = new System.Windows.Forms.DataGridView();
            this.Portfolio_DGW = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Tick_DGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Portfolio_DGW)).BeginInit();
            this.SuspendLayout();
            // 
            // Tick_DGW
            // 
            this.Tick_DGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tick_DGW.Location = new System.Drawing.Point(12, 12);
            this.Tick_DGW.Name = "Tick_DGW";
            this.Tick_DGW.Size = new System.Drawing.Size(278, 426);
            this.Tick_DGW.TabIndex = 0;
            // 
            // Portfolio_DGW
            // 
            this.Portfolio_DGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Portfolio_DGW.Location = new System.Drawing.Point(296, 12);
            this.Portfolio_DGW.Name = "Portfolio_DGW";
            this.Portfolio_DGW.Size = new System.Drawing.Size(279, 426);
            this.Portfolio_DGW.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Portfolio_DGW);
            this.Controls.Add(this.Tick_DGW);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Tick_DGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Portfolio_DGW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Tick_DGW;
        private System.Windows.Forms.DataGridView Portfolio_DGW;
    }
}

