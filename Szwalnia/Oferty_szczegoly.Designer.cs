namespace Szwalnia
{
    partial class Oferty_szczegoly
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
            this.components = new System.ComponentModel.Container();
            this.lblMain = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.szwalniaDataSet = new Szwalnia.SzwalniaDataSet();
            this.ofertaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ofertaTableAdapter = new Szwalnia.SzwalniaDataSetTableAdapters.OfertaTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt11 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofertaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMain.Location = new System.Drawing.Point(150, 18);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(153, 46);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "lnlMain";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(226, 102);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(201, 22);
            this.txt1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwa elemntu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Oznaczenie elemntu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(226, 130);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(201, 22);
            this.txt2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nazwa dostawcy";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(226, 158);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(201, 22);
            this.txt3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cena jednosntkowa";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ilość minimalna zamówienia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ilość maksymalna zamówienia";
            // 
            // szwalniaDataSet
            // 
            this.szwalniaDataSet.DataSetName = "SzwalniaDataSet";
            this.szwalniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ofertaBindingSource
            // 
            this.ofertaBindingSource.DataMember = "Oferta";
            this.ofertaBindingSource.DataSource = this.szwalniaDataSet;
            // 
            // ofertaTableAdapter
            // 
            this.ofertaTableAdapter.ClearBeforeFill = true;
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(226, 245);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(201, 22);
            this.txt6.TabIndex = 18;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(226, 217);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(201, 22);
            this.txt5.TabIndex = 17;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(226, 189);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(201, 22);
            this.txt4.TabIndex = 16;
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(226, 273);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(201, 22);
            this.txt7.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ilość w paczce";
            // 
            // txt8
            // 
            this.txt8.Location = new System.Drawing.Point(226, 301);
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(201, 22);
            this.txt8.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Jednostka";
            // 
            // txt9
            // 
            this.txt9.AllowDrop = true;
            this.txt9.Location = new System.Drawing.Point(226, 329);
            this.txt9.Name = "txt9";
            this.txt9.Size = new System.Drawing.Size(201, 22);
            this.txt9.TabIndex = 24;
            this.txt9.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label9
            // 
            this.label9.AllowDrop = true;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Ilość paczek w opakowaniu";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txt10
            // 
            this.txt10.Location = new System.Drawing.Point(226, 357);
            this.txt10.Name = "txt10";
            this.txt10.Size = new System.Drawing.Size(201, 22);
            this.txt10.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Deklarowyany czas dostawy";
            // 
            // txt11
            // 
            this.txt11.Location = new System.Drawing.Point(226, 385);
            this.txt11.Name = "txt11";
            this.txt11.Size = new System.Drawing.Size(201, 22);
            this.txt11.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(135, 385);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Data oferty";
            // 
            // Oferty_szczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 450);
            this.Controls.Add(this.txt11);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt10);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lblMain);
            this.Name = "Oferty_szczegoly";
            this.Text = "Oferty_szczegoly";
            this.Load += new System.EventHandler(this.Oferty_szczegoly_Load);
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofertaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private SzwalniaDataSet szwalniaDataSet;
        private System.Windows.Forms.BindingSource ofertaBindingSource;
        private SzwalniaDataSetTableAdapters.OfertaTableAdapter ofertaTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt11;
        private System.Windows.Forms.Label label11;
    }
}