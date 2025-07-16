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
using System.Data.SqlClient;



namespace Agencia_de_viajes
{
    public partial class frmEstimado_de_tiempo : Form
    {
        //INSTANCIAS
        SqlConnection conn = new SqlConnection(@"Data Source=.; Initial Catalog=BD_Mabup; Integrated Security=True");
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

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    //CREANDO REGISTRO
                    cmd.CommandText = "UPDATE tb_Usuarios SET Estimado_de_tiempo ='" + lblCronometro.Text + "' WHERE id = " + ID;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    timer2.Enabled = true;
                    lblCarga.Visible = true;
                    picLoad.Visible = true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Exit();
                }
            }
            else if (checkBox2.Checked == true)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                //CREANDO REGISTRO
                cmd.CommandText = "UPDATE tb_Usuarios SET Estimado_de_tiempo ='" + txtHoras.Text +":"+ txtMinutos.Text +":"+ txtSegundos.Text + "' WHERE id = " + ID;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                timer2.Enabled = true;
                lblCarga.Visible = true;
                picLoad.Visible = true;

                cronometro.Stop();

            }
            else
            {
                lblAviso.Visible = true;
            }
           

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
