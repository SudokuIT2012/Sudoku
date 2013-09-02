namespace Sudoku.GUI.UserControls
{
    partial class _ucSudokuErstellenAutomatisch
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._cmdLeicht = new System.Windows.Forms.Button();
            this._cmdAbbrechen = new System.Windows.Forms.Button();
            this._cmdMittel = new System.Windows.Forms.Button();
            this._cmdSchwer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(233, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(3, 233);
            this.label4.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(3, 233);
            this.label3.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 3);
            this.label2.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 3);
            this.label1.TabIndex = 37;
            // 
            // _cmdLeicht
            // 
            this._cmdLeicht.BackColor = System.Drawing.Color.PeachPuff;
            this._cmdLeicht.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdLeicht.Location = new System.Drawing.Point(9, 26);
            this._cmdLeicht.Name = "_cmdLeicht";
            this._cmdLeicht.Size = new System.Drawing.Size(218, 35);
            this._cmdLeicht.TabIndex = 36;
            this._cmdLeicht.Text = "Leicht";
            this._cmdLeicht.UseVisualStyleBackColor = false;
            this._cmdLeicht.Click += new System.EventHandler(this._cmdLeicht_Click);
            // 
            // _cmdAbbrechen
            // 
            this._cmdAbbrechen.BackColor = System.Drawing.Color.PeachPuff;
            this._cmdAbbrechen.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdAbbrechen.Location = new System.Drawing.Point(54, 192);
            this._cmdAbbrechen.Name = "_cmdAbbrechen";
            this._cmdAbbrechen.Size = new System.Drawing.Size(130, 35);
            this._cmdAbbrechen.TabIndex = 35;
            this._cmdAbbrechen.Text = "Abbrechen";
            this._cmdAbbrechen.UseVisualStyleBackColor = false;
            this._cmdAbbrechen.Click += new System.EventHandler(this._cmdAbbrechen_Click);
            // 
            // _cmdMittel
            // 
            this._cmdMittel.BackColor = System.Drawing.Color.PeachPuff;
            this._cmdMittel.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdMittel.Location = new System.Drawing.Point(9, 72);
            this._cmdMittel.Name = "_cmdMittel";
            this._cmdMittel.Size = new System.Drawing.Size(218, 35);
            this._cmdMittel.TabIndex = 41;
            this._cmdMittel.Text = "Mittel";
            this._cmdMittel.UseVisualStyleBackColor = false;
            this._cmdMittel.Click += new System.EventHandler(this._cmdMittel_Click);
            // 
            // _cmdSchwer
            // 
            this._cmdSchwer.BackColor = System.Drawing.Color.PeachPuff;
            this._cmdSchwer.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdSchwer.Location = new System.Drawing.Point(9, 119);
            this._cmdSchwer.Name = "_cmdSchwer";
            this._cmdSchwer.Size = new System.Drawing.Size(218, 35);
            this._cmdSchwer.TabIndex = 42;
            this._cmdSchwer.Text = "Schwer";
            this._cmdSchwer.UseVisualStyleBackColor = false;
            this._cmdSchwer.Click += new System.EventHandler(this._cmdSchwer_Click);
            // 
            // _ucSudokuErstellenAutomatisch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._cmdSchwer);
            this.Controls.Add(this._cmdMittel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cmdLeicht);
            this.Controls.Add(this._cmdAbbrechen);
            this.Name = "_ucSudokuErstellenAutomatisch";
            this.Size = new System.Drawing.Size(236, 233);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _cmdLeicht;
        private System.Windows.Forms.Button _cmdAbbrechen;
        private System.Windows.Forms.Button _cmdMittel;
        private System.Windows.Forms.Button _cmdSchwer;
    }
}
