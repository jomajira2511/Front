namespace CursoCsharp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBLHolaMundo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBLHolaMundo
            // 
            this.LBLHolaMundo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LBLHolaMundo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBLHolaMundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLHolaMundo.ForeColor = System.Drawing.Color.DarkOrchid;
            this.LBLHolaMundo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LBLHolaMundo.Location = new System.Drawing.Point(0, 0);
            this.LBLHolaMundo.Name = "LBLHolaMundo";
            this.LBLHolaMundo.Size = new System.Drawing.Size(1441, 70);
            this.LBLHolaMundo.TabIndex = 0;
            this.LBLHolaMundo.Text = "Hola mundo ";
            this.LBLHolaMundo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBLHolaMundo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 646);
            this.Controls.Add(this.LBLHolaMundo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBLHolaMundo;
    }
}

