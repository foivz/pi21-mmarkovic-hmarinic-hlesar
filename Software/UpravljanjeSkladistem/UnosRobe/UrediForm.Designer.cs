
namespace UnosRobe
{
    partial class UrediForm
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
            this.dodajRobuButton = new System.Windows.Forms.Button();
            this.mjernaJedinicaComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.opisRobeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nazivRobeTextBox = new System.Windows.Forms.TextBox();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(180, 290);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos robe";
            // 
            // dodajRobuButton
            // 
            this.dodajRobuButton.Location = new System.Drawing.Point(6, 225);
            this.dodajRobuButton.Name = "dodajRobuButton";
            this.dodajRobuButton.Size = new System.Drawing.Size(168, 59);
            this.dodajRobuButton.TabIndex = 5;
            this.dodajRobuButton.Text = "Spremi";
            this.dodajRobuButton.UseVisualStyleBackColor = true;
            this.dodajRobuButton.Click += new System.EventHandler(this.dodajRobuButton_Click);
            // 
            // mjernaJedinicaComboBox
            // 
            this.mjernaJedinicaComboBox.FormattingEnabled = true;
            this.mjernaJedinicaComboBox.Location = new System.Drawing.Point(6, 143);
            this.mjernaJedinicaComboBox.Name = "mjernaJedinicaComboBox";
            this.mjernaJedinicaComboBox.Size = new System.Drawing.Size(121, 21);
            this.mjernaJedinicaComboBox.TabIndex = 10;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Opis robe:";
            // 
            // opisRobeTextBox
            // 
            this.opisRobeTextBox.Location = new System.Drawing.Point(6, 90);
            this.opisRobeTextBox.Name = "opisRobeTextBox";
            this.opisRobeTextBox.Size = new System.Drawing.Size(162, 20);
            this.opisRobeTextBox.TabIndex = 7;
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
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(6, 323);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(186, 23);
            this.odustaniButton.TabIndex = 2;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // UrediForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 358);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "UrediForm";
            this.Text = "UrediForm";
            this.Load += new System.EventHandler(this.UrediForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button dodajRobuButton;
        private System.Windows.Forms.ComboBox mjernaJedinicaComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox opisRobeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nazivRobeTextBox;
        private System.Windows.Forms.Button odustaniButton;
    }
}