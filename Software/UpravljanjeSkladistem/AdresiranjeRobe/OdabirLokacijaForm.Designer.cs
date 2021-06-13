
namespace AdresiranjeRobe
{
    partial class OdabirLokacijaForm
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
            this.odaberiLokacijuButton = new System.Windows.Forms.Button();
            this.stableniPrikazTreeView = new System.Windows.Forms.TreeView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.odabranaLokacijaLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // odaberiLokacijuButton
            // 
            this.odaberiLokacijuButton.Location = new System.Drawing.Point(6, 215);
            this.odaberiLokacijuButton.Name = "odaberiLokacijuButton";
            this.odaberiLokacijuButton.Size = new System.Drawing.Size(304, 44);
            this.odaberiLokacijuButton.TabIndex = 6;
            this.odaberiLokacijuButton.Text = "Odaberi označenu lokaciju";
            this.odaberiLokacijuButton.UseVisualStyleBackColor = true;
            this.odaberiLokacijuButton.Click += new System.EventHandler(this.odaberiLokacijuButton_Click);
            // 
            // stableniPrikazTreeView
            // 
            this.stableniPrikazTreeView.Location = new System.Drawing.Point(6, 19);
            this.stableniPrikazTreeView.Name = "stableniPrikazTreeView";
            this.stableniPrikazTreeView.Size = new System.Drawing.Size(304, 192);
            this.stableniPrikazTreeView.TabIndex = 7;
            this.stableniPrikazTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.stableniPrikazTreeView_NodeMouseClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.stableniPrikazTreeView);
            this.groupBox4.Controls.Add(this.odaberiLokacijuButton);
            this.groupBox4.Location = new System.Drawing.Point(13, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(319, 267);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Odabir lokacija";
            // 
            // odabranaLokacijaLabel
            // 
            this.odabranaLokacijaLabel.AutoSize = true;
            this.odabranaLokacijaLabel.ForeColor = System.Drawing.Color.Red;
            this.odabranaLokacijaLabel.Location = new System.Drawing.Point(118, 9);
            this.odabranaLokacijaLabel.Name = "odabranaLokacijaLabel";
            this.odabranaLokacijaLabel.Size = new System.Drawing.Size(63, 13);
            this.odabranaLokacijaLabel.TabIndex = 11;
            this.odabranaLokacijaLabel.Text = "Placeholder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Odabrana lokacija:";
            // 
            // OdabirLokacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 306);
            this.Controls.Add(this.odabranaLokacijaLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox4);
            this.Name = "OdabirLokacija";
            this.Text = "Odabir lokacije";
            this.Load += new System.EventHandler(this.OdabirLokacija_Load);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button odaberiLokacijuButton;
        private System.Windows.Forms.TreeView stableniPrikazTreeView;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label odabranaLokacijaLabel;
        private System.Windows.Forms.Label label2;
    }
}