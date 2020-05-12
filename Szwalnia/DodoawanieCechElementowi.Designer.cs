namespace Szwalnia
{
    partial class DodoawanieCechElementowi
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
            this.dgvListaElementow = new System.Windows.Forms.DataGridView();
            this.dgvListaCech = new System.Windows.Forms.DataGridView();
            this.dgvListaJednostek = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtSlowna = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMain = new System.Windows.Forms.Label();
            this.numCecha = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaElementow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCech)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaJednostek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCecha)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaElementow
            // 
            this.dgvListaElementow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaElementow.Location = new System.Drawing.Point(399, 12);
            this.dgvListaElementow.Name = "dgvListaElementow";
            this.dgvListaElementow.RowHeadersWidth = 51;
            this.dgvListaElementow.RowTemplate.Height = 24;
            this.dgvListaElementow.Size = new System.Drawing.Size(503, 190);
            this.dgvListaElementow.TabIndex = 0;
            // 
            // dgvListaCech
            // 
            this.dgvListaCech.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCech.Location = new System.Drawing.Point(399, 208);
            this.dgvListaCech.Name = "dgvListaCech";
            this.dgvListaCech.RowHeadersWidth = 51;
            this.dgvListaCech.RowTemplate.Height = 24;
            this.dgvListaCech.Size = new System.Drawing.Size(503, 190);
            this.dgvListaCech.TabIndex = 1;
            // 
            // dgvListaJednostek
            // 
            this.dgvListaJednostek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaJednostek.Location = new System.Drawing.Point(399, 404);
            this.dgvListaJednostek.Name = "dgvListaJednostek";
            this.dgvListaJednostek.RowHeadersWidth = 51;
            this.dgvListaJednostek.RowTemplate.Height = 24;
            this.dgvListaJednostek.Size = new System.Drawing.Size(503, 190);
            this.dgvListaJednostek.TabIndex = 2;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(284, 564);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(85, 30);
            this.btnDodaj.TabIndex = 14;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // txtSlowna
            // 
            this.txtSlowna.Location = new System.Drawing.Point(180, 149);
            this.txtSlowna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSlowna.Name = "txtSlowna";
            this.txtSlowna.Size = new System.Drawing.Size(151, 22);
            this.txtSlowna.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Wartość słowna cechy";
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Location = new System.Drawing.Point(105, 35);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(185, 17);
            this.lblMain.TabIndex = 11;
            this.lblMain.Text = "Dodawanie cech elementom";
            // 
            // numCecha
            // 
            this.numCecha.Location = new System.Drawing.Point(180, 177);
            this.numCecha.Name = "numCecha";
            this.numCecha.Size = new System.Drawing.Size(120, 22);
            this.numCecha.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Wartość cechy";
            // 
            // DodoawanieCechElementowi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 609);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numCecha);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtSlowna);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.dgvListaJednostek);
            this.Controls.Add(this.dgvListaCech);
            this.Controls.Add(this.dgvListaElementow);
            this.Name = "DodoawanieCechElementowi";
            this.Text = "DodoawanieCechElementowi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaElementow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCech)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaJednostek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaElementow;
        private System.Windows.Forms.DataGridView dgvListaCech;
        private System.Windows.Forms.DataGridView dgvListaJednostek;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtSlowna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.NumericUpDown numCecha;
        private System.Windows.Forms.Label label2;
    }
}