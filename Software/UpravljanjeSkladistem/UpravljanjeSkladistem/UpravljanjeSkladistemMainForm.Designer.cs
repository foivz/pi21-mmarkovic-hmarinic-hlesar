
namespace UpravljanjeSkladistem
{
    partial class UpravljanjeSkladistemMainForm
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
            this.loginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.registracijaButton = new System.Windows.Forms.Button();
            this.adresiranjeRobeButton = new System.Windows.Forms.Button();
            this.kreiranjePrimkiButton = new System.Windows.Forms.Button();
            this.pretragaRobeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unosRobeButton = new System.Windows.Forms.Button();
            this.korisnickeKontroleGroupBox = new System.Windows.Forms.GroupBox();
            this.kreiranjeIzdatnicaButton = new System.Windows.Forms.Button();
            this.azuriranjeStanjaButton = new System.Windows.Forms.Button();
            this.izlazButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.prijavljeniKorisnikGroupBox = new System.Windows.Forms.GroupBox();
            this.ulogaLabel = new System.Windows.Forms.Label();
            this.nazivLabel = new System.Windows.Forms.Label();
            this.odjavaButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.korisnickeKontroleGroupBox.SuspendLayout();
            this.prijavljeniKorisnikGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(8, 23);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(145, 79);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(888, 95);
            this.label1.TabIndex = 1;
            this.label1.Text = "Upravljanje skladištem";
            // 
            // registracijaButton
            // 
            this.registracijaButton.Enabled = false;
            this.registracijaButton.Location = new System.Drawing.Point(8, 110);
            this.registracijaButton.Margin = new System.Windows.Forms.Padding(4);
            this.registracijaButton.Name = "registracijaButton";
            this.registracijaButton.Size = new System.Drawing.Size(145, 79);
            this.registracijaButton.TabIndex = 2;
            this.registracijaButton.Text = "Registracija korisnika";
            this.registracijaButton.UseVisualStyleBackColor = true;
            this.registracijaButton.Click += new System.EventHandler(this.registracijaButton_Click);
            // 
            // adresiranjeRobeButton
            // 
            this.adresiranjeRobeButton.Enabled = false;
            this.adresiranjeRobeButton.Location = new System.Drawing.Point(161, 23);
            this.adresiranjeRobeButton.Margin = new System.Windows.Forms.Padding(4);
            this.adresiranjeRobeButton.Name = "adresiranjeRobeButton";
            this.adresiranjeRobeButton.Size = new System.Drawing.Size(145, 79);
            this.adresiranjeRobeButton.TabIndex = 3;
            this.adresiranjeRobeButton.Text = "Adresiranje robe";
            this.adresiranjeRobeButton.UseVisualStyleBackColor = true;
            this.adresiranjeRobeButton.Click += new System.EventHandler(this.adresiranjeRobeButton_Click);
            // 
            // kreiranjePrimkiButton
            // 
            this.kreiranjePrimkiButton.Enabled = false;
            this.kreiranjePrimkiButton.Location = new System.Drawing.Point(161, 110);
            this.kreiranjePrimkiButton.Margin = new System.Windows.Forms.Padding(4);
            this.kreiranjePrimkiButton.Name = "kreiranjePrimkiButton";
            this.kreiranjePrimkiButton.Size = new System.Drawing.Size(145, 79);
            this.kreiranjePrimkiButton.TabIndex = 4;
            this.kreiranjePrimkiButton.Text = "Pregled primki";
            this.kreiranjePrimkiButton.UseVisualStyleBackColor = true;
            this.kreiranjePrimkiButton.Click += new System.EventHandler(this.kreiranjePrimkiButton_Click);
            // 
            // pretragaRobeButton
            // 
            this.pretragaRobeButton.Enabled = false;
            this.pretragaRobeButton.Location = new System.Drawing.Point(8, 110);
            this.pretragaRobeButton.Margin = new System.Windows.Forms.Padding(4);
            this.pretragaRobeButton.Name = "pretragaRobeButton";
            this.pretragaRobeButton.Size = new System.Drawing.Size(145, 79);
            this.pretragaRobeButton.TabIndex = 5;
            this.pretragaRobeButton.Text = "Pretraga robe";
            this.pretragaRobeButton.UseVisualStyleBackColor = true;
            this.pretragaRobeButton.Click += new System.EventHandler(this.pretragaRobeButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginButton);
            this.groupBox1.Controls.Add(this.registracijaButton);
            this.groupBox1.Location = new System.Drawing.Point(93, 178);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(163, 199);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login/registracija";
            // 
            // unosRobeButton
            // 
            this.unosRobeButton.Enabled = false;
            this.unosRobeButton.Location = new System.Drawing.Point(8, 23);
            this.unosRobeButton.Margin = new System.Windows.Forms.Padding(4);
            this.unosRobeButton.Name = "unosRobeButton";
            this.unosRobeButton.Size = new System.Drawing.Size(145, 79);
            this.unosRobeButton.TabIndex = 7;
            this.unosRobeButton.Text = "Unos robe";
            this.unosRobeButton.UseVisualStyleBackColor = true;
            this.unosRobeButton.Click += new System.EventHandler(this.unosRobeButton_Click);
            // 
            // korisnickeKontroleGroupBox
            // 
            this.korisnickeKontroleGroupBox.Controls.Add(this.kreiranjeIzdatnicaButton);
            this.korisnickeKontroleGroupBox.Controls.Add(this.azuriranjeStanjaButton);
            this.korisnickeKontroleGroupBox.Controls.Add(this.unosRobeButton);
            this.korisnickeKontroleGroupBox.Controls.Add(this.pretragaRobeButton);
            this.korisnickeKontroleGroupBox.Controls.Add(this.kreiranjePrimkiButton);
            this.korisnickeKontroleGroupBox.Controls.Add(this.adresiranjeRobeButton);
            this.korisnickeKontroleGroupBox.Location = new System.Drawing.Point(360, 178);
            this.korisnickeKontroleGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.korisnickeKontroleGroupBox.Name = "korisnickeKontroleGroupBox";
            this.korisnickeKontroleGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.korisnickeKontroleGroupBox.Size = new System.Drawing.Size(317, 287);
            this.korisnickeKontroleGroupBox.TabIndex = 8;
            this.korisnickeKontroleGroupBox.TabStop = false;
            this.korisnickeKontroleGroupBox.Text = "Korisničke kontrole";
            // 
            // kreiranjeIzdatnicaButton
            // 
            this.kreiranjeIzdatnicaButton.Enabled = false;
            this.kreiranjeIzdatnicaButton.Location = new System.Drawing.Point(161, 196);
            this.kreiranjeIzdatnicaButton.Margin = new System.Windows.Forms.Padding(4);
            this.kreiranjeIzdatnicaButton.Name = "kreiranjeIzdatnicaButton";
            this.kreiranjeIzdatnicaButton.Size = new System.Drawing.Size(145, 79);
            this.kreiranjeIzdatnicaButton.TabIndex = 9;
            this.kreiranjeIzdatnicaButton.Text = "Kreiranje izdatnica";
            this.kreiranjeIzdatnicaButton.UseVisualStyleBackColor = true;
            // 
            // azuriranjeStanjaButton
            // 
            this.azuriranjeStanjaButton.Enabled = false;
            this.azuriranjeStanjaButton.Location = new System.Drawing.Point(8, 196);
            this.azuriranjeStanjaButton.Margin = new System.Windows.Forms.Padding(4);
            this.azuriranjeStanjaButton.Name = "azuriranjeStanjaButton";
            this.azuriranjeStanjaButton.Size = new System.Drawing.Size(145, 79);
            this.azuriranjeStanjaButton.TabIndex = 8;
            this.azuriranjeStanjaButton.Text = "Ažuriranje stanja skladišta";
            this.azuriranjeStanjaButton.UseVisualStyleBackColor = true;
            // 
            // izlazButton
            // 
            this.izlazButton.Location = new System.Drawing.Point(986, 488);
            this.izlazButton.Margin = new System.Windows.Forms.Padding(4);
            this.izlazButton.Name = "izlazButton";
            this.izlazButton.Size = new System.Drawing.Size(153, 53);
            this.izlazButton.TabIndex = 10;
            this.izlazButton.Text = "Izlaz";
            this.izlazButton.UseVisualStyleBackColor = true;
            this.izlazButton.Click += new System.EventHandler(this.izlazButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(31, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Naziv korisnika:";
            // 
            // prijavljeniKorisnikGroupBox
            // 
            this.prijavljeniKorisnikGroupBox.Controls.Add(this.ulogaLabel);
            this.prijavljeniKorisnikGroupBox.Controls.Add(this.nazivLabel);
            this.prijavljeniKorisnikGroupBox.Controls.Add(this.odjavaButton);
            this.prijavljeniKorisnikGroupBox.Controls.Add(this.label3);
            this.prijavljeniKorisnikGroupBox.Controls.Add(this.label2);
            this.prijavljeniKorisnikGroupBox.Location = new System.Drawing.Point(769, 178);
            this.prijavljeniKorisnikGroupBox.Name = "prijavljeniKorisnikGroupBox";
            this.prijavljeniKorisnikGroupBox.Size = new System.Drawing.Size(281, 197);
            this.prijavljeniKorisnikGroupBox.TabIndex = 12;
            this.prijavljeniKorisnikGroupBox.TabStop = false;
            this.prijavljeniKorisnikGroupBox.Text = "Prijavljeni korisnik";
            this.prijavljeniKorisnikGroupBox.Visible = false;
            // 
            // ulogaLabel
            // 
            this.ulogaLabel.AutoSize = true;
            this.ulogaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ulogaLabel.Location = new System.Drawing.Point(146, 73);
            this.ulogaLabel.Name = "ulogaLabel";
            this.ulogaLabel.Size = new System.Drawing.Size(88, 17);
            this.ulogaLabel.TabIndex = 15;
            this.ulogaLabel.Text = "ulogaLabel";
            // 
            // nazivLabel
            // 
            this.nazivLabel.AutoSize = true;
            this.nazivLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazivLabel.Location = new System.Drawing.Point(146, 43);
            this.nazivLabel.Name = "nazivLabel";
            this.nazivLabel.Size = new System.Drawing.Size(86, 17);
            this.nazivLabel.TabIndex = 14;
            this.nazivLabel.Text = "nazivLabel";
            // 
            // odjavaButton
            // 
            this.odjavaButton.Enabled = false;
            this.odjavaButton.Location = new System.Drawing.Point(71, 123);
            this.odjavaButton.Margin = new System.Windows.Forms.Padding(4);
            this.odjavaButton.Name = "odjavaButton";
            this.odjavaButton.Size = new System.Drawing.Size(153, 53);
            this.odjavaButton.TabIndex = 13;
            this.odjavaButton.Text = "Odjava";
            this.odjavaButton.UseVisualStyleBackColor = true;
            this.odjavaButton.Click += new System.EventHandler(this.odjavaButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(89, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Uloga:";
            // 
            // UpravljanjeSkladistemMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 554);
            this.Controls.Add(this.prijavljeniKorisnikGroupBox);
            this.Controls.Add(this.izlazButton);
            this.Controls.Add(this.korisnickeKontroleGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpravljanjeSkladistemMainForm";
            this.Text = "Upravljanje skladištem";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.UpravljanjeSkladistemMainForm_HelpRequested);
            this.groupBox1.ResumeLayout(false);
            this.korisnickeKontroleGroupBox.ResumeLayout(false);
            this.prijavljeniKorisnikGroupBox.ResumeLayout(false);
            this.prijavljeniKorisnikGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registracijaButton;
        private System.Windows.Forms.Button adresiranjeRobeButton;
        private System.Windows.Forms.Button kreiranjePrimkiButton;
        private System.Windows.Forms.Button pretragaRobeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button unosRobeButton;
        private System.Windows.Forms.GroupBox korisnickeKontroleGroupBox;
        private System.Windows.Forms.Button kreiranjeIzdatnicaButton;
        private System.Windows.Forms.Button azuriranjeStanjaButton;
        private System.Windows.Forms.Button izlazButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox prijavljeniKorisnikGroupBox;
        private System.Windows.Forms.Label ulogaLabel;
        private System.Windows.Forms.Label nazivLabel;
        private System.Windows.Forms.Button odjavaButton;
        private System.Windows.Forms.Label label3;
    }
}

