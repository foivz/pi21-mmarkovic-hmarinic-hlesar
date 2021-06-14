DROP TABLE RobaNaLokaciji;
DROP TABLE Lokacija;
DROP TABLE StavkeDokumenta;
DROP TABLE Roba;
DROP TABLE MjernaJedinica;
DROP TABLE Dokument;
DROP TABLE VrstaDokumenta;
DROP TABLE Korisnik;
DROP TABLE Uloga;

CREATE TABLE Uloga (
	Id INT PRIMARY KEY IDENTITY(1,1),
	Naziv VARCHAR(45)
);

CREATE TABLE Korisnik (
	Id INT PRIMARY KEY IDENTITY(1,1),
	IdUloga INT REFERENCES uloga(id),
	Ime VARCHAR(255),
	Prezime VARCHAR(255),
	OIB BIGINT,
	KontaktBroj VARCHAR(45),
	Email VARCHAR(45),
	KorisnickoIme VARCHAR(45),
	Lozinka VARCHAR(255),
	Status BIT,
	Adresa VARCHAR(255),
	Mjesto VARCHAR(255),
	IBAN VARCHAR(255)
);

CREATE TABLE VrstaDokumenta (
	Id INT PRIMARY KEY IDENTITY(1,1),
	Naziv VARCHAR(255)
);

CREATE TABLE Dokument (
	Id INT PRIMARY KEY IDENTITY(1,1),
	Vrsta INT REFERENCES VrstaDokumenta(id),
	Datum DATE,
	Klijent INT REFERENCES Korisnik(id),
	Unio INT REFERENCES Korisnik(id),
);

CREATE TABLE MjernaJedinica (
	Id INT PRIMARY KEY IDENTITY(1,1),
	Naziv VARCHAR(255),
	Kratica VARCHAR(5),
);

CREATE TABLE Roba (
	Id INT PRIMARY KEY IDENTITY(1,1),
	MjernaJedinica INT REFERENCES MjernaJedinica(id),
	Naziv VARCHAR(255),
	Opis VARCHAR(255),
);

CREATE TABLE StavkeDokumenta (
	IdDokument INT REFERENCES Dokument(id) ON DELETE CASCADE,
	IdRoba INT REFERENCES Roba(id) ON DELETE CASCADE,
	PRIMARY KEY (IdDokument, IdRoba),
	Kolicina INT,
	JedinicnaCijena FLOAT,
);

CREATE TABLE Lokacija (
	Id INT PRIMARY KEY IDENTITY(1,1),
	Naziv VARCHAR(255),
	Nadlokacija INT REFERENCES Lokacija(id),
);

CREATE TABLE RobaNaLokaciji (
	IdRoba INT REFERENCES Roba(id),
	IdLokacija INT REFERENCES Lokacija(id),
	PRIMARY KEY (IdRoba, IdLokacija),
	Kolicina INT,
);

INSERT INTO VrstaDokumenta (Naziv) VALUES ('Primka'), ('Izdatnica');

INSERT INTO Uloga (Naziv) VALUES ('Klijent'), ('Administrator');

INSERT INTO Korisnik (Prezime, Ime, IdUloga) VALUES ('Klijent 1', 'Test', 1), ('Klijent 2', 'Test', 1), ('Klijent 3', 'Test', 1);

INSERT INTO MjernaJedinica (Naziv, Kratica) VALUES ('Komad', 'kom'), ('Kilogram', 'kg'), ('Litra', 'l');

INSERT INTO Roba (Naziv, Opis, MjernaJedinica) VALUES ('Metalna sipka', '', 1), ('Gradevinski materijal', '', 1), ('Staro zeljezo', '', 2), ('Kutija', 'kartonska', 1);

INSERT INTO Lokacija (Naziv) VALUES ('Skladište 1'), ('Skladište 2'), ('Skladište 3');
INSERT INTO Lokacija (Naziv, Nadlokacija) VALUES ('Soba 1', 1), ('Soba 2', 1), ('Soba 3', 1), ('Soba 1', 2);
INSERT INTO Lokacija (Naziv, Nadlokacija) VALUES ('Polica 1', 4), ('Polica 1', 5), ('Polica 2', 5);
INSERT INTO Lokacija (Naziv, Nadlokacija) VALUES ('Kutija', 8), ('Kutija 1', 9), ('Kutija 2', 9);