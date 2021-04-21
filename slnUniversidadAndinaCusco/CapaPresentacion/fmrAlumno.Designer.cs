
namespace CapaPresentacion
{
    partial class fmrAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtLugarNacimiento = new System.Windows.Forms.TextBox();
            this.btnEstudiar = new System.Windows.Forms.Button();
            this.btnTrabajar = new System.Windows.Forms.Button();
            this.btnAprobarExamen = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(166, 70);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidos.TabIndex = 0;
            this.txtApellidos.TextChanged += new System.EventHandler(this.txtApellidos_TextChanged);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(166, 121);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(100, 20);
            this.txtNombres.TabIndex = 1;
            this.txtNombres.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(166, 163);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 2;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            // 
            // txtLugarNacimiento
            // 
            this.txtLugarNacimiento.Location = new System.Drawing.Point(166, 205);
            this.txtLugarNacimiento.Name = "txtLugarNacimiento";
            this.txtLugarNacimiento.Size = new System.Drawing.Size(100, 20);
            this.txtLugarNacimiento.TabIndex = 3;
            this.txtLugarNacimiento.TextChanged += new System.EventHandler(this.txtLugarNacimiento_TextChanged);
            // 
            // btnEstudiar
            // 
            this.btnEstudiar.Location = new System.Drawing.Point(34, 261);
            this.btnEstudiar.Name = "btnEstudiar";
            this.btnEstudiar.Size = new System.Drawing.Size(75, 23);
            this.btnEstudiar.TabIndex = 4;
            this.btnEstudiar.Text = "Estudiar";
            this.btnEstudiar.UseVisualStyleBackColor = true;
            this.btnEstudiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTrabajar
            // 
            this.btnTrabajar.Location = new System.Drawing.Point(136, 260);
            this.btnTrabajar.Name = "btnTrabajar";
            this.btnTrabajar.Size = new System.Drawing.Size(75, 23);
            this.btnTrabajar.TabIndex = 5;
            this.btnTrabajar.Text = "Trabajar";
            this.btnTrabajar.UseVisualStyleBackColor = true;
            this.btnTrabajar.Click += new System.EventHandler(this.btnTrabajar_Click);
            // 
            // btnAprobarExamen
            // 
            this.btnAprobarExamen.Location = new System.Drawing.Point(238, 260);
            this.btnAprobarExamen.Name = "btnAprobarExamen";
            this.btnAprobarExamen.Size = new System.Drawing.Size(109, 23);
            this.btnAprobarExamen.TabIndex = 6;
            this.btnAprobarExamen.Text = "Aprobar Examen";
            this.btnAprobarExamen.UseVisualStyleBackColor = true;
            this.btnAprobarExamen.Click += new System.EventHandler(this.btnAprobarExamen_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(309, 66);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 7;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(309, 136);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 8;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.button5_Click);
            // 
            // fmrAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnAprobarExamen);
            this.Controls.Add(this.btnTrabajar);
            this.Controls.Add(this.btnEstudiar);
            this.Controls.Add(this.txtLugarNacimiento);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidos);
            this.Name = "fmrAlumno";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtLugarNacimiento;
        private System.Windows.Forms.Button btnEstudiar;
        private System.Windows.Forms.Button btnTrabajar;
        private System.Windows.Forms.Button btnAprobarExamen;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
    }
}