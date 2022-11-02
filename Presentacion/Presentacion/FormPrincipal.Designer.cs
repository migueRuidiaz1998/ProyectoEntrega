namespace Presentacion
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BotonSospechosos = new System.Windows.Forms.Button();
            this.BotonDetectives = new System.Windows.Forms.Button();
            this.BotonCasos = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(76, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Casos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(252, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Detectives";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(425, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sospechosos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(149, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "OFICINA DE DETECTIVES";
            // 
            // BotonSospechosos
            // 
            this.BotonSospechosos.BackColor = System.Drawing.Color.White;
            this.BotonSospechosos.Image = global::Presentacion.Properties.Resources.Sospechoso__1_;
            this.BotonSospechosos.Location = new System.Drawing.Point(414, 118);
            this.BotonSospechosos.Name = "BotonSospechosos";
            this.BotonSospechosos.Size = new System.Drawing.Size(124, 121);
            this.BotonSospechosos.TabIndex = 2;
            this.BotonSospechosos.UseVisualStyleBackColor = false;
            this.BotonSospechosos.Click += new System.EventHandler(this.BotonSospechosos_Click);
            // 
            // BotonDetectives
            // 
            this.BotonDetectives.BackColor = System.Drawing.Color.White;
            this.BotonDetectives.ForeColor = System.Drawing.SystemColors.Control;
            this.BotonDetectives.Image = global::Presentacion.Properties.Resources.Detective__1_;
            this.BotonDetectives.Location = new System.Drawing.Point(232, 118);
            this.BotonDetectives.Name = "BotonDetectives";
            this.BotonDetectives.Size = new System.Drawing.Size(124, 121);
            this.BotonDetectives.TabIndex = 1;
            this.BotonDetectives.UseVisualStyleBackColor = false;
            this.BotonDetectives.Click += new System.EventHandler(this.BotonDetectives_Click);
            // 
            // BotonCasos
            // 
            this.BotonCasos.BackColor = System.Drawing.Color.White;
            this.BotonCasos.ForeColor = System.Drawing.SystemColors.Control;
            this.BotonCasos.Image = global::Presentacion.Properties.Resources.Caso__1_;
            this.BotonCasos.Location = new System.Drawing.Point(45, 118);
            this.BotonCasos.Name = "BotonCasos";
            this.BotonCasos.Size = new System.Drawing.Size(124, 121);
            this.BotonCasos.TabIndex = 0;
            this.BotonCasos.UseVisualStyleBackColor = false;
            // 
            // Cerrar
            // 
            this.Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cerrar.Location = new System.Drawing.Point(463, 326);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 7;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotonSospechosos);
            this.Controls.Add(this.BotonDetectives);
            this.Controls.Add(this.BotonCasos);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BotonDetectives;
        private System.Windows.Forms.Button BotonSospechosos;
        private System.Windows.Forms.Button BotonCasos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Cerrar;
    }
}

