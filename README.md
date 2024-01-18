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
Lisätavoiteena on löytää kortit mahdollisimman vähillä yrityksillä tai nopeimalla ajalla.
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

Valikonvaihto koodi, jota käytetään esim. päävalikossa valitsemaan pelimuoto. Koodi myös toistaa äänen kun nappia painaa.

![PäävalikkoKoodi](https://github.com/Hamppi990/Muistipeli1/assets/87445182/da278d0e-96b3-407a-b19b-3fe6313ad8bb)

Tuloksen tallentaminen tiedostoon. Pelin loputtua pelaaja voi tallentaa tuloksensa "Omat tiedostot" kansioon. Koodi kirjoittaa tiedostoon pisteet ja ajan. (Koodi kirjoittaa myös muistipelissä käännettyjen korttien määrän.)

![tallennus](https://github.com/Hamppi990/Muistipeli1/assets/87445182/77736927-79a4-465b-8b4b-e83aa54a2811)

### Sanapeli
Sanapelissä käytettävien sanojen lista. Ruudulla arvattavat sanat ovat kirjoitettu tähän. (Rivi 33-35) Koodi myös tekee sanojen järjestyksestä satunnaisen joka kerta kun pelin käynnistää uudelleen. (Rivi 24 ja 40).

![sanalista](https://github.com/Hamppi990/Muistipeli1/assets/87445182/20909026-a8ca-418a-842f-f6ff743e9ffa)

Sanojen piilotus. Koodi poistaa sanasta kolme satunnaista kirjainta ja lisää niiden tilalle alaviivan "_".

![sanojenpiilotus](https://github.com/Hamppi990/Muistipeli1/assets/87445182/22692f10-fad1-4ebb-bd43-963eb971cee9)

Sanojen tarkastus koodi. Koodi tarkastaa onko pelaajan syöttämä sama kuin ruudulla oleva sana. Jos sana on sama, niin ruudulla näkyy teksti "Oikein" ja pelaaja saa yhden pisteen. Jos sana on eri, niin ruudulla näkyy teksti "Väärin" ja pelaaja ei saa pistettä.

![sanojen tarkastus](https://github.com/Hamppi990/Muistipeli1/assets/87445182/56542e0b-b3db-44d8-9830-b68ff25a3e00)

Tuloksen lukeminen tiedostosta. Pelin loputtua pelaaja voi lukea tuloksensa muistiosta, joka avautuu kun painaa "Katso viimeisin tulos" painiketta.

![tallennusSanapeli](https://github.com/Hamppi990/Muistipeli1/assets/87445182/11a688e8-3f5a-4fcb-90de-a5b3ff571cf8)


![ajanotto](https://github.com/Hamppi990/Muistipeli1/assets/87445182/539af7b6-e1b0-44e6-a16e-fc3bb5b96ca7)


## Jatkokehitysideat
- Muutaman löydetyn bugin korjaus, esimerkiksi välillä muutama muistipelin kortti ei käänny.
- Korttien kääntämisen tulisi olla sulavampaa muistipelissä, ja kun pelaaja on löytänyt kaikki korttiparit, pelin tulisi päättyä automaattisesti ilman tarvetta klikata ruutua uudelleen.
- Vinkki-systeemi sanapeliin, eli pelaaja voisi katsoa videon, jossa Niilo22 sanoo arvattavan sanan jossain lauseessa ja siten auttaa pelaajaa arvaamaan sanan. Video olisi integroitu Formsiin, eli pelaajan ei tarvitsisi poistua sovelluksesta.
