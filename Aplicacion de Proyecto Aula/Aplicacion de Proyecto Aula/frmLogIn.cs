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

/*
 Piña Vargas Edgar Diego, 5IM12, 02/12/20, Esta aplicacion hace uso de la libreria
 System.Data.SqlClient y llama a sus distintas clases para ejecutar sus procesos
 y de esta forma poder manipular la conexion con sql
*/

namespace Agencia_de_viajes
{
    public partial class frmLogIn : Form
    {      

        private void frmPresentacion_Load(object sender, EventArgs e)
        {

        }

        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnIniciar_Sesion_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader Dr;
                SqlConnection conn = new SqlConnection(@"Data Source=.; Initial Catalog=BD_Mabup; Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
               

                conn.Open();

                cmd.Connection = conn;
                StringBuilder Sel = new StringBuilder();
               
                //VALIDANDO USUARIO Y CONTRASEÑA EN SQL
                Sel.Append("SELECT * FROM tb_Usuarios WHERE Usuario ='" + txtUsuario.Text + "' AND Contraseña = '" + txtContraseña.Text + "'");
                cmd = new SqlCommand(Sel.ToString(), conn);
                Dr = cmd.ExecuteReader();
                if (Dr.Read())
                {
                    lblAviso.Visible = false;

                    string Nombre = Convert.ToString(Dr[3]);
                    string Pat = Convert.ToString(Dr[4]);
                    string Mat = Convert.ToString(Dr[5]);
                    string Usuario = Nombre+" "+Pat+" "+Mat;
                    
                    MessageBox.Show("Bienvenid@ " + Usuario);

                    timer1.Enabled = true;
                    picApp_Load.Visible = true;

                }
                else
                {
                    lblAviso.Text = "Verifica el usuario y/o contraseña";
                    lblAviso.Visible = true;
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error");
                Application.Exit();
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistro Registro = new frmRegistro();
            Registro.Show();           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            frmVentana_principal Principal = new frmVentana_principal(txtUsuario.Text, txtContraseña.Text);
            Principal.Show();
            this.Hide();
            timer1.Enabled = false;
        }
    }
}
