
namespace CapaPresentacion
{
    partial class fmrRector
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
            this.btnRepresentar = new System.Windows.Forms.Button();
            this.btnDirigir = new System.Windows.Forms.Button();
            this.btnReglamentar = new System.Windows.Forms.Button();
            this.btnCoordinar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.txtGradoInstruccion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRepresentar
            // 
            this.btnRepresentar.Location = new System.Drawing.Point(23, 208);
            this.btnRepresentar.Name = "btnRepresentar";
            this.btnRepresentar.Size = new System.Drawing.Size(75, 23);
            this.btnRepresentar.TabIndex = 0;
            this.btnRepresentar.Text = "Representar";
            this.btnRepresentar.UseVisualStyleBackColor = true;
            this.btnRepresentar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDirigir
            // 
            this.btnDirigir.Location = new System.Drawing.Point(119, 208);
            this.btnDirigir.Name = "btnDirigir";
            this.btnDirigir.Size = new System.Drawing.Size(75, 23);
            this.btnDirigir.TabIndex = 1;
            this.btnDirigir.Text = "Dirigir";
            this.btnDirigir.UseVisualStyleBackColor = true;
            this.btnDirigir.Click += new System.EventHandler(this.btnDirigir_Click);
            // 
            // btnReglamentar
            // 
            this.btnReglamentar.Location = new System.Drawing.Point(215, 208);
            this.btnReglamentar.Name = "btnReglamentar";
            this.btnReglamentar.Size = new System.Drawing.Size(75, 23);
            this.btnReglamentar.TabIndex = 2;
            this.btnReglamentar.Text = "Reglamentar";
            this.btnReglamentar.UseVisualStyleBackColor = true;
            this.btnReglamentar.Click += new System.EventHandler(this.btnReglamentar_Click);
            // 
            // btnCoordinar
            // 
            this.btnCoordinar.Location = new System.Drawing.Point(309, 208);
            this.btnCoordinar.Name = "btnCoordinar";
            this.btnCoordinar.Size = new System.Drawing.Size(75, 23);
            this.btnCoordinar.TabIndex = 3;
            this.btnCoordinar.Text = "Coordinar";
            this.btnCoordinar.UseVisualStyleBackColor = true;
            this.btnCoordinar.Click += new System.EventHandler(this.btnCoordinar_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(205, 29);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 4;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(205, 70);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 5;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(80, 12);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidos.TabIndex = 6;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(80, 49);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(100, 20);
            this.txtNombres.TabIndex = 7;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(80, 86);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 8;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(80, 123);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(100, 20);
            this.txtEspecialidad.TabIndex = 9;
            // 
            // txtGradoInstruccion
            // 
            this.txtGradoInstruccion.Location = new System.Drawing.Point(80, 160);
            this.txtGradoInstruccion.Name = "txtGradoInstruccion";
            this.txtGradoInstruccion.Size = new System.Drawing.Size(100, 20);
            this.txtGradoInstruccion.TabIndex = 10;
            // 
            // fmrRector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGradoInstruccion);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnCoordinar);
            this.Controls.Add(this.btnReglamentar);
            this.Controls.Add(this.btnDirigir);
            this.Controls.Add(this.btnRepresentar);
            this.Name = "fmrRector";
            this.Text = "fmrRector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRepresentar;
        private System.Windows.Forms.Button btnDirigir;
        private System.Windows.Forms.Button btnReglamentar;
        private System.Windows.Forms.Button btnCoordinar;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.TextBox txtGradoInstruccion;
    }
}