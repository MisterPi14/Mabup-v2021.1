using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;  //Libreria para la clase Stopwatch
using Oracle.ManagedDataAccess.Client;



namespace Agencia_de_viajes
{
    public partial class frmEstimado_de_tiempo : Form
    {
        //INSTANCIAS
        OracleConnection conn = new OracleConnection(@"Data Source=localhost:1521/XEPDB1;User Id=USR_MABUP;Password=123456789;");
        Stopwatch cronometro = new Stopwatch();

        //DATOS
        int ID = 00, Segundos=0, Minutos=0, Horas=0;
        

        public frmEstimado_de_tiempo(int id)
        {
            ID = id;
            InitializeComponent();
            btnSiguiente.Enabled = false;

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            cronometro.Restart();
            timer1.Enabled = true;
            cronometro.Start();
            btnIniciar.Enabled = false;
            btnDetener.Enabled = true;
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            btnSiguiente.Enabled = true;
            timer1.Enabled = false;
            cronometro.Stop();
            btnDetener.Enabled = false;
            btnIniciar.Enabled = true;
        }

        private void GuardarEstimado(TimeSpan tiempoEstimado)
        {
            // Usar 'using' asegura que la conexión se cierre incluso si hay un error
            using (OracleConnection conn = new OracleConnection(@"Data Source=localhost:1521/XEPDB1;User Id=USR_MABUP;Password=123456789;"))
            {
                try
                {
                    conn.Open();
                    // El comando también debe estar en un 'using'
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "UPDATE tb_Usuarios SET Estimado_de_tiempo = :estimado WHERE id = :id";

                        // Especifica el tipo de dato y el valor para cada parámetro
                        cmd.Parameters.Add(":estimado", OracleDbType.IntervalDS, tiempoEstimado, ParameterDirection.Input);
                        cmd.Parameters.Add(":id", OracleDbType.Int32, ID, ParameterDirection.Input);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar en la base de datos: " + ex.Message);
                }
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            TimeSpan estimado;

            if (checkBox1.Checked)
            {
                // Opción 1: Obtiene el TimeSpan directamente del cronómetro
                cronometro.Stop(); // Detiene el cronómetro antes de obtener el valor
                estimado = cronometro.Elapsed;
            }
            else if (checkBox2.Checked)
            {
                // Opción 2: Construye el TimeSpan a partir de los textos
                // Usar TryParse es más seguro para evitar errores de conversión
                int.TryParse(txtHoras.Text, out int horas);
                int.TryParse(txtMinutos.Text, out int minutos);
                int.TryParse(txtSegundos.Text, out int segundos);

                estimado = new TimeSpan(horas, minutos, segundos);
            }
            else
            {
                // Si no se seleccionó ninguna opción, muestra el aviso y termina
                lblAviso.Visible = true;
                return;
            }

            // Llama al método centralizado para guardar el TimeSpan en la base de datos
            GuardarEstimado(estimado);

            // Activa la animación de carga y el siguiente paso
            lblAviso.Visible = false;
            timer2.Enabled = true;
            lblCarga.Visible = true;
            picLoad.Visible = true;
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCronometro.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:000}", cronometro.Elapsed.Hours, cronometro.Elapsed.Minutes, cronometro.Elapsed.Seconds, cronometro.Elapsed.Milliseconds/10);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            frmLogIn Retorno = new frmLogIn();
            this.Hide();
            Retorno.Show();
            timer2.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (lblCronometro.Text == "00:00:00:000")
            {
                btnSiguiente.Enabled = false;
            }
                //Flechas Arriba
                lblFU_Meses.Visible = false;
                lblFU_Semanas.Visible = false;
                lblFU_Dias.Visible = false;

                //Flechas Abajo
                lblFD_Meses.Visible = false;
                lblFD_Semanas.Visible = false;
                lblFD_Dias.Visible = false;

                //Cajas de texto
                txtHoras.Visible = false;
                txtMinutos.Visible = false;
                txtSegundos.Visible = false;

                //Etiquetas lapsos
                lblMeses.Visible = false;
                lblSemanas.Visible = false;
                lblDias.Visible = false;

                //Cronometro
                lblCronometro.Visible = true;
                btnIniciar.Visible = true;
                btnDetener.Visible = true;
                checkBox2.Checked = false;

                //Boton Aceptar
                btnSiguiente.Visible = true;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (txtHoras.Text == "00" || txtMinutos.Text == "00" || txtSegundos.Text == "00")
            {
                btnSiguiente.Enabled = false;
            }
            
                 //Flechas Arriba
                lblFU_Meses.Visible = true;
                lblFU_Semanas.Visible = true;
                lblFU_Dias.Visible = true;

                //Flechas Abajo
                lblFD_Meses.Visible = true;
                lblFD_Semanas.Visible = true;
                lblFD_Dias.Visible = true;

                //Cajas de texto
                txtHoras.Visible = true;
                txtMinutos.Visible = true;
                txtSegundos.Visible = true;

                //Etiquetas lapsos
                lblMeses.Visible = true;
                lblSemanas.Visible = true;
                lblDias.Visible = true;

                //Cronometro
                lblCronometro.Visible = false;
                btnIniciar.Visible = false;
                btnDetener.Visible = false;
                checkBox1.Checked = false;

                //Boton Aceptar
                btnSiguiente.Visible = true;
           
        }

