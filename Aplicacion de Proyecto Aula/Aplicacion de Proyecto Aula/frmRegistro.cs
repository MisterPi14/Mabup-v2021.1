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
using Oracle.ManagedDataAccess.Client;


namespace Agencia_de_viajes
{
    public partial class frmRegistro : Form
    {
        int ID_Usuario = 0;

        OracleConnection conn = new OracleConnection(@"Data Source=localhost:1521/XEPDB1;User Id=USR_MABUP;Password=123456789;");

        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != ""&&txtApellidoPat.Text!=""&&txtApellidoMat.Text!=""&&txtCorreo.Text!=""&&txtContraseña.Text!="")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    //CREANDO ID
                    SqlDataReader Lector;
                    conn.Open();
                    cmd.CommandText = "SELECT MAX(id) AS Ultima_id FROM tb_Usuarios";
                    Lector = cmd.ExecuteReader();
                    Lector.Read();
                    ID_Usuario = Convert.ToInt32(Lector[0]) + 1;
                    conn.Close();

                    //CREANDO REGISTRO
                    cmd.CommandText = "INSERT INTO tb_Usuarios VALUES (@id, @Usuario, @Contraseña, @Nombre, @Ap_Pat, @Ap_Mat, @Estimado_de_tiempo)";

                    //CREANDO PARAMETROS
                    cmd.Parameters.Add("@id", SqlDbType.Int);
                    cmd.Parameters.Add("@Usuario", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Contraseña", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Ap_Pat", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Ap_Mat", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@Estimado_de_tiempo", SqlDbType.Time);

                    //ASIGNANDO VALORES A LOS ATRIBUTOS

                    cmd.Parameters["@id"].Value = ID_Usuario;
                    cmd.Parameters["@Usuario"].Value = txtCorreo.Text;
                    cmd.Parameters["@Contraseña"].Value = txtContraseña.Text;
                    cmd.Parameters["@Nombre"].Value = txtNombre.Text;
                    cmd.Parameters["@Ap_Pat"].Value = txtApellidoPat.Text;
                    cmd.Parameters["@Ap_Mat"].Value = txtApellidoMat.Text;
                    cmd.Parameters["@Estimado_de_tiempo"].Value = "0";


                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    //OCULTANDO REGISTRO


                    lblAviso.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    txtNombre.Visible = false;
                    txtCorreo.Visible = false;
                    txtContraseña.Visible = false;
                    btnCancelar.Visible = false;
                    btnGuardar.Visible = false;
                    txtApellidoPat.Visible = false;
                    txtApellidoMat.Visible = false;
                    panel1.Visible = false;
                    btnCompletado.Visible = true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Llena todos los campos");
            }
                                                      
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogIn Presentacion = new frmLogIn();
            Presentacion.Show();
        }
        private void btnCompletado_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmEstimado_de_tiempo Estimando_Tiempo = new frmEstimado_de_tiempo(ID_Usuario);
            Estimando_Tiempo.Show();
        }
    }
}
