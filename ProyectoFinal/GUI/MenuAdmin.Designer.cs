namespace GUI
{
    partial class MenuAdmin
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
            this.transparentControl2 = new TransControl_src.TransparentControl();
            this.transparentControl1 = new TransControl_src.TransparentControl();
            this.btnAccesorios = new System.Windows.Forms.Button();
            this.btnLibros = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.transparentControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // transparentControl2
            // 
            this.transparentControl2.Location = new System.Drawing.Point(162, 0);
            this.transparentControl2.MinimumSize = new System.Drawing.Size(100, 75);
            this.transparentControl2.Name = "transparentControl2";
            this.transparentControl2.Opacity = 0.5D;
            this.transparentControl2.Size = new System.Drawing.Size(639, 75);
            this.transparentControl2.TabIndex = 2;
            this.transparentControl2.Text = "transparentControl2";
            this.transparentControl2.Transparent = true;
            this.transparentControl2.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(64)))));
            // 
            // transparentControl1
            // 
            this.transparentControl1.Controls.Add(this.btnUsuarios);
            this.transparentControl1.Controls.Add(this.btnAccesorios);
            this.transparentControl1.Controls.Add(this.btnLibros);
            this.transparentControl1.Location = new System.Drawing.Point(0, 0);
            this.transparentControl1.MinimumSize = new System.Drawing.Size(100, 75);
            this.transparentControl1.Name = "transparentControl1";
            this.transparentControl1.Opacity = 0.5D;
            this.transparentControl1.Size = new System.Drawing.Size(162, 451);
            this.transparentControl1.TabIndex = 3;
            this.transparentControl1.Text = "transparentControl1";
            this.transparentControl1.Transparent = true;
            this.transparentControl1.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(64)))));
            // 
            // btnAccesorios
            // 
            this.btnAccesorios.BackColor = System.Drawing.Color.Transparent;
            this.btnAccesorios.FlatAppearance.BorderSize = 0;
            this.btnAccesorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccesorios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccesorios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(73)))));
            this.btnAccesorios.Location = new System.Drawing.Point(0, 153);
            this.btnAccesorios.Name = "btnAccesorios";
            this.btnAccesorios.Size = new System.Drawing.Size(162, 68);
            this.btnAccesorios.TabIndex = 1;
            this.btnAccesorios.Text = "Accesorios";
            this.btnAccesorios.UseVisualStyleBackColor = false;
            // 
            // btnLibros
            // 
            this.btnLibros.BackColor = System.Drawing.Color.Transparent;
            this.btnLibros.FlatAppearance.BorderSize = 0;
            this.btnLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(73)))));
            this.btnLibros.Location = new System.Drawing.Point(0, 79);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Size = new System.Drawing.Size(162, 68);
            this.btnLibros.TabIndex = 0;
            this.btnLibros.Text = "Libros";
            this.btnLibros.UseVisualStyleBackColor = false;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(73)))));
            this.btnUsuarios.Location = new System.Drawing.Point(0, 227);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(162, 68);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transparentControl2);
            this.Controls.Add(this.transparentControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdmin";
            this.transparentControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TransControl_src.TransparentControl transparentControl2;
        private TransControl_src.TransparentControl transparentControl1;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnAccesorios;
        private System.Windows.Forms.Button btnLibros;
    }
}