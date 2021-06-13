
namespace UnosRobe
{
    partial class UnosRobeForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nazivMjerneJediniceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kraticaMjerneJediniceTextBox = new System.Windows.Forms.TextBox();
            this.dodajMjernuJedinicuButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nazivRobeTextBox = new System.Windows.Forms.TextBox();
            this.opisRobeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mjernaJedinicaComboBox = new System.Windows.Forms.ComboBox();
            this.dodajRobuButton = new System.Windows.Forms.Button();
            this.urediRobuButton = new System.Windows.Forms.Button();
            this.obrisiRobuButton = new System.Windows.Forms.Button();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivMjerneJedinice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.odabirLokacijeButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.odabirRobeButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.odabranaLokacijaTextBox = new System.Windows.Forms.TextBox();
            this.pregledNazivTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pregledOpisTextBox = new System.Windows.Forms.TextBox();
            this.pregledMjernaJedinicaTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.kolicinaTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dodajNaLokacijuButton = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjernaJedinicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjernaJedinica1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.robaNaLokacijisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeDokumentasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.robaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.robaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dodajRobuButton);
            this.groupBox1.Controls.Add(this.mjernaJedinicaComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.opisRobeTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nazivRobeTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos robe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dodajMjernuJedinicuButton);
            this.groupBox2.Controls.Add(this.kraticaMjerneJediniceTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nazivMjerneJediniceTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 153);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nova mjerna jedinica";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.Opis,
            this.NazivMjerneJedinice,
            this.mjernaJedinicaDataGridViewTextBoxColumn,
            this.mjernaJedinica1DataGridViewTextBoxColumn,
            this.robaNaLokacijisDataGridViewTextBoxColumn,
            this.stavkeDokumentasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.robaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(445, 174);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.obrisiRobuButton);
            this.groupBox3.Controls.Add(this.urediRobuButton);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(196, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(458, 290);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prikaz svih vrsta robe";
            // 
            // nazivMjerneJediniceTextBox
            // 
            this.nazivMjerneJediniceTextBox.Location = new System.Drawing.Point(6, 39);
            this.nazivMjerneJediniceTextBox.Name = "nazivMjerneJediniceTextBox";
            this.nazivMjerneJediniceTextBox.Size = new System.Drawing.Size(110, 20);
            this.nazivMjerneJediniceTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv mjerne jedinice:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kratica mjerne jedinice:";
            // 
            // kraticaMjerneJediniceTextBox
            // 
            this.kraticaMjerneJediniceTextBox.Location = new System.Drawing.Point(6, 78);
            this.kraticaMjerneJediniceTextBox.Name = "kraticaMjerneJediniceTextBox";
            this.kraticaMjerneJediniceTextBox.Size = new System.Drawing.Size(110, 20);
            this.kraticaMjerneJediniceTextBox.TabIndex = 3;
            // 
            // dodajMjernuJedinicuButton
            // 
            this.dodajMjernuJedinicuButton.Location = new System.Drawing.Point(6, 112);
            this.dodajMjernuJedinicuButton.Name = "dodajMjernuJedinicuButton";
            this.dodajMjernuJedinicuButton.Size = new System.Drawing.Size(110, 23);
            this.dodajMjernuJedinicuButton.TabIndex = 4;
            this.dodajMjernuJedinicuButton.Text = "Spremi";
            this.dodajMjernuJedinicuButton.UseVisualStyleBackColor = true;
            this.dodajMjernuJedinicuButton.Click += new System.EventHandler(this.dodajMjernuJedinicuButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Naziv robe:";
            // 
            // nazivRobeTextBox
            // 
            this.nazivRobeTextBox.Location = new System.Drawing.Point(6, 37);
            this.nazivRobeTextBox.Name = "nazivRobeTextBox";
            this.nazivRobeTextBox.Size = new System.Drawing.Size(110, 20);
            this.nazivRobeTextBox.TabIndex = 5;
            // 
            // opisRobeTextBox
            // 
            this.opisRobeTextBox.Location = new System.Drawing.Point(6, 90);
            this.opisRobeTextBox.Name = "opisRobeTextBox";
            this.opisRobeTextBox.Size = new System.Drawing.Size(162, 20);
            this.opisRobeTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Opis robe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mjerna jedinica:";
            // 
            // mjernaJedinicaComboBox
            // 
            this.mjernaJedinicaComboBox.FormattingEnabled = true;
            this.mjernaJedinicaComboBox.Location = new System.Drawing.Point(6, 143);
            this.mjernaJedinicaComboBox.Name = "mjernaJedinicaComboBox";
            this.mjernaJedinicaComboBox.Size = new System.Drawing.Size(121, 21);
            this.mjernaJedinicaComboBox.TabIndex = 10;
            // 
            // dodajRobuButton
            // 
            this.dodajRobuButton.Location = new System.Drawing.Point(0, 225);
            this.dodajRobuButton.Name = "dodajRobuButton";
            this.dodajRobuButton.Size = new System.Drawing.Size(168, 59);
            this.dodajRobuButton.TabIndex = 5;
            this.dodajRobuButton.Text = "Spremi";
            this.dodajRobuButton.UseVisualStyleBackColor = true;
            this.dodajRobuButton.Click += new System.EventHandler(this.dodajRobuButton_Click);
            // 
            // urediRobuButton
            // 
            this.urediRobuButton.Location = new System.Drawing.Point(6, 225);
            this.urediRobuButton.Name = "urediRobuButton";
            this.urediRobuButton.Size = new System.Drawing.Size(121, 59);
            this.urediRobuButton.TabIndex = 3;
            this.urediRobuButton.Text = "Uredi odabranu robu";
            this.urediRobuButton.UseVisualStyleBackColor = true;
            this.urediRobuButton.Click += new System.EventHandler(this.urediRobuButton_Click);
            // 
            // obrisiRobuButton
            // 
            this.obrisiRobuButton.ForeColor = System.Drawing.Color.Red;
            this.obrisiRobuButton.Location = new System.Drawing.Point(330, 225);
            this.obrisiRobuButton.Name = "obrisiRobuButton";
            this.obrisiRobuButton.Size = new System.Drawing.Size(121, 59);
            this.obrisiRobuButton.TabIndex = 4;
            this.obrisiRobuButton.Text = "Obriši odabranu robu";
            this.obrisiRobuButton.UseVisualStyleBackColor = true;
            this.obrisiRobuButton.Click += new System.EventHandler(this.obrisiRobuButton_Click);
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // NazivMjerneJedinice
            // 
            this.NazivMjerneJedinice.DataPropertyName = "NazivMjerneJedinice";
            this.NazivMjerneJedinice.HeaderText = "Mjerna jedinica";
            this.NazivMjerneJedinice.Name = "NazivMjerneJedinice";
            this.NazivMjerneJedinice.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dodajNaLokacijuButton);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.kolicinaTextBox);
            this.groupBox4.Controls.Add(this.odabranaLokacijaTextBox);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.odabirRobeButton);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.odabirLokacijeButton);
            this.groupBox4.Location = new System.Drawing.Point(142, 308);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(505, 153);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dodavanje robe na lokaciju";
            // 
            // odabirLokacijeButton
            // 
            this.odabirLokacijeButton.Location = new System.Drawing.Point(6, 103);
            this.odabirLokacijeButton.Name = "odabirLokacijeButton";
            this.odabirLokacijeButton.Size = new System.Drawing.Size(165, 41);
            this.odabirLokacijeButton.TabIndex = 0;
            this.odabirLokacijeButton.Text = "Odabir lokacije";
            this.odabirLokacijeButton.UseVisualStyleBackColor = true;
            this.odabirLokacijeButton.Click += new System.EventHandler(this.odabirLokacijeButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Odabrana lokacija:";
            // 
            // odabirRobeButton
            // 
            this.odabirRobeButton.Location = new System.Drawing.Point(9, 23);
            this.odabirRobeButton.Name = "odabirRobeButton";
            this.odabirRobeButton.Size = new System.Drawing.Size(162, 38);
            this.odabirRobeButton.TabIndex = 8;
            this.odabirRobeButton.Text = "Odabir robe";
            this.odabirRobeButton.UseVisualStyleBackColor = true;
            this.odabirRobeButton.Click += new System.EventHandler(this.odabirRobeButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.pregledMjernaJedinicaTextBox);
            this.groupBox5.Controls.Add(this.pregledOpisTextBox);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.pregledNazivTextBox);
            this.groupBox5.Location = new System.Drawing.Point(177, 31);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(220, 104);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Odabrana roba";
            // 
            // odabranaLokacijaTextBox
            // 
            this.odabranaLokacijaTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.odabranaLokacijaTextBox.ForeColor = System.Drawing.Color.Red;
            this.odabranaLokacijaTextBox.Location = new System.Drawing.Point(9, 78);
            this.odabranaLokacijaTextBox.Name = "odabranaLokacijaTextBox";
            this.odabranaLokacijaTextBox.ReadOnly = true;
            this.odabranaLokacijaTextBox.Size = new System.Drawing.Size(162, 20);
            this.odabranaLokacijaTextBox.TabIndex = 5;
            this.odabranaLokacijaTextBox.Text = "Lokacija nije odabrana";
            // 
            // pregledNazivTextBox
            // 
            this.pregledNazivTextBox.Location = new System.Drawing.Point(99, 23);
            this.pregledNazivTextBox.Name = "pregledNazivTextBox";
            this.pregledNazivTextBox.ReadOnly = true;
            this.pregledNazivTextBox.Size = new System.Drawing.Size(110, 20);
            this.pregledNazivTextBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Naziv robe:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Opis robe:";
            // 
            // pregledOpisTextBox
            // 
            this.pregledOpisTextBox.Location = new System.Drawing.Point(99, 48);
            this.pregledOpisTextBox.Name = "pregledOpisTextBox";
            this.pregledOpisTextBox.ReadOnly = true;
            this.pregledOpisTextBox.Size = new System.Drawing.Size(110, 20);
            this.pregledOpisTextBox.TabIndex = 12;
            // 
            // pregledMjernaJedinicaTextBox
            // 
            this.pregledMjernaJedinicaTextBox.Location = new System.Drawing.Point(99, 74);
            this.pregledMjernaJedinicaTextBox.Name = "pregledMjernaJedinicaTextBox";
            this.pregledMjernaJedinicaTextBox.ReadOnly = true;
            this.pregledMjernaJedinicaTextBox.Size = new System.Drawing.Size(110, 20);
            this.pregledMjernaJedinicaTextBox.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Mjerna jedinica:";
            // 
            // kolicinaTextBox
            // 
            this.kolicinaTextBox.Location = new System.Drawing.Point(403, 39);
            this.kolicinaTextBox.Name = "kolicinaTextBox";
            this.kolicinaTextBox.Size = new System.Drawing.Size(96, 20);
            this.kolicinaTextBox.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(403, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Količina:";
            // 
            // dodajNaLokacijuButton
            // 
            this.dodajNaLokacijuButton.Location = new System.Drawing.Point(406, 67);
            this.dodajNaLokacijuButton.Name = "dodajNaLokacijuButton";
            this.dodajNaLokacijuButton.Size = new System.Drawing.Size(93, 77);
            this.dodajNaLokacijuButton.TabIndex = 16;
            this.dodajNaLokacijuButton.Text = "Dodaj";
            this.dodajNaLokacijuButton.UseVisualStyleBackColor = true;
            this.dodajNaLokacijuButton.Click += new System.EventHandler(this.dodajNaLokacijuButton_Click);
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
            // mjernaJedinicaDataGridViewTextBoxColumn
            // 
            this.mjernaJedinicaDataGridViewTextBoxColumn.DataPropertyName = "MjernaJedinica";
            this.mjernaJedinicaDataGridViewTextBoxColumn.HeaderText = "MjernaJedinica";
            this.mjernaJedinicaDataGridViewTextBoxColumn.Name = "mjernaJedinicaDataGridViewTextBoxColumn";
            this.mjernaJedinicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.mjernaJedinicaDataGridViewTextBoxColumn.Visible = false;
            // 
            // mjernaJedinica1DataGridViewTextBoxColumn
            // 
            this.mjernaJedinica1DataGridViewTextBoxColumn.DataPropertyName = "MjernaJedinica1";
            this.mjernaJedinica1DataGridViewTextBoxColumn.HeaderText = "MjernaJedinica1";
            this.mjernaJedinica1DataGridViewTextBoxColumn.Name = "mjernaJedinica1DataGridViewTextBoxColumn";
            this.mjernaJedinica1DataGridViewTextBoxColumn.ReadOnly = true;
            this.mjernaJedinica1DataGridViewTextBoxColumn.Visible = false;
            // 
            // robaNaLokacijisDataGridViewTextBoxColumn
            // 
            this.robaNaLokacijisDataGridViewTextBoxColumn.DataPropertyName = "RobaNaLokacijis";
            this.robaNaLokacijisDataGridViewTextBoxColumn.HeaderText = "RobaNaLokacijis";
            this.robaNaLokacijisDataGridViewTextBoxColumn.Name = "robaNaLokacijisDataGridViewTextBoxColumn";
            this.robaNaLokacijisDataGridViewTextBoxColumn.ReadOnly = true;
            this.robaNaLokacijisDataGridViewTextBoxColumn.Visible = false;
            // 
            // stavkeDokumentasDataGridViewTextBoxColumn
            // 
            this.stavkeDokumentasDataGridViewTextBoxColumn.DataPropertyName = "StavkeDokumentas";
            this.stavkeDokumentasDataGridViewTextBoxColumn.HeaderText = "StavkeDokumentas";
            this.stavkeDokumentasDataGridViewTextBoxColumn.Name = "stavkeDokumentasDataGridViewTextBoxColumn";
            this.stavkeDokumentasDataGridViewTextBoxColumn.ReadOnly = true;
            this.stavkeDokumentasDataGridViewTextBoxColumn.Visible = false;
            // 
            // robaBindingSource
            // 
            this.robaBindingSource.DataSource = typeof(SkladisteDb.Roba);
            this.robaBindingSource.CurrentChanged += new System.EventHandler(this.robaBindingSource_CurrentChanged);
            // 
            // UnosRobeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 473);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UnosRobeForm";
            this.Text = "Unos robe";
            this.Load += new System.EventHandler(this.UnosRobeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.robaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource robaBindingSource;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button dodajRobuButton;
        private System.Windows.Forms.ComboBox mjernaJedinicaComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox opisRobeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nazivRobeTextBox;
        private System.Windows.Forms.Button dodajMjernuJedinicuButton;
        private System.Windows.Forms.TextBox kraticaMjerneJediniceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nazivMjerneJediniceTextBox;
        private System.Windows.Forms.Button urediRobuButton;
        private System.Windows.Forms.Button obrisiRobuButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivMjerneJedinice;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjernaJedinicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjernaJedinica1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn robaNaLokacijisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeDokumentasDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button odabirLokacijeButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button dodajNaLokacijuButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox kolicinaTextBox;
        private System.Windows.Forms.TextBox odabranaLokacijaTextBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pregledMjernaJedinicaTextBox;
        private System.Windows.Forms.TextBox pregledOpisTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pregledNazivTextBox;
        private System.Windows.Forms.Button odabirRobeButton;
    }
}

