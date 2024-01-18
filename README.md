# Niilo22 Pelit

## Sovelluksen käyttötarkoitus ja toiminta

Otin työkseni tehdä YouTubettaja "Niilo22" teemaisen muisti- ja sanapelin C#- kielellä. Alustana toimii Windows Forms. Muistipelissä on Niilo22:sta kuvia ja sanapelissä sanat liittyvät Niilo22:sen hauskohin heittoihin.
## Muistipelissä:
### Pelin kulku
Muistipelissä ideana on kääntää kaksi korttia kerrallaan yrittäen löytää kuvapareja.
Jos pelaaja löytää parin, se pysyy ruudulla ja pelaaja jatkaa pelaamista.
Jos ei, kortit käännetään takaisin kuvapuoli alaspäin.
### Tavoite
Pelaajan tavoitteena on löytää kaikki kuvaparit mahdollisimman vähillä yrityksillä ja aikaa käyttäen.
### Voittaminen
Peli päättyy, kun kaikki kuvaparit on löydetty.
Lisätavoitteena on löytää kortit mahdollisimman vähillä yrityksillä tai nopeimmalla ajalla.
Tuloksen voi tallentaa ja sitä voi myöhemmin tarkastella.

## Sanapelissä:
### Pelin kulku
Sanapelissä ideana on arvata ruudulla näkyvä sana vihjeen avulla.
Jos pelaaja arvaa sanan, tulee seuraava sana ja pelaaja saa pisteen.
Jos ei, niin peli näyttää seuraavan sanan, mutta pelaaja ei saa pistettä.
### Tavoite
Pelaajan tavoitteena on arvata mahdollisimman monta sanaa ja mahdollisimman nopeassa ajassa.
### Voittaminen
Peli päättyy, kun kaikki sanat on käyty läpi.
Tuloksen voi tallentaa ja sitä voi myöhemmin tarkastella.

