namespace Szwalnia
{
    partial class NiewykorzystanyMaterialProces
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
            this.dgvNiewykorzystanyMaterial = new System.Windows.Forms.DataGridView();
            this.lblTekst = new System.Windows.Forms.Label();
            this.btnNowy = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiewykorzystanyMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNiewykorzystanyMaterial
            // 
            this.dgvNiewykorzystanyMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNiewykorzystanyMaterial.Location = new System.Drawing.Point(48, 85);
            this.dgvNiewykorzystanyMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvNiewykorzystanyMaterial.Name = "dgvNiewykorzystanyMaterial";
            this.dgvNiewykorzystanyMaterial.RowHeadersWidth = 51;
            this.dgvNiewykorzystanyMaterial.Size = new System.Drawing.Size(921, 393);
            this.dgvNiewykorzystanyMaterial.TabIndex = 0;
            // 
            // lblTekst
            // 
            this.lblTekst.AutoSize = true;
            this.lblTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTekst.Location = new System.Drawing.Point(125, 39);
            this.lblTekst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTekst.Name = "lblTekst";
            this.lblTekst.Size = new System.Drawing.Size(64, 25);
            this.lblTekst.TabIndex = 1;
            this.lblTekst.Text = "label1";
            // 
            // btnNowy
            // 
            this.btnNowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNowy.Location = new System.Drawing.Point(270, 486);
            this.btnNowy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNowy.Name = "btnNowy";
            this.btnNowy.Size = new System.Drawing.Size(107, 62);
            this.btnNowy.TabIndex = 9;
            this.btnNowy.Text = "Nowy";
            this.btnNowy.UseVisualStyleBackColor = true;
            this.btnNowy.Click += new System.EventHandler(this.btnNowy_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnuluj.Location = new System.Drawing.Point(588, 486);
            this.btnAnuluj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(107, 62);
            this.btnAnuluj.TabIndex = 7;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnZapisz
            // 
            this.btnZapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZapisz.Location = new System.Drawing.Point(426, 486);
            this.btnZapisz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(107, 62);
            this.btnZapisz.TabIndex = 8;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // NiewykorzystanyMaterialProces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1016, 561);
            this.Controls.Add(this.btnNowy);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.lblTekst);
            this.Controls.Add(this.dgvNiewykorzystanyMaterial);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NiewykorzystanyMaterialProces";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Niewykorzystany materiał / odpad";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiewykorzystanyMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNiewykorzystanyMaterial;
        private System.Windows.Forms.Label lblTekst;
        private System.Windows.Forms.Button btnNowy;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnZapisz;
    }
}