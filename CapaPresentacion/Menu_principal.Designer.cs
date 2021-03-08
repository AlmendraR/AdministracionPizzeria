
namespace AdministracionPizzeria.CapaPresentacion
{
    partial class Menu_principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_principal));
            this.menu_lateral = new System.Windows.Forms.Panel();
            this.bt_salir = new System.Windows.Forms.Button();
            this.smenu_personal = new System.Windows.Forms.Panel();
            this.bt_informepersonal = new System.Windows.Forms.Button();
            this.bt_dardebaja = new System.Windows.Forms.Button();
            this.bt_ingresarnuevo = new System.Windows.Forms.Button();
            this.bt_buscarpersonal = new System.Windows.Forms.Button();
            this.bt_personal = new System.Windows.Forms.Button();
            this.smenu_inventario = new System.Windows.Forms.Panel();
            this.bt_eliminarinsumo = new System.Windows.Forms.Button();
            this.bt_buscarsalida = new System.Windows.Forms.Button();
            this.bt_ingresarsalida = new System.Windows.Forms.Button();
            this.bt_ingresarnuevoinsumo = new System.Windows.Forms.Button();
            this.bt_buscarllegada = new System.Windows.Forms.Button();
            this.bt_ingresarllegada = new System.Windows.Forms.Button();
            this.bt_informeinventario = new System.Windows.Forms.Button();
            this.bt_buscarcuadre = new System.Windows.Forms.Button();
            this.bt_cuadrarinventario = new System.Windows.Forms.Button();
            this.bt_inventario = new System.Windows.Forms.Button();
            this.separador = new System.Windows.Forms.Panel();
            this.menu_superior = new System.Windows.Forms.Panel();
            this.panel_estadocaja = new System.Windows.Forms.Panel();
            this.mostrar_estadocaja = new System.Windows.Forms.Label();
            this.panel_nombreusuario = new System.Windows.Forms.Panel();
            this.mostrar_nombreusuario = new System.Windows.Forms.Label();
            this.panel_cargousuario = new System.Windows.Forms.Panel();
            this.mostrar_cargousuario = new System.Windows.Forms.Label();
            this.panel_fechayhora = new System.Windows.Forms.Panel();
            this.mostrar_horayfecha = new System.Windows.Forms.Label();
            this.bt_cerrarcaja = new System.Windows.Forms.Button();
            this.separador_sup2 = new System.Windows.Forms.Panel();
            this.bt_abrircaja = new System.Windows.Forms.Button();
            this.separador_sup1 = new System.Windows.Forms.Panel();
            this.bt_cambiarusuario = new System.Windows.Forms.Button();
            this.panel_formularios = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu_lateral.SuspendLayout();
            this.smenu_personal.SuspendLayout();
            this.smenu_inventario.SuspendLayout();
            this.menu_superior.SuspendLayout();
            this.panel_estadocaja.SuspendLayout();
            this.panel_nombreusuario.SuspendLayout();
            this.panel_cargousuario.SuspendLayout();
            this.panel_fechayhora.SuspendLayout();
            this.panel_formularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_lateral
            // 
            this.menu_lateral.BackColor = System.Drawing.Color.Black;
            this.menu_lateral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menu_lateral.Controls.Add(this.bt_salir);
            this.menu_lateral.Controls.Add(this.smenu_personal);
            this.menu_lateral.Controls.Add(this.bt_personal);
            this.menu_lateral.Controls.Add(this.smenu_inventario);
            this.menu_lateral.Controls.Add(this.bt_inventario);
            this.menu_lateral.Controls.Add(this.separador);
            this.menu_lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_lateral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.menu_lateral.Location = new System.Drawing.Point(0, 0);
            this.menu_lateral.Margin = new System.Windows.Forms.Padding(4);
            this.menu_lateral.Name = "menu_lateral";
            this.menu_lateral.Size = new System.Drawing.Size(250, 609);
            this.menu_lateral.TabIndex = 0;
            // 
            // bt_salir
            // 
            this.bt_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.bt_salir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bt_salir.FlatAppearance.BorderSize = 0;
            this.bt_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_salir.Location = new System.Drawing.Point(0, 562);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(248, 45);
            this.bt_salir.TabIndex = 9;
            this.bt_salir.Text = "Salir";
            this.bt_salir.UseVisualStyleBackColor = false;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click_1);
            // 
            // smenu_personal
            // 
            this.smenu_personal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.smenu_personal.Controls.Add(this.bt_informepersonal);
            this.smenu_personal.Controls.Add(this.bt_dardebaja);
            this.smenu_personal.Controls.Add(this.bt_ingresarnuevo);
            this.smenu_personal.Controls.Add(this.bt_buscarpersonal);
            this.smenu_personal.Dock = System.Windows.Forms.DockStyle.Top;
            this.smenu_personal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smenu_personal.Location = new System.Drawing.Point(0, 548);
            this.smenu_personal.Name = "smenu_personal";
            this.smenu_personal.Size = new System.Drawing.Size(248, 160);
            this.smenu_personal.TabIndex = 8;
            // 
            // bt_informepersonal
            // 
            this.bt_informepersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_informepersonal.FlatAppearance.BorderSize = 0;
            this.bt_informepersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_informepersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_informepersonal.Location = new System.Drawing.Point(0, 120);
            this.bt_informepersonal.Name = "bt_informepersonal";
            this.bt_informepersonal.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.bt_informepersonal.Size = new System.Drawing.Size(248, 40);
            this.bt_informepersonal.TabIndex = 6;
            this.bt_informepersonal.Text = "Informe de personal";
            this.bt_informepersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_informepersonal.UseVisualStyleBackColor = true;
            this.bt_informepersonal.Click += new System.EventHandler(this.bt_informepersonal_Click);
            // 
            // bt_dardebaja
            // 
            this.bt_dardebaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_dardebaja.FlatAppearance.BorderSize = 0;
            this.bt_dardebaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_dardebaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dardebaja.Location = new System.Drawing.Point(0, 80);
            this.bt_dardebaja.Name = "bt_dardebaja";
            this.bt_dardebaja.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.bt_dardebaja.Size = new System.Drawing.Size(248, 40);
            this.bt_dardebaja.TabIndex = 5;
            this.bt_dardebaja.Text = "Dar de baja";
            this.bt_dardebaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_dardebaja.UseVisualStyleBackColor = true;
            this.bt_dardebaja.Click += new System.EventHandler(this.bt_dardebaja_Click);
            // 
            // bt_ingresarnuevo
            // 
            this.bt_ingresarnuevo.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_ingresarnuevo.FlatAppearance.BorderSize = 0;
            this.bt_ingresarnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ingresarnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ingresarnuevo.Location = new System.Drawing.Point(0, 40);
            this.bt_ingresarnuevo.Name = "bt_ingresarnuevo";
            this.bt_ingresarnuevo.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.bt_ingresarnuevo.Size = new System.Drawing.Size(248, 40);
            this.bt_ingresarnuevo.TabIndex = 1;
            this.bt_ingresarnuevo.Text = "Ingresar nuevo";
            this.bt_ingresarnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ingresarnuevo.UseVisualStyleBackColor = true;
            this.bt_ingresarnuevo.Click += new System.EventHandler(this.bt_ingresarnuevo_Click);
            // 
            // bt_buscarpersonal
            // 
            this.bt_buscarpersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_buscarpersonal.FlatAppearance.BorderSize = 0;
            this.bt_buscarpersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_buscarpersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_buscarpersonal.Location = new System.Drawing.Point(0, 0);
            this.bt_buscarpersonal.Name = "bt_buscarpersonal";
            this.bt_buscarpersonal.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.bt_buscarpersonal.Size = new System.Drawing.Size(248, 40);
            this.bt_buscarpersonal.TabIndex = 0;
            this.bt_buscarpersonal.Text = "Buscar personal";
            this.bt_buscarpersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_buscarpersonal.UseVisualStyleBackColor = true;
            this.bt_buscarpersonal.Click += new System.EventHandler(this.bt_buscarpersonal_Click);
            // 
            // bt_personal
            // 
            this.bt_personal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.bt_personal.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_personal.FlatAppearance.BorderSize = 0;
            this.bt_personal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_personal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_personal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.bt_personal.Location = new System.Drawing.Point(0, 503);
            this.bt_personal.Name = "bt_personal";
            this.bt_personal.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bt_personal.Size = new System.Drawing.Size(248, 45);
            this.bt_personal.TabIndex = 7;
            this.bt_personal.Text = "Personal";
            this.bt_personal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_personal.UseVisualStyleBackColor = false;
            this.bt_personal.Click += new System.EventHandler(this.bt_personal_Click);
            // 
            // smenu_inventario
            // 
            this.smenu_inventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.smenu_inventario.Controls.Add(this.bt_eliminarinsumo);
            this.smenu_inventario.Controls.Add(this.bt_buscarsalida);
            this.smenu_inventario.Controls.Add(this.bt_ingresarsalida);
            this.smenu_inventario.Controls.Add(this.bt_ingresarnuevoinsumo);
            this.smenu_inventario.Controls.Add(this.bt_buscarllegada);
            this.smenu_inventario.Controls.Add(this.bt_ingresarllegada);
            this.smenu_inventario.Controls.Add(this.bt_informeinventario);
            this.smenu_inventario.Controls.Add(this.bt_buscarcuadre);
            this.smenu_inventario.Controls.Add(this.bt_cuadrarinventario);
            this.smenu_inventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.smenu_inventario.Location = new System.Drawing.Point(0, 143);
            this.smenu_inventario.Name = "smenu_inventario";
            this.smenu_inventario.Size = new System.Drawing.Size(248, 360);
            this.smenu_inventario.TabIndex = 6;
            // 
            // bt_eliminarinsumo
            // 
            this.bt_eliminarinsumo.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_eliminarinsumo.FlatAppearance.BorderSize = 0;
            this.bt_eliminarinsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_eliminarinsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_eliminarinsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.bt_eliminarinsumo.Location = new System.Drawing.Point(0, 320);
            this.bt_eliminarinsumo.Name = "bt_eliminarinsumo";
            this.bt_eliminarinsumo.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.bt_eliminarinsumo.Size = new System.Drawing.Size(248, 40);
            this.bt_eliminarinsumo.TabIndex = 9;
            this.bt_eliminarinsumo.Text = "Eliminar insumo";
            this.bt_eliminarinsumo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_eliminarinsumo.UseVisualStyleBackColor = true;
            this.bt_eliminarinsumo.Click += new System.EventHandler(this.bt_eliminarinsumo_Click);
            // 
            // bt_buscarsalida
            // 
            this.bt_buscarsalida.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_buscarsalida.FlatAppearance.BorderSize = 0;
            this.bt_buscarsalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_buscarsalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_buscarsalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.bt_buscarsalida.Location = new System.Drawing.Point(0, 280);
            this.bt_buscarsalida.Name = "bt_buscarsalida";
            this.bt_buscarsalida.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.bt_buscarsalida.Size = new System.Drawing.Size(248, 40);
            this.bt_buscarsalida.TabIndex = 8;
            this.bt_buscarsalida.Text = "Buscar salida insumo";
            this.bt_buscarsalida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_buscarsalida.UseVisualStyleBackColor = true;
            this.bt_buscarsalida.Click += new System.EventHandler(this.bt_buscarsalida_Click);
            // 
            // bt_ingresarsalida
            // 
            this.bt_ingresarsalida.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_ingresarsalida.FlatAppearance.BorderSize = 0;
            this.bt_ingresarsalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ingresarsalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ingresarsalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.bt_ingresarsalida.Location = new System.Drawing.Point(0, 240);
            this.bt_ingresarsalida.Name = "bt_ingresarsalida";
            this.bt_ingresarsalida.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.bt_ingresarsalida.Size = new System.Drawing.Size(248, 40);
            this.bt_ingresarsalida.TabIndex = 7;
            this.bt_ingresarsalida.Text = "Ingresar salida insumo";
            this.bt_ingresarsalida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ingresarsalida.UseVisualStyleBackColor = true;
            this.bt_ingresarsalida.Click += new System.EventHandler(this.bt_ingresarsalida_Click);
            // 
            // bt_ingresarnuevoinsumo
            // 
            this.bt_ingresarnuevoinsumo.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_ingresarnuevoinsumo.FlatAppearance.BorderSize = 0;
            this.bt_ingresarnuevoinsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ingresarnuevoinsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ingresarnuevoinsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.bt_ingresarnuevoinsumo.Location = new System.Drawing.Point(0, 200);
            this.bt_ingresarnuevoinsumo.Name = "bt_ingresarnuevoinsumo";
            this.bt_ingresarnuevoinsumo.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.bt_ingresarnuevoinsumo.Size = new System.Drawing.Size(248, 40);
            this.bt_ingresarnuevoinsumo.TabIndex = 6;
            this.bt_ingresarnuevoinsumo.Text = "Ingresar nuevo insumo";
            this.bt_ingresarnuevoinsumo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ingresarnuevoinsumo.UseVisualStyleBackColor = false;
            this.bt_ingresarnuevoinsumo.Click += new System.EventHandler(this.bt_ingresarnuevoinsumo_Click);
            // 
            // bt_buscarllegada
            // 
            this.bt_buscarllegada.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_buscarllegada.FlatAppearance.BorderSize = 0;
            this.bt_buscarllegada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_buscarllegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_buscarllegada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.bt_buscarllegada.Location = new System.Drawing.Point(0, 160);
            this.bt_buscarllegada.Name = "bt_buscarllegada";
            this.bt_buscarllegada.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.bt_buscarllegada.Size = new System.Drawing.Size(248, 40);
            this.bt_buscarllegada.TabIndex = 5;
            this.bt_buscarllegada.Text = "Buscar llegada insumo";
            this.bt_buscarllegada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_buscarllegada.UseVisualStyleBackColor = true;
            this.bt_buscarllegada.Click += new System.EventHandler(this.bt_buscarllegada_Click);
            // 
            // bt_ingresarllegada
            // 
            this.bt_ingresarllegada.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_ingresarllegada.FlatAppearance.BorderSize = 0;
            this.bt_ingresarllegada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ingresarllegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ingresarllegada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.bt_ingresarllegada.Location = new System.Drawing.Point(0, 120);
            this.bt_ingresarllegada.Name = "bt_ingresarllegada";
            this.bt_ingresarllegada.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.bt_ingresarllegada.Size = new System.Drawing.Size(248, 40);
            this.bt_ingresarllegada.TabIndex = 4;
            this.bt_ingresarllegada.Text = "Ingresar llegada insumo";
            this.bt_ingresarllegada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ingresarllegada.UseVisualStyleBackColor = true;
            this.bt_ingresarllegada.Click += new System.EventHandler(this.bt_ingresarllegada_Click);
            // 
            // bt_informeinventario
            // 
            this.bt_informeinventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_informeinventario.FlatAppearance.BorderSize = 0;
            this.bt_informeinventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_informeinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_informeinventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.bt_informeinventario.Location = new System.Drawing.Point(0, 80);
            this.bt_informeinventario.Name = "bt_informeinventario";
            this.bt_informeinventario.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.bt_informeinventario.Size = new System.Drawing.Size(248, 40);
            this.bt_informeinventario.TabIndex = 3;
            this.bt_informeinventario.Text = "Informe de inventario";
            this.bt_informeinventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_informeinventario.UseVisualStyleBackColor = true;
            this.bt_informeinventario.Click += new System.EventHandler(this.bt_informeinventario_Click);
            // 
            // bt_buscarcuadre
            // 
            this.bt_buscarcuadre.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_buscarcuadre.FlatAppearance.BorderSize = 0;
            this.bt_buscarcuadre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_buscarcuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_buscarcuadre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.bt_buscarcuadre.Location = new System.Drawing.Point(0, 40);
            this.bt_buscarcuadre.Name = "bt_buscarcuadre";
            this.bt_buscarcuadre.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.bt_buscarcuadre.Size = new System.Drawing.Size(248, 40);
            this.bt_buscarcuadre.TabIndex = 3;
            this.bt_buscarcuadre.Text = "Buscar cuadre";
            this.bt_buscarcuadre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_buscarcuadre.UseVisualStyleBackColor = true;
            this.bt_buscarcuadre.Click += new System.EventHandler(this.bt_buscarcuadre_Click);
            // 
            // bt_cuadrarinventario
            // 
            this.bt_cuadrarinventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_cuadrarinventario.FlatAppearance.BorderSize = 0;
            this.bt_cuadrarinventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cuadrarinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cuadrarinventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.bt_cuadrarinventario.Location = new System.Drawing.Point(0, 0);
            this.bt_cuadrarinventario.Name = "bt_cuadrarinventario";
            this.bt_cuadrarinventario.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.bt_cuadrarinventario.Size = new System.Drawing.Size(248, 40);
            this.bt_cuadrarinventario.TabIndex = 1;
            this.bt_cuadrarinventario.Text = "Cuadrar inventario";
            this.bt_cuadrarinventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cuadrarinventario.UseVisualStyleBackColor = true;
            this.bt_cuadrarinventario.Click += new System.EventHandler(this.bt_nuevocuadre_Click);
            // 
            // bt_inventario
            // 
            this.bt_inventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.bt_inventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_inventario.FlatAppearance.BorderSize = 0;
            this.bt_inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_inventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_inventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.bt_inventario.Location = new System.Drawing.Point(0, 98);
            this.bt_inventario.Name = "bt_inventario";
            this.bt_inventario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bt_inventario.Size = new System.Drawing.Size(248, 45);
            this.bt_inventario.TabIndex = 0;
            this.bt_inventario.Text = "Inventario";
            this.bt_inventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_inventario.UseVisualStyleBackColor = false;
            this.bt_inventario.Click += new System.EventHandler(this.bt_inventario_Click);
            // 
            // separador
            // 
            this.separador.BackColor = System.Drawing.Color.Black;
            this.separador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.separador.Dock = System.Windows.Forms.DockStyle.Top;
            this.separador.Location = new System.Drawing.Point(0, 0);
            this.separador.Margin = new System.Windows.Forms.Padding(4);
            this.separador.Name = "separador";
            this.separador.Size = new System.Drawing.Size(248, 98);
            this.separador.TabIndex = 0;
            // 
            // menu_superior
            // 
            this.menu_superior.BackColor = System.Drawing.Color.Black;
            this.menu_superior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menu_superior.Controls.Add(this.panel_estadocaja);
            this.menu_superior.Controls.Add(this.panel_nombreusuario);
            this.menu_superior.Controls.Add(this.panel_cargousuario);
            this.menu_superior.Controls.Add(this.panel_fechayhora);
            this.menu_superior.Controls.Add(this.bt_cerrarcaja);
            this.menu_superior.Controls.Add(this.separador_sup2);
            this.menu_superior.Controls.Add(this.bt_abrircaja);
            this.menu_superior.Controls.Add(this.separador_sup1);
            this.menu_superior.Controls.Add(this.bt_cambiarusuario);
            this.menu_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_superior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(178)))));
            this.menu_superior.Location = new System.Drawing.Point(250, 0);
            this.menu_superior.Name = "menu_superior";
            this.menu_superior.Size = new System.Drawing.Size(778, 100);
            this.menu_superior.TabIndex = 1;
            // 
            // panel_estadocaja
            // 
            this.panel_estadocaja.Controls.Add(this.mostrar_estadocaja);
            this.panel_estadocaja.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_estadocaja.Location = new System.Drawing.Point(340, 6);
            this.panel_estadocaja.Name = "panel_estadocaja";
            this.panel_estadocaja.Size = new System.Drawing.Size(436, 23);
            this.panel_estadocaja.TabIndex = 14;
            // 
            // mostrar_estadocaja
            // 
            this.mostrar_estadocaja.AutoSize = true;
            this.mostrar_estadocaja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mostrar_estadocaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrar_estadocaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.mostrar_estadocaja.Location = new System.Drawing.Point(0, 0);
            this.mostrar_estadocaja.Name = "mostrar_estadocaja";
            this.mostrar_estadocaja.Size = new System.Drawing.Size(102, 16);
            this.mostrar_estadocaja.TabIndex = 0;
            this.mostrar_estadocaja.Text = "Estado de caja:";
            // 
            // panel_nombreusuario
            // 
            this.panel_nombreusuario.Controls.Add(this.mostrar_nombreusuario);
            this.panel_nombreusuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_nombreusuario.Location = new System.Drawing.Point(340, 29);
            this.panel_nombreusuario.Name = "panel_nombreusuario";
            this.panel_nombreusuario.Size = new System.Drawing.Size(436, 23);
            this.panel_nombreusuario.TabIndex = 13;
            // 
            // mostrar_nombreusuario
            // 
            this.mostrar_nombreusuario.AutoSize = true;
            this.mostrar_nombreusuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mostrar_nombreusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrar_nombreusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.mostrar_nombreusuario.Location = new System.Drawing.Point(0, 0);
            this.mostrar_nombreusuario.Name = "mostrar_nombreusuario";
            this.mostrar_nombreusuario.Size = new System.Drawing.Size(58, 16);
            this.mostrar_nombreusuario.TabIndex = 0;
            this.mostrar_nombreusuario.Text = "Usuario:";
            // 
            // panel_cargousuario
            // 
            this.panel_cargousuario.Controls.Add(this.mostrar_cargousuario);
            this.panel_cargousuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_cargousuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(178)))));
            this.panel_cargousuario.Location = new System.Drawing.Point(340, 52);
            this.panel_cargousuario.Name = "panel_cargousuario";
            this.panel_cargousuario.Size = new System.Drawing.Size(436, 23);
            this.panel_cargousuario.TabIndex = 12;
            // 
            // mostrar_cargousuario
            // 
            this.mostrar_cargousuario.AutoSize = true;
            this.mostrar_cargousuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mostrar_cargousuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrar_cargousuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.mostrar_cargousuario.Location = new System.Drawing.Point(0, 0);
            this.mostrar_cargousuario.Name = "mostrar_cargousuario";
            this.mostrar_cargousuario.Size = new System.Drawing.Size(48, 16);
            this.mostrar_cargousuario.TabIndex = 0;
            this.mostrar_cargousuario.Text = "Cargo:";
            // 
            // panel_fechayhora
            // 
            this.panel_fechayhora.Controls.Add(this.mostrar_horayfecha);
            this.panel_fechayhora.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_fechayhora.Location = new System.Drawing.Point(340, 75);
            this.panel_fechayhora.Name = "panel_fechayhora";
            this.panel_fechayhora.Size = new System.Drawing.Size(436, 23);
            this.panel_fechayhora.TabIndex = 2;
            // 
            // mostrar_horayfecha
            // 
            this.mostrar_horayfecha.AutoSize = true;
            this.mostrar_horayfecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mostrar_horayfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrar_horayfecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.mostrar_horayfecha.Location = new System.Drawing.Point(0, 0);
            this.mostrar_horayfecha.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.mostrar_horayfecha.Name = "mostrar_horayfecha";
            this.mostrar_horayfecha.Size = new System.Drawing.Size(49, 16);
            this.mostrar_horayfecha.TabIndex = 0;
            this.mostrar_horayfecha.Text = "Fecha:";
            // 
            // bt_cerrarcaja
            // 
            this.bt_cerrarcaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.bt_cerrarcaja.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_cerrarcaja.FlatAppearance.BorderSize = 0;
            this.bt_cerrarcaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cerrarcaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cerrarcaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.bt_cerrarcaja.Location = new System.Drawing.Point(240, 0);
            this.bt_cerrarcaja.Name = "bt_cerrarcaja";
            this.bt_cerrarcaja.Size = new System.Drawing.Size(100, 98);
            this.bt_cerrarcaja.TabIndex = 10;
            this.bt_cerrarcaja.Text = "Cerrar caja registradora";
            this.bt_cerrarcaja.UseVisualStyleBackColor = false;
            this.bt_cerrarcaja.Click += new System.EventHandler(this.button2_Click);
            // 
            // separador_sup2
            // 
            this.separador_sup2.Dock = System.Windows.Forms.DockStyle.Left;
            this.separador_sup2.Location = new System.Drawing.Point(220, 0);
            this.separador_sup2.Name = "separador_sup2";
            this.separador_sup2.Size = new System.Drawing.Size(20, 98);
            this.separador_sup2.TabIndex = 2;
            // 
            // bt_abrircaja
            // 
            this.bt_abrircaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.bt_abrircaja.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_abrircaja.FlatAppearance.BorderSize = 0;
            this.bt_abrircaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_abrircaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_abrircaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.bt_abrircaja.Location = new System.Drawing.Point(120, 0);
            this.bt_abrircaja.Name = "bt_abrircaja";
            this.bt_abrircaja.Size = new System.Drawing.Size(100, 98);
            this.bt_abrircaja.TabIndex = 2;
            this.bt_abrircaja.Text = "Abrir caja registradora";
            this.bt_abrircaja.UseVisualStyleBackColor = false;
            this.bt_abrircaja.Click += new System.EventHandler(this.button3_Click);
            // 
            // separador_sup1
            // 
            this.separador_sup1.Dock = System.Windows.Forms.DockStyle.Left;
            this.separador_sup1.Location = new System.Drawing.Point(100, 0);
            this.separador_sup1.Name = "separador_sup1";
            this.separador_sup1.Size = new System.Drawing.Size(20, 98);
            this.separador_sup1.TabIndex = 9;
            // 
            // bt_cambiarusuario
            // 
            this.bt_cambiarusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.bt_cambiarusuario.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_cambiarusuario.FlatAppearance.BorderSize = 0;
            this.bt_cambiarusuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cambiarusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cambiarusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.bt_cambiarusuario.Location = new System.Drawing.Point(0, 0);
            this.bt_cambiarusuario.Name = "bt_cambiarusuario";
            this.bt_cambiarusuario.Size = new System.Drawing.Size(100, 98);
            this.bt_cambiarusuario.TabIndex = 2;
            this.bt_cambiarusuario.Text = "Cambiar usuario";
            this.bt_cambiarusuario.UseVisualStyleBackColor = false;
            this.bt_cambiarusuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_formularios
            // 
            this.panel_formularios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_formularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel_formularios.Controls.Add(this.pictureBox1);
            this.panel_formularios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_formularios.ForeColor = System.Drawing.Color.Black;
            this.panel_formularios.Location = new System.Drawing.Point(250, 100);
            this.panel_formularios.Name = "panel_formularios";
            this.panel_formularios.Size = new System.Drawing.Size(778, 509);
            this.panel_formularios.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(241, 105);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Menu_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.panel_formularios);
            this.Controls.Add(this.menu_superior);
            this.Controls.Add(this.menu_lateral);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(178)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu_lateral.ResumeLayout(false);
            this.smenu_personal.ResumeLayout(false);
            this.smenu_inventario.ResumeLayout(false);
            this.menu_superior.ResumeLayout(false);
            this.panel_estadocaja.ResumeLayout(false);
            this.panel_estadocaja.PerformLayout();
            this.panel_nombreusuario.ResumeLayout(false);
            this.panel_nombreusuario.PerformLayout();
            this.panel_cargousuario.ResumeLayout(false);
            this.panel_cargousuario.PerformLayout();
            this.panel_fechayhora.ResumeLayout(false);
            this.panel_fechayhora.PerformLayout();
            this.panel_formularios.ResumeLayout(false);
            this.panel_formularios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_lateral;
        private System.Windows.Forms.Panel smenu_personal;
        private System.Windows.Forms.Button bt_informepersonal;
        private System.Windows.Forms.Button bt_dardebaja;
        private System.Windows.Forms.Button bt_ingresarnuevo;
        private System.Windows.Forms.Button bt_buscarpersonal;
        private System.Windows.Forms.Button bt_personal;
        private System.Windows.Forms.Panel smenu_inventario;
        private System.Windows.Forms.Button bt_eliminarinsumo;
        private System.Windows.Forms.Button bt_buscarsalida;
        private System.Windows.Forms.Button bt_ingresarsalida;
        private System.Windows.Forms.Button bt_ingresarnuevoinsumo;
        private System.Windows.Forms.Button bt_buscarllegada;
        private System.Windows.Forms.Button bt_ingresarllegada;
        private System.Windows.Forms.Button bt_informeinventario;
        private System.Windows.Forms.Button bt_inventario;
        private System.Windows.Forms.Button bt_buscarcuadre;
        private System.Windows.Forms.Button bt_cuadrarinventario;
        private System.Windows.Forms.Panel menu_superior;
        private System.Windows.Forms.Button bt_abrircaja;
        private System.Windows.Forms.Button bt_cambiarusuario;
        private System.Windows.Forms.Button bt_cerrarcaja;
        private System.Windows.Forms.Panel separador_sup2;
        private System.Windows.Forms.Panel separador_sup1;
        private System.Windows.Forms.Panel panel_estadocaja;
        private System.Windows.Forms.Label mostrar_estadocaja;
        private System.Windows.Forms.Panel panel_nombreusuario;
        private System.Windows.Forms.Label mostrar_nombreusuario;
        private System.Windows.Forms.Panel panel_cargousuario;
        private System.Windows.Forms.Label mostrar_cargousuario;
        private System.Windows.Forms.Panel panel_fechayhora;
        private System.Windows.Forms.Label mostrar_horayfecha;
        private System.Windows.Forms.Panel separador;
        private System.Windows.Forms.Panel panel_formularios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_salir;
    }
}

