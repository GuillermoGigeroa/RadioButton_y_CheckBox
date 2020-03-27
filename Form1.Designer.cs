namespace RadioButton_y_CheckBox
{
    partial class Ventana
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
            this.Etiqueta1 = new System.Windows.Forms.Label();
            this.Etiqueta2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.CheckProgramador = new System.Windows.Forms.CheckBox();
            this.BotonOK = new System.Windows.Forms.Button();
            this.CajaSexo = new System.Windows.Forms.GroupBox();
            this.RadioButtonMujer = new System.Windows.Forms.RadioButton();
            this.RadioButtonHombre = new System.Windows.Forms.RadioButton();
            this.Etiqueta3 = new System.Windows.Forms.Label();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.CajaSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Etiqueta1
            // 
            this.Etiqueta1.AutoSize = true;
            this.Etiqueta1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta1.Location = new System.Drawing.Point(12, 18);
            this.Etiqueta1.Name = "Etiqueta1";
            this.Etiqueta1.Size = new System.Drawing.Size(56, 18);
            this.Etiqueta1.TabIndex = 0;
            this.Etiqueta1.Text = "Nombre";
            // 
            // Etiqueta2
            // 
            this.Etiqueta2.AutoSize = true;
            this.Etiqueta2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta2.Location = new System.Drawing.Point(12, 55);
            this.Etiqueta2.Name = "Etiqueta2";
            this.Etiqueta2.Size = new System.Drawing.Size(96, 18);
            this.Etiqueta2.TabIndex = 0;
            this.Etiqueta2.Text = "Programador";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(114, 18);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(279, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // CheckProgramador
            // 
            this.CheckProgramador.AutoSize = true;
            this.CheckProgramador.Checked = true;
            this.CheckProgramador.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckProgramador.Location = new System.Drawing.Point(114, 59);
            this.CheckProgramador.Name = "CheckProgramador";
            this.CheckProgramador.Size = new System.Drawing.Size(15, 14);
            this.CheckProgramador.TabIndex = 2;
            this.CheckProgramador.UseVisualStyleBackColor = true;
            // 
            // BotonOK
            // 
            this.BotonOK.Location = new System.Drawing.Point(412, 18);
            this.BotonOK.Name = "BotonOK";
            this.BotonOK.Size = new System.Drawing.Size(109, 20);
            this.BotonOK.TabIndex = 3;
            this.BotonOK.Text = "OK";
            this.BotonOK.UseVisualStyleBackColor = true;
            this.BotonOK.Click += new System.EventHandler(this.BotonOK_Click);
            // 
            // CajaSexo
            // 
            this.CajaSexo.Controls.Add(this.RadioButtonMujer);
            this.CajaSexo.Controls.Add(this.RadioButtonHombre);
            this.CajaSexo.ForeColor = System.Drawing.Color.Coral;
            this.CajaSexo.Location = new System.Drawing.Point(15, 90);
            this.CajaSexo.Name = "CajaSexo";
            this.CajaSexo.Size = new System.Drawing.Size(440, 47);
            this.CajaSexo.TabIndex = 5;
            this.CajaSexo.TabStop = false;
            this.CajaSexo.Text = "Sexo";
            // 
            // RadioButtonMujer
            // 
            this.RadioButtonMujer.AutoSize = true;
            this.RadioButtonMujer.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RadioButtonMujer.ForeColor = System.Drawing.Color.Black;
            this.RadioButtonMujer.Location = new System.Drawing.Point(297, 19);
            this.RadioButtonMujer.Name = "RadioButtonMujer";
            this.RadioButtonMujer.Size = new System.Drawing.Size(51, 17);
            this.RadioButtonMujer.TabIndex = 0;
            this.RadioButtonMujer.Text = "Mujer";
            this.RadioButtonMujer.UseVisualStyleBackColor = true;
            // 
            // RadioButtonHombre
            // 
            this.RadioButtonHombre.AutoSize = true;
            this.RadioButtonHombre.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RadioButtonHombre.Checked = true;
            this.RadioButtonHombre.ForeColor = System.Drawing.Color.Black;
            this.RadioButtonHombre.Location = new System.Drawing.Point(82, 19);
            this.RadioButtonHombre.Name = "RadioButtonHombre";
            this.RadioButtonHombre.Size = new System.Drawing.Size(62, 17);
            this.RadioButtonHombre.TabIndex = 0;
            this.RadioButtonHombre.TabStop = true;
            this.RadioButtonHombre.Text = "Hombre";
            this.RadioButtonHombre.UseVisualStyleBackColor = true;
            // 
            // Etiqueta3
            // 
            this.Etiqueta3.AutoSize = true;
            this.Etiqueta3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta3.Location = new System.Drawing.Point(12, 149);
            this.Etiqueta3.Name = "Etiqueta3";
            this.Etiqueta3.Size = new System.Drawing.Size(56, 18);
            this.Etiqueta3.TabIndex = 6;
            this.Etiqueta3.Text = "Salida";
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(12, 170);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(509, 116);
            this.txtSalida.TabIndex = 1;
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 298);
            this.Controls.Add(this.Etiqueta3);
            this.Controls.Add(this.CajaSexo);
            this.Controls.Add(this.BotonOK);
            this.Controls.Add(this.CheckProgramador);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.Etiqueta2);
            this.Controls.Add(this.Etiqueta1);
            this.Name = "Ventana";
            this.Text = "RadioButton y CheckBox";
            this.Load += new System.EventHandler(this.Ventana_Load);
            this.CajaSexo.ResumeLayout(false);
            this.CajaSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Etiqueta1;
        private System.Windows.Forms.Label Etiqueta2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox CheckProgramador;
        private System.Windows.Forms.Button BotonOK;
        private System.Windows.Forms.GroupBox CajaSexo;
        private System.Windows.Forms.RadioButton RadioButtonMujer;
        private System.Windows.Forms.RadioButton RadioButtonHombre;
        private System.Windows.Forms.Label Etiqueta3;
        private System.Windows.Forms.TextBox txtSalida;
    }
}

