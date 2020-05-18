namespace Szwalnia
{
    partial class OdbiorMaterialu
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
            this.dgvOdebranyMaterialMagazyn = new System.Windows.Forms.DataGridView();
            this.dgvOdebranyMaterialProdukcja = new System.Windows.Forms.DataGridView();
            this.lblProces = new System.Windows.Forms.Label();
            this.lblMagazyn = new System.Windows.Forms.Label();
            this.lblProdukcja = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdebranyMaterialMagazyn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdebranyMaterialProdukcja)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOdebranyMaterialMagazyn
            // 
            this.dgvOdebranyMaterialMagazyn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdebranyMaterialMagazyn.Location = new System.Drawing.Point(53, 79);
            this.dgvOdebranyMaterialMagazyn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvOdebranyMaterialMagazyn.Name = "dgvOdebranyMaterialMagazyn";
            this.dgvOdebranyMaterialMagazyn.RowHeadersWidth = 51;
            this.dgvOdebranyMaterialMagazyn.RowTemplate.Height = 24;
            this.dgvOdebranyMaterialMagazyn.Size = new System.Drawing.Size(816, 160);
            this.dgvOdebranyMaterialMagazyn.TabIndex = 0;
            this.dgvOdebranyMaterialMagazyn.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOdebranyMaterialMagazyn_CellDoubleClick);
            // 
            // dgvOdebranyMaterialProdukcja
            // 
            this.dgvOdebranyMaterialProdukcja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdebranyMaterialProdukcja.Location = new System.Drawing.Point(53, 354);
            this.dgvOdebranyMaterialProdukcja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvOdebranyMaterialProdukcja.Name = "dgvOdebranyMaterialProdukcja";
            this.dgvOdebranyMaterialProdukcja.RowHeadersWidth = 51;
            this.dgvOdebranyMaterialProdukcja.RowTemplate.Height = 24;
            this.dgvOdebranyMaterialProdukcja.Size = new System.Drawing.Size(816, 163);
            this.dgvOdebranyMaterialProdukcja.TabIndex = 1;
            // 
            // lblProces
            // 
            this.lblProces.AutoSize = true;
            this.lblProces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProces.Location = new System.Drawing.Point(220, 11);
            this.lblProces.Name = "lblProces";
            this.lblProces.Size = new System.Drawing.Size(64, 25);
            this.lblProces.TabIndex = 2;
            this.lblProces.Text = "label1";
            this.lblProces.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMagazyn
            // 
            this.lblMagazyn.AutoSize = true;
            this.lblMagazyn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMagazyn.Location = new System.Drawing.Point(51, 43);
            this.lblMagazyn.Name = "lblMagazyn";
            this.lblMagazyn.Size = new System.Drawing.Size(60, 24);
            this.lblMagazyn.TabIndex = 3;
            this.lblMagazyn.Text = "label1";
            // 
            // lblProdukcja
            // 
            this.lblProdukcja.AutoSize = true;
            this.lblProdukcja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProdukcja.Location = new System.Drawing.Point(51, 319);
            this.lblProdukcja.Name = "lblProdukcja";
            this.lblProdukcja.Size = new System.Drawing.Size(60, 24);
            this.lblProdukcja.TabIndex = 4;
            this.lblProdukcja.Text = "label1";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.Location = new System.Drawing.Point(153, 254);
            this.lblOpis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(597, 24);
            this.lblOpis.TabIndex = 10;
            this.lblOpis.Text = "Kliknij dwukrotnie na dostarczenie, aby odebrać materiał na produkcję";
            // 
            // OdbiorMaterialu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(913, 528);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblProdukcja);
            this.Controls.Add(this.lblMagazyn);
            this.Controls.Add(this.lblProces);
            this.Controls.Add(this.dgvOdebranyMaterialProdukcja);
            this.Controls.Add(this.dgvOdebranyMaterialMagazyn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OdbiorMaterialu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odbiór materiału";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdebranyMaterialMagazyn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdebranyMaterialProdukcja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOdebranyMaterialMagazyn;
        private System.Windows.Forms.DataGridView dgvOdebranyMaterialProdukcja;
        private System.Windows.Forms.Label lblProces;
        private System.Windows.Forms.Label lblMagazyn;
        private System.Windows.Forms.Label lblProdukcja;
        private System.Windows.Forms.Label lblOpis;
    }
}