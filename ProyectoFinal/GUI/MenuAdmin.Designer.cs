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
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLibros = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAccesorios = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(73)))));
            this.btnUsuarios.Location = new System.Drawing.Point(4, 184);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(162, 68);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Location = new System.Drawing.Point(161, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 33);
            this.panel1.TabIndex = 4;
            // 
            // btnLibros
            // 
            this.btnLibros.BackColor = System.Drawing.Color.Transparent;
            this.btnLibros.FlatAppearance.BorderSize = 0;
            this.btnLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(73)))));
            this.btnLibros.Location = new System.Drawing.Point(1, 36);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Size = new System.Drawing.Size(162, 68);
            this.btnLibros.TabIndex = 2;
            this.btnLibros.Text = "Libros";
            this.btnLibros.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Sienna;
            this.panel2.Controls.Add(this.btnAccesorios);
            this.panel2.Controls.Add(this.btnLibros);
            this.panel2.Controls.Add(this.btnUsuarios);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 452);
            this.panel2.TabIndex = 5;
            // 
            // btnAccesorios
            // 
            this.btnAccesorios.BackColor = System.Drawing.Color.Transparent;
            this.btnAccesorios.FlatAppearance.BorderSize = 0;
            this.btnAccesorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccesorios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccesorios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(73)))));
            this.btnAccesorios.Location = new System.Drawing.Point(1, 110);
            this.btnAccesorios.Name = "btnAccesorios";
            this.btnAccesorios.Size = new System.Drawing.Size(162, 68);
            this.btnAccesorios.TabIndex = 3;
            this.btnAccesorios.Text = "Accesorios";
            this.btnAccesorios.UseVisualStyleBackColor = false;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdmin";
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLibros;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAccesorios;
    }
}