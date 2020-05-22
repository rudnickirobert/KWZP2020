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
            this.gbxEdycja = new System.Windows.Forms.GroupBox();
            this.tbOdpad = new System.Windows.Forms.TextBox();
            this.lblOdpad = new System.Windows.Forms.Label();
            this.tbNiewykorzystanyMaterial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNiewykorzystanyMaterial = new System.Windows.Forms.Label();
            this.btnEdycja = new System.Windows.Forms.Button();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblMagazynOdebral = new System.Windows.Forms.Label();
            this.ckbOdbior = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiewykorzystanyMaterial)).BeginInit();
            this.gbxEdycja.SuspendLayout();
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
            this.dgvNiewykorzystanyMaterial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNiewykorzystanyMaterial_CellClick);
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
            this.btnNowy.Location = new System.Drawing.Point(347, 553);
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
            this.btnAnuluj.Location = new System.Drawing.Point(520, 553);
            this.btnAnuluj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(107, 62);
            this.btnAnuluj.TabIndex = 7;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // gbxEdycja
            // 
            this.gbxEdycja.Controls.Add(this.ckbOdbior);
            this.gbxEdycja.Controls.Add(this.lblMagazynOdebral);
            this.gbxEdycja.Controls.Add(this.tbOdpad);
            this.gbxEdycja.Controls.Add(this.lblOdpad);
            this.gbxEdycja.Controls.Add(this.tbNiewykorzystanyMaterial);
            this.gbxEdycja.Controls.Add(this.label2);
            this.gbxEdycja.Controls.Add(this.lblNiewykorzystanyMaterial);
            this.gbxEdycja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbxEdycja.Location = new System.Drawing.Point(989, 124);
            this.gbxEdycja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxEdycja.Name = "gbxEdycja";
            this.gbxEdycja.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxEdycja.Size = new System.Drawing.Size(559, 191);
            this.gbxEdycja.TabIndex = 52;
            this.gbxEdycja.TabStop = false;
            this.gbxEdycja.Text = "Edycja";
            // 
            // tbOdpad
            // 
            this.tbOdpad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbOdpad.Location = new System.Drawing.Point(328, 41);
            this.tbOdpad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOdpad.Name = "tbOdpad";
            this.tbOdpad.Size = new System.Drawing.Size(172, 29);
            this.tbOdpad.TabIndex = 60;
            // 
            // lblOdpad
            // 
            this.lblOdpad.AutoSize = true;
            this.lblOdpad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdpad.Location = new System.Drawing.Point(31, 48);
            this.lblOdpad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdpad.Name = "lblOdpad";
            this.lblOdpad.Size = new System.Drawing.Size(0, 24);
            this.lblOdpad.TabIndex = 55;
            // 
            // tbNiewykorzystanyMaterial
            // 
            this.tbNiewykorzystanyMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNiewykorzystanyMaterial.Location = new System.Drawing.Point(328, 85);
            this.tbNiewykorzystanyMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNiewykorzystanyMaterial.Name = "tbNiewykorzystanyMaterial";
            this.tbNiewykorzystanyMaterial.Size = new System.Drawing.Size(172, 29);
            this.tbNiewykorzystanyMaterial.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(31, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 54;
            this.label2.Text = "Odpad";
            // 
            // lblNiewykorzystanyMaterial
            // 
            this.lblNiewykorzystanyMaterial.AutoSize = true;
            this.lblNiewykorzystanyMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNiewykorzystanyMaterial.Location = new System.Drawing.Point(31, 89);
            this.lblNiewykorzystanyMaterial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNiewykorzystanyMaterial.Name = "lblNiewykorzystanyMaterial";
            this.lblNiewykorzystanyMaterial.Size = new System.Drawing.Size(223, 24);
            this.lblNiewykorzystanyMaterial.TabIndex = 53;
            this.lblNiewykorzystanyMaterial.Text = "Niewykorzystany materiał";
            // 
            // btnEdycja
            // 
            this.btnEdycja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdycja.Location = new System.Drawing.Point(1202, 323);
            this.btnEdycja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdycja.Name = "btnEdycja";
            this.btnEdycja.Size = new System.Drawing.Size(149, 62);
            this.btnEdycja.TabIndex = 51;
            this.btnEdycja.Text = "Edytuj";
            this.btnEdycja.UseVisualStyleBackColor = true;
            this.btnEdycja.Click += new System.EventHandler(this.btnEdycja_Click);
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.Location = new System.Drawing.Point(44, 500);
            this.lblOpis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(357, 24);
            this.lblOpis.TabIndex = 53;
            this.lblOpis.Text = "Kilknij na materiał, który chcesz edytować";
            // 
            // lblMagazynOdebral
            // 
            this.lblMagazynOdebral.AutoSize = true;
            this.lblMagazynOdebral.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMagazynOdebral.Location = new System.Drawing.Point(31, 136);
            this.lblMagazynOdebral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMagazynOdebral.Name = "lblMagazynOdebral";
            this.lblMagazynOdebral.Size = new System.Drawing.Size(159, 24);
            this.lblMagazynOdebral.TabIndex = 61;
            this.lblMagazynOdebral.Text = "Magazyn odebrał";
            // 
            // ckbOdbior
            // 
            this.ckbOdbior.AutoSize = true;
            this.ckbOdbior.Location = new System.Drawing.Point(392, 138);
            this.ckbOdbior.Name = "ckbOdbior";
            this.ckbOdbior.Size = new System.Drawing.Size(18, 17);
            this.ckbOdbior.TabIndex = 62;
            this.ckbOdbior.UseVisualStyleBackColor = true;
            // 
            // NiewykorzystanyMaterialProces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1581, 629);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.gbxEdycja);
            this.Controls.Add(this.btnEdycja);
            this.Controls.Add(this.btnNowy);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.lblTekst);
            this.Controls.Add(this.dgvNiewykorzystanyMaterial);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NiewykorzystanyMaterialProces";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Niewykorzystany materiał / odpad";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiewykorzystanyMaterial)).EndInit();
            this.gbxEdycja.ResumeLayout(false);
            this.gbxEdycja.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNiewykorzystanyMaterial;
        private System.Windows.Forms.Label lblTekst;
        private System.Windows.Forms.Button btnNowy;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.GroupBox gbxEdycja;
        private System.Windows.Forms.Button btnEdycja;
        private System.Windows.Forms.TextBox tbOdpad;
        private System.Windows.Forms.Label lblOdpad;
        private System.Windows.Forms.TextBox tbNiewykorzystanyMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNiewykorzystanyMaterial;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.CheckBox ckbOdbior;
        private System.Windows.Forms.Label lblMagazynOdebral;
    }
}