## Vuokaavio sovelluksesta
![niilo22](https://github.com/Hamppi990/Muistipeli1/assets/87445182/63f99042-9cba-40d8-9b61-d116be47d42c)

## Sovelluksen esittely

Kun pelin käynnistää, käynnistyy päävalikko, josta sitten voi valita kumpaa peliä haluaa pelata.

![päävalikko](https://github.com/Hamppi990/Muistipeli1/assets/87445182/52e97181-927b-4e7c-9411-194d737d23a0)

Tältä näyttää kun pelaaja valitsee päävalikosta sanapelin ja peli on käynnissä.

![sanapeli](https://github.com/Hamppi990/Muistipeli1/assets/87445182/e315c7be-bd84-49b7-9200-15c79c864f1e)

Tältä näyttää kun sanapelin kaikki sanat on käyty läpi ja peli on ohi.
Pelin tuloksen voi tässä vaiheessa tallentaa tai pelin voi aloittaa alusta.

![sanapelivoitto](https://github.com/Hamppi990/Muistipeli1/assets/87445182/3a8ae0ce-ede4-4ee0-a0b6-8a067adcad57)

Tältä näyttää kun pelaaja valitsee päävalikosta muistipelin. Tässä valikossa voi valita muistipelissä olevan vaikeustason.
Helpossa vaikeustasossa on 2x5 ruudukko. Keksitasossa on 3x4 ruudukko. Vaikeassa vaikeustasossa on 4x4 ruudukko ja mukana on myös "pommi pari" minkä yhdistäessä, lopettaa pelin välittömästi.

![vaikeus](https://github.com/Hamppi990/Muistipeli1/assets/87445182/cb5a69e7-0d62-46a1-8826-8a752a4a16cd)

Tältä näyttää kun valitsee vaikeustasovalikosta helpon vaikeustason ja peli on käynnissä. 2x5 ruudukko.

![helppo](https://github.com/Hamppi990/Muistipeli1/assets/87445182/9585248a-2a63-44ba-b31c-fca05c7d6d93)

Tältä näyttää kun häviää minkä tahansa muistipelin. Pelin tuloksen voi tässä vaiheessa tallentaa tai pelin voi aloittaa alusta.

![häviö](https://github.com/Hamppi990/Muistipeli1/assets/87445182/12db1eff-65b7-468e-bf36-1acfddea6363)

Tältä näyttää kun valitsee vaikeustasovalikosta keskitason vaikeustason ja peli on käynnissä. 3x4 ruudukko.

![keskitaso](https://github.com/Hamppi990/Muistipeli1/assets/87445182/195dc649-16d0-4c5a-b389-1dc6b7a24ae8)

Tältä näyttää kun voittaa minkä tahansa muistipelin. Pelin tuloksen voi tässä vaiheessa tallentaa tai pelin voi aloittaa alusta.

![voitto](https://github.com/Hamppi990/Muistipeli1/assets/87445182/17e27296-479c-4c91-aae8-91cbb0328c77)

Tältä näyttää kun valitsee vaikeustasovalikosta vaikean vaikeustason ja peli on käynnissä. 4x4 ruudukko.

![vaikea](https://github.com/Hamppi990/Muistipeli1/assets/87445182/59c816ca-4f07-4979-ade6-0909738d1396)

Tältä näyttää kun vaikeassa vaikeustasossa yhdistää "pommiparin". Peli loppuu ja sen voi aloittaa sitten alusta.

![pommi](https://github.com/Hamppi990/Muistipeli1/assets/87445182/1762fe19-366d-4baf-86bb-3216bb28172b)



## Koodin esittely
### Yleinen

Valikonvaihto koodi, jota käytetään esim. päävalikossa valitsemaan pelimuoto. Koodi siis avaa uuden formsin ja piilottaa nykyisen.
``` C#
        private void Button1_Click(object sender, EventArgs e)
        {
            soundPlayer.SoundLocation = soundPlayer.SoundLocation = "Sound/Click.wav";
            soundPlayer.Play();
            this.Hide();

            Form2 form2 = Application.OpenForms.OfType<Form2>().FirstOrDefault() ?? new Form2();
            form2.Show();
        }
```
Tuloksen tallentaminen tiedostoon. Pelin loputtua pelaaja voi tallentaa tuloksensa "Omat tiedostot" kansioon. Koodi kirjoittaa tiedostoon pisteet ja ajan. (Koodi kirjoittaa myös muistipelissä käännettyjen korttien määrän.)
``` C#
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
```
### Sanapeli

Sanapelissä käytettävien sanojen lista. Ruudulla arvattavat sanat ovat kirjoitettu tähän. Koodi myös tekee sanojen järjestyksestä satunnaisen joka kerta, kun pelin käynnistää uudelleen.
``` C#

words = words.OrderBy(x => random.Next()).ToArray();

readonly string[] words = new[] {"Bengalintiikeri", "Käsirysy", "SpongeBob", "Viinatanssi", "Ylilauta",
    "Juustopuuro", "Kahvinkeitin", "Fanipuhelin", "Viina", "Kukkosoosi", "Keksi", "Fragile-X",
    "Olut", "Tabletti", "Rutles" };

readonly Random random = new Random();

```
Sanojen piilotus. Koodi poistaa sanasta kolme satunnaista kirjainta ja lisää niiden tilalle alaviivan "_".
``` C#
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
```
Sanojen tarkastus koodi. Koodi tarkastaa onko pelaajan syöttämä sama kuin ruudulla oleva sana. Jos sana on sama, niin ruudulla näkyy teksti "Oikein" ja pelaaja saa yhden pisteen. Jos sana on eri, niin ruudulla näkyy teksti "Väärin" ja pelaaja ei saa pistettä.
``` C#
public void CheckWord()
{
    if(Word.Text.Equals(words[index]))
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
```
Tuloksen lukeminen tiedostosta. Pelin loputtua pelaaja voi lukea tuloksensa muistiosta, joka avautuu kun painaa "Katso viimeisin tulos" painiketta.
``` C#
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
```
Ajanotto koodi. Koodi lisää "countUp" arvoon joka sekunti yhden pisteen. Ruudulla näkyy tulos alussa sekunteina ja kun pisteitä on yli 60, ruudulla näkyy aika minuutteina ja sekunteina.
``` C#
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
```
### Muistipeli

Pelin aloitus koodi. Koodi joka kierroksen alussa resetoi kuvien ominaisuudet ja tekee kuvien sijainnista satunnaisen joka kerta kun pelin aloittaa uudelleen. Koodi myös resetoi tuloksen ja aloittaa ajan.
``` C#
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
```
Kuvien lataaminen. Koodi asettaa ruudukon tasaisesti ruudulle, jonka taakse kuvat tulevat.
``` C#
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
```
Aikaraja koodi. Koodi miinustaa "countDown" arvosta joka sekunti yhden pisteen. Yhteensä aikaa on 30 sekuntia jokaisessa muistipelissä. Jos aika loppuu ennen kuin pelaaja on löytänyt kaikki parit, pelaaja häviää pelin. Koodi näyttää jäljellä olevat kortit pelaajalle.
``` C#
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
```

Korttien kääntämis koodi.
``` C#
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
            soundPlayer.SoundLocation = soundPlayer.SoundLocation = "Sound/cardFlip.wav";
            soundPlayer.Play();

```


Korttien tarkastaminen.
``` C#
        private void CheckPicture(PictureBox A, PictureBox B)
        {
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
```

**Vaikeassa muistipelissä:**

Pommin tarkastus koodi. Koodi tarkastaa onko pelaaja yhdistänyt "pommiparin", jos on niin peli päättyy.
``` C#
if (choice1 == "9" && choice2 == "9")
{

    foreach (PictureBox x in pictures)
        if (x.Tag != null)
        {
            x.Image = Image.FromFile("pics/" + (string)x.Tag + ".png");
        }
    soundPlayer.SoundLocation = soundPlayer.SoundLocation = "Sound/bomb.wav";
    soundPlayer.Play();
    GameOver1("Peli päättyi, koska yhdistit pommit! ");
    return;

}
```
## Jatkokehitysideat
- Muutaman löydetyn bugin korjaus, esimerkiksi välillä muutama muistipelin kortti ei käänny.
- Korttien kääntämisen voisi olla sulavampaa muistipelissä, ja kun pelaaja on löytänyt kaikki korttiparit, pelin tulisi päättyä automaattisesti ilman tarvetta klikata ruutua uudelleen.
- Vinkki-systeemi sanapeliin, eli pelaaja voisi katsoa videon, jossa Niilo22 sanoo arvattavan sanan jossain lauseessa ja siten auttaa pelaajaa arvaamaan sanan. Video olisi integroitu Formsiin, eli pelaajan ei tarvitsisi poistua sovelluksesta.
- Pelin taustalle voisi lisätä musiikkia.
