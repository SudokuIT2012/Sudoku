namespace Sudoku.GUI.UserControls
{
    partial class _ucZahlenAuswahl
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
            this._cmdLeer = new System.Windows.Forms.Button();
            this._cmdZurueck = new System.Windows.Forms.Button();
            this._cmd9 = new System.Windows.Forms.Button();
            this._cmd8 = new System.Windows.Forms.Button();
            this._cmd7 = new System.Windows.Forms.Button();
            this._cmd6 = new System.Windows.Forms.Button();
            this._cmd5 = new System.Windows.Forms.Button();
            this._cmd4 = new System.Windows.Forms.Button();
            this._cmd3 = new System.Windows.Forms.Button();
            this._cmd2 = new System.Windows.Forms.Button();
            this._cmd1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _cmdLeer
            // 
            this._cmdLeer.BackColor = System.Drawing.Color.PeachPuff;
            this._cmdLeer.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdLeer.Location = new System.Drawing.Point(141, 193);
            this._cmdLeer.Name = "_cmdLeer";
            this._cmdLeer.Size = new System.Drawing.Size(86, 35);
            this._cmdLeer.TabIndex = 21;
            this._cmdLeer.Text = "Leer";
            this._cmdLeer.UseVisualStyleBackColor = false;
            this._cmdLeer.Click += new System.EventHandler(this._cmdLeer_Click);
            // 
            // _cmdZurueck
            // 
            this._cmdZurueck.BackColor = System.Drawing.Color.PeachPuff;
            this._cmdZurueck.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdZurueck.Location = new System.Drawing.Point(5, 193);
            this._cmdZurueck.Name = "_cmdZurueck";
            this._cmdZurueck.Size = new System.Drawing.Size(130, 35);
            this._cmdZurueck.TabIndex = 20;
            this._cmdZurueck.Text = "Abbrechen";
            this._cmdZurueck.UseVisualStyleBackColor = false;
            this._cmdZurueck.Click += new System.EventHandler(this._cmdZurueck_Click);
            // 
            // _cmd9
            // 
            this._cmd9.BackColor = System.Drawing.Color.PeachPuff;
            this._cmd9.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmd9.Location = new System.Drawing.Point(154, 129);
            this._cmd9.Name = "_cmd9";
            this._cmd9.Size = new System.Drawing.Size(62, 56);
            this._cmd9.TabIndex = 19;
            this._cmd9.Text = "9";
            this._cmd9.UseVisualStyleBackColor = false;
            this._cmd9.Click += new System.EventHandler(this.AuswahlGetroffen);
            // 
            // _cmd8
            // 
            this._cmd8.BackColor = System.Drawing.Color.PeachPuff;
            this._cmd8.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmd8.Location = new System.Drawing.Point(86, 128);
            this._cmd8.Name = "_cmd8";
            this._cmd8.Size = new System.Drawing.Size(62, 56);
            this._cmd8.TabIndex = 18;
            this._cmd8.Text = "8";
            this._cmd8.UseVisualStyleBackColor = false;
            this._cmd8.Click += new System.EventHandler(this.AuswahlGetroffen);
            // 
            // _cmd7
            // 
            this._cmd7.BackColor = System.Drawing.Color.PeachPuff;
            this._cmd7.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmd7.Location = new System.Drawing.Point(18, 129);
            this._cmd7.Name = "_cmd7";
            this._cmd7.Size = new System.Drawing.Size(62, 56);
            this._cmd7.TabIndex = 17;
            this._cmd7.Text = "7";
            this._cmd7.UseVisualStyleBackColor = false;
            this._cmd7.Click += new System.EventHandler(this.AuswahlGetroffen);
            // 
            // _cmd6
            // 
            this._cmd6.BackColor = System.Drawing.Color.PeachPuff;
            this._cmd6.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmd6.Location = new System.Drawing.Point(154, 67);
            this._cmd6.Name = "_cmd6";
            this._cmd6.Size = new System.Drawing.Size(62, 56);
            this._cmd6.TabIndex = 16;
            this._cmd6.Text = "6";
            this._cmd6.UseVisualStyleBackColor = false;
            this._cmd6.Click += new System.EventHandler(this.AuswahlGetroffen);
            // 
            // _cmd5
            // 
            this._cmd5.BackColor = System.Drawing.Color.PeachPuff;
            this._cmd5.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmd5.Location = new System.Drawing.Point(86, 66);
            this._cmd5.Name = "_cmd5";
            this._cmd5.Size = new System.Drawing.Size(62, 56);
            this._cmd5.TabIndex = 15;
            this._cmd5.Text = "5";
            this._cmd5.UseVisualStyleBackColor = false;
            this._cmd5.Click += new System.EventHandler(this.AuswahlGetroffen);
            // 
            // _cmd4
            // 
            this._cmd4.BackColor = System.Drawing.Color.PeachPuff;
            this._cmd4.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmd4.Location = new System.Drawing.Point(18, 67);
            this._cmd4.Name = "_cmd4";
            this._cmd4.Size = new System.Drawing.Size(62, 56);
            this._cmd4.TabIndex = 14;
            this._cmd4.Text = "4";
            this._cmd4.UseVisualStyleBackColor = false;
            this._cmd4.Click += new System.EventHandler(this.AuswahlGetroffen);
            // 
            // _cmd3
            // 
            this._cmd3.BackColor = System.Drawing.Color.PeachPuff;
            this._cmd3.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmd3.Location = new System.Drawing.Point(154, 5);
            this._cmd3.Name = "_cmd3";
            this._cmd3.Size = new System.Drawing.Size(62, 56);
            this._cmd3.TabIndex = 13;
            this._cmd3.Text = "3";
            this._cmd3.UseVisualStyleBackColor = false;
            this._cmd3.Click += new System.EventHandler(this.AuswahlGetroffen);
            // 
            // _cmd2
            // 
            this._cmd2.BackColor = System.Drawing.Color.PeachPuff;
            this._cmd2.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmd2.Location = new System.Drawing.Point(86, 4);
            this._cmd2.Name = "_cmd2";
            this._cmd2.Size = new System.Drawing.Size(62, 56);
            this._cmd2.TabIndex = 12;
            this._cmd2.Text = "2";
            this._cmd2.UseVisualStyleBackColor = false;
            this._cmd2.Click += new System.EventHandler(this.AuswahlGetroffen);
            // 
            // _cmd1
            // 
            this._cmd1.BackColor = System.Drawing.Color.PeachPuff;
            this._cmd1.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmd1.Location = new System.Drawing.Point(18, 5);
            this._cmd1.Name = "_cmd1";
            this._cmd1.Size = new System.Drawing.Size(62, 56);
            this._cmd1.TabIndex = 11;
            this._cmd1.Text = "1";
            this._cmd1.UseVisualStyleBackColor = false;
            this._cmd1.Click += new System.EventHandler(this.AuswahlGetroffen);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 3);
            this.label1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 3);
            this.label2.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(3, 233);
            this.label3.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(233, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(3, 233);
            this.label4.TabIndex = 25;
            // 
            // _ucZahlenAuswahl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cmdLeer);
            this.Controls.Add(this._cmdZurueck);
            this.Controls.Add(this._cmd9);
            this.Controls.Add(this._cmd8);
            this.Controls.Add(this._cmd7);
            this.Controls.Add(this._cmd6);
            this.Controls.Add(this._cmd5);
            this.Controls.Add(this._cmd4);
            this.Controls.Add(this._cmd3);
            this.Controls.Add(this._cmd2);
            this.Controls.Add(this._cmd1);
            this.Name = "_ucZahlenAuswahl";
            this.Size = new System.Drawing.Size(236, 233);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _cmdLeer;
        private System.Windows.Forms.Button _cmdZurueck;
        private System.Windows.Forms.Button _cmd9;
        private System.Windows.Forms.Button _cmd8;
        private System.Windows.Forms.Button _cmd7;
        private System.Windows.Forms.Button _cmd6;
        private System.Windows.Forms.Button _cmd5;
        private System.Windows.Forms.Button _cmd4;
        private System.Windows.Forms.Button _cmd3;
        private System.Windows.Forms.Button _cmd2;
        private System.Windows.Forms.Button _cmd1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
