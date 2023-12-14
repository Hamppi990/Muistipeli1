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
    }
}
