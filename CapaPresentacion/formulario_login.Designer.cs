
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
            this.Bt_aceptarlogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_contraseñalogin = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_usuariologin
            // 
            this.cb_usuariologin.FormattingEnabled = true;
            this.cb_usuariologin.Location = new System.Drawing.Point(229, 74);
            this.cb_usuariologin.Margin = new System.Windows.Forms.Padding(4);
            this.cb_usuariologin.Name = "cb_usuariologin";
            this.cb_usuariologin.Size = new System.Drawing.Size(265, 24);
            this.cb_usuariologin.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.panel1.Controls.Add(this.Bt_aceptarlogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 217);
            this.panel1.TabIndex = 1;
            // 
            // Bt_aceptarlogin
            // 
            this.Bt_aceptarlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            this.Bt_aceptarlogin.FlatAppearance.BorderSize = 0;
            this.Bt_aceptarlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_aceptarlogin.ForeColor = System.Drawing.Color.Black;
            this.Bt_aceptarlogin.Location = new System.Drawing.Point(32, 49);
            this.Bt_aceptarlogin.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_aceptarlogin.Name = "Bt_aceptarlogin";
            this.Bt_aceptarlogin.Size = new System.Drawing.Size(133, 123);
            this.Bt_aceptarlogin.TabIndex = 3;
            this.Bt_aceptarlogin.Text = "Ingresar";
            this.Bt_aceptarlogin.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(164)))), ((int)(((byte)(66)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(225, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(164)))), ((int)(((byte)(66)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(225, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de usuario";
            // 
            // tb_contraseñalogin
            // 
            this.tb_contraseñalogin.Location = new System.Drawing.Point(229, 148);
            this.tb_contraseñalogin.Margin = new System.Windows.Forms.Padding(4);
            this.tb_contraseñalogin.Name = "tb_contraseñalogin";
            this.tb_contraseñalogin.Size = new System.Drawing.Size(265, 22);
            this.tb_contraseñalogin.TabIndex = 2;
            // 
            // formulario_login
            // 
            this.AcceptButton = this.Bt_aceptarlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(164)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(528, 217);
            this.Controls.Add(this.tb_contraseñalogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_usuariologin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formulario_login";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_usuariologin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_contraseñalogin;
        private System.Windows.Forms.Button Bt_aceptarlogin;
    }
}