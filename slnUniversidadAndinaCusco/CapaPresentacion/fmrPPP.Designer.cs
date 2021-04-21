
namespace CapaPresentacion
{
    partial class fmrPPP
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
            this.btnAprender = new System.Windows.Forms.Button();
            this.btnAdquirirConocimientoPractico = new System.Windows.Forms.Button();
            this.btnDesarrollarnos = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtSemestre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAprender
            // 
            this.btnAprender.Location = new System.Drawing.Point(16, 201);
            this.btnAprender.Name = "btnAprender";
            this.btnAprender.Size = new System.Drawing.Size(75, 23);
            this.btnAprender.TabIndex = 0;
            this.btnAprender.Text = "Aprender";
            this.btnAprender.UseVisualStyleBackColor = true;
            this.btnAprender.Click += new System.EventHandler(this.btnAprender_Click);
            // 
            // btnAdquirirConocimientoPractico
            // 
            this.btnAdquirirConocimientoPractico.Location = new System.Drawing.Point(132, 201);
            this.btnAdquirirConocimientoPractico.Name = "btnAdquirirConocimientoPractico";
            this.btnAdquirirConocimientoPractico.Size = new System.Drawing.Size(178, 23);
            this.btnAdquirirConocimientoPractico.TabIndex = 1;
            this.btnAdquirirConocimientoPractico.Text = "Adquirir Conocimiento Practico";
            this.btnAdquirirConocimientoPractico.UseVisualStyleBackColor = true;
            this.btnAdquirirConocimientoPractico.Click += new System.EventHandler(this.btnAdquirirConocimientoPractico_Click);
            // 
            // btnDesarrollarnos
            // 
            this.btnDesarrollarnos.Location = new System.Drawing.Point(338, 201);
            this.btnDesarrollarnos.Name = "btnDesarrollarnos";
            this.btnDesarrollarnos.Size = new System.Drawing.Size(91, 23);
            this.btnDesarrollarnos.TabIndex = 2;
            this.btnDesarrollarnos.Text = "Desarrollarnos";
            this.btnDesarrollarnos.UseVisualStyleBackColor = true;
            this.btnDesarrollarnos.Click += new System.EventHandler(this.btnDesarrollarnos_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(235, 12);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 3;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(235, 65);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 4;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(71, 12);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidos.TabIndex = 5;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(71, 47);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(100, 20);
            this.txtNombres.TabIndex = 6;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(71, 83);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 7;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(71, 122);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(100, 20);
            this.txtCarrera.TabIndex = 8;
            // 
            // txtSemestre
            // 
            this.txtSemestre.Location = new System.Drawing.Point(71, 159);
            this.txtSemestre.Name = "txtSemestre";
            this.txtSemestre.Size = new System.Drawing.Size(100, 20);
            this.txtSemestre.TabIndex = 9;
            // 
            // fmrPPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSemestre);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnDesarrollarnos);
            this.Controls.Add(this.btnAdquirirConocimientoPractico);
            this.Controls.Add(this.btnAprender);
            this.Name = "fmrPPP";
            this.Text = "fmrPPP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAprender;
        private System.Windows.Forms.Button btnAdquirirConocimientoPractico;
        private System.Windows.Forms.Button btnDesarrollarnos;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtSemestre;
    }
}