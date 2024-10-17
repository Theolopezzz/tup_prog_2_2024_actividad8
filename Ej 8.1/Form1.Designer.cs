namespace Ej_8._1
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
            this.bVerCuentas = new System.Windows.Forms.Button();
            this.bImportarCuentas = new System.Windows.Forms.Button();
            this.bExportarCuentas = new System.Windows.Forms.Button();
            this.bResguardar = new System.Windows.Forms.Button();
            this.bRestaurar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bVerCuentas
            // 
            this.bVerCuentas.Location = new System.Drawing.Point(490, 12);
            this.bVerCuentas.Name = "bVerCuentas";
            this.bVerCuentas.Size = new System.Drawing.Size(141, 48);
            this.bVerCuentas.TabIndex = 0;
            this.bVerCuentas.Text = "1- Ver Cuentas";
            this.bVerCuentas.UseVisualStyleBackColor = true;
            this.bVerCuentas.Click += new System.EventHandler(this.bVerCuentas_Click);
            // 
            // bImportarCuentas
            // 
            this.bImportarCuentas.Location = new System.Drawing.Point(490, 77);
            this.bImportarCuentas.Name = "bImportarCuentas";
            this.bImportarCuentas.Size = new System.Drawing.Size(141, 48);
            this.bImportarCuentas.TabIndex = 1;
            this.bImportarCuentas.Text = "2- Importar Cuentas";
            this.bImportarCuentas.UseVisualStyleBackColor = true;
            // 
            // bExportarCuentas
            // 
            this.bExportarCuentas.Location = new System.Drawing.Point(490, 142);
            this.bExportarCuentas.Name = "bExportarCuentas";
            this.bExportarCuentas.Size = new System.Drawing.Size(141, 48);
            this.bExportarCuentas.TabIndex = 2;
            this.bExportarCuentas.Text = "3- Exportar Cuentas";
            this.bExportarCuentas.UseVisualStyleBackColor = true;
            // 
            // bResguardar
            // 
            this.bResguardar.Location = new System.Drawing.Point(490, 204);
            this.bResguardar.Name = "bResguardar";
            this.bResguardar.Size = new System.Drawing.Size(141, 48);
            this.bResguardar.TabIndex = 3;
            this.bResguardar.Text = "4- Resguardar (Backup)";
            this.bResguardar.UseVisualStyleBackColor = true;
            // 
            // bRestaurar
            // 
            this.bRestaurar.Location = new System.Drawing.Point(490, 267);
            this.bRestaurar.Name = "bRestaurar";
            this.bRestaurar.Size = new System.Drawing.Size(141, 48);
            this.bRestaurar.TabIndex = 4;
            this.bRestaurar.Text = "5- Restaurar (Restore)";
            this.bRestaurar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(461, 303);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 328);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bRestaurar);
            this.Controls.Add(this.bResguardar);
            this.Controls.Add(this.bExportarCuentas);
            this.Controls.Add(this.bImportarCuentas);
            this.Controls.Add(this.bVerCuentas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bVerCuentas;
        private System.Windows.Forms.Button bImportarCuentas;
        private System.Windows.Forms.Button bExportarCuentas;
        private System.Windows.Forms.Button bResguardar;
        private System.Windows.Forms.Button bRestaurar;
        private System.Windows.Forms.TextBox textBox1;
    }
}

