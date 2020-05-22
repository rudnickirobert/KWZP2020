namespace Szwalnia
{
    partial class WyborOferty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WyborOferty));
            this.dgvListaOfert = new System.Windows.Forms.DataGridView();
            this.lblListaOfert = new System.Windows.Forms.Label();
            this.dgvMagazynZawartosc = new System.Windows.Forms.DataGridView();
            this.lblListaProduktowWMagazynie = new System.Windows.Forms.Label();
            this.btnPrzypiszCalyMagazyn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaOfert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazynZawartosc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaOfert
            // 
            this.dgvListaOfert.AllowUserToAddRows = false;
            this.dgvListaOfert.AllowUserToDeleteRows = false;
            this.dgvListaOfert.AllowUserToOrderColumns = true;
            this.dgvListaOfert.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaOfert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaOfert.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaOfert.Location = new System.Drawing.Point(12, 29);
            this.dgvListaOfert.Name = "dgvListaOfert";
            this.dgvListaOfert.Size = new System.Drawing.Size(776, 218);
            this.dgvListaOfert.TabIndex = 0;
            this.dgvListaOfert.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaOfert_CellDoubleClick);
            // 
            // lblListaOfert
            // 
            this.lblListaOfert.Location = new System.Drawing.Point(13, 13);
            this.lblListaOfert.Name = "lblListaOfert";
            this.lblListaOfert.Size = new System.Drawing.Size(775, 13);
            this.lblListaOfert.TabIndex = 1;
            this.lblListaOfert.Text = "Lista ofert dostawców";
            this.lblListaOfert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvMagazynZawartosc
            // 
            this.dgvMagazynZawartosc.AllowUserToAddRows = false;
            this.dgvMagazynZawartosc.AllowUserToDeleteRows = false;
            this.dgvMagazynZawartosc.AllowUserToOrderColumns = true;
            this.dgvMagazynZawartosc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMagazynZawartosc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMagazynZawartosc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMagazynZawartosc.Location = new System.Drawing.Point(12, 302);
            this.dgvMagazynZawartosc.Name = "dgvMagazynZawartosc";
            this.dgvMagazynZawartosc.Size = new System.Drawing.Size(776, 190);
            this.dgvMagazynZawartosc.TabIndex = 0;
            this.dgvMagazynZawartosc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMagazynZawartosc_CellDoubleClick);
            // 
            // lblListaProduktowWMagazynie
            // 
            this.lblListaProduktowWMagazynie.Location = new System.Drawing.Point(12, 286);
            this.lblListaProduktowWMagazynie.Name = "lblListaProduktowWMagazynie";
            this.lblListaProduktowWMagazynie.Size = new System.Drawing.Size(776, 13);
            this.lblListaProduktowWMagazynie.TabIndex = 1;
            this.lblListaProduktowWMagazynie.Text = "Lista materiałów w magazynie";
            this.lblListaProduktowWMagazynie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrzypiszCalyMagazyn
            // 
            this.btnPrzypiszCalyMagazyn.Location = new System.Drawing.Point(555, 273);
            this.btnPrzypiszCalyMagazyn.Name = "btnPrzypiszCalyMagazyn";
            this.btnPrzypiszCalyMagazyn.Size = new System.Drawing.Size(233, 23);
            this.btnPrzypiszCalyMagazyn.TabIndex = 2;
            this.btnPrzypiszCalyMagazyn.Text = "Przypisz wszystkie materiały z magazynu";
            this.btnPrzypiszCalyMagazyn.UseVisualStyleBackColor = true;
            this.btnPrzypiszCalyMagazyn.Click += new System.EventHandler(this.btnPrzypiszCalyMagazyn_Click);
            // 
            // WyborOferty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.btnPrzypiszCalyMagazyn);
            this.Controls.Add(this.lblListaProduktowWMagazynie);
            this.Controls.Add(this.lblListaOfert);
            this.Controls.Add(this.dgvMagazynZawartosc);
            this.Controls.Add(this.dgvListaOfert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WyborOferty";
            this.Text = "Wybór oferty";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WyborOferty_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaOfert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazynZawartosc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaOfert;
        private System.Windows.Forms.Label lblListaOfert;
        private System.Windows.Forms.DataGridView dgvMagazynZawartosc;
        private System.Windows.Forms.Label lblListaProduktowWMagazynie;
        private System.Windows.Forms.Button btnPrzypiszCalyMagazyn;
    }
}