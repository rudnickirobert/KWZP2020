namespace Szwalnia
{
    partial class WyborPolkiDoOdlozenia
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
            this.cmbPracownicy = new System.Windows.Forms.ComboBox();
            this.dgvWolnePolki = new System.Windows.Forms.DataGridView();
            this.lblInfoWybierzPracownika = new System.Windows.Forms.Label();
            this.lblInfoWybierzPolke = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWolnePolki)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPracownicy
            // 
            this.cmbPracownicy.FormattingEnabled = true;
            this.cmbPracownicy.Location = new System.Drawing.Point(15, 35);
            this.cmbPracownicy.Name = "cmbPracownicy";
            this.cmbPracownicy.Size = new System.Drawing.Size(773, 21);
            this.cmbPracownicy.TabIndex = 0;
            // 
            // dgvWolnePolki
            // 
            this.dgvWolnePolki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWolnePolki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWolnePolki.Location = new System.Drawing.Point(12, 108);
            this.dgvWolnePolki.Name = "dgvWolnePolki";
            this.dgvWolnePolki.Size = new System.Drawing.Size(776, 257);
            this.dgvWolnePolki.TabIndex = 1;
            this.dgvWolnePolki.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWolnePolki_CellContentDoubleClick);
            // 
            // lblInfoWybierzPracownika
            // 
            this.lblInfoWybierzPracownika.Location = new System.Drawing.Point(9, 9);
            this.lblInfoWybierzPracownika.Name = "lblInfoWybierzPracownika";
            this.lblInfoWybierzPracownika.Size = new System.Drawing.Size(779, 23);
            this.lblInfoWybierzPracownika.TabIndex = 2;
            this.lblInfoWybierzPracownika.Text = "Wybierz pracownika przyjmującego dostawę";
            this.lblInfoWybierzPracownika.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfoWybierzPolke
            // 
            this.lblInfoWybierzPolke.Location = new System.Drawing.Point(12, 82);
            this.lblInfoWybierzPolke.Name = "lblInfoWybierzPolke";
            this.lblInfoWybierzPolke.Size = new System.Drawing.Size(776, 23);
            this.lblInfoWybierzPolke.TabIndex = 3;
            this.lblInfoWybierzPolke.Text = "Wybierz półkę na którą odłożony zostanie element";
            this.lblInfoWybierzPolke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(713, 415);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Zatwierdź";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // WyborPolkiDoOdlozenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblInfoWybierzPolke);
            this.Controls.Add(this.lblInfoWybierzPracownika);
            this.Controls.Add(this.dgvWolnePolki);
            this.Controls.Add(this.cmbPracownicy);
            this.Name = "WyborPolkiDoOdlozenia";
            this.Text = "WyborPolkiDoOdlozenia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WyborPolkiDoOdlozenia_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWolnePolki)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPracownicy;
        private System.Windows.Forms.DataGridView dgvWolnePolki;
        private System.Windows.Forms.Label lblInfoWybierzPracownika;
        private System.Windows.Forms.Label lblInfoWybierzPolke;
        private System.Windows.Forms.Button btnApply;
    }
}