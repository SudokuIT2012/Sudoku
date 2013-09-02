namespace Sudoku
{
    partial class _frmHauptmenue
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_frmHauptmenue));
            this._picSchliessen = new System.Windows.Forms.PictureBox();
            this._picGiraffe = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._lblFarbe1 = new System.Windows.Forms.Label();
            this._lblFarbe2 = new System.Windows.Forms.Label();
            this._lblFarbe3 = new System.Windows.Forms.Label();
            this._lblFarbe4 = new System.Windows.Forms.Label();
            this._lblFarbe5 = new System.Windows.Forms.Label();
            this._lblFarbe6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._cmdSudokuErstellen = new System.Windows.Forms.Button();
            this._cmdSudokuSpielen = new System.Windows.Forms.Button();
            this._cmdAnleitung = new System.Windows.Forms.Button();
            this._cmdHauptmenue = new System.Windows.Forms.Button();
            this._ucMeldung1 = new Sudoku.GUI.UserControls._ucMeldung();
            this._ucSudokuErstellenAutomatisch1 = new Sudoku.GUI.UserControls._ucSudokuErstellenAutomatisch();
            this._ucZahlenAuswahl1 = new Sudoku.GUI.UserControls._ucZahlenAuswahl();
            this._ucSpiel = new Sudoku.GUI.UserControls._ucSudokuGross();
            this._ucSudokuSpielAuswahl1 = new Sudoku.GUI.UserControls._ucSudokuSpielAuswahl();
            this._ucSudokuErstellen1 = new Sudoku.GUI.UserControls._ucSudokuErstellen();
            ((System.ComponentModel.ISupportInitialize)(this._picSchliessen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._picGiraffe)).BeginInit();
            this.SuspendLayout();
            // 
            // _picSchliessen
            // 
            this._picSchliessen.Image = ((System.Drawing.Image)(resources.GetObject("_picSchliessen.Image")));
            this._picSchliessen.Location = new System.Drawing.Point(1071, 6);
            this._picSchliessen.Name = "_picSchliessen";
            this._picSchliessen.Size = new System.Drawing.Size(51, 47);
            this._picSchliessen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._picSchliessen.TabIndex = 0;
            this._picSchliessen.TabStop = false;
            this._picSchliessen.Click += new System.EventHandler(this._picSchliessen_Click);
            // 
            // _picGiraffe
            // 
            this._picGiraffe.BackColor = System.Drawing.Color.Transparent;
            this._picGiraffe.Image = ((System.Drawing.Image)(resources.GetObject("_picGiraffe.Image")));
            this._picGiraffe.Location = new System.Drawing.Point(655, 57);
            this._picGiraffe.Name = "_picGiraffe";
            this._picGiraffe.Size = new System.Drawing.Size(443, 602);
            this._picGiraffe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._picGiraffe.TabIndex = 4;
            this._picGiraffe.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(6, 900);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1122, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(6, 900);
            this.label4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1500, 6);
            this.label5.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(0, 755);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1500, 6);
            this.label6.TabIndex = 8;
            // 
            // _lblFarbe1
            // 
            this._lblFarbe1.BackColor = System.Drawing.Color.PeachPuff;
            this._lblFarbe1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lblFarbe1.Location = new System.Drawing.Point(1060, 131);
            this._lblFarbe1.Name = "_lblFarbe1";
            this._lblFarbe1.Size = new System.Drawing.Size(30, 30);
            this._lblFarbe1.TabIndex = 11;
            this._lblFarbe1.Click += new System.EventHandler(this._lblFarbe1_Click);
            // 
            // _lblFarbe2
            // 
            this._lblFarbe2.BackColor = System.Drawing.Color.Plum;
            this._lblFarbe2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lblFarbe2.Location = new System.Drawing.Point(1060, 175);
            this._lblFarbe2.Name = "_lblFarbe2";
            this._lblFarbe2.Size = new System.Drawing.Size(30, 30);
            this._lblFarbe2.TabIndex = 12;
            this._lblFarbe2.Click += new System.EventHandler(this._lblFarbe2_Click);
            // 
            // _lblFarbe3
            // 
            this._lblFarbe3.BackColor = System.Drawing.Color.LightCoral;
            this._lblFarbe3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lblFarbe3.Location = new System.Drawing.Point(1060, 214);
            this._lblFarbe3.Name = "_lblFarbe3";
            this._lblFarbe3.Size = new System.Drawing.Size(30, 30);
            this._lblFarbe3.TabIndex = 13;
            this._lblFarbe3.Click += new System.EventHandler(this._lblFarbe3_Click);
            // 
            // _lblFarbe4
            // 
            this._lblFarbe4.BackColor = System.Drawing.Color.SeaGreen;
            this._lblFarbe4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lblFarbe4.Location = new System.Drawing.Point(1060, 255);
            this._lblFarbe4.Name = "_lblFarbe4";
            this._lblFarbe4.Size = new System.Drawing.Size(30, 30);
            this._lblFarbe4.TabIndex = 14;
            this._lblFarbe4.Click += new System.EventHandler(this._lblFarbe4_Click);
            // 
            // _lblFarbe5
            // 
            this._lblFarbe5.BackColor = System.Drawing.Color.Gold;
            this._lblFarbe5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lblFarbe5.Location = new System.Drawing.Point(1060, 294);
            this._lblFarbe5.Name = "_lblFarbe5";
            this._lblFarbe5.Size = new System.Drawing.Size(30, 30);
            this._lblFarbe5.TabIndex = 14;
            this._lblFarbe5.Click += new System.EventHandler(this._lblFarbe5_Click);
            // 
            // _lblFarbe6
            // 
            this._lblFarbe6.BackColor = System.Drawing.Color.LightSkyBlue;
            this._lblFarbe6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lblFarbe6.Location = new System.Drawing.Point(1060, 340);
            this._lblFarbe6.Name = "_lblFarbe6";
            this._lblFarbe6.Size = new System.Drawing.Size(30, 30);
            this._lblFarbe6.TabIndex = 14;
            this._lblFarbe6.Click += new System.EventHandler(this._lblFarbe6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(379, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(356, 53);
            this.label9.TabIndex = 21;
            this.label9.Text = "Sudoku - Spielehr";
            // 
            // _cmdSudokuErstellen
            // 
            this._cmdSudokuErstellen.FlatAppearance.BorderSize = 3;
            this._cmdSudokuErstellen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cmdSudokuErstellen.Font = new System.Drawing.Font("Comic Sans MS", 27.75F);
            this._cmdSudokuErstellen.Location = new System.Drawing.Point(197, 373);
            this._cmdSudokuErstellen.Name = "_cmdSudokuErstellen";
            this._cmdSudokuErstellen.Size = new System.Drawing.Size(321, 80);
            this._cmdSudokuErstellen.TabIndex = 26;
            this._cmdSudokuErstellen.Text = "Bau dein Sudoku";
            this._cmdSudokuErstellen.UseVisualStyleBackColor = true;
            this._cmdSudokuErstellen.Click += new System.EventHandler(this.button1_Click);
            // 
            // _cmdSudokuSpielen
            // 
            this._cmdSudokuSpielen.FlatAppearance.BorderSize = 3;
            this._cmdSudokuSpielen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cmdSudokuSpielen.Font = new System.Drawing.Font("Comic Sans MS", 27.75F);
            this._cmdSudokuSpielen.Location = new System.Drawing.Point(197, 255);
            this._cmdSudokuSpielen.Name = "_cmdSudokuSpielen";
            this._cmdSudokuSpielen.Size = new System.Drawing.Size(321, 80);
            this._cmdSudokuSpielen.TabIndex = 26;
            this._cmdSudokuSpielen.Text = "Sudoku spielen";
            this._cmdSudokuSpielen.UseVisualStyleBackColor = true;
            this._cmdSudokuSpielen.Click += new System.EventHandler(this._cmdSudokuSpielen_Click);
            // 
            // _cmdAnleitung
            // 
            this._cmdAnleitung.FlatAppearance.BorderSize = 3;
            this._cmdAnleitung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cmdAnleitung.Font = new System.Drawing.Font("Comic Sans MS", 27.75F);
            this._cmdAnleitung.Location = new System.Drawing.Point(197, 486);
            this._cmdAnleitung.Name = "_cmdAnleitung";
            this._cmdAnleitung.Size = new System.Drawing.Size(321, 80);
            this._cmdAnleitung.TabIndex = 27;
            this._cmdAnleitung.Text = "Anleitung";
            this._cmdAnleitung.UseVisualStyleBackColor = true;
            // 
            // _cmdHauptmenue
            // 
            this._cmdHauptmenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cmdHauptmenue.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdHauptmenue.Location = new System.Drawing.Point(866, 256);
            this._cmdHauptmenue.Name = "_cmdHauptmenue";
            this._cmdHauptmenue.Size = new System.Drawing.Size(169, 67);
            this._cmdHauptmenue.TabIndex = 28;
            this._cmdHauptmenue.Text = "Hauptmenü";
            this._cmdHauptmenue.UseVisualStyleBackColor = true;
            this._cmdHauptmenue.Visible = false;
            this._cmdHauptmenue.Click += new System.EventHandler(this._cmdHauptmenue_Click);
            // 
            // _ucMeldung1
            // 
            this._ucMeldung1.BackColor = System.Drawing.Color.Transparent;
            this._ucMeldung1.Location = new System.Drawing.Point(267, 61);
            this._ucMeldung1.Name = "_ucMeldung1";
            this._ucMeldung1.Size = new System.Drawing.Size(386, 208);
            this._ucMeldung1.TabIndex = 22;
            this._ucMeldung1.Visible = false;
            // 
            // _ucSudokuErstellenAutomatisch1
            // 
            this._ucSudokuErstellenAutomatisch1.BackColor = System.Drawing.Color.White;
            this._ucSudokuErstellenAutomatisch1.Hauptmenue = null;
            this._ucSudokuErstellenAutomatisch1.Location = new System.Drawing.Point(197, 247);
            this._ucSudokuErstellenAutomatisch1.Name = "_ucSudokuErstellenAutomatisch1";
            this._ucSudokuErstellenAutomatisch1.Size = new System.Drawing.Size(236, 233);
            this._ucSudokuErstellenAutomatisch1.TabIndex = 24;
            this._ucSudokuErstellenAutomatisch1.UCSudokuErstellen = null;
            this._ucSudokuErstellenAutomatisch1.Visible = false;
            // 
            // _ucZahlenAuswahl1
            // 
            this._ucZahlenAuswahl1.BackColor = System.Drawing.Color.White;
            this._ucZahlenAuswahl1.FeldGross = null;
            this._ucZahlenAuswahl1.Location = new System.Drawing.Point(197, 247);
            this._ucZahlenAuswahl1.Name = "_ucZahlenAuswahl1";
            this._ucZahlenAuswahl1.Size = new System.Drawing.Size(236, 233);
            this._ucZahlenAuswahl1.TabIndex = 23;
            this._ucZahlenAuswahl1.Visible = false;
            this._ucZahlenAuswahl1.Zahl = null;
            // 
            // _ucSpiel
            // 
            this._ucSpiel.ID = new System.Guid("00000000-0000-0000-0000-000000000000");
            this._ucSpiel.Location = new System.Drawing.Point(12, 62);
            this._ucSpiel.Name = "_ucSpiel";
            this._ucSpiel.Schwierigkeitsgrad = null;
            this._ucSpiel.Size = new System.Drawing.Size(623, 650);
            this._ucSpiel.Sudokus = null;
            this._ucSpiel.TabIndex = 10;
            this._ucSpiel.Visible = false;
            // 
            // _ucSudokuSpielAuswahl1
            // 
            this._ucSudokuSpielAuswahl1.Location = new System.Drawing.Point(12, 62);
            this._ucSudokuSpielAuswahl1.Name = "_ucSudokuSpielAuswahl1";
            this._ucSudokuSpielAuswahl1.Size = new System.Drawing.Size(605, 687);
            this._ucSudokuSpielAuswahl1.Sudokus = null;
            this._ucSudokuSpielAuswahl1.TabIndex = 9;
            this._ucSudokuSpielAuswahl1.Visible = false;
            this._ucSudokuSpielAuswahl1.VisibleChanged += new System.EventHandler(this._ucSudokuSpielAuswahl1_VisibleChanged);
            // 
            // _ucSudokuErstellen1
            // 
            this._ucSudokuErstellen1.Location = new System.Drawing.Point(13, 62);
            this._ucSudokuErstellen1.Name = "_ucSudokuErstellen1";
            this._ucSudokuErstellen1.Size = new System.Drawing.Size(605, 650);
            this._ucSudokuErstellen1.TabIndex = 15;
            this._ucSudokuErstellen1.Visible = false;
            // 
            // _frmHauptmenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1128, 761);
            this.Controls.Add(this._cmdHauptmenue);
            this.Controls.Add(this._cmdAnleitung);
            this.Controls.Add(this._ucMeldung1);
            this.Controls.Add(this._cmdSudokuSpielen);
            this.Controls.Add(this._cmdSudokuErstellen);
            this.Controls.Add(this._ucSudokuErstellenAutomatisch1);
            this.Controls.Add(this._ucZahlenAuswahl1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this._lblFarbe6);
            this.Controls.Add(this._lblFarbe5);
            this.Controls.Add(this._lblFarbe4);
            this.Controls.Add(this._lblFarbe3);
            this.Controls.Add(this._lblFarbe2);
            this.Controls.Add(this._lblFarbe1);
            this.Controls.Add(this._picSchliessen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._picGiraffe);
            this.Controls.Add(this._ucSpiel);
            this.Controls.Add(this._ucSudokuSpielAuswahl1);
            this.Controls.Add(this._ucSudokuErstellen1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_frmHauptmenue";
            this.Text = "Hauptmenü";
            ((System.ComponentModel.ISupportInitialize)(this._picSchliessen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._picGiraffe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _picSchliessen;
        private System.Windows.Forms.PictureBox _picGiraffe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private GUI.UserControls._ucSudokuSpielAuswahl _ucSudokuSpielAuswahl1;
        private GUI.UserControls._ucSudokuGross _ucSpiel;
        private System.Windows.Forms.Label _lblFarbe1;
        private System.Windows.Forms.Label _lblFarbe2;
        private System.Windows.Forms.Label _lblFarbe3;
        private GUI.UserControls._ucSudokuErstellen _ucSudokuErstellen1;
        private System.Windows.Forms.Label _lblFarbe4;
        private System.Windows.Forms.Label _lblFarbe5;
        private System.Windows.Forms.Label _lblFarbe6;
        private System.Windows.Forms.Label label9;
        private GUI.UserControls._ucMeldung _ucMeldung1;
        private GUI.UserControls._ucZahlenAuswahl _ucZahlenAuswahl1;
        private GUI.UserControls._ucSudokuErstellenAutomatisch _ucSudokuErstellenAutomatisch1;
        private System.Windows.Forms.Button _cmdSudokuErstellen;
        private System.Windows.Forms.Button _cmdSudokuSpielen;
        private System.Windows.Forms.Button _cmdAnleitung;
        private System.Windows.Forms.Button _cmdHauptmenue;
    }
}

