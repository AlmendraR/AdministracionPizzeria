using System;
using System.Windows.Forms;

namespace AdministracionPizzeria.CapaPresentacion
{
    public partial class Menu_principal : Form
    {
        public Menu_principal()
        {
            InitializeComponent();
            Iniciarmenus();
        }

        //Funciones del menú//
        private void Iniciarmenus()
        {
            smenu_inventario.Visible = false;
            smenu_cuadres.Visible = false;
            smenu_llegadasysalidas.Visible = false;
            smenu_personal.Visible = false;
            smenu_administrar.Visible = false;
        }

        private void Ocultarsubmenu()
        {
            if (smenu_inventario.Visible == true)
                smenu_inventario.Visible = false;
            if (smenu_cuadres.Visible == true)
                smenu_cuadres.Visible = false;
            if (smenu_llegadasysalidas.Visible == true)
                smenu_llegadasysalidas.Visible = false;
            if (smenu_personal.Visible == true)
                smenu_personal.Visible = false;
            if (smenu_administrar.Visible == true)
                smenu_administrar.Visible = false;
        }

        private void Mostrarsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                Ocultarsubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void Bt_nuevocuadre_Click(object sender, EventArgs e)
        {
            Abrirformularios(new Formulario_cuadrarinventario());
            Ocultarsubmenu();
        }

        private void Bt_buscarcuadre_Click(object sender, EventArgs e)
        {
            Abrirformularios(new Formulario_mostrarcuadres());
            Ocultarsubmenu();
        }

        private void Bt_inventario_Click(object sender, EventArgs e)
        {
            Mostrarsubmenu(smenu_inventario);
        }

        private void Bt_personal_Click(object sender, EventArgs e)
        {
            Mostrarsubmenu(smenu_personal);
        }


        private void Bt_ingresarllegada_Click(object sender, EventArgs e)
        {
            Abrirformularios(new Formulario_ingresarllegada());
            Ocultarsubmenu();
        }

        private void Bt_buscarllegada_Click(object sender, EventArgs e)
        {
            Abrirformularios(new Formulario_buscarllegadainsumo());
            Ocultarsubmenu();
        }

        private void Bt_ingresarsalida_Click(object sender, EventArgs e)
        {
            //
            //
            //
            Ocultarsubmenu();
        }

        private void Bt_buscarsalida_Click(object sender, EventArgs e)
        {
            Abrirformularios(new Formulario_buscarsalidainsumo());
            Ocultarsubmenu();
        }

        private void Bt_buscarpersonal_Click(object sender, EventArgs e)
        {
            //
            //
            //
            Ocultarsubmenu();
        }

        private void Bt_ingresarnuevo_Click(object sender, EventArgs e)
        {
            //
            //
            //
            Ocultarsubmenu();
        }

        private void Bt_dardebaja_Click(object sender, EventArgs e)
        {
            //
            //
            //
            Ocultarsubmenu();
        }

        private void Bt_informepersonal_Click(object sender, EventArgs e)
        {
            Abrirformularios(new Formulario_resumenpersonal());
            Ocultarsubmenu();
        }


        Formulario_login login;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (login == null)
            {
                login = new Formulario_login();
                login.FormClosed += new FormClosedEventHandler(CerrarLogin);
                MdiParent = this.MdiParent;
                login.Show();
                login.TopMost = true;
            }
            else
                login.Activate();
            
            Ocultarsubmenu();
        }



        private void Button3_Click(object sender, EventArgs e)
        {
            //
            //
            //
            Ocultarsubmenu();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //
            //
            //
            Ocultarsubmenu();
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

        private void Bt_salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bt_cuadres_Click(object sender, EventArgs e)
        {
            Mostrarsubmenu(smenu_cuadres);
        }

        private void Bt_llegadasysalidas_Click(object sender, EventArgs e)
        {
            Mostrarsubmenu(smenu_llegadasysalidas);
        }

        private void Bt_personal_Click_1(object sender, EventArgs e)
        {
            Mostrarsubmenu(smenu_personal);
        }

        private void Bt_administrar_Click(object sender, EventArgs e)
        {
            Mostrarsubmenu(smenu_administrar);
        }

        private void Bt_resumeninventario_Click(object sender, EventArgs e)
        {
            Abrirformularios(new Formulario_resumeninventario());
            Ocultarsubmenu();
        }

        private void Bt_agregarproducto_Click(object sender, EventArgs e)
        {
            Abrirformularios(new Formulario_agregarproducto());
            Ocultarsubmenu();
        }
        private void Bt_cambiarusuariolateral_Click(object sender, EventArgs e)
 
            {
                if (login == null)
                {
                    login = new Formulario_login();
                    login.FormClosed += new FormClosedEventHandler(CerrarLogin);
                    MdiParent = this.MdiParent;
                    login.Show();
                    login.TopMost = true;
                }
                else
                    login.Activate();

                Ocultarsubmenu();
            }
        void CerrarLogin(object sender, EventArgs e)
        {
            login = null;

        }

        private void Bt_cuadrarinventario_Click(object sender, EventArgs e)
        {
            Abrirformularios(new Formulario_cuadrarinventario());
            Ocultarsubmenu();
        }

        private void Bt_crearusuario_Click(object sender, EventArgs e)
        {
            Abrirformularios(new Formulario_crearusuario());
            Ocultarsubmenu();
        }

        private void Bt_eliminarproducto_Click(object sender, EventArgs e)
        {
            Abrirformularios(new Formulario_eliminarproducto());
            Ocultarsubmenu();
        }

        private void Bt_mostrarcuadres_Click(object sender, EventArgs e)
        {
            Abrirformularios(new Formulario_mostrarcuadres());
            Ocultarsubmenu();
        }

        private void Bt_ingresarpersonal_Click(object sender, EventArgs e)
        {
            Abrirformularios(new Formulario_ingresarpersonal());
            Ocultarsubmenu();
        }

        private void Bt_ingresarllegada_Click_1(object sender, EventArgs e)
        {
            Abrirformularios(new Formulario_ingresarllegada());
            Ocultarsubmenu();
        }

        private void Bt_buscarllegada_Click_1(object sender, EventArgs e)
        {
            Abrirformularios(new Formulario_buscarllegadainsumo());
            Ocultarsubmenu();
        }

        private void Bt_buscarsalida_Click_1(object sender, EventArgs e)
        {
            Abrirformularios(new Formulario_buscarsalidainsumo());
            Ocultarsubmenu();
        }

        private void Bt_dardebaja_Click_1(object sender, EventArgs e)
        {
            Abrirformularios(new Formulario_dardebaja());
            Ocultarsubmenu();
        }

        private void Bt_ingresarsalida_Click_1(object sender, EventArgs e)
        {
            Abrirformularios(new Formulario_ingresarsalida());
            Ocultarsubmenu();
        }

        private string f = DateTime.Today.ToShortDateString();
        private void Menu_principal_Load(object sender, EventArgs e)
        {
            mostrar_horayfecha.Text = "Fecha:        " + f;
        }
    }

}
