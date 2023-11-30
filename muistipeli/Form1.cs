using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace muistipeli
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 };
        string choice1;
        string choice2;
        int Tries;
        List<PictureBox> pictures = new List<PictureBox>();
        PictureBox picA;
        PictureBox picB;
        int matches;
        int timeTotal = 30;
        int countDown;
        bool gameOver = false;

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
            lblTime.Text = "Aikaa jäljellä: " + countDown;

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
            btnStart.Enabled = true;
            btnRestart.Enabled = false;
            GameTime.Enabled = false;
            btnSave.Enabled = false;
            Tries = 0;
            matches = 0;
        }

        private void LoadPicture()
        {
            int LeftPosition = 20;
            int TopPosition = 20;
            int rows = 0;

            for (int Size = 0; Size < 12; Size++)
            {
                PictureBox NewPic = new PictureBox();
                NewPic.Height = 50;
                NewPic.Width = 50;
                NewPic.SizeMode = PictureBoxSizeMode.StretchImage;
                NewPic.BackColor = Color.LightSlateGray;
                NewPic.Click += NewPic_Click;
                pictures.Add(NewPic);

                if (rows < 3)
                {
                    rows++;
                    NewPic.Left = LeftPosition;
                    NewPic.Top = TopPosition;
                    this.Controls.Add(NewPic);
                    LeftPosition = LeftPosition + 60;

                }

                if (rows == 3)
                {
                    rows = 0;
                    LeftPosition = 20;
                    TopPosition = TopPosition + 60;

                }
            }
            RestartGame();
        }

        private void NewPic_Click(object sender, EventArgs e)
        {
            if (gameOver || btnRestart.Enabled == false)
            {
                return;
            }
            if (choice1 == null)
            {
                picA = sender as PictureBox;
                if (picA.Tag != null && picA.Image == null)
                {
                    picA.Image = Image.FromFile("pics/" + (string)picA.Tag + ".png");
                    choice1 = (string)picA.Tag;
                }
            }
            else if (choice2 == null)
            {
                picB = sender as PictureBox;
                if (picB.Tag != null && picB.Image == null)
                {
                    picB.Image = Image.FromFile("pics/" + (string)picB.Tag + ".png");
                    choice2 = (string)picB.Tag;
                }
            }
            else
            {
                CheckPicture(picA, picB);
            }

        }

        private void RestartGame()
        {

        }

        private void CheckPicture(PictureBox A, PictureBox B)
        {
            if (choice1 == choice2)
            {
                A.Tag = null;
                B.Tag = null;
                matches++;
                lblMatch.Text = "Löydetyt parit: " + matches;
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
            lblTime.Text = "Aikaa jäljellä: " + timeTotal;
            lblMatch.Text = "Löydetyt parit: " + matches;
            gameOver = false;
            GameTime.Start();
            countDown = timeTotal;

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            GameTime.Enabled = true;

        }

        private void StartClick(object sender, MouseEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "KeskitasonMuistipelinTulos.txt");

            StringBuilder resultData = new StringBuilder();
            resultData.AppendLine(lblTime.Text);
            resultData.AppendLine(lblStatus.Text);
            resultData.AppendLine(lblMatch.Text);

            File.WriteAllText(filePath, resultData.ToString());
        }

        private void btnDiff_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 form2 = Application.OpenForms.OfType<Form2>().FirstOrDefault();

            if (form2 == null)
            {
                form2 = new Form2();
            }
            form2.Show();
        }
    }
}
