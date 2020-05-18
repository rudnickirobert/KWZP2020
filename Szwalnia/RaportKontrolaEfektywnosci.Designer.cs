namespace Szwalnia
{
    partial class RaportKontrolaEfektywnosci
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
            this.dgvKontrolaProcesu = new System.Windows.Forms.DataGridView();
            this.btnSzukajIDPrcoes = new System.Windows.Forms.Button();
            this.lblRaportKontrola = new System.Windows.Forms.Label();
            this.nudProces = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudZamowienie = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIDZamowienia = new System.Windows.Forms.Button();
            this.btnSzukajStatus = new System.Windows.Forms.Button();
            this.btnSzukajData = new System.Windows.Forms.Button();
            this.dtpDataKontroli = new System.Windows.Forms.DateTimePicker();
            this.btnWszystkie = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKontrolaProcesu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZamowienie)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKontrolaProcesu
            // 
            this.dgvKontrolaProcesu.AllowUserToAddRows = false;
            this.dgvKontrolaProcesu.AllowUserToDeleteRows = false;
            this.dgvKontrolaProcesu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKontrolaProcesu.Location = new System.Drawing.Point(16, 421);
            this.dgvKontrolaProcesu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvKontrolaProcesu.Name = "dgvKontrolaProcesu";
            this.dgvKontrolaProcesu.ReadOnly = true;
            this.dgvKontrolaProcesu.RowHeadersWidth = 51;
            this.dgvKontrolaProcesu.Size = new System.Drawing.Size(1268, 261);
            this.dgvKontrolaProcesu.TabIndex = 4;
            // 
            // btnSzukajIDPrcoes
            // 
            this.btnSzukajIDPrcoes.Image = global::Szwalnia.Properties.Resources.lupa28x28;
            this.btnSzukajIDPrcoes.Location = new System.Drawing.Point(476, 25);
            this.btnSzukajIDPrcoes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSzukajIDPrcoes.Name = "btnSzukajIDPrcoes";
            this.btnSzukajIDPrcoes.Size = new System.Drawing.Size(45, 34);
            this.btnSzukajIDPrcoes.TabIndex = 5;
            this.btnSzukajIDPrcoes.UseVisualStyleBackColor = true;
            this.btnSzukajIDPrcoes.Click += new System.EventHandler(this.btnSzukajIDPrcoes_Click);
            // 
            // lblRaportKontrola
            // 
            this.lblRaportKontrola.AutoSize = true;
            this.lblRaportKontrola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRaportKontrola.Location = new System.Drawing.Point(532, 47);
            this.lblRaportKontrola.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRaportKontrola.Name = "lblRaportKontrola";
            this.lblRaportKontrola.Size = new System.Drawing.Size(253, 25);
            this.lblRaportKontrola.TabIndex = 6;
            this.lblRaportKontrola.Text = "Raport kontroli efektywności";
            // 
            // nudProces
            // 
            this.nudProces.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudProces.Location = new System.Drawing.Point(296, 30);
            this.nudProces.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudProces.Name = "nudProces";
            this.nudProces.Size = new System.Drawing.Size(145, 29);
            this.nudProces.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID procesu produkcyjnego";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(17, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID zamówienia";
            // 
            // nudZamowienie
            // 
            this.nudZamowienie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudZamowienie.Location = new System.Drawing.Point(296, 78);
            this.nudZamowienie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudZamowienie.Name = "nudZamowienie";
            this.nudZamowienie.Size = new System.Drawing.Size(145, 29);
            this.nudZamowienie.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(17, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Status produktów";
            // 
            // cbxStatus
            // 
            this.cbxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(295, 128);
            this.cbxStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(341, 32);
            this.cbxStatus.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(15, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Data kontroli";
            // 
            // btnIDZamowienia
            // 
            this.btnIDZamowienia.Image = global::Szwalnia.Properties.Resources.lupa28x28;
            this.btnIDZamowienia.Location = new System.Drawing.Point(476, 75);
            this.btnIDZamowienia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIDZamowienia.Name = "btnIDZamowienia";
            this.btnIDZamowienia.Size = new System.Drawing.Size(45, 34);
            this.btnIDZamowienia.TabIndex = 14;
            this.btnIDZamowienia.UseVisualStyleBackColor = true;
            this.btnIDZamowienia.Click += new System.EventHandler(this.btnIDZamowienia_Click);
            // 
            // btnSzukajStatus
            // 
            this.btnSzukajStatus.Image = global::Szwalnia.Properties.Resources.lupa28x28;
            this.btnSzukajStatus.Location = new System.Drawing.Point(672, 128);
            this.btnSzukajStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSzukajStatus.Name = "btnSzukajStatus";
            this.btnSzukajStatus.Size = new System.Drawing.Size(40, 34);
            this.btnSzukajStatus.TabIndex = 15;
            this.btnSzukajStatus.UseVisualStyleBackColor = true;
            this.btnSzukajStatus.Click += new System.EventHandler(this.btnSzukajStatus_Click);
            // 
            // btnSzukajData
            // 
            this.btnSzukajData.Image = global::Szwalnia.Properties.Resources.lupa28x28;
            this.btnSzukajData.Location = new System.Drawing.Point(476, 181);
            this.btnSzukajData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSzukajData.Name = "btnSzukajData";
            this.btnSzukajData.Size = new System.Drawing.Size(45, 34);
            this.btnSzukajData.TabIndex = 16;
            this.btnSzukajData.UseVisualStyleBackColor = true;
            this.btnSzukajData.Click += new System.EventHandler(this.btnSzukajData_Click);
            // 
            // dtpDataKontroli
            // 
            this.dtpDataKontroli.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDataKontroli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDataKontroli.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataKontroli.Location = new System.Drawing.Point(297, 187);
            this.dtpDataKontroli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDataKontroli.Name = "dtpDataKontroli";
            this.dtpDataKontroli.Size = new System.Drawing.Size(143, 27);
            this.dtpDataKontroli.TabIndex = 19;
            // 
            // btnWszystkie
            // 
            this.btnWszystkie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWszystkie.Location = new System.Drawing.Point(19, 261);
            this.btnWszystkie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWszystkie.Name = "btnWszystkie";
            this.btnWszystkie.Size = new System.Drawing.Size(211, 37);
            this.btnWszystkie.TabIndex = 33;
            this.btnWszystkie.Text = "Wszystko";
            this.btnWszystkie.UseVisualStyleBackColor = true;
            this.btnWszystkie.Click += new System.EventHandler(this.btnWszystkie_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWszystkie);
            this.groupBox1.Controls.Add(this.dtpDataKontroli);
            this.groupBox1.Controls.Add(this.btnSzukajData);
            this.groupBox1.Controls.Add(this.btnSzukajStatus);
            this.groupBox1.Controls.Add(this.btnIDZamowienia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxStatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudZamowienie);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudProces);
            this.groupBox1.Controls.Add(this.btnSzukajIDPrcoes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(316, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 309);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wyszukiwanie";
            // 
            // RaportKontrolaEfektywnosci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1303, 713);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblRaportKontrola);
            this.Controls.Add(this.dgvKontrolaProcesu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RaportKontrolaEfektywnosci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raport kontroli efektywności";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKontrolaProcesu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZamowienie)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvKontrolaProcesu;
        private System.Windows.Forms.Button btnSzukajIDPrcoes;
        private System.Windows.Forms.Label lblRaportKontrola;
        private System.Windows.Forms.NumericUpDown nudProces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudZamowienie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIDZamowienia;
        private System.Windows.Forms.Button btnSzukajStatus;
        private System.Windows.Forms.Button btnSzukajData;
        private System.Windows.Forms.DateTimePicker dtpDataKontroli;
        private System.Windows.Forms.Button btnWszystkie;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}