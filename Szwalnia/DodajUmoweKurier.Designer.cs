namespace Szwalnia
{
    partial class DodajUmoweKurier
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbKurier = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.szwalniaDataSet6 = new Szwalnia.SzwalniaDataSet6();
            this.szwalniaDataSet6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.szwalniaDataSet4 = new Szwalnia.SzwalniaDataSet4();
            this.szwalniaDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dostawcyZaopatrzenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dostawcy_ZaopatrzenieTableAdapter = new Szwalnia.SzwalniaDataSet4TableAdapters.Dostawcy_ZaopatrzenieTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostawcyZaopatrzenieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wprowadź dane umowy.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwa kuriera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data zawarcia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Czas dostawy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Koszt (za km)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Koszt stały";
            // 
            // cmbKurier
            // 
            this.cmbKurier.DataSource = this.dostawcyZaopatrzenieBindingSource;
            this.cmbKurier.DisplayMember = "Nazwa";
            this.cmbKurier.FormattingEnabled = true;
            this.cmbKurier.Location = new System.Drawing.Point(157, 50);
            this.cmbKurier.Name = "cmbKurier";
            this.cmbKurier.Size = new System.Drawing.Size(121, 21);
            this.cmbKurier.TabIndex = 6;
            this.cmbKurier.ValueMember = "Nazwa";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(157, 103);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 7;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(158, 129);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 8;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(157, 155);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 76);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // szwalniaDataSet6
            // 
            this.szwalniaDataSet6.DataSetName = "SzwalniaDataSet6";
            this.szwalniaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // szwalniaDataSet6BindingSource
            // 
            this.szwalniaDataSet6BindingSource.DataSource = this.szwalniaDataSet6;
            this.szwalniaDataSet6BindingSource.Position = 0;
            // 
            // szwalniaDataSet4
            // 
            this.szwalniaDataSet4.DataSetName = "SzwalniaDataSet4";
            this.szwalniaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // szwalniaDataSet4BindingSource
            // 
            this.szwalniaDataSet4BindingSource.DataSource = this.szwalniaDataSet4;
            this.szwalniaDataSet4BindingSource.Position = 0;
            // 
            // dostawcyZaopatrzenieBindingSource
            // 
            this.dostawcyZaopatrzenieBindingSource.DataMember = "Dostawcy_Zaopatrzenie";
            this.dostawcyZaopatrzenieBindingSource.DataSource = this.szwalniaDataSet4BindingSource;
            // 
            // dostawcy_ZaopatrzenieTableAdapter
            // 
            this.dostawcy_ZaopatrzenieTableAdapter.ClearBeforeFill = true;
            // 
            // DodajUmoweKurier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 200);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cmbKurier);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodajUmoweKurier";
            this.Text = "Dodaj nową umowę z kurierem";
            this.Load += new System.EventHandler(this.DodajUmoweKurier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostawcyZaopatrzenieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbKurier;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource szwalniaDataSet6BindingSource;
        private SzwalniaDataSet6 szwalniaDataSet6;
        private System.Windows.Forms.BindingSource szwalniaDataSet4BindingSource;
        private SzwalniaDataSet4 szwalniaDataSet4;
        private System.Windows.Forms.BindingSource dostawcyZaopatrzenieBindingSource;
        private SzwalniaDataSet4TableAdapters.Dostawcy_ZaopatrzenieTableAdapter dostawcy_ZaopatrzenieTableAdapter;
    }
}