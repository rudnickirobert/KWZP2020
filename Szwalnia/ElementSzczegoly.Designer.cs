namespace Szwalnia
{
    partial class ElementSzczegoly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElementSzczegoly));
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.lblElement = new System.Windows.Forms.Label();
            this.dgvSzczegol = new System.Windows.Forms.DataGridView();
            this.txtOkres = new System.Windows.Forms.TextBox();
            this.lblNazwa = new System.Windows.Forms.Label();
            this.lblOkres = new System.Windows.Forms.Label();
            this.btnWstecz = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDodawanieCech = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzczegol)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(159, 71);
            this.txtNazwa.Margin = new System.Windows.Forms.Padding(4);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(132, 22);
            this.txtNazwa.TabIndex = 2;
            // 
            // lblElement
            // 
            this.lblElement.AutoSize = true;
            this.lblElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblElement.Location = new System.Drawing.Point(17, 11);
            this.lblElement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblElement.Name = "lblElement";
            this.lblElement.Size = new System.Drawing.Size(109, 39);
            this.lblElement.TabIndex = 3;
            this.lblElement.Text = "label1";
            // 
            // dgvSzczegol
            // 
            this.dgvSzczegol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSzczegol.Location = new System.Drawing.Point(16, 167);
            this.dgvSzczegol.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSzczegol.Name = "dgvSzczegol";
            this.dgvSzczegol.RowHeadersWidth = 51;
            this.dgvSzczegol.Size = new System.Drawing.Size(656, 383);
            this.dgvSzczegol.TabIndex = 4;
            // 
            // txtOkres
            // 
            this.txtOkres.Location = new System.Drawing.Point(159, 101);
            this.txtOkres.Margin = new System.Windows.Forms.Padding(4);
            this.txtOkres.Name = "txtOkres";
            this.txtOkres.Size = new System.Drawing.Size(132, 22);
            this.txtOkres.TabIndex = 2;
            // 
            // lblNazwa
            // 
            this.lblNazwa.AutoSize = true;
            this.lblNazwa.Location = new System.Drawing.Point(21, 80);
            this.lblNazwa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNazwa.Name = "lblNazwa";
            this.lblNazwa.Size = new System.Drawing.Size(50, 17);
            this.lblNazwa.TabIndex = 5;
            this.lblNazwa.Text = "Nazwa";
            // 
            // lblOkres
            // 
            this.lblOkres.AutoSize = true;
            this.lblOkres.Location = new System.Drawing.Point(21, 105);
            this.lblOkres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOkres.Name = "lblOkres";
            this.lblOkres.Size = new System.Drawing.Size(130, 17);
            this.lblOkres.TabIndex = 5;
            this.lblOkres.Text = "Okres przydatnosci";
            // 
            // btnWstecz
            // 
            this.btnWstecz.Location = new System.Drawing.Point(541, 119);
            this.btnWstecz.Name = "btnWstecz";
            this.btnWstecz.Size = new System.Drawing.Size(131, 30);
            this.btnWstecz.TabIndex = 25;
            this.btnWstecz.Text = "Wstecz";
            this.btnWstecz.UseVisualStyleBackColor = true;
            this.btnWstecz.Click += new System.EventHandler(this.btnWstecz_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(541, 83);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(131, 30);
            this.btnUsun.TabIndex = 26;
            this.btnUsun.Text = "Usuń rekord";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnDodawanieCech
            // 
            this.btnDodawanieCech.Location = new System.Drawing.Point(541, 47);
            this.btnDodawanieCech.Name = "btnDodawanieCech";
            this.btnDodawanieCech.Size = new System.Drawing.Size(131, 30);
            this.btnDodawanieCech.TabIndex = 27;
            this.btnDodawanieCech.Text = "Dodaj cechy";
            this.btnDodawanieCech.UseVisualStyleBackColor = true;
            this.btnDodawanieCech.Click += new System.EventHandler(this.btnDodawanieCech_Click);
            // 
            // ElementSzczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 554);
            this.Controls.Add(this.btnDodawanieCech);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnWstecz);
            this.Controls.Add(this.lblOkres);
            this.Controls.Add(this.lblNazwa);
            this.Controls.Add(this.dgvSzczegol);
            this.Controls.Add(this.lblElement);
            this.Controls.Add(this.txtOkres);
            this.Controls.Add(this.txtNazwa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ElementSzczegoly";
            this.Text = "Okno szczegolow elementow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ElementSzczegoly_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzczegol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.Label lblElement;
        private System.Windows.Forms.DataGridView dgvSzczegol;
        private System.Windows.Forms.TextBox txtOkres;
        private System.Windows.Forms.Label lblNazwa;
        private System.Windows.Forms.Label lblOkres;
        private System.Windows.Forms.Button btnWstecz;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDodawanieCech;
    }
}