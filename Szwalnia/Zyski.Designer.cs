﻿namespace Szwalnia
{
    partial class Zyski
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
            this.dgvZyski = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZyski)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZyski
            // 
            this.dgvZyski.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvZyski.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZyski.Location = new System.Drawing.Point(27, 32);
            this.dgvZyski.Name = "dgvZyski";
            this.dgvZyski.RowHeadersWidth = 51;
            this.dgvZyski.RowTemplate.Height = 24;
            this.dgvZyski.Size = new System.Drawing.Size(356, 390);
            this.dgvZyski.TabIndex = 0;
            // 
            // Zyski
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.dgvZyski);
            this.Name = "Zyski";
            this.Text = "Zyski";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZyski)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZyski;
    }
}