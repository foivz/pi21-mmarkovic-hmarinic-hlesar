# Naziv projekta
Aplikacija za upravljanje skladištem

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Marko Marković | mmarkovic@foi.hr | 0035208092 | mmarkovic101
Hrvoje Marinić | hmarinic@foi.hr | 0016129838 | hmarinic
Hrvoje Lesar | hlesar@foi.hr | 0016133479 | HrvojeLesar

## Opis domene
Aplikacija služi zaposlenicima u skladištu za praćenje robe na skladištu. Zaposlenici skladišta tijekom zaprimanja i izdavanja robe mogu izraditi potrebne dokumente čime se ažuriraju podaci o robi na skladištu. Aplikacija služi i za praćenje trenutnog stanja na skladištu, praćenje promjena na skladištu i prijavu potencijalnih problema koji se mogu javiti u tom procesu.

## Specifikacija projekta

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Login | Za pristup aplikaciji zaposlenik ili administrator se mora prijaviti svojim korisničkim imenom i lozinkom u aplikaciju i ovisno ulozi ima različite mogućnosti korištenja aplikacije. | Marko Marković
F02 | Registracija zaposlenika | Administrator ima mogućnost dodavanja novih zaposlenika u bazu podataka i generira korisničko ime i lozinku za tog zaposlenika. | Hrvoje Marinić
F03 | Unos robe | Korisnik aplikacije otvara sučelje za unos nove vrste robe, upisuje potrebne podatke o robi na za to određeno polje i podaci se pohranjuju u bazu podataka za daljnje korištenje. | Marko Marković
F04 | Pretraga robe na skladištu | Korisnik aplikacije ima mogućnost pretrage robe prema različitim uvjetima koje korisnik zadaje. | Hrvoje Lesar
F05 | Kreiranje primki | Korisnik aplikacije tijekom zaprimanja robe u kreira skladišnu primku, primka se pohranjuje i ažurira se stanje na skladištu. Isto tako, zaposlenik ima i pregled svih već prije kreiranih primki. | Hrvoje Lesar
F06 | Kreiranje izdatnica | Korisnik aplikacije tijekom izdavanja robe u kreira izdatnicu, izdatnica se pohranjuje i ažurira se stanje na skladištu. Isto tako, zaposlenik ima i pregled svih već prije kreiranih izdatnica. | Hrvoje Marinić
F07 | Ažuriranje stanja na skladištu | Korisnik aplikacije može ažurirati određene podatke o robi na skladištu, a podaci o svakoj promjeni se pohranjuju u bazu podataka. | Marko Marković
F08 | Adresiranje robe | Korisnik tijekom primitka robe na skladište u aplikaciju unosi lokaciju na koju je roba smještena(npr. skladište, prostorija, polica, kutija) i može pretraživati sav sadržaj koji se nalazi na odabranoj lokaciji | Hrvoje Lesar

## Tehnologije i oprema
.NET(VisualStudio), GitHub, VisualParadigm, SQL
