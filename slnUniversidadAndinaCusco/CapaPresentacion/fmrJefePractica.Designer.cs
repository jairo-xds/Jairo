
namespace CapaPresentacion
{
    partial class fmrJefePractica
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
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtCursoPractico = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.btnDirigir = new System.Windows.Forms.Button();
            this.btnEnseñar = new System.Windows.Forms.Button();
            this.btnAyudar = new System.Windows.Forms.Button();
            this.btnCoordinar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(82, 74);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(100, 20);
            this.txtNombres.TabIndex = 0;
            // 
            // txtCursoPractico
            // 
            this.txtCursoPractico.Location = new System.Drawing.Point(82, 117);
            this.txtCursoPractico.Name = "txtCursoPractico";
            this.txtCursoPractico.Size = new System.Drawing.Size(100, 20);
            this.txtCursoPractico.TabIndex = 1;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(82, 155);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.txtFechaNacimiento.TabIndex = 2;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(82, 38);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidos.TabIndex = 3;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(82, 197);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(100, 20);
            this.txtEspecialidad.TabIndex = 4;
            // 
            // btnDirigir
            // 
            this.btnDirigir.Location = new System.Drawing.Point(21, 243);
            this.btnDirigir.Name = "btnDirigir";
            this.btnDirigir.Size = new System.Drawing.Size(75, 23);
            this.btnDirigir.TabIndex = 5;
            this.btnDirigir.Text = "Dirigir";
            this.btnDirigir.UseVisualStyleBackColor = true;
            this.btnDirigir.Click += new System.EventHandler(this.btnDirigir_Click);
            // 
            // btnEnseñar
            // 
            this.btnEnseñar.Location = new System.Drawing.Point(121, 242);
            this.btnEnseñar.Name = "btnEnseñar";
            this.btnEnseñar.Size = new System.Drawing.Size(75, 23);
            this.btnEnseñar.TabIndex = 6;
            this.btnEnseñar.Text = "Enseñar";
            this.btnEnseñar.UseVisualStyleBackColor = true;
            this.btnEnseñar.Click += new System.EventHandler(this.btnEnseñar_Click);
            // 
            // btnAyudar
            // 
            this.btnAyudar.Location = new System.Drawing.Point(218, 242);
            this.btnAyudar.Name = "btnAyudar";
            this.btnAyudar.Size = new System.Drawing.Size(75, 23);
            this.btnAyudar.TabIndex = 7;
            this.btnAyudar.Text = "Ayudar";
            this.btnAyudar.UseVisualStyleBackColor = true;
            this.btnAyudar.Click += new System.EventHandler(this.btnAyudar_Click);
            // 
            // btnCoordinar
            // 
            this.btnCoordinar.Location = new System.Drawing.Point(318, 242);
            this.btnCoordinar.Name = "btnCoordinar";
            this.btnCoordinar.Size = new System.Drawing.Size(75, 23);
            this.btnCoordinar.TabIndex = 8;
            this.btnCoordinar.Text = "Coordinar";
            this.btnCoordinar.UseVisualStyleBackColor = true;
            this.btnCoordinar.Click += new System.EventHandler(this.btnCoordinar_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(274, 38);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 9;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(274, 70);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 10;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // fmrJefePractica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnCoordinar);
            this.Controls.Add(this.btnAyudar);
            this.Controls.Add(this.btnEnseñar);
            this.Controls.Add(this.btnDirigir);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.txtCursoPractico);
            this.Controls.Add(this.txtNombres);
            this.Name = "fmrJefePractica";
            this.Text = "fmrJefePractica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtCursoPractico;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.Button btnDirigir;
        private System.Windows.Forms.Button btnEnseñar;
        private System.Windows.Forms.Button btnAyudar;
        private System.Windows.Forms.Button btnCoordinar;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
    }
}