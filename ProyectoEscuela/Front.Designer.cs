namespace ProyectoEscuela
{
    partial class Front
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
            this.btn_nuevoAlumno = new System.Windows.Forms.Button();
            this.btn_asistencias = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_nuevoAlumno
            // 
            this.btn_nuevoAlumno.Location = new System.Drawing.Point(37, 33);
            this.btn_nuevoAlumno.Name = "btn_nuevoAlumno";
            this.btn_nuevoAlumno.Size = new System.Drawing.Size(141, 23);
            this.btn_nuevoAlumno.TabIndex = 0;
            this.btn_nuevoAlumno.Text = "Alumnos";
            this.btn_nuevoAlumno.UseVisualStyleBackColor = true;
            this.btn_nuevoAlumno.Click += new System.EventHandler(this.btn_nuevoAlumno_Click);
            // 
            // btn_asistencias
            // 
            this.btn_asistencias.Location = new System.Drawing.Point(37, 88);
            this.btn_asistencias.Name = "btn_asistencias";
            this.btn_asistencias.Size = new System.Drawing.Size(141, 23);
            this.btn_asistencias.TabIndex = 1;
            this.btn_asistencias.Text = "Tomar asistencia";
            this.btn_asistencias.UseVisualStyleBackColor = true;
            this.btn_asistencias.Click += new System.EventHandler(this.btn_asistencias_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Iniciar sesion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(650, 22);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(121, 20);
            this.txt_user.TabIndex = 3;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(650, 62);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(121, 20);
            this.txt_pass.TabIndex = 4;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Consultar alumno";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(37, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Registrar notas";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Front
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_asistencias);
            this.Controls.Add(this.btn_nuevoAlumno);
            this.Name = "Front";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nuevoAlumno;
        private System.Windows.Forms.Button btn_asistencias;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

