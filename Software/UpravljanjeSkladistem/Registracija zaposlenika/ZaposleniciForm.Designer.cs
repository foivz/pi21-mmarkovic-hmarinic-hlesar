
namespace Registracija_zaposlenika
{
    partial class ZaposleniciForm
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
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaposleniciDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUlogaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontaktBrojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnickoImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iBANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokumentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokuments1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulogaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noviZaposlenikButton = new System.Windows.Forms.Button();
            this.IzlazButton = new System.Windows.Forms.Button();
            this.AzurirajButton = new System.Windows.Forms.Button();
            this.ulogaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ObrisiZaposlenikaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataSource = typeof(SkladisteDb.Korisnik);
            // 
            // zaposleniciDataGridView
            // 
            this.zaposleniciDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zaposleniciDataGridView.AutoGenerateColumns = false;
            this.zaposleniciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zaposleniciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idUlogaDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn,
            this.kontaktBrojDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.korisnickoImeDataGridViewTextBoxColumn,
            this.lozinkaDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.mjestoDataGridViewTextBoxColumn,
            this.iBANDataGridViewTextBoxColumn,
            this.dokumentsDataGridViewTextBoxColumn,
            this.dokuments1DataGridViewTextBoxColumn,
            this.ulogaDataGridViewTextBoxColumn});
            this.zaposleniciDataGridView.DataSource = this.korisnikBindingSource;
            this.zaposleniciDataGridView.Location = new System.Drawing.Point(12, 30);
            this.zaposleniciDataGridView.Name = "zaposleniciDataGridView";
            this.zaposleniciDataGridView.RowHeadersWidth = 51;
            this.zaposleniciDataGridView.RowTemplate.Height = 24;
            this.zaposleniciDataGridView.Size = new System.Drawing.Size(948, 359);
            this.zaposleniciDataGridView.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // idUlogaDataGridViewTextBoxColumn
            // 
            this.idUlogaDataGridViewTextBoxColumn.DataPropertyName = "Uloga";
            this.idUlogaDataGridViewTextBoxColumn.HeaderText = "Uloga";
            this.idUlogaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idUlogaDataGridViewTextBoxColumn.Name = "idUlogaDataGridViewTextBoxColumn";
            this.idUlogaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idUlogaDataGridViewTextBoxColumn.Width = 125;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.Width = 125;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            this.oIBDataGridViewTextBoxColumn.Width = 125;
            // 
            // kontaktBrojDataGridViewTextBoxColumn
            // 
            this.kontaktBrojDataGridViewTextBoxColumn.DataPropertyName = "KontaktBroj";
            this.kontaktBrojDataGridViewTextBoxColumn.HeaderText = "KontaktBroj";
            this.kontaktBrojDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kontaktBrojDataGridViewTextBoxColumn.Name = "kontaktBrojDataGridViewTextBoxColumn";
            this.kontaktBrojDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // korisnickoImeDataGridViewTextBoxColumn
            // 
            this.korisnickoImeDataGridViewTextBoxColumn.DataPropertyName = "KorisnickoIme";
            this.korisnickoImeDataGridViewTextBoxColumn.HeaderText = "KorisnickoIme";
            this.korisnickoImeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.korisnickoImeDataGridViewTextBoxColumn.Name = "korisnickoImeDataGridViewTextBoxColumn";
            this.korisnickoImeDataGridViewTextBoxColumn.Width = 125;
            // 
            // lozinkaDataGridViewTextBoxColumn
            // 
            this.lozinkaDataGridViewTextBoxColumn.DataPropertyName = "Lozinka";
            this.lozinkaDataGridViewTextBoxColumn.HeaderText = "Lozinka";
            this.lozinkaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lozinkaDataGridViewTextBoxColumn.Name = "lozinkaDataGridViewTextBoxColumn";
            this.lozinkaDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Visible = false;
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.Width = 125;
            // 
            // mjestoDataGridViewTextBoxColumn
            // 
            this.mjestoDataGridViewTextBoxColumn.DataPropertyName = "Mjesto";
            this.mjestoDataGridViewTextBoxColumn.HeaderText = "Mjesto";
            this.mjestoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mjestoDataGridViewTextBoxColumn.Name = "mjestoDataGridViewTextBoxColumn";
            this.mjestoDataGridViewTextBoxColumn.Width = 125;
            // 
            // iBANDataGridViewTextBoxColumn
            // 
            this.iBANDataGridViewTextBoxColumn.DataPropertyName = "IBAN";
            this.iBANDataGridViewTextBoxColumn.HeaderText = "IBAN";
            this.iBANDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iBANDataGridViewTextBoxColumn.Name = "iBANDataGridViewTextBoxColumn";
            this.iBANDataGridViewTextBoxColumn.Width = 125;
            // 
            // dokumentsDataGridViewTextBoxColumn
            // 
            this.dokumentsDataGridViewTextBoxColumn.DataPropertyName = "Dokuments";
            this.dokumentsDataGridViewTextBoxColumn.HeaderText = "Dokuments";
            this.dokumentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dokumentsDataGridViewTextBoxColumn.Name = "dokumentsDataGridViewTextBoxColumn";
            this.dokumentsDataGridViewTextBoxColumn.Visible = false;
            this.dokumentsDataGridViewTextBoxColumn.Width = 125;
            // 
            // dokuments1DataGridViewTextBoxColumn
            // 
            this.dokuments1DataGridViewTextBoxColumn.DataPropertyName = "Dokuments1";
            this.dokuments1DataGridViewTextBoxColumn.HeaderText = "Dokuments1";
            this.dokuments1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dokuments1DataGridViewTextBoxColumn.Name = "dokuments1DataGridViewTextBoxColumn";
            this.dokuments1DataGridViewTextBoxColumn.Visible = false;
            this.dokuments1DataGridViewTextBoxColumn.Width = 125;
            // 
            // ulogaDataGridViewTextBoxColumn
            // 
            this.ulogaDataGridViewTextBoxColumn.DataPropertyName = "Uloga";
            this.ulogaDataGridViewTextBoxColumn.HeaderText = "Uloga";
            this.ulogaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ulogaDataGridViewTextBoxColumn.Name = "ulogaDataGridViewTextBoxColumn";
            this.ulogaDataGridViewTextBoxColumn.Visible = false;
            this.ulogaDataGridViewTextBoxColumn.Width = 125;
            // 
            // noviZaposlenikButton
            // 
            this.noviZaposlenikButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.noviZaposlenikButton.Location = new System.Drawing.Point(12, 395);
            this.noviZaposlenikButton.Name = "noviZaposlenikButton";
            this.noviZaposlenikButton.Size = new System.Drawing.Size(152, 43);
            this.noviZaposlenikButton.TabIndex = 2;
            this.noviZaposlenikButton.Text = "Novi zaposlenik";
            this.noviZaposlenikButton.UseVisualStyleBackColor = true;
            this.noviZaposlenikButton.Click += new System.EventHandler(this.noviZaposlenikButton_Click);
            // 
            // IzlazButton
            // 
            this.IzlazButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IzlazButton.Location = new System.Drawing.Point(829, 395);
            this.IzlazButton.Name = "IzlazButton";
            this.IzlazButton.Size = new System.Drawing.Size(131, 43);
            this.IzlazButton.TabIndex = 3;
            this.IzlazButton.Text = "Izlaz";
            this.IzlazButton.UseVisualStyleBackColor = true;
            this.IzlazButton.Click += new System.EventHandler(this.IzlazButton_Click);
            // 
            // AzurirajButton
            // 
            this.AzurirajButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AzurirajButton.Location = new System.Drawing.Point(170, 395);
            this.AzurirajButton.Name = "AzurirajButton";
            this.AzurirajButton.Size = new System.Drawing.Size(148, 43);
            this.AzurirajButton.TabIndex = 4;
            this.AzurirajButton.Text = "Ažuriraj zaposlenika";
            this.AzurirajButton.UseVisualStyleBackColor = true;
            this.AzurirajButton.Click += new System.EventHandler(this.AzurirajButton_Click);
            // 
            // ulogaBindingSource
            // 
            this.ulogaBindingSource.DataSource = typeof(SkladisteDb.Uloga);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Popis zaposlenika: ";
            // 
            // ObrisiZaposlenikaButton
            // 
            this.ObrisiZaposlenikaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ObrisiZaposlenikaButton.ForeColor = System.Drawing.Color.Red;
            this.ObrisiZaposlenikaButton.Location = new System.Drawing.Point(324, 395);
            this.ObrisiZaposlenikaButton.Name = "ObrisiZaposlenikaButton";
            this.ObrisiZaposlenikaButton.Size = new System.Drawing.Size(148, 43);
            this.ObrisiZaposlenikaButton.TabIndex = 6;
            this.ObrisiZaposlenikaButton.Text = "Obriši zaposlenika";
            this.ObrisiZaposlenikaButton.UseVisualStyleBackColor = true;
            this.ObrisiZaposlenikaButton.Click += new System.EventHandler(this.ObrisiZaposlenikaButton_Click);
            // 
            // ZaposleniciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.ObrisiZaposlenikaButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AzurirajButton);
            this.Controls.Add(this.IzlazButton);
            this.Controls.Add(this.noviZaposlenikButton);
            this.Controls.Add(this.zaposleniciDataGridView);
            this.Name = "ZaposleniciForm";
            this.Text = "Registracija zaposlenika";
            this.Load += new System.EventHandler(this.ZaposleniciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private System.Windows.Forms.DataGridView zaposleniciDataGridView;
        private System.Windows.Forms.Button noviZaposlenikButton;
        private System.Windows.Forms.Button IzlazButton;
        private System.Windows.Forms.BindingSource ulogaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUlogaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontaktBrojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickoImeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iBANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokuments1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulogaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button AzurirajButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ObrisiZaposlenikaButton;
    }
}

