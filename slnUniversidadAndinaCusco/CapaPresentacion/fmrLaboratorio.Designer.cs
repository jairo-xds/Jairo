
namespace CapaPresentacion
{
    partial class fmrLaboratorio
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
            this.btnInvestigar = new System.Windows.Forms.Button();
            this.btnExperimentar = new System.Windows.Forms.Button();
            this.btnAprender = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.txtElementios = new System.Windows.Forms.TextBox();
            this.txtForo = new System.Windows.Forms.TextBox();
            this.txtCantidadAlumnos = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInvestigar
            // 
            this.btnInvestigar.Location = new System.Drawing.Point(75, 211);
            this.btnInvestigar.Name = "btnInvestigar";
            this.btnInvestigar.Size = new System.Drawing.Size(75, 23);
            this.btnInvestigar.TabIndex = 0;
            this.btnInvestigar.Text = "Investigar";
            this.btnInvestigar.UseVisualStyleBackColor = true;
            this.btnInvestigar.Click += new System.EventHandler(this.btnInvestigar_Click);
            // 
            // btnExperimentar
            // 
            this.btnExperimentar.Location = new System.Drawing.Point(193, 211);
            this.btnExperimentar.Name = "btnExperimentar";
            this.btnExperimentar.Size = new System.Drawing.Size(75, 23);
            this.btnExperimentar.TabIndex = 1;
            this.btnExperimentar.Text = "Experimentar";
            this.btnExperimentar.UseVisualStyleBackColor = true;
            this.btnExperimentar.Click += new System.EventHandler(this.btnExperimentar_Click);
            // 
            // btnAprender
            // 
            this.btnAprender.Location = new System.Drawing.Point(313, 211);
            this.btnAprender.Name = "btnAprender";
            this.btnAprender.Size = new System.Drawing.Size(75, 23);
            this.btnAprender.TabIndex = 2;
            this.btnAprender.Text = "Aprender";
            this.btnAprender.UseVisualStyleBackColor = true;
            this.btnAprender.Click += new System.EventHandler(this.btnAprender_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(269, 27);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 3;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(269, 103);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 4;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // txtElementios
            // 
            this.txtElementios.Location = new System.Drawing.Point(75, 28);
            this.txtElementios.Name = "txtElementios";
            this.txtElementios.Size = new System.Drawing.Size(100, 20);
            this.txtElementios.TabIndex = 5;
            this.txtElementios.TextChanged += new System.EventHandler(this.txtElemento_TextChanged);
            // 
            // txtForo
            // 
            this.txtForo.Location = new System.Drawing.Point(75, 73);
            this.txtForo.Name = "txtForo";
            this.txtForo.Size = new System.Drawing.Size(100, 20);
            this.txtForo.TabIndex = 6;
            // 
            // txtCantidadAlumnos
            // 
            this.txtCantidadAlumnos.Location = new System.Drawing.Point(75, 158);
            this.txtCantidadAlumnos.Name = "txtCantidadAlumnos";
            this.txtCantidadAlumnos.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadAlumnos.TabIndex = 7;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(75, 120);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 8;
            // 
            // fmrLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtCantidadAlumnos);
            this.Controls.Add(this.txtForo);
            this.Controls.Add(this.txtElementios);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnAprender);
            this.Controls.Add(this.btnExperimentar);
            this.Controls.Add(this.btnInvestigar);
            this.Name = "fmrLaboratorio";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInvestigar;
        private System.Windows.Forms.Button btnExperimentar;
        private System.Windows.Forms.Button btnAprender;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.TextBox txtElementios;
        private System.Windows.Forms.TextBox txtForo;
        private System.Windows.Forms.TextBox txtCantidadAlumnos;
        private System.Windows.Forms.TextBox txtTipo;
    }
}