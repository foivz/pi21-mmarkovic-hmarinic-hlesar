﻿
namespace AdresiranjeRobe
{
    partial class AdresiranjeRobeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nazivNoveLokacijeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.robaNaOdredenojLokacijiCheckBox = new System.Windows.Forms.CheckBox();
            this.robaDgv = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivMjerneJedinice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjernaJedinicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjernaJedinica1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.robaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.stableniPrikazTreeView = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.odabranaLokacijaLabel = new System.Windows.Forms.Label();
            this.izlazButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.obrisiOdabranuLokacijuButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.robaDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robaBindingSource)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nemaNadlokacijeCheckBox);
            this.groupBox2.Controls.Add(this.dodajLokacijuButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nazivNoveLokacijeTextBox);
            this.groupBox2.Location = new System.Drawing.Point(18, 346);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 124);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodavanje nove lokacije";
            // 
            // nemaNadlokacijeCheckBox
            // 
            this.nemaNadlokacijeCheckBox.AutoSize = true;
            this.nemaNadlokacijeCheckBox.Location = new System.Drawing.Point(6, 69);
            this.nemaNadlokacijeCheckBox.Name = "nemaNadlokacijeCheckBox";
            this.nemaNadlokacijeCheckBox.Size = new System.Drawing.Size(111, 17);
            this.nemaNadlokacijeCheckBox.TabIndex = 7;
            this.nemaNadlokacijeCheckBox.Text = "Nema nadlokacije";
            this.nemaNadlokacijeCheckBox.UseVisualStyleBackColor = true;
            // 
            // dodajLokacijuButton
            // 
            this.dodajLokacijuButton.Location = new System.Drawing.Point(6, 92);
            this.dodajLokacijuButton.Name = "dodajLokacijuButton";
            this.dodajLokacijuButton.Size = new System.Drawing.Size(181, 23);
            this.dodajLokacijuButton.TabIndex = 6;
            this.dodajLokacijuButton.Text = "Dodaj lokaciju";
            this.dodajLokacijuButton.UseVisualStyleBackColor = true;
            this.dodajLokacijuButton.Click += new System.EventHandler(this.dodajLokacijuButton_Click);
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
            this.nazivNoveLokacijeTextBox.Size = new System.Drawing.Size(181, 20);
            this.nazivNoveLokacijeTextBox.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.robaNaOdredenojLokacijiCheckBox);
            this.groupBox4.Controls.Add(this.robaDgv);
            this.groupBox4.Location = new System.Drawing.Point(384, 31);
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
            this.robaNaOdredenojLokacijiCheckBox.Size = new System.Drawing.Size(206, 17);
            this.robaNaOdredenojLokacijiCheckBox.TabIndex = 8;
            this.robaNaOdredenojLokacijiCheckBox.Text = "Uključi prikaz robe sa svih podlokacija";
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
            this.NazivMjerneJedinice,
            this.mjernaJedinicaDataGridViewTextBoxColumn,
            this.mjernaJedinica1DataGridViewTextBoxColumn});
            this.robaDgv.DataSource = this.robaBindingSource;
            this.robaDgv.Location = new System.Drawing.Point(6, 19);
            this.robaDgv.Name = "robaDgv";
            this.robaDgv.ReadOnly = true;
            this.robaDgv.Size = new System.Drawing.Size(494, 261);
            this.robaDgv.TabIndex = 1;
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
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // NazivMjerneJedinice
            // 
            this.NazivMjerneJedinice.DataPropertyName = "NazivMjerneJedinice";
            this.NazivMjerneJedinice.HeaderText = "Mjerna jedinica";
            this.NazivMjerneJedinice.Name = "NazivMjerneJedinice";
            this.NazivMjerneJedinice.ReadOnly = true;
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
            // robaBindingSource
            // 
            this.robaBindingSource.DataSource = typeof(SkladisteDb.Roba);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.stableniPrikazTreeView);
            this.groupBox5.Location = new System.Drawing.Point(18, 31);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(360, 309);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pregled lokacija";
            // 
            // stableniPrikazTreeView
            // 
            this.stableniPrikazTreeView.Location = new System.Drawing.Point(6, 19);
            this.stableniPrikazTreeView.Name = "stableniPrikazTreeView";
            this.stableniPrikazTreeView.Size = new System.Drawing.Size(348, 284);
            this.stableniPrikazTreeView.TabIndex = 7;
            this.stableniPrikazTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.stableniPrikazTreeView_NodeMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Odabrana lokacija:";
            // 
            // odabranaLokacijaLabel
            // 
            this.odabranaLokacijaLabel.AutoSize = true;
            this.odabranaLokacijaLabel.ForeColor = System.Drawing.Color.Red;
            this.odabranaLokacijaLabel.Location = new System.Drawing.Point(123, 9);
            this.odabranaLokacijaLabel.Name = "odabranaLokacijaLabel";
            this.odabranaLokacijaLabel.Size = new System.Drawing.Size(63, 13);
            this.odabranaLokacijaLabel.TabIndex = 9;
            this.odabranaLokacijaLabel.Text = "Placeholder";
            // 
            // izlazButton
            // 
            this.izlazButton.Location = new System.Drawing.Point(788, 438);
            this.izlazButton.Name = "izlazButton";
            this.izlazButton.Size = new System.Drawing.Size(96, 32);
            this.izlazButton.TabIndex = 10;
            this.izlazButton.Text = "Izlaz";
            this.izlazButton.UseVisualStyleBackColor = true;
            this.izlazButton.Click += new System.EventHandler(this.izlazButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.obrisiOdabranuLokacijuButton);
            this.groupBox1.Location = new System.Drawing.Point(217, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 63);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Brisanje odabrane lokacije";
            // 
            // obrisiOdabranuLokacijuButton
            // 
            this.obrisiOdabranuLokacijuButton.ForeColor = System.Drawing.Color.Red;
            this.obrisiOdabranuLokacijuButton.Location = new System.Drawing.Point(6, 19);
            this.obrisiOdabranuLokacijuButton.Name = "obrisiOdabranuLokacijuButton";
            this.obrisiOdabranuLokacijuButton.Size = new System.Drawing.Size(149, 36);
            this.obrisiOdabranuLokacijuButton.TabIndex = 11;
            this.obrisiOdabranuLokacijuButton.Text = "Obriši odabranu lokaciju";
            this.obrisiOdabranuLokacijuButton.UseVisualStyleBackColor = true;
            this.obrisiOdabranuLokacijuButton.Click += new System.EventHandler(this.obrisiOdabranuLokacijuButton_Click);
            // 
            // AdresiranjeRobeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 481);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.izlazButton);
            this.Controls.Add(this.odabranaLokacijaLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Name = "AdresiranjeRobeForm";
            this.Text = "Adresiranje Robe";
            this.Load += new System.EventHandler(this.AdresiranjeRobe_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.AdresiranjeRobeForm_HelpRequested);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.robaDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robaBindingSource)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox nemaNadlokacijeCheckBox;
        private System.Windows.Forms.Button dodajLokacijuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nazivNoveLokacijeTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView robaDgv;
        private System.Windows.Forms.CheckBox robaNaOdredenojLokacijiCheckBox;
        private System.Windows.Forms.BindingSource robaBindingSource;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TreeView stableniPrikazTreeView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label odabranaLokacijaLabel;
        private System.Windows.Forms.Button izlazButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button obrisiOdabranuLokacijuButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivMjerneJedinice;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjernaJedinicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjernaJedinica1DataGridViewTextBoxColumn;
    }
}

