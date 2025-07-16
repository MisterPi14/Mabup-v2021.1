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
    public partial class frmAgregar_Tarea : Form
    {
        int Dificultad = 0;
        string Usuario = "", Contraseña = "";

        int ID = 0;

        //INSTANCIA
        OracleConnection conn = new OracleConnection(@"Data Source=localhost:1521/XEPDB1;User Id=USR_MABUP;Password=123456789;");
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
                OracleCommand Consulta_ID = new OracleCommand();
                Consulta_ID.Connection = conn;

                OracleDataReader Lector;
                conn.Open();
                Consulta_ID.CommandText = "SELECT id FROM tb_Usuarios WHERE Usuario = '" + Usuario + "' AND Contraseña  = '" + Contraseña + "'";
                Lector = Consulta_ID.ExecuteReader();
                Lector.Read();
                ID = Convert.ToInt32(Lector[0]);
                conn.Close();
                

                //GUARDANDO LA TAREA

                OracleCommand Guardar_Tarea = new OracleCommand();
                Guardar_Tarea.Connection = conn;

                
                //CREANDO REGISTRO
                // sintaxis de sql server Guardar_Tarea.CommandText = "INSERT INTO tb_Tareas VALUES (@id, @Titulo, @Fecha_Inicio, @Hora_Inicio, @Fecha_Entrega, @Hora_Entrega, @Materia, @Dificultad, @Tema_Tarea, @Completado)";
                Guardar_Tarea.CommandText = @"INSERT INTO tb_Tareas (
                                id, Titulo, Fecha_Inicio, Hora_Inicio, Fecha_Entrega, 
                                Hora_Entrega, Materia, Dificultad, Tema_Tarea, Completado
                            ) VALUES (
                                :id, :Titulo, :Fecha_Inicio, :Hora_Inicio, :Fecha_Entrega, 
                                :Hora_Entrega, :Materia, :Dificultad, :Tema_Tarea, :Completado
                            )";
                // --- CREANDO PARÁMETROS PARA ORACLE ---
                // Se usa ":" como prefijo y los tipos de dato de Oracle (OracleDbType)

                Guardar_Tarea.Parameters.Add(":id", OracleDbType.Int32);
                Guardar_Tarea.Parameters.Add(":Titulo", OracleDbType.NVarchar2);
                Guardar_Tarea.Parameters.Add(":Fecha_Inicio", OracleDbType.Date);
                Guardar_Tarea.Parameters.Add(":Hora_Inicio", OracleDbType.Varchar2); // No hay tipo TIME, se usa Varchar2
                Guardar_Tarea.Parameters.Add(":Fecha_Entrega", OracleDbType.Date);
                Guardar_Tarea.Parameters.Add(":Hora_Entrega", OracleDbType.Varchar2); // No hay tipo TIME, se usa Varchar2
                Guardar_Tarea.Parameters.Add(":Materia", OracleDbType.NVarchar2);
                Guardar_Tarea.Parameters.Add(":Dificultad", OracleDbType.Int32);
                Guardar_Tarea.Parameters.Add(":Tema_Tarea", OracleDbType.NVarchar2);
                Guardar_Tarea.Parameters.Add(":Completado", OracleDbType.Int32);    // No hay tipo BIT, se usa un número (0 o 1)

                // --- ASIGNANDO VALORES A LOS PARÁMETROS ---
                // Se accede a los parámetros usando el prefijo ":"

                Guardar_Tarea.Parameters[":id"].Value = ID;
                Guardar_Tarea.Parameters[":Titulo"].Value = txtTitulo_Tarea.Text;
                Guardar_Tarea.Parameters[":Fecha_Inicio"].Value = DateTime.Today; // ✨ Mejor práctica: enviar el objeto DateTime directamente
                Guardar_Tarea.Parameters[":Hora_Inicio"].Value = DateTime.Now.ToString("HH:mm:ss");
                Guardar_Tarea.Parameters[":Fecha_Entrega"].Value = dtpFecha_Entrega.Value; // ✨ Mejor práctica: usar .Value en lugar de .Text
                Guardar_Tarea.Parameters[":Hora_Entrega"].Value = cbHoras.Text + ":" + cbMinutos.Text + ":00";
                Guardar_Tarea.Parameters[":Materia"].Value = cbMateria.Text;
                Guardar_Tarea.Parameters[":Dificultad"].Value = Dificultad;
                Guardar_Tarea.Parameters[":Tema_Tarea"].Value = cbTema_Tarea.Text;
                Guardar_Tarea.Parameters[":Completado"].Value = 0;


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
