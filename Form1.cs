using System;
using System.Drawing;
using System.Speech.Synthesis;
using System.Data;
using System.Windows.Forms;

namespace TAPU2_Ejemplo11
{
    public partial class frmEjecucion : Form
    {
        Button button = new Button();
        public frmEjecucion()
        {
            InitializeComponent();
        }

        private void btnCrearControl_Click(object sender, EventArgs e)
        {
            //Crear controles, en tiempo de ejecucion 
            //Istanciar una clase de tipo Button
            
            button.Name = "btn1";
            button.Text = "Soy nuevo";
            button.Top = this.Height / 2;
            button.Left = this.Width / 2;
            button.Height = 50;
            button.Width = 90;
            button.FlatStyle = FlatStyle.Flat;
            //Este control hay que ponerlo en el form1
            this.Controls.Add(button);
            //asociar el button al evento
            button.Click+=new EventHandler(btn1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(button);
        }

        private void btn1_Click(object sender, EventArgs eventArgs)
        {
            this.BackColor = Color.Aqua;
            MessageBox.Show("Ya jala este botonsillo");
        }

        private void frmEjecucion_Load(object sender, EventArgs e)
        {
            lblCantidad.Text = tbCantidad.Value.ToString();
        }

        private void tbCantidad_Scroll(object sender, EventArgs e)
        {
            lblCantidad.Text = tbCantidad.Value.ToString();
        }

        private void btnCrearCajas_Click(object sender, EventArgs e)
        {
            //crear las cajas 
            byte CantidadDeCajas = Convert.ToByte( tbCantidad.Value); //convierte byte por byte
            //o hacer un casteo    byte CantidadDeCajas = (byte)tbCantidad.Value; es como si lo maquillara para que se vea como un int pero no lo convierte en si 
            for (int i = 0; i < CantidadDeCajas; i ++)
            {
                TextBox txtControl = new TextBox();
                txtControl.Name = "txt" + " " + i.ToString();
                txtControl.Tag = i;
                txtControl.Size = new Size(60, 15);
                txtControl.Location = new Point(ClientSize.Width / 2, 25 * (i+1));
                txtControl.Text = txtControl.Name;
                this.Controls.Add(txtControl);

                //asociarlo a un evento
                txtControl.Click += new EventHandler(txtClick);
            }
        }
        //metodo para usar las cajas
        public void txtClick(object sender, EventArgs e)
        {
           string speech = string.Format("El nombre del control es:" + ((TextBox)sender).Tag.ToString());
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            while(true)
            {
                speechSynthesizer.Speak(speech);
            }
           // MessageBox.Show("Control:" + ((TextBox)sender).Tag.ToString());
        }

        private void frmEjecucion_DoubleClick(object sender, EventArgs e)
        {
            //capturar la pantalla de SO
            Bitmap screen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            using (Graphics g = Graphics.FromImage(screen))
            {
                //con el CopyFromScreen convierte el codigo de la imagen en imagen para poder viasualizarla 
                g.CopyFromScreen(0, 0, 0, 0, screen.Size);
            }
            pictureBox1.Image = screen;
        }
    }
}
