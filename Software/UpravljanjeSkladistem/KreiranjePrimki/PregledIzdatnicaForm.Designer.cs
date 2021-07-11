
namespace KreiranjePrimki
{
    partial class PregledIzdatnicaForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.obrisiIzdatnicuButton = new System.Windows.Forms.Button();
            this.novaIzdatnicaButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stavkeIzdatniceDataGridVIew = new System.Windows.Forms.DataGridView();
            this.robaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpisRobe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MjernaJedinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicnaCijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDokumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRobaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivRobeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisRobeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivMjerneJedinicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukupnaCijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeDokumentaBindingSource = new System.Windows.Forms.BindingSource();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pregledIzdatnicaDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klijent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klijentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnik1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaDokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeDokumentasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokumentBindingSource = new System.Windows.Forms.BindingSource();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeIzdatniceDataGridVIew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeDokumentaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pregledIzdatnicaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.obrisiIzdatnicuButton);
            this.groupBox3.Controls.Add(this.novaIzdatnicaButton);
            this.groupBox3.Location = new System.Drawing.Point(741, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(228, 276);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kontrole";
            // 
            // obrisiIzdatnicuButton
            // 
            this.obrisiIzdatnicuButton.ForeColor = System.Drawing.Color.Red;
            this.obrisiIzdatnicuButton.Location = new System.Drawing.Point(8, 202);
            this.obrisiIzdatnicuButton.Margin = new System.Windows.Forms.Padding(4);
            this.obrisiIzdatnicuButton.Name = "obrisiIzdatnicuButton";
            this.obrisiIzdatnicuButton.Size = new System.Drawing.Size(212, 58);
            this.obrisiIzdatnicuButton.TabIndex = 5;
            this.obrisiIzdatnicuButton.Text = "Obriši izdatnicu";
            this.obrisiIzdatnicuButton.UseVisualStyleBackColor = true;
            this.obrisiIzdatnicuButton.Click += new System.EventHandler(this.obrisiIzdatnicuButton_Click);
            // 
            // novaIzdatnicaButton
            // 
            this.novaIzdatnicaButton.Location = new System.Drawing.Point(8, 23);
            this.novaIzdatnicaButton.Margin = new System.Windows.Forms.Padding(4);
            this.novaIzdatnicaButton.Name = "novaIzdatnicaButton";
            this.novaIzdatnicaButton.Size = new System.Drawing.Size(212, 58);
            this.novaIzdatnicaButton.TabIndex = 4;
            this.novaIzdatnicaButton.Text = "Nova izdatnica";
            this.novaIzdatnicaButton.UseVisualStyleBackColor = true;
            this.novaIzdatnicaButton.Click += new System.EventHandler(this.novaIzdatnicaButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.stavkeIzdatniceDataGridVIew);
            this.groupBox2.Location = new System.Drawing.Point(13, 296);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(956, 222);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stavke odabrane izdatnice";
            // 
            // stavkeIzdatniceDataGridVIew
            // 
            this.stavkeIzdatniceDataGridVIew.AllowUserToAddRows = false;
            this.stavkeIzdatniceDataGridVIew.AllowUserToDeleteRows = false;
            this.stavkeIzdatniceDataGridVIew.AutoGenerateColumns = false;
            this.stavkeIzdatniceDataGridVIew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stavkeIzdatniceDataGridVIew.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.robaDataGridViewTextBoxColumn,
            this.OpisRobe,
            this.MjernaJedinica,
            this.kolicinaDataGridViewTextBoxColumn,
            this.jedinicnaCijenaDataGridViewTextBoxColumn,
            this.UkupnaCijena,
            this.idDokumentDataGridViewTextBoxColumn,
            this.idRobaDataGridViewTextBoxColumn,
            this.dokumentDataGridViewTextBoxColumn,
            this.nazivRobeDataGridViewTextBoxColumn,
            this.opisRobeDataGridViewTextBoxColumn,
            this.nazivMjerneJedinicaDataGridViewTextBoxColumn,
            this.ukupnaCijenaDataGridViewTextBoxColumn});
            this.stavkeIzdatniceDataGridVIew.DataSource = this.stavkeDokumentaBindingSource;
            this.stavkeIzdatniceDataGridVIew.Location = new System.Drawing.Point(8, 23);
            this.stavkeIzdatniceDataGridVIew.Margin = new System.Windows.Forms.Padding(4);
            this.stavkeIzdatniceDataGridVIew.Name = "stavkeIzdatniceDataGridVIew";
            this.stavkeIzdatniceDataGridVIew.ReadOnly = true;
            this.stavkeIzdatniceDataGridVIew.RowHeadersWidth = 51;
            this.stavkeIzdatniceDataGridVIew.Size = new System.Drawing.Size(940, 185);
            this.stavkeIzdatniceDataGridVIew.TabIndex = 1;
            // 
            // robaDataGridViewTextBoxColumn
            // 
            this.robaDataGridViewTextBoxColumn.DataPropertyName = "NazivRobe";
            this.robaDataGridViewTextBoxColumn.HeaderText = "Roba";
            this.robaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.robaDataGridViewTextBoxColumn.Name = "robaDataGridViewTextBoxColumn";
            this.robaDataGridViewTextBoxColumn.ReadOnly = true;
            this.robaDataGridViewTextBoxColumn.Width = 125;
            // 
            // OpisRobe
            // 
            this.OpisRobe.DataPropertyName = "OpisRobe";
            this.OpisRobe.HeaderText = "Opis robe";
            this.OpisRobe.MinimumWidth = 6;
            this.OpisRobe.Name = "OpisRobe";
            this.OpisRobe.ReadOnly = true;
            this.OpisRobe.Width = 125;
            // 
            // MjernaJedinica
            // 
            this.MjernaJedinica.DataPropertyName = "NazivMjerneJedinica";
            this.MjernaJedinica.HeaderText = "Mjerna jedinica";
            this.MjernaJedinica.MinimumWidth = 6;
            this.MjernaJedinica.Name = "MjernaJedinica";
            this.MjernaJedinica.ReadOnly = true;
            this.MjernaJedinica.Width = 125;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kolicinaDataGridViewTextBoxColumn.Width = 125;
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
            // nazivRobeDataGridViewTextBoxColumn
            // 
            this.nazivRobeDataGridViewTextBoxColumn.DataPropertyName = "NazivRobe";
            this.nazivRobeDataGridViewTextBoxColumn.HeaderText = "NazivRobe";
            this.nazivRobeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazivRobeDataGridViewTextBoxColumn.Name = "nazivRobeDataGridViewTextBoxColumn";
            this.nazivRobeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivRobeDataGridViewTextBoxColumn.Visible = false;
            this.nazivRobeDataGridViewTextBoxColumn.Width = 125;
            // 
            // opisRobeDataGridViewTextBoxColumn
            // 
            this.opisRobeDataGridViewTextBoxColumn.DataPropertyName = "OpisRobe";
            this.opisRobeDataGridViewTextBoxColumn.HeaderText = "OpisRobe";
            this.opisRobeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.opisRobeDataGridViewTextBoxColumn.Name = "opisRobeDataGridViewTextBoxColumn";
            this.opisRobeDataGridViewTextBoxColumn.ReadOnly = true;
            this.opisRobeDataGridViewTextBoxColumn.Visible = false;
            this.opisRobeDataGridViewTextBoxColumn.Width = 125;
            // 
            // nazivMjerneJedinicaDataGridViewTextBoxColumn
            // 
            this.nazivMjerneJedinicaDataGridViewTextBoxColumn.DataPropertyName = "NazivMjerneJedinica";
            this.nazivMjerneJedinicaDataGridViewTextBoxColumn.HeaderText = "NazivMjerneJedinica";
            this.nazivMjerneJedinicaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazivMjerneJedinicaDataGridViewTextBoxColumn.Name = "nazivMjerneJedinicaDataGridViewTextBoxColumn";
            this.nazivMjerneJedinicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivMjerneJedinicaDataGridViewTextBoxColumn.Visible = false;
            this.nazivMjerneJedinicaDataGridViewTextBoxColumn.Width = 125;
            // 
            // ukupnaCijenaDataGridViewTextBoxColumn
            // 
            this.ukupnaCijenaDataGridViewTextBoxColumn.DataPropertyName = "UkupnaCijena";
            this.ukupnaCijenaDataGridViewTextBoxColumn.HeaderText = "UkupnaCijena";
            this.ukupnaCijenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ukupnaCijenaDataGridViewTextBoxColumn.Name = "ukupnaCijenaDataGridViewTextBoxColumn";
            this.ukupnaCijenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ukupnaCijenaDataGridViewTextBoxColumn.Visible = false;
            this.ukupnaCijenaDataGridViewTextBoxColumn.Width = 125;
            // 
            // stavkeDokumentaBindingSource
            // 
            this.stavkeDokumentaBindingSource.DataSource = typeof(SkladisteDb.StavkeDokumenta);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pregledIzdatnicaDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(720, 276);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pregled izdatnica";
            // 
            // pregledIzdatnicaDataGridView
            // 
            this.pregledIzdatnicaDataGridView.AllowUserToAddRows = false;
            this.pregledIzdatnicaDataGridView.AllowUserToDeleteRows = false;
            this.pregledIzdatnicaDataGridView.AutoGenerateColumns = false;
            this.pregledIzdatnicaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pregledIzdatnicaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Klijent,
            this.datumDataGridViewTextBoxColumn,
            this.vrstaDataGridViewTextBoxColumn,
            this.klijentDataGridViewTextBoxColumn,
            this.unioDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.korisnik1DataGridViewTextBoxColumn,
            this.vrstaDokumentaDataGridViewTextBoxColumn,
            this.stavkeDokumentasDataGridViewTextBoxColumn});
            this.pregledIzdatnicaDataGridView.DataSource = this.dokumentBindingSource;
            this.pregledIzdatnicaDataGridView.Location = new System.Drawing.Point(8, 23);
            this.pregledIzdatnicaDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.pregledIzdatnicaDataGridView.Name = "pregledIzdatnicaDataGridView";
            this.pregledIzdatnicaDataGridView.ReadOnly = true;
            this.pregledIzdatnicaDataGridView.RowHeadersWidth = 51;
            this.pregledIzdatnicaDataGridView.Size = new System.Drawing.Size(704, 236);
            this.pregledIzdatnicaDataGridView.TabIndex = 0;
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
            // Klijent
            // 
            this.Klijent.DataPropertyName = "Korisnik";
            this.Klijent.HeaderText = "Klijent";
            this.Klijent.MinimumWidth = 6;
            this.Klijent.Name = "Klijent";
            this.Klijent.ReadOnly = true;
            this.Klijent.Width = 125;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumDataGridViewTextBoxColumn.Width = 125;
            // 
            // vrstaDataGridViewTextBoxColumn
            // 
            this.vrstaDataGridViewTextBoxColumn.DataPropertyName = "Vrsta";
            this.vrstaDataGridViewTextBoxColumn.HeaderText = "Vrsta";
            this.vrstaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vrstaDataGridViewTextBoxColumn.Name = "vrstaDataGridViewTextBoxColumn";
            this.vrstaDataGridViewTextBoxColumn.ReadOnly = true;
            this.vrstaDataGridViewTextBoxColumn.Visible = false;
            this.vrstaDataGridViewTextBoxColumn.Width = 125;
            // 
            // klijentDataGridViewTextBoxColumn
            // 
            this.klijentDataGridViewTextBoxColumn.DataPropertyName = "Klijent";
            this.klijentDataGridViewTextBoxColumn.HeaderText = "Klijent";
            this.klijentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.klijentDataGridViewTextBoxColumn.Name = "klijentDataGridViewTextBoxColumn";
            this.klijentDataGridViewTextBoxColumn.ReadOnly = true;
            this.klijentDataGridViewTextBoxColumn.Visible = false;
            this.klijentDataGridViewTextBoxColumn.Width = 125;
            // 
            // unioDataGridViewTextBoxColumn
            // 
            this.unioDataGridViewTextBoxColumn.DataPropertyName = "Korisnik1";
            this.unioDataGridViewTextBoxColumn.HeaderText = "Unio";
            this.unioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unioDataGridViewTextBoxColumn.Name = "unioDataGridViewTextBoxColumn";
            this.unioDataGridViewTextBoxColumn.ReadOnly = true;
            this.unioDataGridViewTextBoxColumn.Width = 125;
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.ReadOnly = true;
            this.korisnikDataGridViewTextBoxColumn.Visible = false;
            this.korisnikDataGridViewTextBoxColumn.Width = 125;
            // 
            // korisnik1DataGridViewTextBoxColumn
            // 
            this.korisnik1DataGridViewTextBoxColumn.DataPropertyName = "Korisnik1";
            this.korisnik1DataGridViewTextBoxColumn.HeaderText = "Korisnik1";
            this.korisnik1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.korisnik1DataGridViewTextBoxColumn.Name = "korisnik1DataGridViewTextBoxColumn";
            this.korisnik1DataGridViewTextBoxColumn.ReadOnly = true;
            this.korisnik1DataGridViewTextBoxColumn.Visible = false;
            this.korisnik1DataGridViewTextBoxColumn.Width = 125;
            // 
            // vrstaDokumentaDataGridViewTextBoxColumn
            // 
            this.vrstaDokumentaDataGridViewTextBoxColumn.DataPropertyName = "VrstaDokumenta";
            this.vrstaDokumentaDataGridViewTextBoxColumn.HeaderText = "VrstaDokumenta";
            this.vrstaDokumentaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vrstaDokumentaDataGridViewTextBoxColumn.Name = "vrstaDokumentaDataGridViewTextBoxColumn";
            this.vrstaDokumentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.vrstaDokumentaDataGridViewTextBoxColumn.Visible = false;
            this.vrstaDokumentaDataGridViewTextBoxColumn.Width = 125;
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
            // dokumentBindingSource
            // 
            this.dokumentBindingSource.DataSource = typeof(SkladisteDb.Dokument);
            this.dokumentBindingSource.CurrentChanged += new System.EventHandler(this.dokumentBindingSource_CurrentChanged);
            // 
            // PregledIzdatnicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 532);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PregledIzdatnicaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled izdatnica";
            this.Load += new System.EventHandler(this.PregledIzdatnicaForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stavkeIzdatniceDataGridVIew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeDokumentaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pregledIzdatnicaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button obrisiIzdatnicuButton;
        private System.Windows.Forms.Button novaIzdatnicaButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView stavkeIzdatniceDataGridVIew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView pregledIzdatnicaDataGridView;
        private System.Windows.Forms.BindingSource stavkeDokumentaBindingSource;
        private System.Windows.Forms.BindingSource dokumentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klijent;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klijentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnik1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaDokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeDokumentasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn robaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpisRobe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjernaJedinica;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicnaCijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnaCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDokumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRobaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivRobeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisRobeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivMjerneJedinicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukupnaCijenaDataGridViewTextBoxColumn;
    }
}