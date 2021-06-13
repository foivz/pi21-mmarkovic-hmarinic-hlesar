
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivMjerneJedinice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjernaJedinicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.robaBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robaBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 505);
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
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(444, 480);
            this.dataGridView1.TabIndex = 0;
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
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NazivMjerneJedinice
            // 
            this.NazivMjerneJedinice.DataPropertyName = "NazivMjerneJedinice";
            this.NazivMjerneJedinice.HeaderText = "Mjerna Jedinica";
            this.NazivMjerneJedinice.Name = "NazivMjerneJedinice";
            this.NazivMjerneJedinice.ReadOnly = true;
            // 
            // mjernaJedinicaDataGridViewTextBoxColumn
            // 
            this.mjernaJedinicaDataGridViewTextBoxColumn.DataPropertyName = "MjernaJedinica";
            this.mjernaJedinicaDataGridViewTextBoxColumn.HeaderText = "MjernaJedinica";
            this.mjernaJedinicaDataGridViewTextBoxColumn.Name = "mjernaJedinicaDataGridViewTextBoxColumn";
            this.mjernaJedinicaDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.groupBox2.Location = new System.Drawing.Point(479, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 302);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga robe";
            // 
            // pretraziRobuNaOdabranojLokacijiButton
            // 
            this.pretraziRobuNaOdabranojLokacijiButton.Location = new System.Drawing.Point(6, 183);
            this.pretraziRobuNaOdabranojLokacijiButton.Name = "pretraziRobuNaOdabranojLokacijiButton";
            this.pretraziRobuNaOdabranojLokacijiButton.Size = new System.Drawing.Size(250, 40);
            this.pretraziRobuNaOdabranojLokacijiButton.TabIndex = 11;
            this.pretraziRobuNaOdabranojLokacijiButton.Text = "Pretraži robu na odabranoj lokaciji";
            this.pretraziRobuNaOdabranojLokacijiButton.UseVisualStyleBackColor = true;
            this.pretraziRobuNaOdabranojLokacijiButton.Click += new System.EventHandler(this.pretraziRobuNaOdabranojLokacijiButton_Click);
            // 
            // izborLokacijeButton
            // 
            this.izborLokacijeButton.Location = new System.Drawing.Point(6, 250);
            this.izborLokacijeButton.Name = "izborLokacijeButton";
            this.izborLokacijeButton.Size = new System.Drawing.Size(250, 40);
            this.izborLokacijeButton.TabIndex = 3;
            this.izborLokacijeButton.Text = "Izbor lokacije";
            this.izborLokacijeButton.UseVisualStyleBackColor = true;
            this.izborLokacijeButton.Click += new System.EventHandler(this.izborLokacijeButton_Click);
            // 
            // odabranaLokacijaLabel
            // 
            this.odabranaLokacijaLabel.AutoSize = true;
            this.odabranaLokacijaLabel.ForeColor = System.Drawing.Color.Red;
            this.odabranaLokacijaLabel.Location = new System.Drawing.Point(108, 234);
            this.odabranaLokacijaLabel.Name = "odabranaLokacijaLabel";
            this.odabranaLokacijaLabel.Size = new System.Drawing.Size(63, 13);
            this.odabranaLokacijaLabel.TabIndex = 5;
            this.odabranaLokacijaLabel.Text = "Placeholder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Maksimalna količina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Minimalna količina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Odabrana lokacija:";
            // 
            // maksimumTextBox
            // 
            this.maksimumTextBox.Location = new System.Drawing.Point(134, 111);
            this.maksimumTextBox.Name = "maksimumTextBox";
            this.maksimumTextBox.Size = new System.Drawing.Size(122, 20);
            this.maksimumTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naziv robe (opcionalno):";
            // 
            // pretragaRobeButton
            // 
            this.pretragaRobeButton.Location = new System.Drawing.Point(6, 137);
            this.pretragaRobeButton.Name = "pretragaRobeButton";
            this.pretragaRobeButton.Size = new System.Drawing.Size(250, 40);
            this.pretragaRobeButton.TabIndex = 3;
            this.pretragaRobeButton.Text = "Pretraži robu na skladištu";
            this.pretragaRobeButton.UseVisualStyleBackColor = true;
            this.pretragaRobeButton.Click += new System.EventHandler(this.pretragaRobeButton_Click);
            // 
            // minimumTextBox
            // 
            this.minimumTextBox.Location = new System.Drawing.Point(6, 111);
            this.minimumTextBox.Name = "minimumTextBox";
            this.minimumTextBox.Size = new System.Drawing.Size(122, 20);
            this.minimumTextBox.TabIndex = 2;
            // 
            // nazivRobeTextBox
            // 
            this.nazivRobeTextBox.Location = new System.Drawing.Point(6, 47);
            this.nazivRobeTextBox.Name = "nazivRobeTextBox";
            this.nazivRobeTextBox.Size = new System.Drawing.Size(122, 20);
            this.nazivRobeTextBox.TabIndex = 0;
            // 
            // odaberiRobuButton
            // 
            this.odaberiRobuButton.Location = new System.Drawing.Point(485, 477);
            this.odaberiRobuButton.Name = "odaberiRobuButton";
            this.odaberiRobuButton.Size = new System.Drawing.Size(250, 40);
            this.odaberiRobuButton.TabIndex = 12;
            this.odaberiRobuButton.Text = "Odaberi robu";
            this.odaberiRobuButton.UseVisualStyleBackColor = true;
            this.odaberiRobuButton.Visible = false;
            this.odaberiRobuButton.Click += new System.EventHandler(this.odaberiRobu_Click);
            // 
            // prikaziSvuRobuButton
            // 
            this.prikaziSvuRobuButton.Location = new System.Drawing.Point(485, 320);
            this.prikaziSvuRobuButton.Name = "prikaziSvuRobuButton";
            this.prikaziSvuRobuButton.Size = new System.Drawing.Size(250, 40);
            this.prikaziSvuRobuButton.TabIndex = 13;
            this.prikaziSvuRobuButton.Text = "Prikaži svu robu";
            this.prikaziSvuRobuButton.UseVisualStyleBackColor = true;
            this.prikaziSvuRobuButton.Visible = false;
            this.prikaziSvuRobuButton.Click += new System.EventHandler(this.prikaziSvuRobuButton_Click);
            // 
            // PretragaRobeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 529);
            this.Controls.Add(this.prikaziSvuRobuButton);
            this.Controls.Add(this.odaberiRobuButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PretragaRobeForm";
            this.Text = "Pretraga robe";
            this.Load += new System.EventHandler(this.PretragaRobeForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robaBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivMjerneJedinice;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjernaJedinicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource robaBindingSource;
        private System.Windows.Forms.Button prikaziSvuRobuButton;
    }
}

