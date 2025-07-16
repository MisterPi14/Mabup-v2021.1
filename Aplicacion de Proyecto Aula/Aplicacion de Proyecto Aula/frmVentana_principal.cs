using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;


using System.Diagnostics;           //Librerias para abrir el programa de videos
using System.Runtime.InteropServices;

namespace Agencia_de_viajes
{
    public partial class frmVentana_principal : Form
    {
        string Usuario = "", Contraseña = "", Nombre = "";
        //INSTANCIAS
        OracleConnection conn = new OracleConnection(@"Data Source=localhost:1521/XEPDB1;User Id=USR_MABUP;Password=123456789;");

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hwc, IntPtr hwp);
      
        public frmVentana_principal(string atrUsuario, string atrContraseña)
        {
            Usuario = atrUsuario;
            Contraseña = atrContraseña;

            InitializeComponent();
            OracleCommand Consulta_Datos = new OracleCommand();
            Consulta_Datos.Connection = conn;
            OracleDataReader Lector;

            conn.Open();
            Consulta_Datos.CommandText = "SELECT Nombre,Ap_Pat,Ap_Mat FROM tb_Usuarios WHERE Usuario = '" + Usuario + "' AND Contraseña  = '" + Contraseña + "'";
            Lector = Consulta_Datos.ExecuteReader();
            Lector.Read();
            Nombre = (Convert.ToString((Lector[0])) +" "+ Convert.ToString((Lector[1])) +" "+ Convert.ToString((Lector[2])));
            conn.Close();
            label2.Text = "Bienvenid@ "+ Nombre +" ¿Que deseas hacer?";
        }

        private void btnDesplazar_Click(object sender, EventArgs e)
        {
            if (paPanel_Opciones.Visible == false)
            {
                btnDesplazar.Text = "←";
                paPanel_Opciones.Visible = true;

                //DATOS
                lblNomUsuario.Text = Nombre;

            }
            else
            {
                btnDesplazar.Text = "≡";
                paPanel_Opciones.Visible = false;
            }

        }

        private void btnCerrar_sesion_Click(object sender, EventArgs e)
        {
            frmLogIn Cerrar_Sesion = new frmLogIn();
            Cerrar_Sesion.Show();
            this.Hide();
        }

        private void picGestionTareas_Click(object sender, EventArgs e)
        {
            frmGestor_Tareas Tareas = new frmGestor_Tareas(Usuario, Contraseña);
            Tareas.Show();
            this.Close();
        }



        private void picVideos_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = "Servicio_de_stream";
                p.Start();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            this.Close();
        }
    }
}
