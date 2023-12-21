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
    public partial class Sanapeli : Form
    {
        readonly SoundPlayer soundPlayer = new SoundPlayer();
        public Sanapeli()
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SanapelinTulos.txt");
            InitializeComponent();
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length > 0)
                {
                    label1.Text = "Viimeisin tulos: " + lines[0];
                }
            }
            else
            {
                Console.WriteLine("Tiedostoa ei löytynyt.");
            }
            BtnNext.Enabled = false;
            btnSave.Enabled = false;
            labelScore.Text = "Pisteet: 0 / 15";
        }

        readonly string[] words = new[] {"Bengalintiikeri", "Käsirysy", "SpongeBob", "Viinatanssi", "Ylilauta",
            "Juustopuuro", "Kahvinkeitin", "Fanipuhelin", "Viina", "Kukkosoosi", "Keksi", "Fragile-X",
            "Olut", "Tabletti", "Rutles" };
        int index = 0;
        int score = 0;
        readonly Random random = new Random();


        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (index > 0)
            { ShowWord(); }
            CheckWord();
            if (index < words.Length - 1)
            {
                index++;
            }
            else
            {
                MessageBox.Show("Peli päättyi! Voit kokeilla peliä uudestaan tai tallentaa tuloksen.");
                BtnNext.Enabled = false;
                BtnStart.Enabled = true;
                btnSave.Enabled = true;

            }
            Word.Text= "";
            Word.Focus();
            soundPlayer.SoundLocation = soundPlayer.SoundLocation = "Sound/Click.wav";
            soundPlayer.Play();
            labelScore.Text = "Pisteet: " + score + " / 15";
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (index ==0)
            { ShowWord(); }
            BtnStart.Enabled = false;
            labelResult.Text = "";
            BtnNext.Enabled = true;
            index = 0;
            score = 0;
            soundPlayer.SoundLocation = soundPlayer.SoundLocation = "Sound/Click.wav";
            soundPlayer.Play();
        }

        private void Word_TextChanged(object sender, EventArgs e)
        {

        }
        public void ShowWord()
        {
            int position1 = random.Next(words[index].Length);
            int position2 = random.Next(words[index].Length);
            int position3 = random.Next(words[index].Length);

            string word = words[index];

            word = word.Remove(position1, 1).Insert(position1, "_");
            word = word.Remove(position2, 1).Insert(position2, "_");
            word = word.Remove(position3, 1).Insert(position3, "_");

            GuessLbl.Text = word;
        }
        public void CheckWord()
        {
            if(Word.Text.Equals(words[index]))
            {
                labelResult.Text = "Oikein";
                labelResult.BackColor = Color.Green;
                score++;
            }
            else
            {
                labelResult.Text = "Väärin";
                labelResult.BackColor = Color.Red;
            }
        }

        private void BtnDiff_Click(object sender, EventArgs e)
        {
            soundPlayer.SoundLocation = soundPlayer.SoundLocation = "Sound/Click.wav";
            soundPlayer.Play();
            this.Hide();

            Form5 form5 = Application.OpenForms.OfType<Form5>().FirstOrDefault() ?? new Form5();
            form5.Show();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            soundPlayer.SoundLocation = soundPlayer.SoundLocation = "Sound/Click.wav";
            soundPlayer.Play();
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SanapelinTulos.txt");

            StringBuilder resultData = new StringBuilder();
            resultData.AppendLine(labelScore.Text);

            File.WriteAllText(filePath, resultData.ToString());
        }

        private void Header_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void LabelScore_Click(object sender, EventArgs e)
        {

        }
    }
}
