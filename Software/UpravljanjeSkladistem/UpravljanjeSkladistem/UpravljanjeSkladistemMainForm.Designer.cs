
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kreiranjeIzdatnicaButton = new System.Windows.Forms.Button();
            this.azuriranjeStanjaButton = new System.Windows.Forms.Button();
            this.izlazButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Enabled = false;
            this.loginButton.Location = new System.Drawing.Point(6, 19);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(109, 64);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(698, 76);
            this.label1.TabIndex = 1;
            this.label1.Text = "Upravljanje skladištem";
            // 
            // registracijaButton
            // 
            this.registracijaButton.Enabled = false;
            this.registracijaButton.Location = new System.Drawing.Point(6, 89);
            this.registracijaButton.Name = "registracijaButton";
            this.registracijaButton.Size = new System.Drawing.Size(109, 64);
            this.registracijaButton.TabIndex = 2;
            this.registracijaButton.Text = "Registracija";
            this.registracijaButton.UseVisualStyleBackColor = true;
            // 
            // adresiranjeRobeButton
            // 
            this.adresiranjeRobeButton.Location = new System.Drawing.Point(121, 19);
            this.adresiranjeRobeButton.Name = "adresiranjeRobeButton";
            this.adresiranjeRobeButton.Size = new System.Drawing.Size(109, 64);
            this.adresiranjeRobeButton.TabIndex = 3;
            this.adresiranjeRobeButton.Text = "Adresiranje robe";
            this.adresiranjeRobeButton.UseVisualStyleBackColor = true;
            this.adresiranjeRobeButton.Click += new System.EventHandler(this.adresiranjeRobeButton_Click);
            // 
            // kreiranjePrimkiButton
            // 
            this.kreiranjePrimkiButton.Location = new System.Drawing.Point(121, 89);
            this.kreiranjePrimkiButton.Name = "kreiranjePrimkiButton";
            this.kreiranjePrimkiButton.Size = new System.Drawing.Size(109, 64);
            this.kreiranjePrimkiButton.TabIndex = 4;
            this.kreiranjePrimkiButton.Text = "Pregled primki";
            this.kreiranjePrimkiButton.UseVisualStyleBackColor = true;
            this.kreiranjePrimkiButton.Click += new System.EventHandler(this.kreiranjePrimkiButton_Click);
            // 
            // pretragaRobeButton
            // 
            this.pretragaRobeButton.Location = new System.Drawing.Point(6, 89);
            this.pretragaRobeButton.Name = "pretragaRobeButton";
            this.pretragaRobeButton.Size = new System.Drawing.Size(109, 64);
            this.pretragaRobeButton.TabIndex = 5;
            this.pretragaRobeButton.Text = "Pretraga robe";
            this.pretragaRobeButton.UseVisualStyleBackColor = true;
            this.pretragaRobeButton.Click += new System.EventHandler(this.pretragaRobeButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginButton);
            this.groupBox1.Controls.Add(this.registracijaButton);
            this.groupBox1.Location = new System.Drawing.Point(69, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 162);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login/registracija";
            // 
            // unosRobeButton
            // 
            this.unosRobeButton.Location = new System.Drawing.Point(6, 19);
            this.unosRobeButton.Name = "unosRobeButton";
            this.unosRobeButton.Size = new System.Drawing.Size(109, 64);
            this.unosRobeButton.TabIndex = 7;
            this.unosRobeButton.Text = "Unos robe";
            this.unosRobeButton.UseVisualStyleBackColor = true;
            this.unosRobeButton.Click += new System.EventHandler(this.unosRobeButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kreiranjeIzdatnicaButton);
            this.groupBox2.Controls.Add(this.azuriranjeStanjaButton);
            this.groupBox2.Controls.Add(this.unosRobeButton);
            this.groupBox2.Controls.Add(this.pretragaRobeButton);
            this.groupBox2.Controls.Add(this.kreiranjePrimkiButton);
            this.groupBox2.Controls.Add(this.adresiranjeRobeButton);
            this.groupBox2.Location = new System.Drawing.Point(296, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 233);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Korisničke kontrole";
            // 
            // kreiranjeIzdatnicaButton
            // 
            this.kreiranjeIzdatnicaButton.Enabled = false;
            this.kreiranjeIzdatnicaButton.Location = new System.Drawing.Point(121, 159);
            this.kreiranjeIzdatnicaButton.Name = "kreiranjeIzdatnicaButton";
            this.kreiranjeIzdatnicaButton.Size = new System.Drawing.Size(109, 64);
            this.kreiranjeIzdatnicaButton.TabIndex = 9;
            this.kreiranjeIzdatnicaButton.Text = "Kreiranje izdatnica";
            this.kreiranjeIzdatnicaButton.UseVisualStyleBackColor = true;
            // 
            // azuriranjeStanjaButton
            // 
            this.azuriranjeStanjaButton.Enabled = false;
            this.azuriranjeStanjaButton.Location = new System.Drawing.Point(6, 159);
            this.azuriranjeStanjaButton.Name = "azuriranjeStanjaButton";
            this.azuriranjeStanjaButton.Size = new System.Drawing.Size(109, 64);
            this.azuriranjeStanjaButton.TabIndex = 8;
            this.azuriranjeStanjaButton.Text = "Ažuriranje stanja skladišta";
            this.azuriranjeStanjaButton.UseVisualStyleBackColor = true;
            // 
            // izlazButton
            // 
            this.izlazButton.Location = new System.Drawing.Point(673, 395);
            this.izlazButton.Name = "izlazButton";
            this.izlazButton.Size = new System.Drawing.Size(115, 43);
            this.izlazButton.TabIndex = 10;
            this.izlazButton.Text = "Izlaz";
            this.izlazButton.UseVisualStyleBackColor = true;
            this.izlazButton.Click += new System.EventHandler(this.izlazButton_Click);
            // 
            // UpravljanjeSkladistemMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.izlazButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "UpravljanjeSkladistemMainForm";
            this.Text = "Upravljanje skladištem";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.UpravljanjeSkladistemMainForm_HelpRequested);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button kreiranjeIzdatnicaButton;
        private System.Windows.Forms.Button azuriranjeStanjaButton;
        private System.Windows.Forms.Button izlazButton;
    }
}

