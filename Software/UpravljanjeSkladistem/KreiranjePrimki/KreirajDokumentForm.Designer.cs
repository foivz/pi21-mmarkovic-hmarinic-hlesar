
namespace KreiranjePrimki
{
    partial class KreirajDokumentForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spremiDokumentButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.odabirKlijentaComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datumIzradeDatePicker = new System.Windows.Forms.DateTimePicker();
            this.vrstaDokumentaComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjernaJedinicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjernaJedinica1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.robaNaLokacijisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeDokumentasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivMjerneJediniceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.robaBindingSource = new System.Windows.Forms.BindingSource();
            this.jedinicnaCijenaTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kolicinaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dodajStavkuButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.obrisiStavkuButton = new System.Windows.Forms.Button();
            this.izmjeniJedinicnaCijenaTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.izmjeniKolicinaTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.izmjeniStavkuButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.robaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpisRobe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicnaCijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDokumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRobaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeDokumentaBindingSource = new System.Windows.Forms.BindingSource();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robaBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeDokumentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spremiDokumentButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.odabirKlijentaComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.datumIzradeDatePicker);
            this.groupBox1.Controls.Add(this.vrstaDokumentaComboBox);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(300, 706);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalji dokumenta";
            // 
            // spremiDokumentButton
            // 
            this.spremiDokumentButton.Location = new System.Drawing.Point(8, 658);
            this.spremiDokumentButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spremiDokumentButton.Name = "spremiDokumentButton";
            this.spremiDokumentButton.Size = new System.Drawing.Size(284, 41);
            this.spremiDokumentButton.TabIndex = 11;
            this.spremiDokumentButton.Text = "Spremi dokument";
            this.spremiDokumentButton.UseVisualStyleBackColor = true;
            this.spremiDokumentButton.Click += new System.EventHandler(this.spremiDokumentButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum izrade dokumenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vrsta dokumenta:";
            // 
            // odabirKlijentaComboBox
            // 
            this.odabirKlijentaComboBox.FormattingEnabled = true;
            this.odabirKlijentaComboBox.Location = new System.Drawing.Point(20, 48);
            this.odabirKlijentaComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.odabirKlijentaComboBox.Name = "odabirKlijentaComboBox";
            this.odabirKlijentaComboBox.Size = new System.Drawing.Size(160, 24);
            this.odabirKlijentaComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Klijent:";
            // 
            // datumIzradeDatePicker
            // 
            this.datumIzradeDatePicker.Location = new System.Drawing.Point(20, 160);
            this.datumIzradeDatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datumIzradeDatePicker.Name = "datumIzradeDatePicker";
            this.datumIzradeDatePicker.Size = new System.Drawing.Size(265, 22);
            this.datumIzradeDatePicker.TabIndex = 1;
            // 
            // vrstaDokumentaComboBox
            // 
            this.vrstaDokumentaComboBox.FormattingEnabled = true;
            this.vrstaDokumentaComboBox.Location = new System.Drawing.Point(20, 97);
            this.vrstaDokumentaComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vrstaDokumentaComboBox.Name = "vrstaDokumentaComboBox";
            this.vrstaDokumentaComboBox.Size = new System.Drawing.Size(160, 24);
            this.vrstaDokumentaComboBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.jedinicnaCijenaTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.kolicinaTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dodajStavkuButton);
            this.groupBox2.Location = new System.Drawing.Point(324, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(727, 350);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odabir stavka";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.mjernaJedinicaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.mjernaJedinica1DataGridViewTextBoxColumn,
            this.robaNaLokacijisDataGridViewTextBoxColumn,
            this.stavkeDokumentasDataGridViewTextBoxColumn,
            this.nazivMjerneJediniceDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.robaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(707, 214);
            this.dataGridView1.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // mjernaJedinicaDataGridViewTextBoxColumn
            // 
            this.mjernaJedinicaDataGridViewTextBoxColumn.DataPropertyName = "MjernaJedinica";
            this.mjernaJedinicaDataGridViewTextBoxColumn.HeaderText = "MjernaJedinica";
            this.mjernaJedinicaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mjernaJedinicaDataGridViewTextBoxColumn.Name = "mjernaJedinicaDataGridViewTextBoxColumn";
            this.mjernaJedinicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.mjernaJedinicaDataGridViewTextBoxColumn.Visible = false;
            this.mjernaJedinicaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivDataGridViewTextBoxColumn.Width = 125;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            this.opisDataGridViewTextBoxColumn.Width = 125;
            // 
            // mjernaJedinica1DataGridViewTextBoxColumn
            // 
            this.mjernaJedinica1DataGridViewTextBoxColumn.DataPropertyName = "MjernaJedinica1";
            this.mjernaJedinica1DataGridViewTextBoxColumn.HeaderText = "MjernaJedinica1";
            this.mjernaJedinica1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mjernaJedinica1DataGridViewTextBoxColumn.Name = "mjernaJedinica1DataGridViewTextBoxColumn";
            this.mjernaJedinica1DataGridViewTextBoxColumn.ReadOnly = true;
            this.mjernaJedinica1DataGridViewTextBoxColumn.Visible = false;
            this.mjernaJedinica1DataGridViewTextBoxColumn.Width = 125;
            // 
            // robaNaLokacijisDataGridViewTextBoxColumn
            // 
            this.robaNaLokacijisDataGridViewTextBoxColumn.DataPropertyName = "RobaNaLokacijis";
            this.robaNaLokacijisDataGridViewTextBoxColumn.HeaderText = "RobaNaLokacijis";
            this.robaNaLokacijisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.robaNaLokacijisDataGridViewTextBoxColumn.Name = "robaNaLokacijisDataGridViewTextBoxColumn";
            this.robaNaLokacijisDataGridViewTextBoxColumn.ReadOnly = true;
            this.robaNaLokacijisDataGridViewTextBoxColumn.Visible = false;
            this.robaNaLokacijisDataGridViewTextBoxColumn.Width = 125;
            // 
            // stavkeDokumentasDataGridViewTextBoxColumn
            // 
            this.stavkeDokumentasDataGridViewTextBoxColumn.DataPropertyName = "StavkeDokumentas";
            this.stavkeDokumentasDataGridViewTextBoxColumn.HeaderText = "StavkeDokumentas";
            this.stavkeDokumentasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stavkeDokumentasDataGridViewTextBoxColumn.Name = "stavkeDokumentasDataGridViewTextBoxColumn";
            this.stavkeDokumentasDataGridViewTextBoxColumn.ReadOnly = true;
            this.stavkeDokumentasDataGridViewTextBoxColumn.Visible = false;
            this.stavkeDokumentasDataGridViewTextBoxColumn.Width = 125;
            // 
            // nazivMjerneJediniceDataGridViewTextBoxColumn
            // 
            this.nazivMjerneJediniceDataGridViewTextBoxColumn.DataPropertyName = "NazivMjerneJedinice";
            this.nazivMjerneJediniceDataGridViewTextBoxColumn.HeaderText = "Mjerna jedinica";
            this.nazivMjerneJediniceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazivMjerneJediniceDataGridViewTextBoxColumn.Name = "nazivMjerneJediniceDataGridViewTextBoxColumn";
            this.nazivMjerneJediniceDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivMjerneJediniceDataGridViewTextBoxColumn.Width = 125;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kolicinaDataGridViewTextBoxColumn.Visible = false;
            this.kolicinaDataGridViewTextBoxColumn.Width = 125;
            // 
            // robaBindingSource
            // 
            this.robaBindingSource.DataSource = typeof(SkladisteDb.Roba);
            // 
            // jedinicnaCijenaTextBox
            // 
            this.jedinicnaCijenaTextBox.Location = new System.Drawing.Point(149, 270);
            this.jedinicnaCijenaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jedinicnaCijenaTextBox.Name = "jedinicnaCijenaTextBox";
            this.jedinicnaCijenaTextBox.Size = new System.Drawing.Size(132, 22);
            this.jedinicnaCijenaTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Jedinična cijena:";
            // 
            // kolicinaTextBox
            // 
            this.kolicinaTextBox.Location = new System.Drawing.Point(8, 270);
            this.kolicinaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kolicinaTextBox.Name = "kolicinaTextBox";
            this.kolicinaTextBox.Size = new System.Drawing.Size(132, 22);
            this.kolicinaTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Količina:";
            // 
            // dodajStavkuButton
            // 
            this.dodajStavkuButton.Location = new System.Drawing.Point(8, 302);
            this.dodajStavkuButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dodajStavkuButton.Name = "dodajStavkuButton";
            this.dodajStavkuButton.Size = new System.Drawing.Size(275, 41);
            this.dodajStavkuButton.TabIndex = 2;
            this.dodajStavkuButton.Text = "Dodaj stavku";
            this.dodajStavkuButton.UseVisualStyleBackColor = true;
            this.dodajStavkuButton.Click += new System.EventHandler(this.dodajStavkuButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.obrisiStavkuButton);
            this.groupBox3.Controls.Add(this.izmjeniJedinicnaCijenaTextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.izmjeniKolicinaTextBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.izmjeniStavkuButton);
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(332, 372);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(727, 350);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pregled dodanih stavki";
            // 
            // obrisiStavkuButton
            // 
            this.obrisiStavkuButton.Location = new System.Drawing.Point(444, 302);
            this.obrisiStavkuButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.obrisiStavkuButton.Name = "obrisiStavkuButton";
            this.obrisiStavkuButton.Size = new System.Drawing.Size(275, 41);
            this.obrisiStavkuButton.TabIndex = 10;
            this.obrisiStavkuButton.Text = "Obrisi stavku";
            this.obrisiStavkuButton.UseVisualStyleBackColor = true;
            this.obrisiStavkuButton.Click += new System.EventHandler(this.obrisiStavkuButton_Click);
            // 
            // izmjeniJedinicnaCijenaTextBox
            // 
            this.izmjeniJedinicnaCijenaTextBox.Location = new System.Drawing.Point(149, 270);
            this.izmjeniJedinicnaCijenaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.izmjeniJedinicnaCijenaTextBox.Name = "izmjeniJedinicnaCijenaTextBox";
            this.izmjeniJedinicnaCijenaTextBox.Size = new System.Drawing.Size(132, 22);
            this.izmjeniJedinicnaCijenaTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 250);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Jedinična cijena:";
            // 
            // izmjeniKolicinaTextBox
            // 
            this.izmjeniKolicinaTextBox.Location = new System.Drawing.Point(8, 270);
            this.izmjeniKolicinaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.izmjeniKolicinaTextBox.Name = "izmjeniKolicinaTextBox";
            this.izmjeniKolicinaTextBox.Size = new System.Drawing.Size(132, 22);
            this.izmjeniKolicinaTextBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 250);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Količina:";
            // 
            // izmjeniStavkuButton
            // 
            this.izmjeniStavkuButton.Location = new System.Drawing.Point(8, 302);
            this.izmjeniStavkuButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.izmjeniStavkuButton.Name = "izmjeniStavkuButton";
            this.izmjeniStavkuButton.Size = new System.Drawing.Size(275, 41);
            this.izmjeniStavkuButton.TabIndex = 2;
            this.izmjeniStavkuButton.Text = "Izmjeni stavku";
            this.izmjeniStavkuButton.UseVisualStyleBackColor = true;
            this.izmjeniStavkuButton.Click += new System.EventHandler(this.izmjeniStavkuButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.robaDataGridViewTextBoxColumn,
            this.OpisRobe,
            this.kolicinaDataGridViewTextBoxColumn1,
            this.jedinicnaCijenaDataGridViewTextBoxColumn,
            this.UkupnaCijena,
            this.idDokumentDataGridViewTextBoxColumn,
            this.idRobaDataGridViewTextBoxColumn,
            this.dokumentDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.stavkeDokumentaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(8, 18);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(711, 214);
            this.dataGridView2.TabIndex = 1;
            // 
            // robaDataGridViewTextBoxColumn
            // 
            this.robaDataGridViewTextBoxColumn.DataPropertyName = "NazivRobe";
            this.robaDataGridViewTextBoxColumn.HeaderText = "Naziv robe";
            this.robaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.robaDataGridViewTextBoxColumn.Name = "robaDataGridViewTextBoxColumn";
            this.robaDataGridViewTextBoxColumn.ReadOnly = true;
            this.robaDataGridViewTextBoxColumn.Width = 125;
            // 
            // OpisRobe
            // 
            this.OpisRobe.DataPropertyName = "OpisRobe";
            this.OpisRobe.HeaderText = "Opis";
            this.OpisRobe.MinimumWidth = 6;
            this.OpisRobe.Name = "OpisRobe";
            this.OpisRobe.ReadOnly = true;
            this.OpisRobe.Width = 125;
            // 
            // kolicinaDataGridViewTextBoxColumn1
            // 
            this.kolicinaDataGridViewTextBoxColumn1.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn1.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.kolicinaDataGridViewTextBoxColumn1.Name = "kolicinaDataGridViewTextBoxColumn1";
            this.kolicinaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.kolicinaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // jedinicnaCijenaDataGridViewTextBoxColumn
            // 
            this.jedinicnaCijenaDataGridViewTextBoxColumn.DataPropertyName = "JedinicnaCijena";
            this.jedinicnaCijenaDataGridViewTextBoxColumn.HeaderText = "Jedinična cijena";
            this.jedinicnaCijenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jedinicnaCijenaDataGridViewTextBoxColumn.Name = "jedinicnaCijenaDataGridViewTextBoxColumn";
            this.jedinicnaCijenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.jedinicnaCijenaDataGridViewTextBoxColumn.Width = 125;
            // 
            // UkupnaCijena
            // 
            this.UkupnaCijena.DataPropertyName = "UkupnaCijena";
            this.UkupnaCijena.HeaderText = "Ukupna cijena";
            this.UkupnaCijena.MinimumWidth = 6;
            this.UkupnaCijena.Name = "UkupnaCijena";
            this.UkupnaCijena.ReadOnly = true;
            this.UkupnaCijena.Width = 125;
            // 
            // idDokumentDataGridViewTextBoxColumn
            // 
            this.idDokumentDataGridViewTextBoxColumn.DataPropertyName = "IdDokument";
            this.idDokumentDataGridViewTextBoxColumn.HeaderText = "IdDokument";
            this.idDokumentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDokumentDataGridViewTextBoxColumn.Name = "idDokumentDataGridViewTextBoxColumn";
            this.idDokumentDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDokumentDataGridViewTextBoxColumn.Visible = false;
            this.idDokumentDataGridViewTextBoxColumn.Width = 125;
            // 
            // idRobaDataGridViewTextBoxColumn
            // 
            this.idRobaDataGridViewTextBoxColumn.DataPropertyName = "IdRoba";
            this.idRobaDataGridViewTextBoxColumn.HeaderText = "IdRoba";
            this.idRobaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idRobaDataGridViewTextBoxColumn.Name = "idRobaDataGridViewTextBoxColumn";
            this.idRobaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idRobaDataGridViewTextBoxColumn.Visible = false;
            this.idRobaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dokumentDataGridViewTextBoxColumn
            // 
            this.dokumentDataGridViewTextBoxColumn.DataPropertyName = "Dokument";
            this.dokumentDataGridViewTextBoxColumn.HeaderText = "Dokument";
            this.dokumentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dokumentDataGridViewTextBoxColumn.Name = "dokumentDataGridViewTextBoxColumn";
            this.dokumentDataGridViewTextBoxColumn.ReadOnly = true;
            this.dokumentDataGridViewTextBoxColumn.Visible = false;
            this.dokumentDataGridViewTextBoxColumn.Width = 125;
            // 
            // stavkeDokumentaBindingSource
            // 
            this.stavkeDokumentaBindingSource.DataSource = typeof(SkladisteDb.StavkeDokumenta);
            this.stavkeDokumentaBindingSource.CurrentChanged += new System.EventHandler(this.stavkeDokumentaBindingSource_CurrentChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Roba";
            this.dataGridViewTextBoxColumn1.HeaderText = "Opis";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // KreirajDokumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 730);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KreirajDokumentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreiraj dokument";
            this.Load += new System.EventHandler(this.KreirajDokumentForm_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.KreirajDokumentForm_HelpRequested);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robaBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeDokumentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox vrstaDokumentaComboBox;
        private System.Windows.Forms.DateTimePicker datumIzradeDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox odabirKlijentaComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button spremiDokumentButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox jedinicnaCijenaTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kolicinaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button dodajStavkuButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button obrisiStavkuButton;
        private System.Windows.Forms.TextBox izmjeniJedinicnaCijenaTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox izmjeniKolicinaTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button izmjeniStavkuButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource robaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjernaJedinicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjernaJedinica1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn robaNaLokacijisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeDokumentasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivMjerneJediniceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stavkeDokumentaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn robaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpisRobe;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicnaCijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnaCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDokumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRobaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentDataGridViewTextBoxColumn;
    }
}