using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Threading.Tasks;

namespace muistipeli
{
    public partial class Form1 : Form
    {
        readonly SoundPlayer soundPlayer = new SoundPlayer();
        List<int> numbers = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 };
        string choice1;
        string choice2;
        int Tries;
        readonly List<PictureBox> pictures = new List<PictureBox>();
        PictureBox picA;
        PictureBox picB;
        int matches;
        readonly int timeTotal = 30;
        int countDown;
        bool gameOver = false;
        bool clickLock = false;

        public Form1()
        {
            InitializeComponent();
            LoadPicture();
            btnRestart.Enabled = false;
            btnSave.Enabled = false;
        }

        private void TimerEvent(object sender, EventArgs e)
        {
            countDown--;
            progressBar1.Value = countDown;
            lblTime.Text = "Aikaa jäljellä: " + countDown + " / 30s";

            if (countDown < 1)
            {
                GameOver("Aika loppui, hävisit pelin :( ");

                foreach (PictureBox x in pictures)
                    if (x.Tag != null)
                    {
                        x.Image = Image.FromFile("pics/" + (string)x.Tag + ".png");
                    }
            }

        }

        private void RestartGameEvent(object sender, EventArgs e)
        {
            soundPlayer.SoundLocation = "Sound/Click.wav";
            soundPlayer.Play();

            RestartGame();

            btnStart.Enabled = false;
            btnRestart.Enabled = true;
            btnSave.Enabled = false;
        }

        private void LoadPicture()
        {
            int LeftPosition = 155;
            int TopPosition = 60;
            int rows = 0;

            for (int Size = 0; Size < 12; Size++)
            {
                PictureBox NewPic = new PictureBox
                {
                    Height = 50,
                    Width = 50,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BackColor = Color.LightSlateGray
                };
                NewPic.Click += NewPic_Click;
                pictures.Add(NewPic);

                if (rows < 3)
                {
                    rows++;
                    NewPic.Left = LeftPosition;
                    NewPic.Top = TopPosition;
                    Controls.Add(NewPic);
                    LeftPosition += 60;

                }

                if (rows == 3)
                {
                    rows = 0;
                    LeftPosition = 155;
                    TopPosition += 60;

                }
            }
            RestartGame();
        }

        private async void NewPic_Click(object sender, EventArgs e)
        {
            if (gameOver || btnRestart.Enabled == false || clickLock)
                return;


            if (!(sender is PictureBox clickedPic) || clickedPic.Image != null || clickedPic.Tag == null)
                return;

            clickedPic.Image = Image.FromFile("pics/" + (string)clickedPic.Tag + ".png");

            soundPlayer.SoundLocation = "Sound/cardFlip.wav";
            soundPlayer.Play();

            if (choice1 == null)
            {
                picA = clickedPic;
                choice1 = (string)clickedPic.Tag;
            }
            else if (choice2 == null && clickedPic != picA)
            {
                picB = clickedPic;
                choice2 = (string)clickedPic.Tag;

                clickLock = true;
                await Task.Delay(300);


                CheckPicture(picA, picB);

                await Task.Delay(200);
                clickLock = false;
            }
        }

        private void RestartGame()
        {
            GameTime.Stop();
            // resetoidaan muuttujat
            choice1 = null;
            choice2 = null;
            picA = null;
            picB = null;
            matches = 0;
            Tries = 0;
            gameOver = false;
            clickLock = false;

            lblMatch.Text = "Löydetyt parit: 0 / 7";
            lblStatus.Text = "Käännetyt kortit: 0";
            lblTime.Text = "Aikaa jäljellä: " + timeTotal + " / 30s";

            countDown = timeTotal;
            progressBar1.Value = countDown;

            numbers = numbers.OrderBy(x => Guid.NewGuid()).ToList();

            for (int i = 0; i < pictures.Count; i++)
            {
                pictures[i].Image = null;
                pictures[i].Tag = numbers[i].ToString();
                pictures[i].BackColor = Color.LightSlateGray;
            }

            GameTime.Start();
        }

        private void CheckPicture(PictureBox A, PictureBox B)
        {
            if (A == null || B == null)
                return;
            if (choice1 == choice2)
            {
                A.Tag = null;
                B.Tag = null;
                matches++;
                Tries++;
                lblMatch.Text = "Löydetyt parit: " + matches + " / 6";
                lblStatus.Text = "Käännetyt kortit: " + Tries;
            }
            else
            {
                Tries++;
                lblStatus.Text = "Käännetyt kortit: " + Tries;
            }

            choice1 = null;
            choice2 = null;
            foreach (PictureBox pics in pictures.ToList())
            {
                if (pics.Tag != null)
                {
                    pics.Image = null;
                }
            }

            if (pictures.All(o => o.Tag == pictures[0].Tag))
            {
                GameOver("Löysit kaikki parit! Hienoa!");


            }

        }

        private void GameOver(string msg)
        {
            GameTime.Stop();
            gameOver = true;
            MessageBox.Show(msg + " Voit kokeilla peliä uudestaan tai tallentaa tuloksen.");
            btnSave.Enabled = true;
        }

        private void StartGameEvent(object sender, EventArgs e)
        {
            soundPlayer.SoundLocation = soundPlayer.SoundLocation = "Sound/Click.wav";
            soundPlayer.Play();
            btnStart.Enabled = false;
            btnRestart.Enabled = true;
            matches = 0;
            var randomList = numbers.OrderBy(x => Guid.NewGuid()).ToList();

            numbers = randomList;

            for (int i = 0; i < pictures.Count; i++)
            {
                pictures[i].Image = null;
                pictures[i].Tag = numbers[i].ToString();
            }

            Tries = 0;
            lblStatus.Text = "Käännetyt kortit: " + Tries;
            lblTime.Text = "Aikaa jäljellä: " + timeTotal + " / 30s";
            lblMatch.Text = "Löydetyt parit: " + matches + " / 6";
            gameOver = false;
            GameTime.Start();
            countDown = timeTotal;

        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            GameTime.Enabled = true;

        }

        private void StartClick(object sender, MouseEventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            soundPlayer.SoundLocation = soundPlayer.SoundLocation = "Sound/Click.wav";
            soundPlayer.Play();
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "KeskitasonMuistipelinTulos.txt");

            StringBuilder resultData = new StringBuilder();
            resultData.AppendLine(lblTime.Text);
            resultData.AppendLine(lblStatus.Text);
            resultData.AppendLine(lblMatch.Text);

            File.WriteAllText(filePath, resultData.ToString());
        }

        private void BtnDiff_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 form2 = Application.OpenForms.OfType<Form2>().FirstOrDefault() ?? new Form2();
            form2.Show();
            btnStart.Enabled = true;
            btnRestart.Enabled = false;
            GameTime.Enabled = false;
            btnSave.Enabled = false;
            Tries = 0;
            matches = 0;
            soundPlayer.SoundLocation = soundPlayer.SoundLocation = "Sound/Click.wav";
            soundPlayer.Play();
        }

        private void BtnStart_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Paina aloittaaksesi!", btnStart);
        }

        private void BtnRestart_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Paina kokeillaksesi uudestaan!", btnRestart);
        }

        private void BtnDiff_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Paina valitaksesi vaikeustason!", btnDiff);
        }

        private void BtnSave_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Paina jos haluat tallentaa nykyisen tuloksen! Aikaisempi tulos korvaantuu uudella tuloksella! Löydät tallenetun tuloksen vaikeustaso valikosta tai omista tiedostoista!", btnSave);
        }
    }
}
