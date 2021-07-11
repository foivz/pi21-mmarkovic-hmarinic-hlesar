
namespace PretragaRobe
{
    partial class PretragaRobeForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivMjerneJedinice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjernaJedinicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.robaBindingSource = new System.Windows.Forms.BindingSource();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pretraziRobuNaOdabranojLokacijiButton = new System.Windows.Forms.Button();
            this.izborLokacijeButton = new System.Windows.Forms.Button();
            this.odabranaLokacijaLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maksimumTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pretragaRobeButton = new System.Windows.Forms.Button();
            this.minimumTextBox = new System.Windows.Forms.TextBox();
            this.nazivRobeTextBox = new System.Windows.Forms.TextBox();
            this.odaberiRobuButton = new System.Windows.Forms.Button();
            this.prikaziSvuRobuButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lokacijaOznaceneRobeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oznacenaRobaBindingSource = new System.Windows.Forms.BindingSource();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robaBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oznacenaRobaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(615, 414);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sva roba na skladištu";
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
            this.kolicinaDataGridViewTextBoxColumn,
            this.NazivMjerneJedinice,
            this.mjernaJedinicaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.robaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(592, 379);
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
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivDataGridViewTextBoxColumn.Width = 125;
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
            // NazivMjerneJedinice
            // 
            this.NazivMjerneJedinice.DataPropertyName = "NazivMjerneJedinice";
            this.NazivMjerneJedinice.HeaderText = "Mjerna Jedinica";
            this.NazivMjerneJedinice.MinimumWidth = 6;
            this.NazivMjerneJedinice.Name = "NazivMjerneJedinice";
            this.NazivMjerneJedinice.ReadOnly = true;
            this.NazivMjerneJedinice.Width = 125;
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
            // robaBindingSource
            // 
            this.robaBindingSource.DataSource = typeof(SkladisteDb.Roba);
            this.robaBindingSource.CurrentChanged += new System.EventHandler(this.robaBindingSource_CurrentChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pretraziRobuNaOdabranojLokacijiButton);
            this.groupBox2.Controls.Add(this.izborLokacijeButton);
            this.groupBox2.Controls.Add(this.odabranaLokacijaLabel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.maksimumTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pretragaRobeButton);
            this.groupBox2.Controls.Add(this.minimumTextBox);
            this.groupBox2.Controls.Add(this.nazivRobeTextBox);
            this.groupBox2.Location = new System.Drawing.Point(640, 101);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(352, 327);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga robe";
            // 
            // pretraziRobuNaOdabranojLokacijiButton
            // 
            this.pretraziRobuNaOdabranojLokacijiButton.Location = new System.Drawing.Point(8, 194);
            this.pretraziRobuNaOdabranojLokacijiButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pretraziRobuNaOdabranojLokacijiButton.Name = "pretraziRobuNaOdabranojLokacijiButton";
            this.pretraziRobuNaOdabranojLokacijiButton.Size = new System.Drawing.Size(333, 49);
            this.pretraziRobuNaOdabranojLokacijiButton.TabIndex = 11;
            this.pretraziRobuNaOdabranojLokacijiButton.Text = "Pretraži robu na odabranoj lokaciji";
            this.pretraziRobuNaOdabranojLokacijiButton.UseVisualStyleBackColor = true;
            this.pretraziRobuNaOdabranojLokacijiButton.Click += new System.EventHandler(this.pretraziRobuNaOdabranojLokacijiButton_Click);
            // 
            // izborLokacijeButton
            // 
            this.izborLokacijeButton.Location = new System.Drawing.Point(8, 267);
            this.izborLokacijeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.izborLokacijeButton.Name = "izborLokacijeButton";
            this.izborLokacijeButton.Size = new System.Drawing.Size(333, 49);
            this.izborLokacijeButton.TabIndex = 3;
            this.izborLokacijeButton.Text = "Izbor lokacije";
            this.izborLokacijeButton.UseVisualStyleBackColor = true;
            this.izborLokacijeButton.Click += new System.EventHandler(this.izborLokacijeButton_Click);
            // 
            // odabranaLokacijaLabel
            // 
            this.odabranaLokacijaLabel.AutoSize = true;
            this.odabranaLokacijaLabel.ForeColor = System.Drawing.Color.Red;
            this.odabranaLokacijaLabel.Location = new System.Drawing.Point(144, 247);
            this.odabranaLokacijaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.odabranaLokacijaLabel.Name = "odabranaLokacijaLabel";
            this.odabranaLokacijaLabel.Size = new System.Drawing.Size(83, 17);
            this.odabranaLokacijaLabel.TabIndex = 5;
            this.odabranaLokacijaLabel.Text = "Placeholder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Maksimalna količina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Minimalna količina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 247);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Odabrana lokacija:";
            // 
            // maksimumTextBox
            // 
            this.maksimumTextBox.Location = new System.Drawing.Point(179, 106);
            this.maksimumTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maksimumTextBox.Name = "maksimumTextBox";
            this.maksimumTextBox.Size = new System.Drawing.Size(161, 22);
            this.maksimumTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naziv robe (opcionalno):";
            // 
            // pretragaRobeButton
            // 
            this.pretragaRobeButton.Location = new System.Drawing.Point(7, 138);
            this.pretragaRobeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pretragaRobeButton.Name = "pretragaRobeButton";
            this.pretragaRobeButton.Size = new System.Drawing.Size(333, 49);
            this.pretragaRobeButton.TabIndex = 3;
            this.pretragaRobeButton.Text = "Pretraži robu na skladištu";
            this.pretragaRobeButton.UseVisualStyleBackColor = true;
            this.pretragaRobeButton.Click += new System.EventHandler(this.pretragaRobeButton_Click);
            // 
            // minimumTextBox
            // 
            this.minimumTextBox.Location = new System.Drawing.Point(8, 106);
            this.minimumTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minimumTextBox.Name = "minimumTextBox";
            this.minimumTextBox.Size = new System.Drawing.Size(161, 22);
            this.minimumTextBox.TabIndex = 2;
            // 
            // nazivRobeTextBox
            // 
            this.nazivRobeTextBox.Location = new System.Drawing.Point(8, 58);
            this.nazivRobeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nazivRobeTextBox.Name = "nazivRobeTextBox";
            this.nazivRobeTextBox.Size = new System.Drawing.Size(161, 22);
            this.nazivRobeTextBox.TabIndex = 0;
            // 
            // odaberiRobuButton
            // 
            this.odaberiRobuButton.Location = new System.Drawing.Point(640, 645);
            this.odaberiRobuButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.odaberiRobuButton.Name = "odaberiRobuButton";
            this.odaberiRobuButton.Size = new System.Drawing.Size(333, 49);
            this.odaberiRobuButton.TabIndex = 12;
            this.odaberiRobuButton.Text = "Odaberi robu";
            this.odaberiRobuButton.UseVisualStyleBackColor = true;
            this.odaberiRobuButton.Visible = false;
            this.odaberiRobuButton.Click += new System.EventHandler(this.odaberiRobu_Click);
            // 
            // prikaziSvuRobuButton
            // 
            this.prikaziSvuRobuButton.Location = new System.Drawing.Point(647, 38);
            this.prikaziSvuRobuButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prikaziSvuRobuButton.Name = "prikaziSvuRobuButton";
            this.prikaziSvuRobuButton.Size = new System.Drawing.Size(333, 49);
            this.prikaziSvuRobuButton.TabIndex = 13;
            this.prikaziSvuRobuButton.Text = "Prikaži svu robu";
            this.prikaziSvuRobuButton.UseVisualStyleBackColor = true;
            this.prikaziSvuRobuButton.Click += new System.EventHandler(this.prikaziSvuRobuButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lokacijaOznaceneRobeLabel);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(16, 436);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(615, 258);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Zapisi označene robe";
            // 
            // lokacijaOznaceneRobeLabel
            // 
            this.lokacijaOznaceneRobeLabel.AutoSize = true;
            this.lokacijaOznaceneRobeLabel.ForeColor = System.Drawing.Color.Red;
            this.lokacijaOznaceneRobeLabel.Location = new System.Drawing.Point(8, 187);
            this.lokacijaOznaceneRobeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lokacijaOznaceneRobeLabel.Name = "lokacijaOznaceneRobeLabel";
            this.lokacijaOznaceneRobeLabel.Size = new System.Drawing.Size(83, 17);
            this.lokacijaOznaceneRobeLabel.TabIndex = 12;
            this.lokacijaOznaceneRobeLabel.Text = "Placeholder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lokacija označene robe:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView2.DataSource = this.oznacenaRobaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(8, 23);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(592, 144);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Naziv";
            this.dataGridViewTextBoxColumn2.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Kolicina";
            this.dataGridViewTextBoxColumn3.HeaderText = "Kolicina";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NazivMjerneJedinice";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mjerna Jedinica";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MjernaJedinica";
            this.dataGridViewTextBoxColumn5.HeaderText = "MjernaJedinica";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // oznacenaRobaBindingSource
            // 
            this.oznacenaRobaBindingSource.DataSource = typeof(SkladisteDb.Roba);
            this.oznacenaRobaBindingSource.CurrentChanged += new System.EventHandler(this.oznacenaRobaBindingSource_CurrentChanged);
            // 
            // PretragaRobeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 709);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.prikaziSvuRobuButton);
            this.Controls.Add(this.odaberiRobuButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PretragaRobeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga robe";
            this.Load += new System.EventHandler(this.PretragaRobeForm_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.PretragaRobeForm_HelpRequested);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robaBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oznacenaRobaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pretragaRobeButton;
        private System.Windows.Forms.TextBox minimumTextBox;
        private System.Windows.Forms.TextBox nazivRobeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maksimumTextBox;
        private System.Windows.Forms.Button izborLokacijeButton;
        private System.Windows.Forms.Button pretraziRobuNaOdabranojLokacijiButton;
        private System.Windows.Forms.Label odabranaLokacijaLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button odaberiRobuButton;
        private System.Windows.Forms.BindingSource robaBindingSource;
        private System.Windows.Forms.Button prikaziSvuRobuButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivMjerneJedinice;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjernaJedinicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lokacijaOznaceneRobeLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource oznacenaRobaBindingSource;
    }
}

