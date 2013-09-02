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
            this.button1 = new System.Windows.Forms.PictureBox();
            this._lblSeite = new System.Windows.Forms.Label();
            this._cmdWeiter = new System.Windows.Forms.PictureBox();
            this._cmdZurueckDeaktiviert = new System.Windows.Forms.PictureBox();
            this._cmdWeiterDeaktiviert = new System.Windows.Forms.PictureBox();
            this._cmdZurueck = new System.Windows.Forms.PictureBox();
            this._cmdLeichteSudokus = new System.Windows.Forms.CheckBox();
            this._cmdMittlereSudokus = new System.Windows.Forms.CheckBox();
            this._cmdSchwereSudokus = new System.Windows.Forms.CheckBox();
            this._ucSudokuKlein1 = new Sudoku.GUI._ucSudokuKlein();
            this._ucSudokuKlein2 = new Sudoku.GUI._ucSudokuKlein();
            this._ucSudokuKlein3 = new Sudoku.GUI._ucSudokuKlein();
            this._ucSudokuKlein4 = new Sudoku.GUI._ucSudokuKlein();
            this._flpAuswahl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cmdWeiter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cmdZurueckDeaktiviert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cmdWeiterDeaktiviert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cmdZurueck)).BeginInit();
            this.SuspendLayout();
            // 
            // _flpAuswahl
            // 
            this._flpAuswahl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._flpAuswahl.Controls.Add(this._ucSudokuKlein1);
            this._flpAuswahl.Controls.Add(this._ucSudokuKlein2);
            this._flpAuswahl.Controls.Add(this._ucSudokuKlein3);
            this._flpAuswahl.Controls.Add(this._ucSudokuKlein4);
            this._flpAuswahl.Location = new System.Drawing.Point(3, 38);
            this._flpAuswahl.Name = "_flpAuswahl";
            this._flpAuswahl.Size = new System.Drawing.Size(599, 584);
            this._flpAuswahl.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(238, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button1.TabIndex = 188;
            this.button1.TabStop = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _lblSeite
            // 
            this._lblSeite.AutoSize = true;
            this._lblSeite.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblSeite.Location = new System.Drawing.Point(406, 634);
            this._lblSeite.Name = "_lblSeite";
            this._lblSeite.Size = new System.Drawing.Size(145, 28);
            this._lblSeite.TabIndex = 3;
            this._lblSeite.Text = "SEITENZAHL";
            // 
            // _cmdWeiter
            // 
            this._cmdWeiter.Image = ((System.Drawing.Image)(resources.GetObject("_cmdWeiter.Image")));
            this._cmdWeiter.Location = new System.Drawing.Point(292, 630);
            this._cmdWeiter.Name = "_cmdWeiter";
            this._cmdWeiter.Size = new System.Drawing.Size(79, 40);
            this._cmdWeiter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._cmdWeiter.TabIndex = 4;
            this._cmdWeiter.TabStop = false;
            this._cmdWeiter.Click += new System.EventHandler(this._cmdWeiter_Click);
            // 
            // _cmdZurueckDeaktiviert
            // 
            this._cmdZurueckDeaktiviert.Image = ((System.Drawing.Image)(resources.GetObject("_cmdZurueckDeaktiviert.Image")));
            this._cmdZurueckDeaktiviert.Location = new System.Drawing.Point(167, 630);
            this._cmdZurueckDeaktiviert.Name = "_cmdZurueckDeaktiviert";
            this._cmdZurueckDeaktiviert.Size = new System.Drawing.Size(79, 40);
            this._cmdZurueckDeaktiviert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._cmdZurueckDeaktiviert.TabIndex = 5;
            this._cmdZurueckDeaktiviert.TabStop = false;
            this._cmdZurueckDeaktiviert.Click += new System.EventHandler(this._cmdZurueck_Click);
            // 
            // _cmdWeiterDeaktiviert
            // 
            this._cmdWeiterDeaktiviert.Image = ((System.Drawing.Image)(resources.GetObject("_cmdWeiterDeaktiviert.Image")));
            this._cmdWeiterDeaktiviert.Location = new System.Drawing.Point(292, 630);
            this._cmdWeiterDeaktiviert.Name = "_cmdWeiterDeaktiviert";
            this._cmdWeiterDeaktiviert.Size = new System.Drawing.Size(79, 40);
            this._cmdWeiterDeaktiviert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._cmdWeiterDeaktiviert.TabIndex = 6;
            this._cmdWeiterDeaktiviert.TabStop = false;
            this._cmdWeiterDeaktiviert.Visible = false;
            this._cmdWeiterDeaktiviert.Click += new System.EventHandler(this._cmdWeiter_Click);
            // 
            // _cmdZurueck
            // 
            this._cmdZurueck.Image = ((System.Drawing.Image)(resources.GetObject("_cmdZurueck.Image")));
            this._cmdZurueck.Location = new System.Drawing.Point(167, 630);
            this._cmdZurueck.Name = "_cmdZurueck";
            this._cmdZurueck.Size = new System.Drawing.Size(79, 40);
            this._cmdZurueck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._cmdZurueck.TabIndex = 7;
            this._cmdZurueck.TabStop = false;
            this._cmdZurueck.Visible = false;
            this._cmdZurueck.Click += new System.EventHandler(this._cmdZurueck_Click);
            // 
            // _cmdLeichteSudokus
            // 
            this._cmdLeichteSudokus.Appearance = System.Windows.Forms.Appearance.Button;
            this._cmdLeichteSudokus.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._cmdLeichteSudokus.Checked = true;
            this._cmdLeichteSudokus.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cmdLeichteSudokus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cmdLeichteSudokus.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdLeichteSudokus.Location = new System.Drawing.Point(3, 3);
            this._cmdLeichteSudokus.Name = "_cmdLeichteSudokus";
            this._cmdLeichteSudokus.Size = new System.Drawing.Size(75, 36);
            this._cmdLeichteSudokus.TabIndex = 11;
            this._cmdLeichteSudokus.Text = "Leicht";
            this._cmdLeichteSudokus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._cmdLeichteSudokus.UseVisualStyleBackColor = true;
            this._cmdLeichteSudokus.Click += new System.EventHandler(this._cmdLeichteSudokus_CheckedChanged);
            // 
            // _cmdMittlereSudokus
            // 
            this._cmdMittlereSudokus.Appearance = System.Windows.Forms.Appearance.Button;
            this._cmdMittlereSudokus.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._cmdMittlereSudokus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cmdMittlereSudokus.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdMittlereSudokus.Location = new System.Drawing.Point(80, 3);
            this._cmdMittlereSudokus.Name = "_cmdMittlereSudokus";
            this._cmdMittlereSudokus.Size = new System.Drawing.Size(75, 36);
            this._cmdMittlereSudokus.TabIndex = 12;
            this._cmdMittlereSudokus.Text = "Mittel";
            this._cmdMittlereSudokus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._cmdMittlereSudokus.UseVisualStyleBackColor = true;
            this._cmdMittlereSudokus.Click += new System.EventHandler(this._cmdMittlereSudokus_CheckedChanged);
            // 
            // _cmdSchwereSudokus
            // 
            this._cmdSchwereSudokus.Appearance = System.Windows.Forms.Appearance.Button;
            this._cmdSchwereSudokus.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._cmdSchwereSudokus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cmdSchwereSudokus.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdSchwereSudokus.Location = new System.Drawing.Point(157, 3);
            this._cmdSchwereSudokus.Name = "_cmdSchwereSudokus";
            this._cmdSchwereSudokus.Size = new System.Drawing.Size(75, 36);
            this._cmdSchwereSudokus.TabIndex = 13;
            this._cmdSchwereSudokus.Text = "Schwer";
            this._cmdSchwereSudokus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._cmdSchwereSudokus.UseVisualStyleBackColor = true;
            this._cmdSchwereSudokus.Click += new System.EventHandler(this._cmdSchwereSudokus_CheckedChanged);
            // 
            // _ucSudokuKlein1
            // 
            this._ucSudokuKlein1.ID = new System.Guid("00000000-0000-0000-0000-000000000000");
            this._ucSudokuKlein1.Location = new System.Drawing.Point(3, 3);
            this._ucSudokuKlein1.Name = "_ucSudokuKlein1";
            this._ucSudokuKlein1.Size = new System.Drawing.Size(264, 267);
            this._ucSudokuKlein1.TabIndex = 0;
            // 
            // _ucSudokuKlein2
            // 
            this._ucSudokuKlein2.ID = new System.Guid("00000000-0000-0000-0000-000000000000");
            this._ucSudokuKlein2.Location = new System.Drawing.Point(273, 3);
            this._ucSudokuKlein2.Name = "_ucSudokuKlein2";
            this._ucSudokuKlein2.Size = new System.Drawing.Size(264, 267);
            this._ucSudokuKlein2.TabIndex = 1;
            // 
            // _ucSudokuKlein3
            // 
            this._ucSudokuKlein3.ID = new System.Guid("00000000-0000-0000-0000-000000000000");
            this._ucSudokuKlein3.Location = new System.Drawing.Point(3, 276);
            this._ucSudokuKlein3.Name = "_ucSudokuKlein3";
            this._ucSudokuKlein3.Size = new System.Drawing.Size(264, 267);
            this._ucSudokuKlein3.TabIndex = 2;
            // 
            // _ucSudokuKlein4
            // 
            this._ucSudokuKlein4.ID = new System.Guid("00000000-0000-0000-0000-000000000000");
            this._ucSudokuKlein4.Location = new System.Drawing.Point(273, 276);
            this._ucSudokuKlein4.Name = "_ucSudokuKlein4";
            this._ucSudokuKlein4.Size = new System.Drawing.Size(264, 267);
            this._ucSudokuKlein4.TabIndex = 3;
            // 
            // _ucSudokuSpielAuswahl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this._cmdSchwereSudokus);
            this.Controls.Add(this._cmdMittlereSudokus);
            this.Controls.Add(this._cmdLeichteSudokus);
            this.Controls.Add(this._cmdZurueckDeaktiviert);
            this.Controls.Add(this._cmdWeiter);
            this.Controls.Add(this._lblSeite);
            this.Controls.Add(this._flpAuswahl);
            this.Controls.Add(this._cmdZurueck);
            this.Controls.Add(this._cmdWeiterDeaktiviert);
            this.Name = "_ucSudokuSpielAuswahl";
            this.Size = new System.Drawing.Size(605, 680);
            this._flpAuswahl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cmdWeiter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cmdZurueckDeaktiviert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cmdWeiterDeaktiviert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cmdZurueck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel _flpAuswahl;
        private System.Windows.Forms.Label _lblSeite;
        private System.Windows.Forms.PictureBox _cmdWeiter;
        private System.Windows.Forms.PictureBox _cmdZurueckDeaktiviert;
        private System.Windows.Forms.PictureBox _cmdWeiterDeaktiviert;
        private System.Windows.Forms.PictureBox _cmdZurueck;
        private _ucSudokuKlein _ucSudokuKlein1;
        private _ucSudokuKlein _ucSudokuKlein2;
        private _ucSudokuKlein _ucSudokuKlein3;
        private _ucSudokuKlein _ucSudokuKlein4;
        private System.Windows.Forms.CheckBox _cmdLeichteSudokus;
        private System.Windows.Forms.CheckBox _cmdMittlereSudokus;
        private System.Windows.Forms.CheckBox _cmdSchwereSudokus;
        private System.Windows.Forms.PictureBox button1;
    }
}
