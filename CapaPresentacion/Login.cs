using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
     

        FrmHome home = new FrmHome();
        SqlConnection conexion = new SqlConnection("server=AZAZYEL;" +
            "database=ELECTROHOGAR; integrated security=true");
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string query = "select * from Empleados where UsuarioEmpleado='" + txtUser.Text + "' and ContraseñaEmpleado='" + txtpsw.Text + "'";
            SqlCommand comando = new SqlCommand(query, conexion);
          
            SqlDataReader Leer;

            try {

                Leer = comando.ExecuteReader();       

                if(Leer.HasRows == true)
                {
                    Leer.Close();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario y la contraseña no coinciden");

                    conexion.Close();
                }
                     
                    

            }
            catch (Exception ex)
            {
                MessageBox.Show("El usuario y contraseña no coinciden");
                conexion.Close();
            }
        }

    

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
