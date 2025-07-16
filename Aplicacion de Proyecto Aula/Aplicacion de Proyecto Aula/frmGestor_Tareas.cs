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
    public partial class frmGestor_Tareas : Form
    {
        //DATOS USUARIO
        string Usuario = "", Contraseña = "";
        int ID=0;

        //DATOS TAREA
        string Titulo = "",  Hora_entrega="";
        DateTime Fecha_entrega;
        int Dificultad = 0;
        
        //NUMERO DE TAREAS
        int n_Tareas=0;


        //INSTANCIA
        SqlConnection conn = new SqlConnection(@"Data Source=.; Initial Catalog=BD_Mabup; Integrated Security=True");

        public frmGestor_Tareas(string atrUsuario, string atrContraseña)
        {
            Usuario = atrUsuario;
            Contraseña = atrContraseña;
            InitializeComponent();
           
            //CONSULTANDO NUMERO DE TAREAS
            SqlCommand Num_Tareas = new SqlCommand();
            Num_Tareas.Connection = conn;

            SqlDataReader Lector_Num_Tareas;
            conn.Open();
            Num_Tareas.CommandText = "SELECT MAX(Num_Tarea) FROM tb_Tareas";
            Lector_Num_Tareas = Num_Tareas.ExecuteReader();
            Lector_Num_Tareas.Read();
            n_Tareas = (Convert.ToInt32((Lector_Num_Tareas[0])));



            conn.Close();

            for (int n = 1; n <= n_Tareas; n++)
            {
                //CONSULTANDO DATOS DE LAS TAREAS
                SqlDataReader Lector;
                SqlCommand Consulta_Tareas = new SqlCommand();
                Consulta_Tareas.Connection = conn;


                conn.Open();

                StringBuilder Sel = new StringBuilder();
                Sel.Append("SELECT Titulo,Fecha_Entrega,Hora_Entrega,Dificultad FROM tb_Usuarios JOIN tb_Tareas ON tb_Usuarios.id = tb_Tareas.id WHERE Usuario='" + Usuario + "' AND Contraseña = '" + Contraseña + "' AND Completado=0 AND Num_Tarea=" + n);
                Consulta_Tareas = new SqlCommand(Sel.ToString(), conn);
                Lector = Consulta_Tareas.ExecuteReader();
                if (Lector.Read())
                {
                    Titulo = (Convert.ToString((Lector[0])));
                    Fecha_entrega = (Convert.ToDateTime((Lector[1])));
                    Hora_entrega = (Convert.ToString((Lector[2])));
                    Dificultad = (Convert.ToInt32((Lector[3])));
                    conn.Close();

                    //Asignando Valores a las cajas de texto
                    lvTareas.Items.Add("Tarea Pendiente: " + Titulo);
                    lvTareas.Items.Add("Fecha de entrega " + Fecha_entrega.ToString("dd-MM-yyyy"));
                    lvTareas.Items.Add("Hora de entrega " + Hora_entrega);
                    lvTareas.Items.Add("Dificultad: " + Convert.ToString(Dificultad));
                    lvTareas.Items.Add("");
                    lvTareas.Items.Add("*************************************************************");
                    lvTareas.Items.Add("");
                }
                else
                {

                }

                conn.Close();

            }

            if (Titulo=="")
            {
                MessageBox.Show("Al parecer tu lista de tareas esta vacia, recuerda puedes crear una tarea en el boton agrgegar tarea");
            }

        }

        private void lblLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogIn Inicio = new frmLogIn();
            Inicio.Show();
        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                //CONSULTANDO ID
                SqlCommand Consulta_ID = new SqlCommand();
                Consulta_ID.Connection = conn;
                SqlDataReader Lector_ID;
                conn.Open();
                Consulta_ID.CommandText = "SELECT id FROM tb_Usuarios WHERE Usuario = '" + Usuario + "' AND Contraseña = '" + Contraseña + "'";
                Lector_ID = Consulta_ID.ExecuteReader();
                Lector_ID.Read();
                ID = (Convert.ToInt32((Lector_ID[0])));
                conn.Close();

                //COMPLETANDO TAREA
                SqlCommand Completada = new SqlCommand();
                Completada.Connection = conn;
                Completada.CommandText = "UPDATE tb_Tareas SET Completado = 1 WHERE Titulo = '" + textBox1.Text + "' AND id =" + ID;
                conn.Open();
                Completada.ExecuteNonQuery();
                conn.Close();
                frmGestor_Tareas Reload = new frmGestor_Tareas(Usuario,Contraseña);
                Reload.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Seleccione una tarea");
            }


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVentana_principal Volver = new frmVentana_principal(Usuario,Contraseña);
            Volver.Show();
        }

        private void btnAgregar_Tarea_Click(object sender, EventArgs e)
        {
            frmAgregar_Tarea AgregarTarea = new frmAgregar_Tarea(Usuario, Contraseña);
            AgregarTarea.Show();
            this.Hide();
        }
    }
}
