﻿namespace Szwalnia
{
    partial class Bilans
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
            this.dgvBilans = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilans)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBilans
            // 
            this.dgvBilans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBilans.Location = new System.Drawing.Point(15, 35);
            this.dgvBilans.Name = "dgvBilans";
            this.dgvBilans.RowHeadersWidth = 51;
            this.dgvBilans.RowTemplate.Height = 24;
            this.dgvBilans.Size = new System.Drawing.Size(761, 386);
            this.dgvBilans.TabIndex = 0;
            // 
            // Bilans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvBilans);
            this.Name = "Bilans";
            this.Text = "Bilans";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBilans;
    }
}