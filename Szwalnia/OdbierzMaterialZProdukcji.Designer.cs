﻿namespace Szwalnia
{
    partial class OdbierzMaterialZProdukcji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdbierzMaterialZProdukcji));
            this.lblInfo = new System.Windows.Forms.Label();
            this.dgvMaterialDoOdebrania = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialDoOdebrania)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(776, 32);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Wybierz materiał z produkcji który odbierasz";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvMaterialDoOdebrania
            // 
            this.dgvMaterialDoOdebrania.AllowUserToAddRows = false;
            this.dgvMaterialDoOdebrania.AllowUserToDeleteRows = false;
            this.dgvMaterialDoOdebrania.AllowUserToOrderColumns = true;
            this.dgvMaterialDoOdebrania.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterialDoOdebrania.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterialDoOdebrania.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMaterialDoOdebrania.Location = new System.Drawing.Point(12, 44);
            this.dgvMaterialDoOdebrania.Name = "dgvMaterialDoOdebrania";
            this.dgvMaterialDoOdebrania.Size = new System.Drawing.Size(776, 394);
            this.dgvMaterialDoOdebrania.TabIndex = 2;
            this.dgvMaterialDoOdebrania.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterialDoOdebrania_CellDoubleClick);
            // 
            // OdbierzMaterialZProdukcji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMaterialDoOdebrania);
            this.Controls.Add(this.lblInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OdbierzMaterialZProdukcji";
            this.Text = "Odbieranie niezużytego materiału z produkcji";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OdbierzMaterialZProdukcji_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialDoOdebrania)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridView dgvMaterialDoOdebrania;
    }
}