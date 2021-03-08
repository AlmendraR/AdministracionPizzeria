
namespace AdministracionPizzeria.CapaPresentacion
{
    partial class formulario_login
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
            this.cb_usuariologin = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_contraseñalogin = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_usuariologin
            // 
            this.cb_usuariologin.FormattingEnabled = true;
            this.cb_usuariologin.Location = new System.Drawing.Point(20, 20);
            this.cb_usuariologin.Name = "cb_usuariologin";
            this.cb_usuariologin.Size = new System.Drawing.Size(220, 21);
            this.cb_usuariologin.TabIndex = 0;
            this.cb_usuariologin.Text = "Nombre de Usuario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.tb_contraseñalogin);
            this.panel1.Controls.Add(this.cb_usuariologin);
            this.panel1.Location = new System.Drawing.Point(20, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 101);
            this.panel1.TabIndex = 1;
            // 
            // tb_contraseñalogin
            // 
            this.tb_contraseñalogin.Location = new System.Drawing.Point(20, 60);
            this.tb_contraseñalogin.Name = "tb_contraseñalogin";
            this.tb_contraseñalogin.Size = new System.Drawing.Size(220, 20);
            this.tb_contraseñalogin.TabIndex = 2;
            this.tb_contraseñalogin.Text = "Contraseña";
            // 
            // formulario_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formulario_login";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_usuariologin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_contraseñalogin;
    }
}