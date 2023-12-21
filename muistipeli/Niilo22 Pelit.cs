using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muistipeli
{
    public partial class Form5 : Form
    {
        readonly SoundPlayer soundPlayer = new SoundPlayer();
        public Form5()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            soundPlayer.SoundLocation = soundPlayer.SoundLocation = "Sound/Click.wav";
            soundPlayer.Play();
            this.Hide();

            Form2 form2 = Application.OpenForms.OfType<Form2>().FirstOrDefault() ?? new Form2();
            form2.Show();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            soundPlayer.SoundLocation = soundPlayer.SoundLocation = "Sound/Click.wav";
            soundPlayer.Play();
            this.Hide();

            Sanapeli form6 = Application.OpenForms.OfType<Sanapeli>().FirstOrDefault() ?? new Sanapeli();
            form6.Show();
        }

        private void Button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Paina aloittaaksesi muistipelin!", button1);
        }

        private void Button2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Paina aloittaaksesi sanapelin!", button2);
        }
    }
    }
