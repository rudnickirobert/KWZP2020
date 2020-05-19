namespace Szwalnia
{
    partial class RaportPracownicyProdukcji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaportPracownicyProdukcji));
            this.dgvPracownicy = new System.Windows.Forms.DataGridView();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblProces = new System.Windows.Forms.Label();
            this.nudProces = new System.Windows.Forms.NumericUpDown();
            this.lblEtap = new System.Windows.Forms.Label();
            this.cbxEtap = new System.Windows.Forms.ComboBox();
            this.btnIdProcesu = new System.Windows.Forms.Button();
            this.btnEtap = new System.Windows.Forms.Button();
            this.btnPracownik = new System.Windows.Forms.Button();
            this.btnWszystkie = new System.Windows.Forms.Button();
            this.btnIdRealizacji = new System.Windows.Forms.Button();
            this.nudRealizacja = new System.Windows.Forms.NumericUpDown();
            this.lblRealizacja = new System.Windows.Forms.Label();
            this.lblImie = new System.Windows.Forms.Label();
            this.cbxPracownik = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.btnData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracownicy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRealizacja)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPracownicy
            // 
            this.dgvPracownicy.AllowUserToAddRows = false;
            this.dgvPracownicy.AllowUserToDeleteRows = false;
            this.dgvPracownicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPracownicy.Location = new System.Drawing.Point(16, 430);
            this.dgvPracownicy.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPracownicy.Name = "dgvPracownicy";
            this.dgvPracownicy.ReadOnly = true;
            this.dgvPracownicy.RowHeadersWidth = 51;
            this.dgvPracownicy.Size = new System.Drawing.Size(1189, 297);
            this.dgvPracownicy.TabIndex = 0;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.Location = new System.Drawing.Point(473, 34);
            this.lblOpis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(291, 25);
            this.lblOpis.TabIndex = 1;
            this.lblOpis.Text = "Praca pracowników na produkcji";
            // 
            // lblProces
            // 
            this.lblProces.AutoSize = true;
            this.lblProces.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProces.Location = new System.Drawing.Point(95, 28);
            this.lblProces.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProces.Name = "lblProces";
            this.lblProces.Size = new System.Drawing.Size(273, 24);
            this.lblProces.TabIndex = 2;
            this.lblProces.Text = "Numer procesu produkcyjnego";
            // 
            // nudProces
            // 
            this.nudProces.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudProces.Location = new System.Drawing.Point(398, 22);
            this.nudProces.Margin = new System.Windows.Forms.Padding(4);
            this.nudProces.Name = "nudProces";
            this.nudProces.Size = new System.Drawing.Size(160, 29);
            this.nudProces.TabIndex = 4;
            // 
            // lblEtap
            // 
            this.lblEtap.AutoSize = true;
            this.lblEtap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEtap.Location = new System.Drawing.Point(97, 138);
            this.lblEtap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEtap.Name = "lblEtap";
            this.lblEtap.Size = new System.Drawing.Size(48, 24);
            this.lblEtap.TabIndex = 5;
            this.lblEtap.Text = "Etap";
            // 
            // cbxEtap
            // 
            this.cbxEtap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxEtap.FormattingEnabled = true;
            this.cbxEtap.Location = new System.Drawing.Point(398, 131);
            this.cbxEtap.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEtap.Name = "cbxEtap";
            this.cbxEtap.Size = new System.Drawing.Size(360, 32);
            this.cbxEtap.TabIndex = 7;
            // 
            // btnIdProcesu
            // 
            this.btnIdProcesu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIdProcesu.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIdProcesu.Image = ((System.Drawing.Image)(resources.GetObject("btnIdProcesu.Image")));
            this.btnIdProcesu.Location = new System.Drawing.Point(593, 19);
            this.btnIdProcesu.Margin = new System.Windows.Forms.Padding(4);
            this.btnIdProcesu.Name = "btnIdProcesu";
            this.btnIdProcesu.Size = new System.Drawing.Size(48, 34);
            this.btnIdProcesu.TabIndex = 11;
            this.btnIdProcesu.UseVisualStyleBackColor = false;
            this.btnIdProcesu.Click += new System.EventHandler(this.btnIdProcesu_Click);
            // 
            // btnEtap
            // 
            this.btnEtap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEtap.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEtap.Image = ((System.Drawing.Image)(resources.GetObject("btnEtap.Image")));
            this.btnEtap.Location = new System.Drawing.Point(795, 129);
            this.btnEtap.Margin = new System.Windows.Forms.Padding(4);
            this.btnEtap.Name = "btnEtap";
            this.btnEtap.Size = new System.Drawing.Size(48, 34);
            this.btnEtap.TabIndex = 12;
            this.btnEtap.UseVisualStyleBackColor = false;
            this.btnEtap.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPracownik
            // 
            this.btnPracownik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPracownik.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPracownik.Image = ((System.Drawing.Image)(resources.GetObject("btnPracownik.Image")));
            this.btnPracownik.Location = new System.Drawing.Point(929, 194);
            this.btnPracownik.Margin = new System.Windows.Forms.Padding(4);
            this.btnPracownik.Name = "btnPracownik";
            this.btnPracownik.Size = new System.Drawing.Size(48, 34);
            this.btnPracownik.TabIndex = 13;
            this.btnPracownik.UseVisualStyleBackColor = false;
            this.btnPracownik.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnWszystkie
            // 
            this.btnWszystkie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWszystkie.Location = new System.Drawing.Point(101, 313);
            this.btnWszystkie.Margin = new System.Windows.Forms.Padding(4);
            this.btnWszystkie.Name = "btnWszystkie";
            this.btnWszystkie.Size = new System.Drawing.Size(211, 37);
            this.btnWszystkie.TabIndex = 14;
            this.btnWszystkie.Text = "Wszystko";
            this.btnWszystkie.UseVisualStyleBackColor = true;
            this.btnWszystkie.Click += new System.EventHandler(this.btnWszystkie_Click);
            // 
            // btnIdRealizacji
            // 
            this.btnIdRealizacji.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIdRealizacji.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIdRealizacji.Image = ((System.Drawing.Image)(resources.GetObject("btnIdRealizacji.Image")));
            this.btnIdRealizacji.Location = new System.Drawing.Point(593, 76);
            this.btnIdRealizacji.Margin = new System.Windows.Forms.Padding(4);
            this.btnIdRealizacji.Name = "btnIdRealizacji";
            this.btnIdRealizacji.Size = new System.Drawing.Size(48, 34);
            this.btnIdRealizacji.TabIndex = 17;
            this.btnIdRealizacji.UseVisualStyleBackColor = false;
            this.btnIdRealizacji.Click += new System.EventHandler(this.btnIdRealizacji_Click);
            // 
            // nudRealizacja
            // 
            this.nudRealizacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudRealizacja.Location = new System.Drawing.Point(398, 78);
            this.nudRealizacja.Margin = new System.Windows.Forms.Padding(4);
            this.nudRealizacja.Name = "nudRealizacja";
            this.nudRealizacja.Size = new System.Drawing.Size(160, 29);
            this.nudRealizacja.TabIndex = 16;
            // 
            // lblRealizacja
            // 
            this.lblRealizacja.AutoSize = true;
            this.lblRealizacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRealizacja.Location = new System.Drawing.Point(95, 84);
            this.lblRealizacja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRealizacja.Name = "lblRealizacja";
            this.lblRealizacja.Size = new System.Drawing.Size(219, 24);
            this.lblRealizacja.TabIndex = 15;
            this.lblRealizacja.Text = "Numer realizacji procesu";
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImie.Location = new System.Drawing.Point(97, 194);
            this.lblImie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(97, 24);
            this.lblImie.TabIndex = 6;
            this.lblImie.Text = "Pracownik";
            // 
            // cbxPracownik
            // 
            this.cbxPracownik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxPracownik.FormattingEnabled = true;
            this.cbxPracownik.Location = new System.Drawing.Point(398, 194);
            this.cbxPracownik.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPracownik.Name = "cbxPracownik";
            this.cbxPracownik.Size = new System.Drawing.Size(501, 32);
            this.cbxPracownik.TabIndex = 18;
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "MM/yyyy";
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(398, 248);
            this.dtpData.Margin = new System.Windows.Forms.Padding(4);
            this.dtpData.Name = "dtpData";
            this.dtpData.ShowUpDown = true;
            this.dtpData.Size = new System.Drawing.Size(159, 29);
            this.dtpData.TabIndex = 19;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblData.Location = new System.Drawing.Point(95, 248);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(115, 24);
            this.lblData.TabIndex = 20;
            this.lblData.Text = "Miesiąc / rok";
            // 
            // btnData
            // 
            this.btnData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnData.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnData.Image = ((System.Drawing.Image)(resources.GetObject("btnData.Image")));
            this.btnData.Location = new System.Drawing.Point(593, 249);
            this.btnData.Margin = new System.Windows.Forms.Padding(4);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(48, 34);
            this.btnData.TabIndex = 21;
            this.btnData.UseVisualStyleBackColor = false;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnData);
            this.groupBox1.Controls.Add(this.lblData);
            this.groupBox1.Controls.Add(this.dtpData);
            this.groupBox1.Controls.Add(this.cbxPracownik);
            this.groupBox1.Controls.Add(this.btnIdRealizacji);
            this.groupBox1.Controls.Add(this.nudRealizacja);
            this.groupBox1.Controls.Add(this.lblRealizacja);
            this.groupBox1.Controls.Add(this.btnWszystkie);
            this.groupBox1.Controls.Add(this.btnPracownik);
            this.groupBox1.Controls.Add(this.btnEtap);
            this.groupBox1.Controls.Add(this.btnIdProcesu);
            this.groupBox1.Controls.Add(this.cbxEtap);
            this.groupBox1.Controls.Add(this.lblImie);
            this.groupBox1.Controls.Add(this.lblEtap);
            this.groupBox1.Controls.Add(this.nudProces);
            this.groupBox1.Controls.Add(this.lblProces);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(150, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 358);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wyszukiwanie";
            // 
            // RaportPracownicyProdukcji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1221, 741);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.dgvPracownicy);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RaportPracownicyProdukcji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raport pracownicy produkcji";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracownicy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRealizacja)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPracownicy;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblProces;
        private System.Windows.Forms.NumericUpDown nudProces;
        private System.Windows.Forms.Label lblEtap;
        private System.Windows.Forms.ComboBox cbxEtap;
        private System.Windows.Forms.Button btnIdProcesu;
        private System.Windows.Forms.Button btnEtap;
        private System.Windows.Forms.Button btnPracownik;
        private System.Windows.Forms.Button btnWszystkie;
        private System.Windows.Forms.Button btnIdRealizacji;
        private System.Windows.Forms.NumericUpDown nudRealizacja;
        private System.Windows.Forms.Label lblRealizacja;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.ComboBox cbxPracownik;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}