        private void lblFU_Dias_Click(object sender, EventArgs e)
        {
            if (Segundos <= 59)
            {
                Segundos++;
            }

            if (Segundos < 10)
            {
                txtSegundos.Text = Convert.ToString("0" + Segundos);
            }
            else
            {
                txtSegundos.Text = Convert.ToString(Segundos);
            }


            if (txtHoras.Text != "00" || txtMinutos.Text != "00" || txtSegundos.Text != "00")
            {
                btnSiguiente.Enabled = true;
            }
            else
            {
                btnSiguiente.Enabled = false;
            }
        }

        private void lblFD_Dias_Click(object sender, EventArgs e)
        {
            if (Segundos > 0)
            {
                Segundos--;
            }

            if (Segundos < 10)
            {
                txtSegundos.Text = Convert.ToString("0" + Segundos);
            }
            else
            {
                txtSegundos.Text = Convert.ToString(Segundos);
            }


            if (txtHoras.Text != "00" || txtMinutos.Text != "00" || txtSegundos.Text != "00")
            {
                btnSiguiente.Enabled = true;
            }
            else
            {
                btnSiguiente.Enabled = false;
            }
        }

        private void lblFU_Semanas_Click(object sender, EventArgs e)
        {
            if (Minutos <= 59)
            {
                Minutos++;
            }

            if (Minutos < 10)
            {
                txtMinutos.Text = Convert.ToString("0" + Minutos);
            }
            else
            {
                txtMinutos.Text = Convert.ToString(Minutos);
            }


            if (txtHoras.Text != "00" || txtMinutos.Text != "00" || txtSegundos.Text != "00")
            {
                btnSiguiente.Enabled = true;
            }
            else
            {
                btnSiguiente.Enabled = false;
            }
        }

        private void lblFD_Semanas_Click(object sender, EventArgs e)
        {
            if (Minutos > 0)
            {
                Minutos--;
            }

            if (Minutos < 10)
            {
                txtMinutos.Text = Convert.ToString("0" + Minutos);
            }
            else
            {
                txtMinutos.Text = Convert.ToString(Minutos);
            }


            if (txtHoras.Text != "00" || txtMinutos.Text != "00" || txtSegundos.Text != "00")
            {
                btnSiguiente.Enabled = true;
            }
            else
            {
                btnSiguiente.Enabled = false;
            }
        }

        private void lblFU_Meses_Click(object sender, EventArgs e)
        {
            if (Horas <= 23)
            {
                Horas++;
            }

            if (Horas < 10)
            {
                txtHoras.Text = Convert.ToString("0" + Horas);
            }
            else
            {
                txtHoras.Text = Convert.ToString(Horas);
            }



            if (txtHoras.Text != "00" || txtMinutos.Text != "00" || txtSegundos.Text != "00")
            {
                btnSiguiente.Enabled = true;
            }
            else
            {
                btnSiguiente.Enabled = false;
            }
        }

        private void lblFD_Meses_Click(object sender, EventArgs e)
        {
            if (Horas > 0)
            {
                Horas--;
            }

            if (Horas < 10)
            {
                txtHoras.Text = Convert.ToString("0" + Horas);
            }
            else
            {
                txtHoras.Text = Convert.ToString(Horas);
            }


            if (txtHoras.Text != "00" || txtMinutos.Text != "00" || txtSegundos.Text != "00")
            {
                btnSiguiente.Enabled = true;
            }
            else
            {
                btnSiguiente.Enabled = false;
            }
        }
    }
}
