CREATE TABLE Developers (
  idDevelopers INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  DeveloperName VARCHAR(40) NULL,
  CurrentBalance FLOAT NULL,
  PRIMARY KEY(idDevelopers)
);

CREATE TABLE Codes (
  Code VARCHAR(20) NOT NULL AUTO_INCREMENT,
  Amount FLOAT NULL,
  PRIMARY KEY(Code)
);

CREATE TABLE Admin (
  idAdmin INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  Name VARCHAR(40) NULL,
  Designation VARCHAR(30) NULL,
  Email VARCHAR(50) NULL,
  Password_2 VARCHAR(45) NULL,
  PRIMARY KEY(idAdmin)
);

CREATE TABLE Users (
  idCustomers INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  Developers_idDevelopers INTEGER UNSIGNED NULL,
  Name VARCHAR(40) NOT NULL,
  EmailID VARCHAR(50) NOT NULL,
  Current Balance FLOAT NULL,
  Password_2 VARCHAR(45) NOT NULL,
  Designation VARCHAR(30) NULL,
  PRIMARY KEY(idCustomers),
  INDEX Customers_FKIndex1(Developers_idDevelopers)
);

CREATE TABLE Game (
  Registration_ID INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  Developers_idDevelopers INTEGER UNSIGNED NOT NULL,
  Title VARCHAR(40) NULL,
  Price INTEGER UNSIGNED NULL,
  Description TEXT NULL,
  PRIMARY KEY(Registration_ID, Developers_idDevelopers),
  INDEX Game_FKIndex1(Developers_idDevelopers)
);

CREATE TABLE Wishlist (
  Users_idCustomers INTEGER UNSIGNED NOT NULL,
  Game_Registration_ID INTEGER UNSIGNED NOT NULL,
  Game_Developers_idDevelopers INTEGER UNSIGNED NOT NULL,
  PRIMARY KEY(Users_idCustomers, Game_Registration_ID, Game_Developers_idDevelopers),
  INDEX Game_has_Customers_FKIndex1(Game_Registration_ID, Game_Developers_idDevelopers),
  INDEX Game_has_Customers_FKIndex2(Users_idCustomers)
);

CREATE TABLE Owns (
  Game_Registration_ID INTEGER UNSIGNED NOT NULL,
  Users_idCustomers INTEGER UNSIGNED NOT NULL,
  Game_Developers_idDevelopers INTEGER UNSIGNED NOT NULL,
  PRIMARY KEY(Game_Registration_ID, Users_idCustomers, Game_Developers_idDevelopers),
  INDEX Game_has_Customers_FKIndex1(Game_Registration_ID, Game_Developers_idDevelopers),
  INDEX Game_has_Customers_FKIndex2(Users_idCustomers)
);


