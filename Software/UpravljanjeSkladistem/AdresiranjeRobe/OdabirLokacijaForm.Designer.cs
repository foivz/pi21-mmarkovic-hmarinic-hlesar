
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
            this.odaberiLokacijuButton.Location = new System.Drawing.Point(8, 265);
            this.odaberiLokacijuButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.odaberiLokacijuButton.Name = "odaberiLokacijuButton";
            this.odaberiLokacijuButton.Size = new System.Drawing.Size(405, 54);
            this.odaberiLokacijuButton.TabIndex = 6;
            this.odaberiLokacijuButton.Text = "Odaberi označenu lokaciju";
            this.odaberiLokacijuButton.UseVisualStyleBackColor = true;
            this.odaberiLokacijuButton.Click += new System.EventHandler(this.odaberiLokacijuButton_Click);
            // 
            // stableniPrikazTreeView
            // 
            this.stableniPrikazTreeView.Location = new System.Drawing.Point(8, 23);
            this.stableniPrikazTreeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stableniPrikazTreeView.Name = "stableniPrikazTreeView";
            this.stableniPrikazTreeView.Size = new System.Drawing.Size(404, 235);
            this.stableniPrikazTreeView.TabIndex = 7;
            this.stableniPrikazTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.stableniPrikazTreeView_NodeMouseClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.stableniPrikazTreeView);
            this.groupBox4.Controls.Add(this.odaberiLokacijuButton);
            this.groupBox4.Location = new System.Drawing.Point(17, 43);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(425, 329);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Odabir lokacija";
            // 
            // odabranaLokacijaLabel
            // 
            this.odabranaLokacijaLabel.AutoSize = true;
            this.odabranaLokacijaLabel.ForeColor = System.Drawing.Color.Red;
            this.odabranaLokacijaLabel.Location = new System.Drawing.Point(157, 11);
            this.odabranaLokacijaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.odabranaLokacijaLabel.Name = "odabranaLokacijaLabel";
            this.odabranaLokacijaLabel.Size = new System.Drawing.Size(83, 17);
            this.odabranaLokacijaLabel.TabIndex = 11;
            this.odabranaLokacijaLabel.Text = "Placeholder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Odabrana lokacija:";
            // 
            // OdabirLokacijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 377);
            this.Controls.Add(this.odabranaLokacijaLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox4);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OdabirLokacijaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odabir lokacije";
            this.Load += new System.EventHandler(this.OdabirLokacija_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.OdabirLokacijaForm_HelpRequested);
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