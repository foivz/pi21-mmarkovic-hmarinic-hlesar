
namespace KreiranjePrimki
{
    partial class PregledPrimkiForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klijent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnik1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaDokumentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeDokumentasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokumentBindingSource = new System.Windows.Forms.BindingSource();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.robaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpisRobe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MjernaJedinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicnaCijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDokumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRobaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeDokumentaBindingSource = new System.Windows.Forms.BindingSource();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.novaPrimkaButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.obrisiPrimkuButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeDokumentaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Klijent,
            this.vrstaDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.unioDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.korisnik1DataGridViewTextBoxColumn,
            this.vrstaDokumentaDataGridViewTextBoxColumn,
            this.stavkeDokumentasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dokumentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(704, 236);
            this.dataGridView1.TabIndex = 0;
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
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumDataGridViewTextBoxColumn.Width = 125;
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
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.robaDataGridViewTextBoxColumn,
            this.OpisRobe,
            this.MjernaJedinica,
            this.kolicinaDataGridViewTextBoxColumn,
            this.jedinicnaCijenaDataGridViewTextBoxColumn,
            this.UkupnaCijena,
            this.idDokumentDataGridViewTextBoxColumn,
            this.idRobaDataGridViewTextBoxColumn,
            this.dokumentDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.stavkeDokumentaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(8, 23);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(940, 185);
            this.dataGridView2.TabIndex = 1;
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
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kolicinaDataGridViewTextBoxColumn.Width = 125;
            // 
            // jedinicnaCijenaDataGridViewTextBoxColumn
            // 
            this.jedinicnaCijenaDataGridViewTextBoxColumn.DataPropertyName = "JedinicnaCijena";
            this.jedinicnaCijenaDataGridViewTextBoxColumn.HeaderText = "Jedinicna cijena";
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(720, 276);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pregled primki";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(16, 298);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(956, 222);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stavke odabrane primke";
            // 
            // novaPrimkaButton
            // 
            this.novaPrimkaButton.Location = new System.Drawing.Point(8, 23);
            this.novaPrimkaButton.Margin = new System.Windows.Forms.Padding(4);
            this.novaPrimkaButton.Name = "novaPrimkaButton";
            this.novaPrimkaButton.Size = new System.Drawing.Size(212, 58);
            this.novaPrimkaButton.TabIndex = 4;
            this.novaPrimkaButton.Text = "Nova primka";
            this.novaPrimkaButton.UseVisualStyleBackColor = true;
            this.novaPrimkaButton.Click += new System.EventHandler(this.novaPrimkaButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.obrisiPrimkuButton);
            this.groupBox3.Controls.Add(this.novaPrimkaButton);
            this.groupBox3.Location = new System.Drawing.Point(744, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(228, 276);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kontrole";
            // 
            // obrisiPrimkuButton
            // 
            this.obrisiPrimkuButton.ForeColor = System.Drawing.Color.Red;
            this.obrisiPrimkuButton.Location = new System.Drawing.Point(8, 202);
            this.obrisiPrimkuButton.Margin = new System.Windows.Forms.Padding(4);
            this.obrisiPrimkuButton.Name = "obrisiPrimkuButton";
            this.obrisiPrimkuButton.Size = new System.Drawing.Size(212, 58);
            this.obrisiPrimkuButton.TabIndex = 5;
            this.obrisiPrimkuButton.Text = "Obriši primku";
            this.obrisiPrimkuButton.UseVisualStyleBackColor = true;
            this.obrisiPrimkuButton.Click += new System.EventHandler(this.obrisiPrimkuButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Korisnik";
            this.dataGridViewTextBoxColumn1.HeaderText = "Klijent";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Roba";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mjerna jedinica";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Roba";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mjerna jedinica";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Korisnik";
            this.dataGridViewTextBoxColumn4.HeaderText = "Klijent";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // PregledPrimkiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 530);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PregledPrimkiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled Primki";
            this.Load += new System.EventHandler(this.PregledPrimkiForm_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.PregledPrimkiForm_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeDokumentaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button novaPrimkaButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource dokumentBindingSource;
        private System.Windows.Forms.BindingSource stavkeDokumentaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn robaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpisRobe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjernaJedinica;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicnaCijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnaCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDokumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRobaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button obrisiPrimkuButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klijent;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnik1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaDokumentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkeDokumentasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

