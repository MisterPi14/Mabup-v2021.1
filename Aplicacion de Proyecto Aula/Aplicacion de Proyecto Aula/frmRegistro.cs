using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;

                    //CREANDO ID
                    OracleDataReader Lector;
                    conn.Open();
                    cmd.CommandText = "SELECT MAX(id) AS Ultima_id FROM tb_Usuarios";
                    Lector = cmd.ExecuteReader();
                    Lector.Read();
                    ID_Usuario = Convert.ToInt32(Lector[0]) + 1;
                    conn.Close();

                    // --- CREANDO REGISTRO (Sintaxis explícita y para Oracle) ---
                    // Se especifican las columnas y se usa ":" para los parámetros
                    cmd.CommandText = @"INSERT INTO tb_Usuarios (
                        id, Usuario, Contraseña, Nombre, Ap_Pat, Ap_Mat, Estimado_de_tiempo
                    ) VALUES (
                        :id, :Usuario, :Contraseña, :Nombre, :Ap_Pat, :Ap_Mat, :Estimado_de_tiempo
                    )";

                    // --- CREANDO PARÁMETROS PARA ORACLE ---
                    cmd.Parameters.Add(":id", OracleDbType.Int32);
                    cmd.Parameters.Add(":Usuario", OracleDbType.NVarchar2);
                    cmd.Parameters.Add(":Contraseña", OracleDbType.NVarchar2);
                    cmd.Parameters.Add(":Nombre", OracleDbType.NVarchar2);
                    cmd.Parameters.Add(":Ap_Pat", OracleDbType.NVarchar2);
                    cmd.Parameters.Add(":Ap_Mat", OracleDbType.NVarchar2);
                    cmd.Parameters.Add(":Estimado_de_tiempo", OracleDbType.IntervalDS); // Oracle no tiene TIME, se usa Varchar2

                    // --- ASIGNANDO VALORES A LOS ATRIBUTOS ---
                    cmd.Parameters[":id"].Value = ID_Usuario;
                    cmd.Parameters[":Usuario"].Value = txtCorreo.Text;
                    cmd.Parameters[":Contraseña"].Value = txtContraseña.Text;
                    cmd.Parameters[":Nombre"].Value = txtNombre.Text;
                    cmd.Parameters[":Ap_Pat"].Value = txtApellidoPat.Text;
                    cmd.Parameters[":Ap_Mat"].Value = txtApellidoMat.Text;
                    cmd.Parameters[":Estimado_de_tiempo"].Value = TimeSpan.Zero;


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
