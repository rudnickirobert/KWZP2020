namespace Szwalnia
{
    partial class WyborPracownika
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
            this.lblWyborPracownika = new System.Windows.Forms.Label();
            this.dgvListaPracownikow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPracownikow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWyborPracownika
            // 
            this.lblWyborPracownika.AutoSize = true;
            this.lblWyborPracownika.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWyborPracownika.Location = new System.Drawing.Point(376, 21);
            this.lblWyborPracownika.Name = "lblWyborPracownika";
            this.lblWyborPracownika.Size = new System.Drawing.Size(403, 38);
            this.lblWyborPracownika.TabIndex = 0;
            this.lblWyborPracownika.Text = "Wybierz pracownika z listy";
            // 
            // dgvListaPracownikow
            // 
            this.dgvListaPracownikow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPracownikow.Location = new System.Drawing.Point(57, 62);
            this.dgvListaPracownikow.Name = "dgvListaPracownikow";
            this.dgvListaPracownikow.RowHeadersWidth = 51;
            this.dgvListaPracownikow.RowTemplate.Height = 24;
            this.dgvListaPracownikow.Size = new System.Drawing.Size(1007, 376);
            this.dgvListaPracownikow.TabIndex = 1;
            this.dgvListaPracownikow.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListaPracownikow_CellMouseDoubleClick);
            // 
            // WyborPracownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 450);
            this.Controls.Add(this.dgvListaPracownikow);
            this.Controls.Add(this.lblWyborPracownika);
            this.Name = "WyborPracownika";
            this.Text = "WyborPracownika";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPracownikow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWyborPracownika;
        private System.Windows.Forms.DataGridView dgvListaPracownikow;
    }
}