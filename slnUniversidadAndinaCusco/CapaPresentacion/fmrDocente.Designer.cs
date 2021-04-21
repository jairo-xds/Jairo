
namespace CapaPresentacion
{
    partial class fmrDocente
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
            this.btnEnseñar = new System.Windows.Forms.Button();
            this.btnMatricular = new System.Windows.Forms.Button();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.btnDesaprobar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtProfesion = new System.Windows.Forms.TextBox();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnseñar
            // 
            this.btnEnseñar.Location = new System.Drawing.Point(43, 216);
            this.btnEnseñar.Name = "btnEnseñar";
            this.btnEnseñar.Size = new System.Drawing.Size(75, 23);
            this.btnEnseñar.TabIndex = 0;
            this.btnEnseñar.Text = "Enseñar";
            this.btnEnseñar.UseVisualStyleBackColor = true;
            this.btnEnseñar.Click += new System.EventHandler(this.btnEnseñar_Click);
            // 
            // btnMatricular
            // 
            this.btnMatricular.Location = new System.Drawing.Point(150, 216);
            this.btnMatricular.Name = "btnMatricular";
            this.btnMatricular.Size = new System.Drawing.Size(75, 23);
            this.btnMatricular.TabIndex = 1;
            this.btnMatricular.Text = "Matricular";
            this.btnMatricular.UseVisualStyleBackColor = true;
            this.btnMatricular.Click += new System.EventHandler(this.btnMatricular_Click);
            // 
            // btnAprobar
            // 
            this.btnAprobar.Location = new System.Drawing.Point(261, 216);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(75, 23);
            this.btnAprobar.TabIndex = 2;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.UseVisualStyleBackColor = true;
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // btnDesaprobar
            // 
            this.btnDesaprobar.Location = new System.Drawing.Point(351, 216);
            this.btnDesaprobar.Name = "btnDesaprobar";
            this.btnDesaprobar.Size = new System.Drawing.Size(75, 23);
            this.btnDesaprobar.TabIndex = 3;
            this.btnDesaprobar.Text = "Desaprobar";
            this.btnDesaprobar.UseVisualStyleBackColor = true;
            this.btnDesaprobar.Click += new System.EventHandler(this.btnDesaprobar_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(350, 40);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 4;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(43, 29);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidos.TabIndex = 5;
            this.txtApellidos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(43, 67);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(100, 20);
            this.txtNombres.TabIndex = 6;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(43, 105);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 7;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(43, 142);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.txtFechaNacimiento.TabIndex = 8;
            // 
            // txtProfesion
            // 
            this.txtProfesion.Location = new System.Drawing.Point(43, 178);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(100, 20);
            this.txtProfesion.TabIndex = 9;
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(350, 115);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 10;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // fmrDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.txtProfesion);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnDesaprobar);
            this.Controls.Add(this.btnAprobar);
            this.Controls.Add(this.btnMatricular);
            this.Controls.Add(this.btnEnseñar);
            this.Name = "fmrDocente";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnseñar;
        private System.Windows.Forms.Button btnMatricular;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Button btnDesaprobar;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.TextBox txtProfesion;
        private System.Windows.Forms.Button btnEscribir;
    }
}