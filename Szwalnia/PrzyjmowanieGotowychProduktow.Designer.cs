namespace Szwalnia
{
    partial class PrzyjmowanieGotowychProduktow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrzyjmowanieGotowychProduktow));
            this.dgvGotoweProdukty = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGotoweProdukty)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGotoweProdukty
            // 
            this.dgvGotoweProdukty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGotoweProdukty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGotoweProdukty.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGotoweProdukty.Location = new System.Drawing.Point(18, 111);
            this.dgvGotoweProdukty.Name = "dgvGotoweProdukty";
            this.dgvGotoweProdukty.Size = new System.Drawing.Size(570, 191);
            this.dgvGotoweProdukty.TabIndex = 0;
            this.dgvGotoweProdukty.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGotoweProdukty_CellDoubleClick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitle.Location = new System.Drawing.Point(12, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(576, 31);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Przyjmowanie gotowych produktów z produkcji";
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(73, 64);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(459, 44);
            this.lblInfo.TabIndex = 19;
            this.lblInfo.Text = "Wybierz produkty, które chcesz przyjąć";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PrzyjmowanieGotowychProduktow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 314);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvGotoweProdukty);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrzyjmowanieGotowychProduktow";
            this.Text = "Przyjmowanie gotowych produktów z produkcji";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrzyjmowanieGotowychProduktow_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGotoweProdukty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGotoweProdukty;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInfo;
    }
}