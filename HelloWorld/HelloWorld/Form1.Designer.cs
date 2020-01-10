namespace HelloWorld
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
            this.btnKaixo = new System.Windows.Forms.Button();
            this.Itxi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKaixo
            // 
            this.btnKaixo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKaixo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaixo.Font = new System.Drawing.Font("Miriam Libre", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaixo.Location = new System.Drawing.Point(181, 185);
            this.btnKaixo.Name = "btnKaixo";
            this.btnKaixo.Size = new System.Drawing.Size(129, 55);
            this.btnKaixo.TabIndex = 0;
            this.btnKaixo.Text = "Kaixo";
            this.btnKaixo.UseVisualStyleBackColor = false;
            this.btnKaixo.Click += new System.EventHandler(this.BtnKaixo_Click);
            // 
            // Itxi
            // 
            this.Itxi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Itxi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Itxi.Font = new System.Drawing.Font("Miriam Libre", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Itxi.Location = new System.Drawing.Point(503, 185);
            this.Itxi.Name = "Itxi";
            this.Itxi.Size = new System.Drawing.Size(129, 55);
            this.Itxi.TabIndex = 1;
            this.Itxi.Text = "Itxi";
            this.Itxi.UseVisualStyleBackColor = false;
            this.Itxi.Click += new System.EventHandler(this.Itxi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Itxi);
            this.Controls.Add(this.btnKaixo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKaixo;
        private System.Windows.Forms.Button Itxi;
    }
}

