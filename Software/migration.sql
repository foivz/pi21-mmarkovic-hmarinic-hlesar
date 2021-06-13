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
	IdDokument INT REFERENCES Dokument(id),
	IdRoba INT REFERENCES Roba(id),
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
