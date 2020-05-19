namespace Szwalnia
{
    partial class Oferty
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOferty = new System.Windows.Forms.DataGridView();
            this.btnDodajOferte = new System.Windows.Forms.Button();
            this.btnWstecz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOferty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz z listy ofertę";
            // 
            // dgvOferty
            // 
            this.dgvOferty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOferty.Location = new System.Drawing.Point(30, 67);
            this.dgvOferty.Name = "dgvOferty";
            this.dgvOferty.Size = new System.Drawing.Size(956, 253);
            this.dgvOferty.TabIndex = 3;
            this.dgvOferty.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOferty_CellDoubleClick);
            // 
            // btnDodajOferte
            // 
            this.btnDodajOferte.Location = new System.Drawing.Point(839, 17);
            this.btnDodajOferte.Name = "btnDodajOferte";
            this.btnDodajOferte.Size = new System.Drawing.Size(122, 35);
            this.btnDodajOferte.TabIndex = 4;
            this.btnDodajOferte.Text = "Dodaj nową ofertę";
            this.btnDodajOferte.UseVisualStyleBackColor = true;
            this.btnDodajOferte.Click += new System.EventHandler(this.btnDodajOferte_Click);
            // 
            // btnWstecz
            // 
            this.btnWstecz.Location = new System.Drawing.Point(705, 17);
            this.btnWstecz.Name = "btnWstecz";
            this.btnWstecz.Size = new System.Drawing.Size(59, 35);
            this.btnWstecz.TabIndex = 5;
            this.btnWstecz.Text = "Powrót";
            this.btnWstecz.UseVisualStyleBackColor = true;
            this.btnWstecz.Click += new System.EventHandler(this.btnWstecz_Click);
            // 
            // Oferty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 450);
            this.Controls.Add(this.btnWstecz);
            this.Controls.Add(this.btnDodajOferte);
            this.Controls.Add(this.dgvOferty);
            this.Controls.Add(this.label1);
            this.Name = "Oferty";
            this.Text = "Oferty";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Oferty_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOferty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOferty;
        private System.Windows.Forms.Button btnDodajOferte;
        private System.Windows.Forms.Button btnWstecz;
    }
}