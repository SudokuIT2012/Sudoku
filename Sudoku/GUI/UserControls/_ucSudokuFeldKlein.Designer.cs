namespace Sudoku.GUI
{
    partial class _ucSudokuFeldKlein
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
            this._lblZahl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lblZahl
            // 
            this._lblZahl.AutoSize = true;
            this._lblZahl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblZahl.Location = new System.Drawing.Point(5, 4);
            this._lblZahl.Name = "_lblZahl";
            this._lblZahl.Size = new System.Drawing.Size(17, 23);
            this._lblZahl.TabIndex = 0;
            this._lblZahl.Text = "1";
            // 
            // _ucSudokuFeldKlein
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._lblZahl);
            this.Name = "_ucSudokuFeldKlein";
            this.Size = new System.Drawing.Size(30, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblZahl;

    }
}
