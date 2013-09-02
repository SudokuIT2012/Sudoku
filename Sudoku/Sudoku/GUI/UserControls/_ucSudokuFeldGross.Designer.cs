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
            this._txtMerken1 = new System.Windows.Forms.TextBox();
            this._txtMerken2 = new System.Windows.Forms.TextBox();
            this._txtMerken3 = new System.Windows.Forms.TextBox();
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
            this._lblZahl.MouseEnter += new System.EventHandler(this._lblZahl_MouseEnter);
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
            this._txtZahl.MouseEnter += new System.EventHandler(this._txtZahl_MouseEnter);
            this._txtZahl.MouseLeave += new System.EventHandler(this._txtZahl_MouseLeave);
            this._txtZahl.MouseMove += new System.Windows.Forms.MouseEventHandler(this._txtZahl_MouseMove);
            // 
            // _txtMerken1
            // 
            this._txtMerken1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._txtMerken1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtMerken1.Location = new System.Drawing.Point(0, 0);
            this._txtMerken1.Multiline = true;
            this._txtMerken1.Name = "_txtMerken1";
            this._txtMerken1.Size = new System.Drawing.Size(20, 20);
            this._txtMerken1.TabIndex = 2;
            this._txtMerken1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtMerken1.Visible = false;
            this._txtMerken1.DoubleClick += new System.EventHandler(this._txtMerken1_DoubleClick);
            this._txtMerken1.MouseEnter += new System.EventHandler(this._txtMerken1_MouseEnter);
            // 
            // _txtMerken2
            // 
            this._txtMerken2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._txtMerken2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtMerken2.Location = new System.Drawing.Point(20, 0);
            this._txtMerken2.Multiline = true;
            this._txtMerken2.Name = "_txtMerken2";
            this._txtMerken2.Size = new System.Drawing.Size(20, 20);
            this._txtMerken2.TabIndex = 3;
            this._txtMerken2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtMerken2.Visible = false;
            this._txtMerken2.DoubleClick += new System.EventHandler(this._txtMerken2_DoubleClick);
            this._txtMerken2.MouseEnter += new System.EventHandler(this._txtMerken2_MouseEnter);
            // 
            // _txtMerken3
            // 
            this._txtMerken3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._txtMerken3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtMerken3.Location = new System.Drawing.Point(40, 0);
            this._txtMerken3.Multiline = true;
            this._txtMerken3.Name = "_txtMerken3";
            this._txtMerken3.Size = new System.Drawing.Size(20, 20);
            this._txtMerken3.TabIndex = 4;
            this._txtMerken3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtMerken3.Visible = false;
            this._txtMerken3.DoubleClick += new System.EventHandler(this._txtMerken3_DoubleClick);
            this._txtMerken3.MouseEnter += new System.EventHandler(this._txtMerken3_MouseEnter);
            // 
            // _ucSudokuFeldGross
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._txtMerken3);
            this.Controls.Add(this._txtMerken2);
            this.Controls.Add(this._txtMerken1);
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
        private System.Windows.Forms.TextBox _txtMerken1;
        private System.Windows.Forms.TextBox _txtMerken2;
        private System.Windows.Forms.TextBox _txtMerken3;
    }
}
