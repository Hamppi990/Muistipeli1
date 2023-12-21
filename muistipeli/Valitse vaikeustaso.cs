using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace muistipeli
{
    public partial class Form2 : Form
    {
        readonly SoundPlayer soundPlayer = new SoundPlayer();

        public Form2()
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "KeskitasonMuistipelinTulos.txt");
            InitializeComponent();
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length > 0)
                {
                    lblTime2.Text = lines[0];
                    lblStatus2.Text = lines[1];
                    lblMatch2.Text = lines[2];
                }
            }
            else
            {
                Console.WriteLine("Tiedostoa ei löytynyt.");
            }
            string filePath1 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "HelponMuistipelinTulos.txt");
            InitializeComponent();
            if (File.Exists(filePath1))
            {
                string[] lines = File.ReadAllLines(filePath1);
                if (lines.Length > 0)
                {
                    lblTime.Text = lines[0];
                    lblStatus.Text = lines[1];
                    lblMatch.Text = lines[2];
                }
            }
            else
            {
                Console.WriteLine("Tiedostoa ei löytynyt.");
            }
            string filePath2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "VaikeanMuistipelinTulos.txt");
            InitializeComponent();
            if (File.Exists(filePath2))
            {
                string[] lines = File.ReadAllLines(filePath2);
                if (lines.Length > 0)
                {
                    lblTime3.Text = lines[0];
                    lblStatus3.Text = lines[1];
                    lblMatch3.Text = lines[2];
                }
            }
            else
            {
                Console.WriteLine("Tiedostoa ei löytynyt.");
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            soundPlayer.SoundLocation = soundPlayer.SoundLocation = "Sound/Click.wav";
            soundPlayer.Play();
            this.Hide();

            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault() ?? new Form1();
            form1.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            soundPlayer.SoundLocation = soundPlayer.SoundLocation = "Sound/Click.wav";
            soundPlayer.Play();
            this.Hide();

            Form4 form4 = Application.OpenForms.OfType<Form4>().FirstOrDefault() ?? new Form4();
            form4.Show();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            soundPlayer.SoundLocation = soundPlayer.SoundLocation = "Sound/Click.wav";
            soundPlayer.Play();
            this.Hide();

            Form3 form3 = Application.OpenForms.OfType<Form3>().FirstOrDefault() ?? new Form3();
            form3.Show();
        }

        private void Vaikeustaso_Click(object sender, EventArgs e)
        {

        }

        private void BtnMed_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Paina valitaksesi keskitason vaikeustason!", btnMed);
        }

        private void Button3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Paina valitaksesi vaikean vaikeustason!", button3);
        }

        private void Button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Paina valitaksesi helpon vaikeustason!", button1);
        }

        private void BtnDiff_Click(object sender, EventArgs e)
        {
            soundPlayer.SoundLocation = soundPlayer.SoundLocation = "Sound/Click.wav";
            soundPlayer.Play();
            this.Hide();

            Form5 form5 = Application.OpenForms.OfType<Form5>().FirstOrDefault() ?? new Form5();
            form5.Show();
        }
    }
}
