using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;

namespace muistipeli
{
    public partial class Sanapeli : Form
    {
        readonly SoundPlayer soundPlayer = new SoundPlayer();
        public Sanapeli()
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SanapelinTulos.txt");
            InitializeComponent();
            BtnStart.Enabled = false;
            BtnNext.Enabled = true;
            btnSave.Enabled = false;
            words = words.OrderBy(x => random.Next()).ToArray();
            labelScore.Text = "Arvatut sanat: 0 / 15";
            ShowWord();
            if (index == 0)
            {
                timer1.Start();
            }
        }

        readonly string[] words = new[] {"Bengalintiikeri", "Käsirysy", "SpongeBob", "Viinatanssi", "Ylilauta",
            "Juustopuuro", "Kahvinkeitin", "Fanipuhelin", "Viina", "Kukkosoosi", "Keksi", "Fragile-X",
            "Olut", "Tabletti", "Rutles" };
        int index;
        int score;
        int round;
        int countUp;
        readonly Random random = new Random();

        private void BtnNext_Click(object sender, EventArgs e)
        {
            round++;
            CheckWord();

            if (round < words.Length)
            {
                index++;
                ShowWord();
            }
            else
            {
                MessageBox.Show("Peli päättyi! Voit kokeilla peliä uudestaan tai tallentaa tuloksen.");
                BtnNext.Enabled = false;
                BtnStart.Enabled = true;
                btnSave.Enabled = true;
            }
            if (round == 15)
            {
                timer1.Stop();
            }
            Word.Text = "";
            Word.Focus();
            soundPlayer.Play();
            labelScore.Text = "Arvatut sanat: " + score + " / 15";
            label1.Text = "Sana: " + round + " / 15";
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            BtnStart.Enabled = false;
            BtnNext.Enabled = true;
            labelResult.Text = "";
            score = 0;
            soundPlayer.SoundLocation = "Sound/Click.wav";
            soundPlayer.Play();
            round =0;
            index = 0;
            ShowWord();
            countUp = 0;
            lbltime.Text = "Aikaa mennyt: 0s";
            timer1.Start();
            btnSave.Enabled = false;
        }

            private void Word_TextChanged(object sender, EventArgs e)
        {

        }
        public void ShowWord()
        {
            Debug.WriteLine("ShowWord: index = " + index);
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
            if(Word.Text.ToLower(new CultureInfo("fi-FI")).Equals(words[index].ToLower(new CultureInfo("fi-FI"))))
            {
                labelResult.Text = "Oikein";
                labelResult.BackColor = Color.Green;
                score++;
                soundPlayer.SoundLocation = "Sound/Correct.wav";
            }
            else
            {
                labelResult.Text = "Väärin";
                labelResult.BackColor = Color.Red;
                soundPlayer.SoundLocation = "Sound/Incorrect.wav";
            }
        }

        private void BtnDiff_Click(object sender, EventArgs e)
        {
            soundPlayer.SoundLocation = "Sound/Click.wav";
            soundPlayer.Play();
            this.Hide();

            Form5 form5 = Application.OpenForms.OfType<Form5>().FirstOrDefault() ?? new Form5();
            form5.Show();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            soundPlayer.SoundLocation = "Sound/Click.wav";
            soundPlayer.Play();
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SanapelinTulos.txt");

            StringBuilder resultData = new StringBuilder();
            resultData.AppendLine(labelScore.Text);
            resultData.AppendLine(lbltime.Text);

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

        private void TimerEvent(object sender, EventArgs e)
        {
            countUp++;

            int minutes = countUp / 60;
            int seconds = countUp % 60;
            if (countUp >= 60)
            {
                lbltime.Text = "Aikaa mennyt: " + minutes + "m " + seconds + "s";
            }
            else
            {
                lbltime.Text = "Aikaa mennyt: " + seconds + "s";
            }
        }

        private void GuessLbl_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SanapelinTulos.txt");

            if (File.Exists(filePath))
            {
                try
                {
                    Process.Start("notepad.exe", filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tiedoston avaaminen epäonnistui: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Tiedostoa ei löydy.");
            }
        }

        private void BtnNext_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Paina siirtyäksesi seuraavaan sanaaan!", BtnNext);

        }

        private void BtnStart_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Paina kokeillaksesi uudestaan!", BtnStart);
        }

        private void Button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Paina jos haluat katsoa viimeisimmän tuloksen!", button1);
        }

        private void BtnSave_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Paina jos haluat tallentaa nykyisen tuloksen! Aikaisempi tulos korvaantuu uudella tuloksella!", btnSave);
        }
    }
}
