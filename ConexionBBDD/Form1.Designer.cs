namespace ConexionBBDD
{
    partial class ConexionSQL
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
            this.txtEstadoBBDD = new System.Windows.Forms.TextBox();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEstadoBBDD
            // 
            this.txtEstadoBBDD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEstadoBBDD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstadoBBDD.Enabled = false;
            this.txtEstadoBBDD.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoBBDD.Location = new System.Drawing.Point(12, 12);
            this.txtEstadoBBDD.Name = "txtEstadoBBDD";
            this.txtEstadoBBDD.Size = new System.Drawing.Size(393, 20);
            this.txtEstadoBBDD.TabIndex = 0;
            this.txtEstadoBBDD.Text = "Closed";
            this.txtEstadoBBDD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEstadoBBDD.TextChanged += new System.EventHandler(this.txtEstadoBBDD_TextChanged);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.Location = new System.Drawing.Point(217, 58);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(188, 42);
            this.btnDesconectar.TabIndex = 2;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(12, 58);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(182, 42);
            this.btnConectar.TabIndex = 3;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // ConexionSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 414);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.txtEstadoBBDD);
            this.Name = "ConexionSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexión  a SQL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstadoBBDD;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnConectar;
    }
}

