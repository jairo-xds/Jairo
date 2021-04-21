
namespace CapaPresentacion
{
    partial class fmrNotas
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
            this.btnAprobar = new System.Windows.Forms.Button();
            this.btnDesaprobar = new System.Windows.Forms.Button();
            this.btnAumentar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAporte = new System.Windows.Forms.TextBox();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAprobar
            // 
            this.btnAprobar.Location = new System.Drawing.Point(15, 176);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(75, 23);
            this.btnAprobar.TabIndex = 0;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.UseVisualStyleBackColor = true;
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // btnDesaprobar
            // 
            this.btnDesaprobar.Location = new System.Drawing.Point(114, 176);
            this.btnDesaprobar.Name = "btnDesaprobar";
            this.btnDesaprobar.Size = new System.Drawing.Size(75, 23);
            this.btnDesaprobar.TabIndex = 1;
            this.btnDesaprobar.Text = "Desaprobar";
            this.btnDesaprobar.UseVisualStyleBackColor = true;
            this.btnDesaprobar.Click += new System.EventHandler(this.btnDesaprobar_Click);
            // 
            // btnAumentar
            // 
            this.btnAumentar.Location = new System.Drawing.Point(205, 176);
            this.btnAumentar.Name = "btnAumentar";
            this.btnAumentar.Size = new System.Drawing.Size(75, 23);
            this.btnAumentar.TabIndex = 2;
            this.btnAumentar.Text = "Aumentar";
            this.btnAumentar.UseVisualStyleBackColor = true;
            this.btnAumentar.Click += new System.EventHandler(this.btnAumentar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(300, 176);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(232, 48);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 4;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(87, 51);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(100, 20);
            this.txtCurso.TabIndex = 5;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(87, 79);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 6;
            // 
            // txtAporte
            // 
            this.txtAporte.Location = new System.Drawing.Point(87, 118);
            this.txtAporte.Name = "txtAporte";
            this.txtAporte.Size = new System.Drawing.Size(100, 20);
            this.txtAporte.TabIndex = 7;
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(232, 89);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 8;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.button6_Click);
            // 
            // fmrNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.txtAporte);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAumentar);
            this.Controls.Add(this.btnDesaprobar);
            this.Controls.Add(this.btnAprobar);
            this.Name = "fmrNotas";
            this.Text = "fmrNotas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Button btnDesaprobar;
        private System.Windows.Forms.Button btnAumentar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAporte;
        private System.Windows.Forms.Button btnEscribir;
    }
}