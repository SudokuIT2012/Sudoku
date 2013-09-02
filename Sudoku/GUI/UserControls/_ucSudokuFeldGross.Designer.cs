namespace Sudoku.GUI.UserControls
{
    partial class _ucSudokuFeldGross
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
            this._txtZahl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _lblZahl
            // 
            this._lblZahl.AutoSize = true;
            this._lblZahl.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblZahl.Location = new System.Drawing.Point(2, 0);
            this._lblZahl.Name = "_lblZahl";
            this._lblZahl.Size = new System.Drawing.Size(0, 53);
            this._lblZahl.TabIndex = 0;
            // 
            // _txtZahl
            // 
            this._txtZahl.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtZahl.Location = new System.Drawing.Point(0, 0);
            this._txtZahl.Name = "_txtZahl";
            this._txtZahl.Size = new System.Drawing.Size(60, 60);
            this._txtZahl.TabIndex = 1;
            this._txtZahl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtZahl.TextChanged += new System.EventHandler(this._txtZahl_TextChanged);
            this._txtZahl.DoubleClick += new System.EventHandler(this._txtZahl_Click);
            // 
            // _ucSudokuFeldGross
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._txtZahl);
            this.Controls.Add(this._lblZahl);
            this.Name = "_ucSudokuFeldGross";
            this.Size = new System.Drawing.Size(60, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblZahl;
        private System.Windows.Forms.TextBox _txtZahl;
    }
}
