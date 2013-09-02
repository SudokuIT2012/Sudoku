namespace Sudoku.GUI.UserControls
{
    partial class _ucSudokuSpielAuswahl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_ucSudokuSpielAuswahl));
            this._flpAuswahl = new System.Windows.Forms.FlowLayoutPanel();
            this._lblSeite = new System.Windows.Forms.Label();
            this._cmdWeiter = new System.Windows.Forms.PictureBox();
            this._cmdZurueck = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._cmdWeiter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cmdZurueck)).BeginInit();
            this.SuspendLayout();
            // 
            // _flpAuswahl
            // 
            this._flpAuswahl.Location = new System.Drawing.Point(3, 3);
            this._flpAuswahl.Name = "_flpAuswahl";
            this._flpAuswahl.Size = new System.Drawing.Size(599, 532);
            this._flpAuswahl.TabIndex = 0;
            // 
            // _lblSeite
            // 
            this._lblSeite.AutoSize = true;
            this._lblSeite.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblSeite.Location = new System.Drawing.Point(406, 556);
            this._lblSeite.Name = "_lblSeite";
            this._lblSeite.Size = new System.Drawing.Size(145, 28);
            this._lblSeite.TabIndex = 3;
            this._lblSeite.Text = "SEITENZAHL";
            // 
            // _cmdWeiter
            // 
            this._cmdWeiter.Image = ((System.Drawing.Image)(resources.GetObject("_cmdWeiter.Image")));
            this._cmdWeiter.Location = new System.Drawing.Point(284, 552);
            this._cmdWeiter.Name = "_cmdWeiter";
            this._cmdWeiter.Size = new System.Drawing.Size(79, 40);
            this._cmdWeiter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._cmdWeiter.TabIndex = 4;
            this._cmdWeiter.TabStop = false;
            this._cmdWeiter.Click += new System.EventHandler(this._cmdWeiter_Click);
            // 
            // _cmdZurueck
            // 
            this._cmdZurueck.Image = ((System.Drawing.Image)(resources.GetObject("_cmdZurueck.Image")));
            this._cmdZurueck.Location = new System.Drawing.Point(145, 552);
            this._cmdZurueck.Name = "_cmdZurueck";
            this._cmdZurueck.Size = new System.Drawing.Size(79, 40);
            this._cmdZurueck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._cmdZurueck.TabIndex = 5;
            this._cmdZurueck.TabStop = false;
            this._cmdZurueck.Click += new System.EventHandler(this._cmdZurueck_Click);
            // 
            // _ucSudokuSpielAuswahl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._cmdZurueck);
            this.Controls.Add(this._cmdWeiter);
            this.Controls.Add(this._lblSeite);
            this.Controls.Add(this._flpAuswahl);
            this.Name = "_ucSudokuSpielAuswahl";
            this.Size = new System.Drawing.Size(605, 600);
            ((System.ComponentModel.ISupportInitialize)(this._cmdWeiter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cmdZurueck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel _flpAuswahl;
        private System.Windows.Forms.Label _lblSeite;
        private System.Windows.Forms.PictureBox _cmdWeiter;
        private System.Windows.Forms.PictureBox _cmdZurueck;
    }
}
