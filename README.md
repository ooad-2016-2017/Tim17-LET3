# Tim17 - LET3

## MyPub

Članovi Tima:

1. Tin Vidović

2. Lamija Hasanagić

3. Edna Fazlagić


## Opis teme:

Aplikacija MyPub je namijenjena da poboljša interakciju između mušterija jednog pub-a i njegovih zaposlenika. Aplikacija ovo treba da postigne user-friendly sučeljem koje omogućava jednostavnu rezervaciju stolova, signalizaciju narudžbe ( kroz specijalno dizajniran uređaj ) kao i svojevrstan jukebox mušterijama. Aplikacija će također pojednostaviti proces narudžbi kao i proces nabavke pića zaposlenicima i menadžeru pub-a.

## Procesi:

###### Registracija/Prijava

Svaki korisnik aplikacije (u zavisnosti od tipa korisnika) ima mogućnost prijave sa ličnim podacima (username i password). Također novim mušterijama je omogućena registracija novog računa.

###### Registracija/Zapošljavanje osoblja

Registraciju, pregled, ažuriranje i brisanje novog osoblja te promociju mušterija u VIP obavlja administrator (menadžer). Registraciju/Zapošljavanje osoblja vrši menadžer iz svoje forme, popunjavanjem adekvatnih ličnih podataka, kao i podataka o plati zaposlenika.

###### Rezervacija

Korisniku je omogućeno da putem aplikacije pristupi mapi raspoloživih stolova za određeni dan i nakon unosa informacija rezerviše dati stol. Odabrani stol se oslobađa ukoliko mušterija kasni više od 15 minuta od vremena za koji je stol rezervisan. Ukoliko se mušterija pojavi u zakazano vrijeme zaposlenik potvrđuje rezervaciju i stol se označava kao zauzet.

###### Naručivanje

Uz pomoć posebno dizajniranog uređaja korisnik signalizira zaposlenicima da je spreman izvršiti narudžbu, nakon čega zaposlenik obračunava istu te se ažurira stanje pića u bazi podataka i eventualno šalje obavijest menadžeru da treba izvršiti narudžbu pića.

###### Plaćanje

Prilikom svake narudžbe zaposlenik vodi istu za jedan od stolova, dok mušterije imaju mogućnost da vide total koji treba platiti. Također mušterije imaju i opciju da plate elektronskim putem, nakon čega se otvara adekvatna forma za unos podataka.

###### Nabavka

O nestanku ili smanjenju preostale količine određenog pića se automatski obavještava menadžer, koji zatim ima mogućnost popunjavanja forme za narudžbu sa namirnicama koje nedostaju.

###### Jukebox

U sklopu aplikacije nalazi se i svojevrstan jukebox. Zaposlenicima je omogućeno kreiranje playlist-i i odabir jedne za datu večer. Mušterije mogu glasati za pjesme sa playlist-e, nakon čega se pušta pjesma s najviše glasova. Na taj način mušterije mogu da učestvuju u odabiru muzike. 

## Funkcionalnosti:

- Kreiranje korisničkog računa
- Kreiranje korisničkog računa za zaposlenike od strane menadžera
- Ažuriranje i brisanje korisničkih računa za zaposlenike od strane menadžera
- Prijava na sistem sa kreiranim korisničkim računom za različite vrste korisnika
- Rezervacija stolova
- Elektronsko plaćanje
- Jukebox
- Pregled menija 
- Signalizacija narudžbe
- Izdavanje narudžbe
- Kreiranje playlist-i
- Osvježavanje zaliha

## Akteri:

1. Mušterija - Mušterija je gost pub-a.Mušterija ima mogućnost rezervacije, naručivanja i korištenja jukebox-a. Mušterija također može biti i VIP gost i kao takva ima određene popuste.
2. Zaposlenik - Zaposlenik je osoba koja ima mogućnost da vidi sve narudžbe, upravlja rezervacijama, vrši izdavanje narudžbi te ima mogućnost kreiranja i biranja playlist-i.
3. Menadžer - Menadžer je vlasnik lokala, ima mogućnost zapošljavanja radnika, otpuštanja radnika, u slučaju nestanka zaliha popunjava formu za narudžbu istih.
4. Sistem za plaćanje - Eksterni sistem koji omogućava korisniku plaćanje elektronskim putem.