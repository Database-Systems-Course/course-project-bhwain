/*CREATE TABLE Admin (
  idAdmin INTEGER, --UNSIGNED NOT NULL AUTO_INCREMENT,
  Name TEXT NULL,
  Designation TEXT NULL,
  Email TEXT NULL,
  Password_2 VARCHAR(45) NULL,
  PRIMARY KEY(idAdmin)
);

CREATE TABLE Customers (
  idCustomers INTEGER,-- UNSIGNED NOT NULL AUTO_INCREMENT,
  Name TEXT NULL,
  EmailID VARCHAR(50) NULL,
  CurrentBalance INTEGER,-- UNSIGNED NULL,
  Password_2 VARCHAR(45) NULL,
  PRIMARY KEY(idCustomers)
);

CREATE TABLE Developers (
  idDevelopers INTEGER,-- UNSIGNED NOT NULL AUTO_INCREMENT,
  DeveloperName TEXT NULL,
  CurrentBalance INTEGER,-- UNSIGNED NULL,
  Type_2 TEXT NULL,
  PRIMARY KEY(idDevelopers)
);

CREATE TABLE Employees (
  idEmployees INTEGER,-- UNSIGNED NOT NULL AUTO_INCREMENT,
  Developers_idDevelopers INTEGER,-- UNSIGNED NOT NULL,
  Name TEXT NULL,
  Designation TEXT NULL,
  Password_2 VARCHAR(45) NULL,
  PRIMARY KEY(idEmployees),
  INDEX Employees_FKIndex1(Developers_idDevelopers)
);

CREATE TABLE Game (
  Registration_ID INTEGER,-- UNSIGNED NOT NULL AUTO_INCREMENT,
  Genres_idGenres INTEGER,-- UNSIGNED NOT NULL,
  Developers_idDevelopers INTEGER, -- UNSIGNED NOT NULL,
  Title TEXT NULL,
  Price INTEGER, -- UNSIGNED NULL,
  PRIMARY KEY(Registration_ID),
  INDEX Game_FKIndex1(Developers_idDevelopers),
  INDEX Game_FKIndex2(Genres_idGenres)
);

CREATE TABLE Genres (
  idGenres INTEGER,-- UNSIGNED NOT NULL AUTO_INCREMENT,
  Name TEXT NULL,
  PRIMARY KEY(idGenres)
);

CREATE TABLE Owns (
  Game_Registration_ID INTEGER, -- UNSIGNED NOT NULL,
  Customers_idCustomers INTEGER, -- UNSIGNED NOT NULL,
  PRIMARY KEY(Game_Registration_ID, Customers_idCustomers),
  INDEX Game_has_Customers_FKIndex1(Game_Registration_ID),
  INDEX Game_has_Customers_FKIndex2(Customers_idCustomers)
);

CREATE TABLE Tags (
  Game_Registration_ID INTEGER,-- UNSIGNED NOT NULL,
  Tag TEXT NULL,
  INDEX Tags_FKIndex1(Game_Registration_ID)
);

CREATE TABLE Wishlist (
  Customers_idCustomers INTEGER,-- UNSIGNED NOT NULL,
  Game_Registration_ID INTEGER, -- UNSIGNED NOT NULL,
  PRIMARY KEY(Customers_idCustomers, Game_Registration_ID),
  INDEX Game_has_Customers_FKIndex1(Game_Registration_ID),
  INDEX Game_has_Customers_FKIndex2(Customers_idCustomers)
);

INSERT INTO Game([Registration_ID], [Title], [Developers_idDevelopers], [Price], [Genres_idGenres]) VALUES (1, 'WITCHER 3', 1, 7500, 1)
INSERT INTO Game([Registration_ID], [Title], [Developers_idDevelopers], [Price], [Genres_idGenres]) VALUES (2, 'PUBG', 2, 3000, 2)
INSERT INTO Game([Registration_ID], [Title], [Developers_idDevelopers], [Price], [Genres_idGenres]) VALUES (3, 'Fortnite', 3, 3000, 2)
INSERT INTO Game([Registration_ID], [Title], [Developers_idDevelopers], [Price], [Genres_idGenres]) VALUES (4, 'Dark Souls 3', 4, 7500, 1)
INSERT INTO Game([Registration_ID], [Title], [Developers_idDevelopers], [Price], [Genres_idGenres]) VALUES (5, 'Sonic', 5, 1500, 3)
INSERT INTO Game([Registration_ID], [Title], [Developers_idDevelopers], [Price], [Genres_idGenres]) VALUES (6, 'Age of Empires', 6, 1500, 4)
INSERT INTO Game([Registration_ID], [Title], [Developers_idDevelopers], [Price], [Genres_idGenres]) VALUES (7, 'NBA 2K20', 7, 8000, 5)
INSERT INTO Game([Registration_ID], [Title], [Developers_idDevelopers], [Price], [Genres_idGenres]) VALUES (8, 'Hitman 2', 8, 7500, 6)
INSERT INTO Game([Registration_ID], [Title], [Developers_idDevelopers], [Price], [Genres_idGenres]) VALUES (9, 'WWE 2K19', 7, 7500, 5)
INSERT INTO Game([Registration_ID], [Title], [Developers_idDevelopers], [Price], [Genres_idGenres]) VALUES (10, 'Cyberpunk 2077', 1, 8000, 1)
INSERT INTO Game([Registration_ID], [Title], [Developers_idDevelopers], [Price], [Genres_idGenres]) VALUES (11, 'Katana Zero', 9, 3000, 7)
INSERT INTO Game([Registration_ID], [Title], [Developers_idDevelopers], [Price], [Genres_idGenres]) VALUES (12, 'GRIS', 9, 3000, 3)
INSERT INTO Game([Registration_ID], [Title], [Developers_idDevelopers], [Price], [Genres_idGenres]) VALUES (13, 'Hotline Miami', 9, 3000, 6)
INSERT INTO Game([Registration_ID], [Title], [Developers_idDevelopers], [Price], [Genres_idGenres]) VALUES (14, 'Spec Ops: The Line', 7, 5000, 6)
INSERT INTO Game([Registration_ID], [Title], [Developers_idDevelopers], [Price], [Genres_idGenres]) VALUES (15, 'Project Swat', 10, 3000, 6)

INSERT INTO Genres(idGenres, Name) VALUES (1, 'Fantasy RPG')
INSERT INTO Genres(idGenres, Name) VALUES (2, 'Battle Royale')
INSERT INTO Genres(idGenres, Name) VALUES (3, 'Platformer')
INSERT INTO Genres(idGenres, Name) VALUES (4, 'Real-Time Strategy')
INSERT INTO Genres(idGenres, Name) VALUES (5, 'Sports')
INSERT INTO Genres(idGenres, Name) VALUES (6, 'Action')
INSERT INTO Genres(idGenres, Name) VALUES (7, 'Hack n Slash')

insert into Admin(idAdmin, Name, Designation, Email, Password_2) values (1, 'Sabah Ismail', 'Smut Artist', 'sabah@bootleger.org', 'i<3fanfic')
insert into Admin(idAdmin, Name, Designation, Email, Password_2) values (2, 'Affan Nemat', 'Unpaid Intern', 'affan@bootleger.org', '696969lol')
insert into Admin(idAdmin, Name, Designation, Email, Password_2) values (3, 'Ali Haider', 'Goddess', 'ali@bootleger.org', 'stopSabahPlis')

insert into Customers(idCustomers, Name, CurrentBalance, EmailID, Password_2) values (1, 'Ali Humza', 420, 'ali2@bootleger.org', 'death2DLD')
insert into Customers(idCustomers, Name, CurrentBalance, EmailID, Password_2) values (2, 'Saim Mahmood', 100000, 'darwin@bootleger.org', 'pokepopXD')
insert into Customers(idCustomers, Name, CurrentBalance, EmailID, Password_2) values (3, 'Gogiwan Oofnobi', 50, 'gogo@bootleger.org', 'uwuDesu:3')
insert into Customers(idCustomers, Name, CurrentBalance, EmailID, Password_2) values (4, 'Zain Nemat', 0, 'bitch@bootleger.org', 'daddyNoUWU')
insert into Customers(idCustomers, Name, CurrentBalance, EmailID, Password_2) values (5, 'Chinua Achebitch', 1000, 'chinnigan@bootleger.org', 'yAmIHere')

insert into Developers(idDevelopers, DeveloperName, CurrentBalance, Type_2) values (1, 'CD Projekt Red', 3000000, 'AAA')
insert into Developers(idDevelopers, DeveloperName, CurrentBalance, Type_2) values (2, 'Tencent Games', 100000, 'AAA')
insert into Developers(idDevelopers, DeveloperName, CurrentBalance, Type_2) values (3, 'Epic Games', 1000000, 'AAA')
insert into Developers(idDevelopers, DeveloperName, CurrentBalance, Type_2) values (4, 'Fromsoft', 2000000, 'AAA')
insert into Developers(idDevelopers, DeveloperName, CurrentBalance, Type_2) values (5, 'Sega', 10000, 'AAA')
insert into Developers(idDevelopers, DeveloperName, CurrentBalance, Type_2) values (6, 'Microsoooft', 1000000, 'AAA')
insert into Developers(idDevelopers, DeveloperName, CurrentBalance, Type_2) values (7, '2K', 500000, 'AAA')
insert into Developers(idDevelopers, DeveloperName, CurrentBalance, Type_2) values (8, 'IO Interactive', 1000000, 'AAA')
insert into Developers(idDevelopers, DeveloperName, CurrentBalance, Type_2) values (9, 'Devolver Digital', 1000000, 'Indie')
insert into Developers(idDevelopers, DeveloperName, CurrentBalance, Type_2) values (10, 'Bhwain', 0, 'Indie')

insert into Employees(idEmployees, Name, Developers_idDevelopers, Designation, Email, Password_2) values (1, 'Shadownite1st', 10, 'Code_Monkey', 'ali3@bootleger.org', 'ohNu:P')
insert into Employees(idEmployees, Name, Developers_idDevelopers, Designation, Email, Password_2) values (2, 'PajamaLlama', 10, 'Zesty Meme Supreme', 'baffan@bootleger.org', 'wtfSabah1997')
insert into Employees(idEmployees, Name, Developers_idDevelopers, Designation, Email, Password_2) values (3, 'Felis Catus', 10, 'Napper', 'catto@bootleger.org', 'zzz4eva')*/
--update Employees set Name = 'Oofmur', Developers_idDevelopers = 10, Designation = 'Oh no', Email = 'oof@bootleger.org', Password_2 = 'literallyDidNothing' where idEmployees = 4