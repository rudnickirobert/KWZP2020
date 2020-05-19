namespace Szwalnia
{
    partial class WydajMaterialProdukcji
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.dgvMaterialyDoWydania = new System.Windows.Forms.DataGridView();
            this.cmbPracownik = new System.Windows.Forms.ComboBox();
            this.lblWybierzPracownika = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialyDoWydania)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(960, 28);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Wybierz materiał do wydania dla produkcji";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvMaterialyDoWydania
            // 
            this.dgvMaterialyDoWydania.AllowUserToAddRows = false;
            this.dgvMaterialyDoWydania.AllowUserToDeleteRows = false;
            this.dgvMaterialyDoWydania.AllowUserToResizeColumns = false;
            this.dgvMaterialyDoWydania.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterialyDoWydania.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterialyDoWydania.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMaterialyDoWydania.Location = new System.Drawing.Point(15, 40);
            this.dgvMaterialyDoWydania.Name = "dgvMaterialyDoWydania";
            this.dgvMaterialyDoWydania.Size = new System.Drawing.Size(957, 378);
            this.dgvMaterialyDoWydania.TabIndex = 1;
            this.dgvMaterialyDoWydania.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterialyDoWydania_CellDoubleClick);
            // 
            // cmbPracownik
            // 
            this.cmbPracownik.FormattingEnabled = true;
            this.cmbPracownik.Location = new System.Drawing.Point(497, 438);
            this.cmbPracownik.Name = "cmbPracownik";
            this.cmbPracownik.Size = new System.Drawing.Size(363, 21);
            this.cmbPracownik.TabIndex = 2;
            // 
            // lblWybierzPracownika
            // 
            this.lblWybierzPracownika.Location = new System.Drawing.Point(104, 438);
            this.lblWybierzPracownika.Name = "lblWybierzPracownika";
            this.lblWybierzPracownika.Size = new System.Drawing.Size(354, 28);
            this.lblWybierzPracownika.TabIndex = 0;
            this.lblWybierzPracownika.Text = "Wybierz pracownika wydającego materiał";
            this.lblWybierzPracownika.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WydajMaterialProdukcji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 485);
            this.Controls.Add(this.cmbPracownik);
            this.Controls.Add(this.dgvMaterialyDoWydania);
            this.Controls.Add(this.lblWybierzPracownika);
            this.Controls.Add(this.lblInfo);
            this.Name = "WydajMaterialProdukcji";
            this.Text = "WydajMaterialProdukcji";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WydajMaterialProdukcji_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialyDoWydania)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridView dgvMaterialyDoWydania;
        private System.Windows.Forms.ComboBox cmbPracownik;
        private System.Windows.Forms.Label lblWybierzPracownika;
    }
}