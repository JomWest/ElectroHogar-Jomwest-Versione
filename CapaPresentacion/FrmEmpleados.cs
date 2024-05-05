using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{

    public partial class FrmEmpleados : Form
    {
        string Cedula, nombre, apellido, user, contraseña;
        int numero;


        NegocioEmpleados metodosEmpleados = new NegocioEmpleados();
        public FrmEmpleados()
        {
            InitializeComponent();
            addciudad();
            addMunicipio();
            CargarDatos();
        }

        public void addciudad()
        {
            cbCiudad.Items.Add("Matagalpa");
            cbCiudad.Items.Add("Esteli");
            cbCiudad.Items.Add("Granada");
            cbCiudad.Items.Add("Jinotega");
        }

        public void addMunicipio()
        {
            cbMunicipio.Items.Add("Sebaco");
            cbMunicipio.Items.Add("San Insidro");
            cbMunicipio.Items.Add("San Ramon");


        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void CargarDatos()
        {
            var lista = metodosEmpleados.LeerDatos();
            DataEmpleado.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                DataEmpleado.Rows.Add(lista[i].NombreEmpleado, lista[i].ApellidoEmpleado, lista[i].TelefonoEmpleado);
            }
            DataEmpleado.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ola");
            CapturarDatos();
            MessageBox.Show("Working");
            metodosEmpleados.NuevoUsuario(Cedula, nombre, apellido, numero, user, contraseña);
            MessageBox.Show("Working");
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void CapturarDatos()
        {
            Cedula = txtcedula.Text.Trim();
            nombre = txtname.Text.Trim();
            apellido = txtapellido.Text.Trim();
            user = txtuser.Text.Trim();
            contraseña = txtpsw.Text.Trim();
            numero = Convert.ToInt32(txtTelefono.Text);
        }
    }
}
