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


namespace Agencia_de_viajes
{
    public partial class frmAgregar_Tarea : Form
    {
        int Dificultad = 0;
        string Usuario = "", Contraseña = "";

        int ID = 0;

        //INSTANCIA
        SqlConnection conn = new SqlConnection(@"Data Source=.; Initial Catalog=BD_Mabup; Integrated Security=True");

        public frmAgregar_Tarea(string atrUsuario, string atrContraseña)
        {
            Usuario = atrUsuario;
            Contraseña = atrContraseña;
            InitializeComponent();
        }

        private void lblLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogIn Inicio = new frmLogIn();
            Inicio.Show();
        }

        private void btnAgregar_Tarea_Click(object sender, EventArgs e)
        {

            if (ChB1.Checked==false&& ChB2.Checked == false && ChB3.Checked == false && ChB4.Checked == false && ChB5.Checked == false && ChB6.Checked == false && ChB7.Checked == false && ChB8.Checked == false && ChB9.Checked == false && ChB10.Checked == false)
            {
                Dificultad = 0;
            }

            if (txtTitulo_Tarea.Text != "" && dtpFecha_Entrega.Text != "" && cbHoras.Text != "" && cbMinutos.Text != "" && cbMateria.Text != "" && Dificultad != 0 && cbTema_Tarea.Text != "")
            {

                //CONSULTANDO ID
                SqlCommand Consulta_ID = new SqlCommand();
                Consulta_ID.Connection = conn;

                SqlDataReader Lector;
                conn.Open();
                Consulta_ID.CommandText = "SELECT id FROM tb_Usuarios WHERE Usuario = '" + Usuario + "' AND Contraseña  = '" + Contraseña + "'";
                Lector = Consulta_ID.ExecuteReader();
                Lector.Read();
                ID = Convert.ToInt32(Lector[0]);
                conn.Close();
                

                //GUARDANDO LA TAREA

                SqlCommand Guardar_Tarea = new SqlCommand();
                Guardar_Tarea.Connection = conn;

                
                //CREANDO REGISTRO
                Guardar_Tarea.CommandText = "INSERT INTO tb_Tareas VALUES (@id, @Titulo, @Fecha_Inicio, @Hora_Inicio, @Fecha_Entrega, @Hora_Entrega, @Materia, @Dificultad, @Tema_Tarea, @Completado)";

                //CREANDO PARAMETROS
                Guardar_Tarea.Parameters.Add("@id", SqlDbType.Int);          
                Guardar_Tarea.Parameters.Add("@Titulo", SqlDbType.NVarChar);
                Guardar_Tarea.Parameters.Add("@Fecha_Inicio", SqlDbType.Date);
                Guardar_Tarea.Parameters.Add("@Hora_Inicio", SqlDbType.Time);
                Guardar_Tarea.Parameters.Add("@Fecha_Entrega", SqlDbType.Date);
                Guardar_Tarea.Parameters.Add("@Hora_Entrega", SqlDbType.Time);
                Guardar_Tarea.Parameters.Add("@Materia", SqlDbType.NVarChar);
                Guardar_Tarea.Parameters.Add("@Dificultad", SqlDbType.Int);
                Guardar_Tarea.Parameters.Add("@Tema_Tarea", SqlDbType.NVarChar);
                Guardar_Tarea.Parameters.Add("@Completado", SqlDbType.Bit);


                //ASIGNANDO VALORES A LOS ATRIBUTOS

                Guardar_Tarea.Parameters["@id"].Value = ID;
                Guardar_Tarea.Parameters["@Titulo"].Value = txtTitulo_Tarea.Text;
                Guardar_Tarea.Parameters["@Fecha_Inicio"].Value = DateTime.Today.ToString("dd-MM-yyyy");
                Guardar_Tarea.Parameters["@Hora_Inicio"].Value = DateTime.Now.ToString("HH:mm:ss");
                Guardar_Tarea.Parameters["@Fecha_Entrega"].Value = dtpFecha_Entrega.Text;
                Guardar_Tarea.Parameters["@Hora_Entrega"].Value = cbHoras.Text + ":" + cbMinutos.Text + ":00.000";
                Guardar_Tarea.Parameters["@Materia"].Value = cbMateria.Text;
                Guardar_Tarea.Parameters["@Dificultad"].Value = Dificultad;
                Guardar_Tarea.Parameters["@Tema_Tarea"].Value = cbTema_Tarea.Text;
                Guardar_Tarea.Parameters["@Completado"].Value = 0;


                conn.Open();
                Guardar_Tarea.ExecuteNonQuery();
                conn.Close();

                //OCULTANDO LOS COMPONENTES
                btnContinuar.Visible = true;
                lblNombre.Visible = false;
                label1.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label3.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
                ChB1.Visible = false;
                ChB2.Visible = false;
                ChB3.Visible = false;
                ChB4.Visible = false;
                ChB5.Visible = false;
                ChB6.Visible = false;
                ChB7.Visible = false;
                ChB8.Visible = false;
                ChB9.Visible = false;
                ChB10.Visible = false;
                txtTitulo_Tarea.Visible = false;
                dtpFecha_Entrega.Visible = false;
                cbHoras.Visible = false;
                cbMinutos.Visible = false;
                cbMateria.Visible = false;
                cbTema_Tarea.Visible = false;
                btnAgregar_Tarea.Visible = false;
                btnCancelar.Visible = false;

            }
            else
            {
                lblAviso.Visible = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmGestor_Tareas Retorno = new frmGestor_Tareas(Usuario, Contraseña);
            Retorno.Show();
            this.Hide();
        }

        private void ChB1_CheckedChanged(object sender, EventArgs e)
        {
            ChB2.Checked = false;
            ChB3.Checked = false;
            ChB4.Checked = false;
            ChB5.Checked = false;
            ChB6.Checked = false;
            ChB7.Checked = false;
            ChB8.Checked = false;
            ChB9.Checked = false;
            ChB10.Checked = false;
            Dificultad = 1;
        }

        private void ChB2_CheckedChanged(object sender, EventArgs e)
        {
            ChB1.Checked = false;
            ChB3.Checked = false;
            ChB4.Checked = false;
            ChB5.Checked = false;
            ChB6.Checked = false;
            ChB7.Checked = false;
            ChB8.Checked = false;
            ChB9.Checked = false;
            ChB10.Checked = false;
            Dificultad = 2;

        }

        private void ChB3_CheckedChanged(object sender, EventArgs e)
        {
            ChB2.Checked = false;
            ChB1.Checked = false;
            ChB4.Checked = false;
            ChB5.Checked = false;
            ChB6.Checked = false;
            ChB7.Checked = false;
            ChB8.Checked = false;
            ChB9.Checked = false;
            ChB10.Checked = false;
            Dificultad = 3;

        }

        private void ChB4_CheckedChanged(object sender, EventArgs e)
        {
            ChB2.Checked = false;
            ChB3.Checked = false;
            ChB1.Checked = false;
            ChB5.Checked = false;
            ChB6.Checked = false;
            ChB7.Checked = false;
            ChB8.Checked = false;
            ChB9.Checked = false;
            ChB10.Checked = false;
            Dificultad = 4;

        }

        private void ChB5_CheckedChanged(object sender, EventArgs e)
        {
            ChB2.Checked = false;
            ChB3.Checked = false;
            ChB4.Checked = false;
            ChB1.Checked = false;
            ChB6.Checked = false;
            ChB7.Checked = false;
            ChB8.Checked = false;
            ChB9.Checked = false;
            ChB10.Checked = false;
            Dificultad = 5;

        }

        private void ChB6_CheckedChanged(object sender, EventArgs e)
        {
            ChB2.Checked = false;
            ChB3.Checked = false;
            ChB4.Checked = false;
            ChB5.Checked = false;
            ChB1.Checked = false;
            ChB7.Checked = false;
            ChB8.Checked = false;
            ChB9.Checked = false;
            ChB10.Checked = false;
            Dificultad = 6;

        }

        private void ChB7_CheckedChanged(object sender, EventArgs e)
        {
            ChB2.Checked = false;
            ChB3.Checked = false;
            ChB4.Checked = false;
            ChB5.Checked = false;
            ChB6.Checked = false;
            ChB1.Checked = false;
            ChB8.Checked = false;
            ChB9.Checked = false;
            ChB10.Checked = false;
            Dificultad = 7;

        }

        private void ChB8_CheckedChanged(object sender, EventArgs e)
        {
            ChB2.Checked = false;
            ChB3.Checked = false;
            ChB4.Checked = false;
            ChB5.Checked = false;
            ChB6.Checked = false;
            ChB7.Checked = false;
            ChB1.Checked = false;
            ChB9.Checked = false;
            ChB10.Checked = false;
            Dificultad = 8;

        }

        private void ChB9_CheckedChanged(object sender, EventArgs e)
        {
            ChB2.Checked = false;
            ChB3.Checked = false;
            ChB4.Checked = false;
            ChB5.Checked = false;
            ChB6.Checked = false;
            ChB7.Checked = false;
            ChB8.Checked = false;
            ChB1.Checked = false;
            ChB10.Checked = false;
            Dificultad = 9;

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            frmGestor_Tareas Retorno = new frmGestor_Tareas(Usuario, Contraseña);
            Retorno.Show();
            this.Hide();
        }

        private void ChB10_CheckedChanged(object sender, EventArgs e)
        {
            ChB2.Checked = false;
            ChB3.Checked = false;
            ChB4.Checked = false;
            ChB5.Checked = false;
            ChB6.Checked = false;
            ChB7.Checked = false;
            ChB8.Checked = false;
            ChB9.Checked = false;
            ChB1.Checked = false;
            Dificultad = 10;

        }
    }
}
