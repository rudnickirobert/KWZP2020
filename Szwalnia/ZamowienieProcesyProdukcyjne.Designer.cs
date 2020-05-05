namespace Szwalnia
{
    partial class ZamowienieProcesyProdukcyjne
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
            this.lblOpisFormularza = new System.Windows.Forms.Label();
            this.lblNapis = new System.Windows.Forms.Label();
            this.nudNumerZamowienia = new System.Windows.Forms.NumericUpDown();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.dgvProcesyProdukcyjne = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumerZamowienia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesyProdukcyjne)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOpisFormularza
            // 
            this.lblOpisFormularza.AutoSize = true;
            this.lblOpisFormularza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpisFormularza.Location = new System.Drawing.Point(194, 34);
            this.lblOpisFormularza.Name = "lblOpisFormularza";
            this.lblOpisFormularza.Size = new System.Drawing.Size(374, 16);
            this.lblOpisFormularza.TabIndex = 0;
            this.lblOpisFormularza.Text = "Wyszukiwanie procesów produkcyjnych w danym zamówieniu";
            // 
            // lblNapis
            // 
            this.lblNapis.AutoSize = true;
            this.lblNapis.Location = new System.Drawing.Point(64, 88);
            this.lblNapis.Name = "lblNapis";
            this.lblNapis.Size = new System.Drawing.Size(132, 13);
            this.lblNapis.TabIndex = 1;
            this.lblNapis.Text = "Wprowadź ID Zamówienia";
            // 
            // nudNumerZamowienia
            // 
            this.nudNumerZamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudNumerZamowienia.Location = new System.Drawing.Point(293, 84);
            this.nudNumerZamowienia.Name = "nudNumerZamowienia";
            this.nudNumerZamowienia.Size = new System.Drawing.Size(120, 22);
            this.nudNumerZamowienia.TabIndex = 2;
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.Location = new System.Drawing.Point(493, 78);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(75, 33);
            this.btnSzukaj.TabIndex = 3;
            this.btnSzukaj.Text = "SZUKAJ";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // dgvProcesyProdukcyjne
            // 
            this.dgvProcesyProdukcyjne.AllowUserToAddRows = false;
            this.dgvProcesyProdukcyjne.AllowUserToDeleteRows = false;
            this.dgvProcesyProdukcyjne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesyProdukcyjne.Location = new System.Drawing.Point(67, 151);
            this.dgvProcesyProdukcyjne.Name = "dgvProcesyProdukcyjne";
            this.dgvProcesyProdukcyjne.ReadOnly = true;
            this.dgvProcesyProdukcyjne.Size = new System.Drawing.Size(677, 272);
            this.dgvProcesyProdukcyjne.TabIndex = 4;
            // 
            // ZamowienieProcesyProdukcyjne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProcesyProdukcyjne);
            this.Controls.Add(this.btnSzukaj);
            this.Controls.Add(this.nudNumerZamowienia);
            this.Controls.Add(this.lblNapis);
            this.Controls.Add(this.lblOpisFormularza);
            this.Name = "ZamowienieProcesyProdukcyjne";
            this.Text = "ZamowienieProcesyProdukcyjne";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumerZamowienia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesyProdukcyjne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpisFormularza;
        private System.Windows.Forms.Label lblNapis;
        private System.Windows.Forms.NumericUpDown nudNumerZamowienia;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.DataGridView dgvProcesyProdukcyjne;
    }
}