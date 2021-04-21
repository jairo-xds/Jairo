
namespace CapaPresentacion
{
    partial class fmrAsignatura
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
            this.btnClasificar = new System.Windows.Forms.Button();
            this.btnConocer = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.txtIdiomas = new System.Windows.Forms.TextBox();
            this.txtAulas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAprender
            // 
            this.btnAprender.Location = new System.Drawing.Point(44, 202);
            this.btnAprender.Name = "btnAprender";
            this.btnAprender.Size = new System.Drawing.Size(75, 23);
            this.btnAprender.TabIndex = 0;
            this.btnAprender.Text = "Aprender";
            this.btnAprender.UseVisualStyleBackColor = true;
            this.btnAprender.Click += new System.EventHandler(this.btnAprender_Click);
            // 
            // btnClasificar
            // 
            this.btnClasificar.Location = new System.Drawing.Point(153, 202);
            this.btnClasificar.Name = "btnClasificar";
            this.btnClasificar.Size = new System.Drawing.Size(75, 23);
            this.btnClasificar.TabIndex = 1;
            this.btnClasificar.Text = "Clasificar";
            this.btnClasificar.UseVisualStyleBackColor = true;
            this.btnClasificar.Click += new System.EventHandler(this.btnClasificar_Click);
            // 
            // btnConocer
            // 
            this.btnConocer.Location = new System.Drawing.Point(254, 202);
            this.btnConocer.Name = "btnConocer";
            this.btnConocer.Size = new System.Drawing.Size(75, 23);
            this.btnConocer.TabIndex = 2;
            this.btnConocer.Text = "Conocer";
            this.btnConocer.UseVisualStyleBackColor = true;
            this.btnConocer.Click += new System.EventHandler(this.btnConocer_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(275, 43);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 3;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(275, 93);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 4;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(118, 43);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(100, 20);
            this.txtEspecialidad.TabIndex = 5;
            this.txtEspecialidad.TextChanged += new System.EventHandler(this.txtEspecialidad_TextChanged);
            // 
            // txtIdiomas
            // 
            this.txtIdiomas.Location = new System.Drawing.Point(118, 93);
            this.txtIdiomas.Name = "txtIdiomas";
            this.txtIdiomas.Size = new System.Drawing.Size(100, 20);
            this.txtIdiomas.TabIndex = 6;
            // 
            // txtAulas
            // 
            this.txtAulas.Location = new System.Drawing.Point(118, 144);
            this.txtAulas.Name = "txtAulas";
            this.txtAulas.Size = new System.Drawing.Size(100, 20);
            this.txtAulas.TabIndex = 7;
            // 
            // fmrAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAulas);
            this.Controls.Add(this.txtIdiomas);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnConocer);
            this.Controls.Add(this.btnClasificar);
            this.Controls.Add(this.btnAprender);
            this.Name = "fmrAsignatura";
            this.Text = "fmrAsignatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAprender;
        private System.Windows.Forms.Button btnClasificar;
        private System.Windows.Forms.Button btnConocer;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.TextBox txtIdiomas;
        private System.Windows.Forms.TextBox txtAulas;
    }
}