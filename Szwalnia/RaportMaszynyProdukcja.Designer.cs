namespace Szwalnia
{
    partial class RaportMaszynyProdukcja
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
            this.btnData = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.cbxMaszyna = new System.Windows.Forms.ComboBox();
            this.btnIdRealizacji = new System.Windows.Forms.Button();
            this.nudRealizacja = new System.Windows.Forms.NumericUpDown();
            this.lblRealizacja = new System.Windows.Forms.Label();
            this.btnWszystkie = new System.Windows.Forms.Button();
            this.btnMaszyna = new System.Windows.Forms.Button();
            this.btnEtap = new System.Windows.Forms.Button();
            this.cbxEtap = new System.Windows.Forms.ComboBox();
            this.lblImie = new System.Windows.Forms.Label();
            this.lblEtap = new System.Windows.Forms.Label();
            this.nudProces = new System.Windows.Forms.NumericUpDown();
            this.lblProces = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.dgvMaszyny = new System.Windows.Forms.DataGridView();
            this.btnIdProcesu = new System.Windows.Forms.Button();
            this.gbWyszukiwanie = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudRealizacja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaszyny)).BeginInit();
            this.gbWyszukiwanie.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnData
            // 
            this.btnData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnData.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnData.Image = global::Szwalnia.Properties.Resources.lupa28x28;
            this.btnData.Location = new System.Drawing.Point(385, 202);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(36, 28);
            this.btnData.TabIndex = 39;
            this.btnData.UseVisualStyleBackColor = false;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblData.Location = new System.Drawing.Point(11, 200);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(93, 18);
            this.lblData.TabIndex = 38;
            this.lblData.Text = "Miesiąc / rok";
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "MM/yyyy";
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(238, 200);
            this.dtpData.Name = "dtpData";
            this.dtpData.ShowUpDown = true;
            this.dtpData.Size = new System.Drawing.Size(120, 24);
            this.dtpData.TabIndex = 37;
            // 
            // cbxMaszyna
            // 
            this.cbxMaszyna.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxMaszyna.FormattingEnabled = true;
            this.cbxMaszyna.Location = new System.Drawing.Point(238, 156);
            this.cbxMaszyna.Name = "cbxMaszyna";
            this.cbxMaszyna.Size = new System.Drawing.Size(335, 26);
            this.cbxMaszyna.TabIndex = 36;
            // 
            // btnIdRealizacji
            // 
            this.btnIdRealizacji.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIdRealizacji.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIdRealizacji.Image = global::Szwalnia.Properties.Resources.lupa28x28;
            this.btnIdRealizacji.Location = new System.Drawing.Point(385, 60);
            this.btnIdRealizacji.Name = "btnIdRealizacji";
            this.btnIdRealizacji.Size = new System.Drawing.Size(36, 28);
            this.btnIdRealizacji.TabIndex = 35;
            this.btnIdRealizacji.UseVisualStyleBackColor = false;
            this.btnIdRealizacji.Click += new System.EventHandler(this.btnIdRealizacji_Click);
            // 
            // nudRealizacja
            // 
            this.nudRealizacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudRealizacja.Location = new System.Drawing.Point(238, 62);
            this.nudRealizacja.Name = "nudRealizacja";
            this.nudRealizacja.Size = new System.Drawing.Size(120, 24);
            this.nudRealizacja.TabIndex = 34;
            // 
            // lblRealizacja
            // 
            this.lblRealizacja.AutoSize = true;
            this.lblRealizacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRealizacja.Location = new System.Drawing.Point(11, 67);
            this.lblRealizacja.Name = "lblRealizacja";
            this.lblRealizacja.Size = new System.Drawing.Size(172, 18);
            this.lblRealizacja.TabIndex = 33;
            this.lblRealizacja.Text = "Numer realizacji procesu";
            // 
            // btnWszystkie
            // 
            this.btnWszystkie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWszystkie.Location = new System.Drawing.Point(14, 245);
            this.btnWszystkie.Name = "btnWszystkie";
            this.btnWszystkie.Size = new System.Drawing.Size(158, 30);
            this.btnWszystkie.TabIndex = 32;
            this.btnWszystkie.Text = "Wszystko";
            this.btnWszystkie.UseVisualStyleBackColor = true;
            this.btnWszystkie.Click += new System.EventHandler(this.btnWszystkie_Click);
            // 
            // btnMaszyna
            // 
            this.btnMaszyna.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMaszyna.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMaszyna.Image = global::Szwalnia.Properties.Resources.lupa28x28;
            this.btnMaszyna.Location = new System.Drawing.Point(596, 152);
            this.btnMaszyna.Name = "btnMaszyna";
            this.btnMaszyna.Size = new System.Drawing.Size(36, 28);
            this.btnMaszyna.TabIndex = 31;
            this.btnMaszyna.UseVisualStyleBackColor = false;
            this.btnMaszyna.Click += new System.EventHandler(this.btnMaszyna_Click);
            // 
            // btnEtap
            // 
            this.btnEtap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEtap.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEtap.Image = global::Szwalnia.Properties.Resources.lupa28x28;
            this.btnEtap.Location = new System.Drawing.Point(596, 107);
            this.btnEtap.Name = "btnEtap";
            this.btnEtap.Size = new System.Drawing.Size(36, 28);
            this.btnEtap.TabIndex = 30;
            this.btnEtap.UseVisualStyleBackColor = false;
            this.btnEtap.Click += new System.EventHandler(this.btnEtap_Click);
            // 
            // cbxEtap
            // 
            this.cbxEtap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxEtap.FormattingEnabled = true;
            this.cbxEtap.Location = new System.Drawing.Point(238, 105);
            this.cbxEtap.Name = "cbxEtap";
            this.cbxEtap.Size = new System.Drawing.Size(335, 26);
            this.cbxEtap.TabIndex = 28;
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImie.Location = new System.Drawing.Point(13, 156);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(68, 18);
            this.lblImie.TabIndex = 27;
            this.lblImie.Text = "Maszyna";
            // 
            // lblEtap
            // 
            this.lblEtap.AutoSize = true;
            this.lblEtap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEtap.Location = new System.Drawing.Point(13, 111);
            this.lblEtap.Name = "lblEtap";
            this.lblEtap.Size = new System.Drawing.Size(38, 18);
            this.lblEtap.TabIndex = 26;
            this.lblEtap.Text = "Etap";
            // 
            // nudProces
            // 
            this.nudProces.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudProces.Location = new System.Drawing.Point(238, 16);
            this.nudProces.Name = "nudProces";
            this.nudProces.Size = new System.Drawing.Size(120, 24);
            this.nudProces.TabIndex = 25;
            // 
            // lblProces
            // 
            this.lblProces.AutoSize = true;
            this.lblProces.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProces.Location = new System.Drawing.Point(11, 21);
            this.lblProces.Name = "lblProces";
            this.lblProces.Size = new System.Drawing.Size(212, 18);
            this.lblProces.TabIndex = 24;
            this.lblProces.Text = "Numer procesu produkcyjnego";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.Location = new System.Drawing.Point(315, 9);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(197, 20);
            this.lblOpis.TabIndex = 23;
            this.lblOpis.Text = "Praca maszyn na produkcji";
            // 
            // dgvMaszyny
            // 
            this.dgvMaszyny.AllowUserToAddRows = false;
            this.dgvMaszyny.AllowUserToDeleteRows = false;
            this.dgvMaszyny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaszyny.Location = new System.Drawing.Point(24, 347);
            this.dgvMaszyny.Name = "dgvMaszyny";
            this.dgvMaszyny.ReadOnly = true;
            this.dgvMaszyny.RowHeadersWidth = 51;
            this.dgvMaszyny.Size = new System.Drawing.Size(759, 227);
            this.dgvMaszyny.TabIndex = 22;
            // 
            // btnIdProcesu
            // 
            this.btnIdProcesu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIdProcesu.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIdProcesu.Image = global::Szwalnia.Properties.Resources.lupa28x28;
            this.btnIdProcesu.Location = new System.Drawing.Point(385, 14);
            this.btnIdProcesu.Name = "btnIdProcesu";
            this.btnIdProcesu.Size = new System.Drawing.Size(36, 28);
            this.btnIdProcesu.TabIndex = 29;
            this.btnIdProcesu.UseVisualStyleBackColor = false;
            this.btnIdProcesu.Click += new System.EventHandler(this.btnIdProcesu_Click);
            // 
            // gbWyszukiwanie
            // 
            this.gbWyszukiwanie.Controls.Add(this.btnData);
            this.gbWyszukiwanie.Controls.Add(this.lblData);
            this.gbWyszukiwanie.Controls.Add(this.dtpData);
            this.gbWyszukiwanie.Controls.Add(this.cbxMaszyna);
            this.gbWyszukiwanie.Controls.Add(this.btnIdRealizacji);
            this.gbWyszukiwanie.Controls.Add(this.nudRealizacja);
            this.gbWyszukiwanie.Controls.Add(this.lblRealizacja);
            this.gbWyszukiwanie.Controls.Add(this.btnWszystkie);
            this.gbWyszukiwanie.Controls.Add(this.btnMaszyna);
            this.gbWyszukiwanie.Controls.Add(this.btnEtap);
            this.gbWyszukiwanie.Controls.Add(this.btnIdProcesu);
            this.gbWyszukiwanie.Controls.Add(this.cbxEtap);
            this.gbWyszukiwanie.Controls.Add(this.lblImie);
            this.gbWyszukiwanie.Controls.Add(this.lblEtap);
            this.gbWyszukiwanie.Controls.Add(this.nudProces);
            this.gbWyszukiwanie.Controls.Add(this.lblProces);
            this.gbWyszukiwanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbWyszukiwanie.Location = new System.Drawing.Point(81, 48);
            this.gbWyszukiwanie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbWyszukiwanie.Name = "gbWyszukiwanie";
            this.gbWyszukiwanie.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbWyszukiwanie.Size = new System.Drawing.Size(641, 282);
            this.gbWyszukiwanie.TabIndex = 40;
            this.gbWyszukiwanie.TabStop = false;
            this.gbWyszukiwanie.Text = "Wyszukiwanie";
            // 
            // RaportMaszynyProdukcja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(798, 586);
            this.Controls.Add(this.gbWyszukiwanie);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.dgvMaszyny);
            this.Name = "RaportMaszynyProdukcja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raport maszyny produkcja";
            ((System.ComponentModel.ISupportInitialize)(this.nudRealizacja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaszyny)).EndInit();
            this.gbWyszukiwanie.ResumeLayout(false);
            this.gbWyszukiwanie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.ComboBox cbxMaszyna;
        private System.Windows.Forms.Button btnIdRealizacji;
        private System.Windows.Forms.NumericUpDown nudRealizacja;
        private System.Windows.Forms.Label lblRealizacja;
        private System.Windows.Forms.Button btnWszystkie;
        private System.Windows.Forms.Button btnMaszyna;
        private System.Windows.Forms.Button btnEtap;
        private System.Windows.Forms.Button btnIdProcesu;
        private System.Windows.Forms.ComboBox cbxEtap;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Label lblEtap;
        private System.Windows.Forms.NumericUpDown nudProces;
        private System.Windows.Forms.Label lblProces;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.DataGridView dgvMaszyny;
        private System.Windows.Forms.GroupBox gbWyszukiwanie;
    }
}