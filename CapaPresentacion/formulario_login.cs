using System.Windows.Forms;

namespace AdministracionPizzeria.CapaPresentacion
{
    public partial class Formulario_login : Form
    {
        public Formulario_login()
        {
            InitializeComponent();
        }

        private void Validarlogin()
        {
            if(cb_usuariologin.Text != "Admin")
            {
                MessageBox.Show("Usuario incorrecto");
            }
            else if (tb_contraseñalogin.Text != "admin")
            {
                MessageBox.Show("Contraseña incorrecta");
            }
            else
            {
                this.Close();
            }
        }

        private void tb_contraseñalogin_Click(object sender, System.EventArgs e)
        {
            if (tb_contraseñalogin.Text == "Contraseña")
            {
                tb_contraseñalogin.Clear();
            }
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            Validarlogin();
        }
    }
}
