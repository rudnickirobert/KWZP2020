namespace Szwalnia
{
    partial class RaportNieuzytyMaterial
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
            this.dgvNieuzytyMaterialOdpad = new System.Windows.Forms.DataGridView();
            this.btnMaterialWyswietlWszystko = new System.Windows.Forms.Button();
            this.dtpDataZakonczenia = new System.Windows.Forms.DateTimePicker();
            this.btnSzukajDataZakonczenia = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.lblProces = new System.Windows.Forms.Label();
            this.nudProces = new System.Windows.Forms.NumericUpDown();
            this.btnSzukajIDPrcoesu = new System.Windows.Forms.Button();
            this.lblRaportKontrola = new System.Windows.Forms.Label();
            this.btnMagazynNieOdebral = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNieuzytyMaterialOdpad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProces)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNieuzytyMaterialOdpad
            // 
            this.dgvNieuzytyMaterialOdpad.AllowUserToAddRows = false;
            this.dgvNieuzytyMaterialOdpad.AllowUserToDeleteRows = false;
            this.dgvNieuzytyMaterialOdpad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNieuzytyMaterialOdpad.Location = new System.Drawing.Point(24, 307);
            this.dgvNieuzytyMaterialOdpad.Name = "dgvNieuzytyMaterialOdpad";
            this.dgvNieuzytyMaterialOdpad.ReadOnly = true;
            this.dgvNieuzytyMaterialOdpad.RowHeadersWidth = 51;
            this.dgvNieuzytyMaterialOdpad.Size = new System.Drawing.Size(976, 264);
            this.dgvNieuzytyMaterialOdpad.TabIndex = 0;
            // 
            // btnMaterialWyswietlWszystko
            // 
            this.btnMaterialWyswietlWszystko.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMaterialWyswietlWszystko.Location = new System.Drawing.Point(16, 150);
            this.btnMaterialWyswietlWszystko.Name = "btnMaterialWyswietlWszystko";
            this.btnMaterialWyswietlWszystko.Size = new System.Drawing.Size(158, 30);
            this.btnMaterialWyswietlWszystko.TabIndex = 31;
            this.btnMaterialWyswietlWszystko.Text = "Wszystko";
            this.btnMaterialWyswietlWszystko.UseVisualStyleBackColor = true;
            this.btnMaterialWyswietlWszystko.Click += new System.EventHandler(this.btnMaterialWyswietlWszystko_Click);
            // 
            // dtpDataZakonczenia
            // 
            this.dtpDataZakonczenia.CustomFormat = "MM/yyyy";
            this.dtpDataZakonczenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDataZakonczenia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataZakonczenia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpDataZakonczenia.Location = new System.Drawing.Point(270, 66);
            this.dtpDataZakonczenia.Name = "dtpDataZakonczenia";
            this.dtpDataZakonczenia.ShowUpDown = true;
            this.dtpDataZakonczenia.Size = new System.Drawing.Size(117, 26);
            this.dtpDataZakonczenia.TabIndex = 30;
            this.dtpDataZakonczenia.Value = new System.DateTime(2020, 5, 1, 0, 0, 0, 0);
            // 
            // btnSzukajDataZakonczenia
            // 
            this.btnSzukajDataZakonczenia.Image = global::Szwalnia.Properties.Resources.lupa28x28;
            this.btnSzukajDataZakonczenia.Location = new System.Drawing.Point(433, 67);
            this.btnSzukajDataZakonczenia.Name = "btnSzukajDataZakonczenia";
            this.btnSzukajDataZakonczenia.Size = new System.Drawing.Size(29, 28);
            this.btnSzukajDataZakonczenia.TabIndex = 29;
            this.btnSzukajDataZakonczenia.UseVisualStyleBackColor = true;
            this.btnSzukajDataZakonczenia.Click += new System.EventHandler(this.btnSzukajDataZakonczenia_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblData.Location = new System.Drawing.Point(15, 72);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(93, 18);
            this.lblData.TabIndex = 26;
            this.lblData.Text = "Miesiąc / rok";
            // 
            // lblProces
            // 
            this.lblProces.AutoSize = true;
            this.lblProces.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProces.Location = new System.Drawing.Point(15, 22);
            this.lblProces.Name = "lblProces";
            this.lblProces.Size = new System.Drawing.Size(181, 18);
            this.lblProces.TabIndex = 21;
            this.lblProces.Text = "ID procesu produkcyjnego";
            // 
            // nudProces
            // 
            this.nudProces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudProces.Location = new System.Drawing.Point(270, 19);
            this.nudProces.Name = "nudProces";
            this.nudProces.Size = new System.Drawing.Size(117, 26);
            this.nudProces.TabIndex = 20;
            // 
            // btnSzukajIDPrcoesu
            // 
            this.btnSzukajIDPrcoesu.Image = global::Szwalnia.Properties.Resources.lupa28x28;
            this.btnSzukajIDPrcoesu.Location = new System.Drawing.Point(433, 17);
            this.btnSzukajIDPrcoesu.Name = "btnSzukajIDPrcoesu";
            this.btnSzukajIDPrcoesu.Size = new System.Drawing.Size(29, 28);
            this.btnSzukajIDPrcoesu.TabIndex = 19;
            this.btnSzukajIDPrcoesu.UseVisualStyleBackColor = true;
            this.btnSzukajIDPrcoesu.Click += new System.EventHandler(this.btnSzukajIDPrcoesu_Click);
            // 
            // lblRaportKontrola
            // 
            this.lblRaportKontrola.AutoSize = true;
            this.lblRaportKontrola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRaportKontrola.Location = new System.Drawing.Point(349, 44);
            this.lblRaportKontrola.Name = "lblRaportKontrola";
            this.lblRaportKontrola.Size = new System.Drawing.Size(322, 20);
            this.lblRaportKontrola.TabIndex = 32;
            this.lblRaportKontrola.Text = "Niewykorzystany materiał / odpad z produkcji";
            // 
            // btnMagazynNieOdebral
            // 
            this.btnMagazynNieOdebral.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMagazynNieOdebral.Location = new System.Drawing.Point(16, 106);
            this.btnMagazynNieOdebral.Name = "btnMagazynNieOdebral";
            this.btnMagazynNieOdebral.Size = new System.Drawing.Size(180, 30);
            this.btnMagazynNieOdebral.TabIndex = 33;
            this.btnMagazynNieOdebral.Text = "Magazyn nie odebrał";
            this.btnMagazynNieOdebral.UseVisualStyleBackColor = true;
            this.btnMagazynNieOdebral.Click += new System.EventHandler(this.btnMagazynNieOdebral_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMagazynNieOdebral);
            this.groupBox1.Controls.Add(this.btnMaterialWyswietlWszystko);
            this.groupBox1.Controls.Add(this.dtpDataZakonczenia);
            this.groupBox1.Controls.Add(this.btnSzukajDataZakonczenia);
            this.groupBox1.Controls.Add(this.lblData);
            this.groupBox1.Controls.Add(this.lblProces);
            this.groupBox1.Controls.Add(this.nudProces);
            this.groupBox1.Controls.Add(this.btnSzukajIDPrcoesu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(273, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(493, 195);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wyszukiwanie";
            // 
            // RaportNieuzytyMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1016, 583);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblRaportKontrola);
            this.Controls.Add(this.dgvNieuzytyMaterialOdpad);
            this.Name = "RaportNieuzytyMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raport niewykorzystany materiał / odpad";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNieuzytyMaterialOdpad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProces)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNieuzytyMaterialOdpad;
        private System.Windows.Forms.Button btnMaterialWyswietlWszystko;
        private System.Windows.Forms.DateTimePicker dtpDataZakonczenia;
        private System.Windows.Forms.Button btnSzukajDataZakonczenia;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblProces;
        private System.Windows.Forms.NumericUpDown nudProces;
        private System.Windows.Forms.Button btnSzukajIDPrcoesu;
        private System.Windows.Forms.Label lblRaportKontrola;
        private System.Windows.Forms.Button btnMagazynNieOdebral;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}