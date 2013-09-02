namespace Sudoku.GUI.UserControls
{
    partial class _ucMeldung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_ucMeldung));
            this._lblMeldungUnten = new System.Windows.Forms.Label();
            this._lblMeldungOben = new System.Windows.Forms.Label();
            this._picMeldungNein = new System.Windows.Forms.PictureBox();
            this._picMeldungOk = new System.Windows.Forms.PictureBox();
            this._picMeldung = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._picMeldungNein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._picMeldungOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._picMeldung)).BeginInit();
            this.SuspendLayout();
            // 
            // _lblMeldungUnten
            // 
            this._lblMeldungUnten.BackColor = System.Drawing.Color.White;
            this._lblMeldungUnten.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblMeldungUnten.Location = new System.Drawing.Point(15, 68);
            this._lblMeldungUnten.Name = "_lblMeldungUnten";
            this._lblMeldungUnten.Size = new System.Drawing.Size(293, 78);
            this._lblMeldungUnten.TabIndex = 23;
            this._lblMeldungUnten.Text = "label2";
            // 
            // _lblMeldungOben
            // 
            this._lblMeldungOben.BackColor = System.Drawing.Color.White;
            this._lblMeldungOben.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblMeldungOben.Location = new System.Drawing.Point(14, 22);
            this._lblMeldungOben.Name = "_lblMeldungOben";
            this._lblMeldungOben.Size = new System.Drawing.Size(294, 46);
            this._lblMeldungOben.TabIndex = 22;
            this._lblMeldungOben.Text = "label2";
            // 
            // _picMeldungNein
            // 
            this._picMeldungNein.BackColor = System.Drawing.Color.White;
            this._picMeldungNein.Image = ((System.Drawing.Image)(resources.GetObject("_picMeldungNein.Image")));
            this._picMeldungNein.Location = new System.Drawing.Point(174, 150);
            this._picMeldungNein.Name = "_picMeldungNein";
            this._picMeldungNein.Size = new System.Drawing.Size(50, 50);
            this._picMeldungNein.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._picMeldungNein.TabIndex = 25;
            this._picMeldungNein.TabStop = false;
            this._picMeldungNein.Click += new System.EventHandler(this._picMeldungNein_Click);
            // 
            // _picMeldungOk
            // 
            this._picMeldungOk.BackColor = System.Drawing.Color.White;
            this._picMeldungOk.Image = ((System.Drawing.Image)(resources.GetObject("_picMeldungOk.Image")));
            this._picMeldungOk.Location = new System.Drawing.Point(80, 150);
            this._picMeldungOk.Name = "_picMeldungOk";
            this._picMeldungOk.Size = new System.Drawing.Size(50, 50);
            this._picMeldungOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._picMeldungOk.TabIndex = 24;
            this._picMeldungOk.TabStop = false;
            this._picMeldungOk.Click += new System.EventHandler(this._picMeldungOk_Click);
            // 
            // _picMeldung
            // 
            this._picMeldung.BackColor = System.Drawing.Color.Transparent;
            this._picMeldung.Image = ((System.Drawing.Image)(resources.GetObject("_picMeldung.Image")));
            this._picMeldung.Location = new System.Drawing.Point(0, 0);
            this._picMeldung.Name = "_picMeldung";
            this._picMeldung.Size = new System.Drawing.Size(386, 208);
            this._picMeldung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._picMeldung.TabIndex = 21;
            this._picMeldung.TabStop = false;
            // 
            // _ucMeldung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this._lblMeldungUnten);
            this.Controls.Add(this._lblMeldungOben);
            this.Controls.Add(this._picMeldungNein);
            this.Controls.Add(this._picMeldungOk);
            this.Controls.Add(this._picMeldung);
            this.Name = "_ucMeldung";
            this.Size = new System.Drawing.Size(386, 208);
            ((System.ComponentModel.ISupportInitialize)(this._picMeldungNein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._picMeldungOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._picMeldung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _lblMeldungUnten;
        private System.Windows.Forms.Label _lblMeldungOben;
        private System.Windows.Forms.PictureBox _picMeldungNein;
        private System.Windows.Forms.PictureBox _picMeldungOk;
        private System.Windows.Forms.PictureBox _picMeldung;
    }
}
