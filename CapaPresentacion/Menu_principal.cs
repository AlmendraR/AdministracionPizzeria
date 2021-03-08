using System;
using System.Windows.Forms;

namespace AdministracionPizzeria.CapaPresentacion
{
    public partial class Menu_principal : Form
    {
        public Menu_principal()
        {
            InitializeComponent();
            iniciarmenus();
        }

        private void iniciarmenus()
        {
            smenu_inventario.Visible = false;
            smenu_personal.Visible = false;
        }

        private void ocultarsubmenu()
        {
            if (smenu_inventario.Visible == true)
                smenu_inventario.Visible = false;
            if (smenu_personal.Visible == true)
                smenu_personal.Visible = false;
        }

        private void mostrarsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                ocultarsubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void bt_nuevocuadre_Click(object sender, EventArgs e)
        {
            Abrirformularios(new Formulario_cuadrarinventario());
            ocultarsubmenu();
        }

        private void bt_buscarcuadre_Click(object sender, EventArgs e)
        {
            Abrirformularios(new Formulario_buscarcuadre());
            ocultarsubmenu();
        }

        private void bt_inventario_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(smenu_inventario);
        }

        private void bt_personal_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(smenu_personal);
        }

        private void bt_informeinventario_Click(object sender, EventArgs e)
        {
            //
            //
            //
            ocultarsubmenu();
        }

        private void bt_ingresarllegada_Click(object sender, EventArgs e)
        {
            Abrirformularios(new Formulario_ingresarllegadainsumo());
            ocultarsubmenu();
        }

        private void bt_buscarllegada_Click(object sender, EventArgs e)
        {
            Abrirformularios(new Formulario_buscarllegadainsumo());
            ocultarsubmenu();
        }

        private void bt_ingresarnuevoinsumo_Click(object sender, EventArgs e)
        {
            Abrirformularios(new Formulario_ingresarnuevoinsumo());
            ocultarsubmenu();
        }

        private void bt_ingresarsalida_Click(object sender, EventArgs e)
        {
            //
            //
            //
            ocultarsubmenu();
        }

        private void bt_buscarsalida_Click(object sender, EventArgs e)
        {
            Abrirformularios(new Formulario_buscarsalidainsumo());
            ocultarsubmenu();
        }

        private void bt_eliminarinsumo_Click(object sender, EventArgs e)
        {
            //
            //
            //
            ocultarsubmenu();
        }

        private void bt_buscarpersonal_Click(object sender, EventArgs e)
        {
            //
            //
            //
            ocultarsubmenu();
        }

        private void bt_ingresarnuevo_Click(object sender, EventArgs e)
        {
            //
            //
            //
            ocultarsubmenu();
        }

        private void bt_dardebaja_Click(object sender, EventArgs e)
        {
            //
            //
            //
            ocultarsubmenu();
        }

        private void bt_informepersonal_Click(object sender, EventArgs e)
        {
            //
            //
            //
            ocultarsubmenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abrirformularios(new formulario_login());
            ocultarsubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //
            //
            //
            ocultarsubmenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //
            //
            //
            ocultarsubmenu();
        }

        private Form formularioactivo = null;
        private void Abrirformularios(Form formularioHijo)
        {
            if (formularioactivo != null)
                formularioactivo.Close();
            formularioactivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panel_formularios.Controls.Add(formularioHijo);
            panel_formularios.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void bt_salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
