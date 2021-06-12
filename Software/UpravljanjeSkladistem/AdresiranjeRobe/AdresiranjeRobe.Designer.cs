
namespace AdresiranjeRobe
{
    partial class AdresiranjeRobe
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nemaNadlokacijeCheckBox = new System.Windows.Forms.CheckBox();
            this.dodajLokacijuButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nazivNoveLokacijeTextBox = new System.Windows.Forms.TextBox();
            this.nadlokacijaComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pregledLokacijaDgv = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.robaNaOdredenojLokacijiCheckBox = new System.Windows.Forms.CheckBox();
            this.robaDgv = new System.Windows.Forms.DataGridView();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pregledPodlokacijaDgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokacijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjernaJedinicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjernaJedinica1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.robaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nadlokacijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokacija1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokacija2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podlokacijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pregledLokacijaDgv)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.robaDgv)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pregledPodlokacijaDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokacijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.podlokacijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nemaNadlokacijeCheckBox);
            this.groupBox2.Controls.Add(this.dodajLokacijuButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nazivNoveLokacijeTextBox);
            this.groupBox2.Controls.Add(this.nadlokacijaComboBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 147);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nova Lokacija";
            // 
            // nemaNadlokacijeCheckBox
            // 
            this.nemaNadlokacijeCheckBox.AutoSize = true;
            this.nemaNadlokacijeCheckBox.Location = new System.Drawing.Point(158, 85);
            this.nemaNadlokacijeCheckBox.Name = "nemaNadlokacijeCheckBox";
            this.nemaNadlokacijeCheckBox.Size = new System.Drawing.Size(111, 17);
            this.nemaNadlokacijeCheckBox.TabIndex = 7;
            this.nemaNadlokacijeCheckBox.Text = "Nema nadlokacije";
            this.nemaNadlokacijeCheckBox.UseVisualStyleBackColor = true;
            this.nemaNadlokacijeCheckBox.CheckedChanged += new System.EventHandler(this.nemaNadlokacijeCheckBox_CheckedChanged);
            // 
            // dodajLokacijuButton
            // 
            this.dodajLokacijuButton.Location = new System.Drawing.Point(6, 118);
            this.dodajLokacijuButton.Name = "dodajLokacijuButton";
            this.dodajLokacijuButton.Size = new System.Drawing.Size(146, 23);
            this.dodajLokacijuButton.TabIndex = 6;
            this.dodajLokacijuButton.Text = "Dodaj lokaciju";
            this.dodajLokacijuButton.UseVisualStyleBackColor = true;
            this.dodajLokacijuButton.Click += new System.EventHandler(this.dodajLokacijuButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nadlokacija (opcionalno)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naziv nove lokacije:";
            // 
            // nazivNoveLokacijeTextBox
            // 
            this.nazivNoveLokacijeTextBox.Location = new System.Drawing.Point(6, 43);
            this.nazivNoveLokacijeTextBox.Name = "nazivNoveLokacijeTextBox";
            this.nazivNoveLokacijeTextBox.Size = new System.Drawing.Size(146, 20);
            this.nazivNoveLokacijeTextBox.TabIndex = 3;
            // 
            // nadlokacijaComboBox
            // 
            this.nadlokacijaComboBox.FormattingEnabled = true;
            this.nadlokacijaComboBox.Location = new System.Drawing.Point(6, 83);
            this.nadlokacijaComboBox.Name = "nadlokacijaComboBox";
            this.nadlokacijaComboBox.Size = new System.Drawing.Size(146, 21);
            this.nadlokacijaComboBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pregledLokacijaDgv);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 309);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pregled lokacija";
            // 
            // pregledLokacijaDgv
            // 
            this.pregledLokacijaDgv.AllowUserToAddRows = false;
            this.pregledLokacijaDgv.AllowUserToDeleteRows = false;
            this.pregledLokacijaDgv.AutoGenerateColumns = false;
            this.pregledLokacijaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pregledLokacijaDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.nadlokacijaDataGridViewTextBoxColumn,
            this.lokacija1DataGridViewTextBoxColumn,
            this.lokacija2DataGridViewTextBoxColumn});
            this.pregledLokacijaDgv.DataSource = this.lokacijaBindingSource;
            this.pregledLokacijaDgv.Location = new System.Drawing.Point(6, 19);
            this.pregledLokacijaDgv.Name = "pregledLokacijaDgv";
            this.pregledLokacijaDgv.ReadOnly = true;
            this.pregledLokacijaDgv.Size = new System.Drawing.Size(348, 261);
            this.pregledLokacijaDgv.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.robaNaOdredenojLokacijiCheckBox);
            this.groupBox4.Controls.Add(this.robaDgv);
            this.groupBox4.Location = new System.Drawing.Point(384, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(506, 309);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Roba na odabranoj lokaciji";
            // 
            // robaNaOdredenojLokacijiCheckBox
            // 
            this.robaNaOdredenojLokacijiCheckBox.AutoSize = true;
            this.robaNaOdredenojLokacijiCheckBox.Location = new System.Drawing.Point(6, 286);
            this.robaNaOdredenojLokacijiCheckBox.Name = "robaNaOdredenojLokacijiCheckBox";
            this.robaNaOdredenojLokacijiCheckBox.Size = new System.Drawing.Size(150, 17);
            this.robaNaOdredenojLokacijiCheckBox.TabIndex = 8;
            this.robaNaOdredenojLokacijiCheckBox.Text = "Prikazi samo direktnu robu";
            this.robaNaOdredenojLokacijiCheckBox.UseVisualStyleBackColor = true;
            this.robaNaOdredenojLokacijiCheckBox.CheckedChanged += new System.EventHandler(this.robaNaOdredenojLokacijiCheckBox_CheckedChanged);
            // 
            // robaDgv
            // 
            this.robaDgv.AllowUserToAddRows = false;
            this.robaDgv.AllowUserToDeleteRows = false;
            this.robaDgv.AutoGenerateColumns = false;
            this.robaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.robaDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nazivDataGridViewTextBoxColumn1,
            this.Kolicina,
            this.mjernaJedinicaDataGridViewTextBoxColumn,
            this.mjernaJedinica1DataGridViewTextBoxColumn});
            this.robaDgv.DataSource = this.robaBindingSource;
            this.robaDgv.Location = new System.Drawing.Point(6, 19);
            this.robaDgv.Name = "robaDgv";
            this.robaDgv.ReadOnly = true;
            this.robaDgv.Size = new System.Drawing.Size(494, 261);
            this.robaDgv.TabIndex = 1;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pregledPodlokacijaDgv);
            this.groupBox3.Location = new System.Drawing.Point(390, 327);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(494, 147);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pregled podlokacija odabrane lokacije";
            // 
            // pregledPodlokacijaDgv
            // 
            this.pregledPodlokacijaDgv.AllowUserToAddRows = false;
            this.pregledPodlokacijaDgv.AllowUserToDeleteRows = false;
            this.pregledPodlokacijaDgv.AutoGenerateColumns = false;
            this.pregledPodlokacijaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pregledPodlokacijaDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pregledPodlokacijaDgv.DataSource = this.podlokacijaBindingSource;
            this.pregledPodlokacijaDgv.Location = new System.Drawing.Point(6, 19);
            this.pregledPodlokacijaDgv.Name = "pregledPodlokacijaDgv";
            this.pregledPodlokacijaDgv.ReadOnly = true;
            this.pregledPodlokacijaDgv.Size = new System.Drawing.Size(482, 122);
            this.pregledPodlokacijaDgv.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Naziv";
            this.dataGridViewTextBoxColumn2.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nadlokacija";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nadlokacija";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Lokacija1";
            this.dataGridViewTextBoxColumn4.HeaderText = "Lokacija1";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Lokacija2";
            this.dataGridViewTextBoxColumn5.HeaderText = "Lokacija2";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // lokacijaBindingSource
            // 
            this.lokacijaBindingSource.DataSource = typeof(SkladisteDb.Lokacija);
            this.lokacijaBindingSource.CurrentChanged += new System.EventHandler(this.lokacijaBindingSource_CurrentChanged);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            this.nazivDataGridViewTextBoxColumn1.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
            this.nazivDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // mjernaJedinicaDataGridViewTextBoxColumn
            // 
            this.mjernaJedinicaDataGridViewTextBoxColumn.DataPropertyName = "MjernaJedinica";
            this.mjernaJedinicaDataGridViewTextBoxColumn.HeaderText = "MjernaJedinica";
            this.mjernaJedinicaDataGridViewTextBoxColumn.Name = "mjernaJedinicaDataGridViewTextBoxColumn";
            this.mjernaJedinicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mjernaJedinica1DataGridViewTextBoxColumn
            // 
            this.mjernaJedinica1DataGridViewTextBoxColumn.DataPropertyName = "MjernaJedinica1";
            this.mjernaJedinica1DataGridViewTextBoxColumn.HeaderText = "MjernaJedinica1";
            this.mjernaJedinica1DataGridViewTextBoxColumn.Name = "mjernaJedinica1DataGridViewTextBoxColumn";
            this.mjernaJedinica1DataGridViewTextBoxColumn.ReadOnly = true;
            this.mjernaJedinica1DataGridViewTextBoxColumn.Visible = false;
            // 
            // robaBindingSource
            // 
            this.robaBindingSource.DataSource = typeof(SkladisteDb.Roba);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nadlokacijaDataGridViewTextBoxColumn
            // 
            this.nadlokacijaDataGridViewTextBoxColumn.DataPropertyName = "Nadlokacija";
            this.nadlokacijaDataGridViewTextBoxColumn.HeaderText = "Nadlokacija";
            this.nadlokacijaDataGridViewTextBoxColumn.Name = "nadlokacijaDataGridViewTextBoxColumn";
            this.nadlokacijaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lokacija1DataGridViewTextBoxColumn
            // 
            this.lokacija1DataGridViewTextBoxColumn.DataPropertyName = "Lokacija1";
            this.lokacija1DataGridViewTextBoxColumn.HeaderText = "Lokacija1";
            this.lokacija1DataGridViewTextBoxColumn.Name = "lokacija1DataGridViewTextBoxColumn";
            this.lokacija1DataGridViewTextBoxColumn.ReadOnly = true;
            this.lokacija1DataGridViewTextBoxColumn.Visible = false;
            // 
            // lokacija2DataGridViewTextBoxColumn
            // 
            this.lokacija2DataGridViewTextBoxColumn.DataPropertyName = "Lokacija2";
            this.lokacija2DataGridViewTextBoxColumn.HeaderText = "Lokacija2";
            this.lokacija2DataGridViewTextBoxColumn.Name = "lokacija2DataGridViewTextBoxColumn";
            this.lokacija2DataGridViewTextBoxColumn.ReadOnly = true;
            this.lokacija2DataGridViewTextBoxColumn.Visible = false;
            // 
            // podlokacijaBindingSource
            // 
            this.podlokacijaBindingSource.DataSource = typeof(SkladisteDb.Lokacija);
            // 
            // AdresiranjeRobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 486);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdresiranjeRobe";
            this.Text = "Adresiranje Robe";
            this.Load += new System.EventHandler(this.AdresiranjeRobe_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pregledLokacijaDgv)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.robaDgv)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pregledPodlokacijaDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokacijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.podlokacijaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox nemaNadlokacijeCheckBox;
        private System.Windows.Forms.Button dodajLokacijuButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nazivNoveLokacijeTextBox;
        private System.Windows.Forms.ComboBox nadlokacijaComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView pregledLokacijaDgv;
        private System.Windows.Forms.BindingSource lokacijaBindingSource;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView robaDgv;
        private System.Windows.Forms.CheckBox robaNaOdredenojLokacijiCheckBox;
        private System.Windows.Forms.BindingSource robaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokacijasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn robasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nadlokacijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokacija1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokacija2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjernaJedinicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjernaJedinica1DataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView pregledPodlokacijaDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource podlokacijaBindingSource;
    }
}

