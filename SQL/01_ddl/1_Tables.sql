
--USE MASTER
--GO
--DROP DATABASE LoLDatabase
--GO
CREATE DATABASE LoLDatabase;
GO
--USE LoLDatabase (if needed);


CREATE TABLE Region (
name			VARCHAR(50)			NOT NULL	PRIMARY KEY,		
emblem			VARCHAR(350)		NOT NULL
);


CREATE TABLE Champion (
name			VARCHAR(25)			NOT NULL	PRIMARY KEY,
gender			VARCHAR(6)			NOT NULL	CHECK(gender IN	('Male', 'Female', 'Other')),
description		VARCHAR(50),
species			VARCHAR(30)			NOT NULL,
region_name		VARCHAR(50)			FOREIGN KEY REFERENCES Region(name),
splashArt		VARCHAR(350)		NOT NULL,
quote			VARCHAR(200),
releaseDate		DATE				NOT NULL
);


CREATE TABLE Abilities (
champion_name		VARCHAR(25)		NOT NULL    FOREIGN KEY REFERENCES Champion(name)	PRIMARY KEY,

P_name				VARCHAR(50),
P_description		VARCHAR(MAX),

Q_name				VARCHAR(50),
Q_description		VARCHAR(MAX),

W_name				VARCHAR(50),
W_description		VARCHAR(MAX),

E_name				VARCHAR(50),
E_description		VARCHAR(MAX),	

R_name				VARCHAR(50),
R_description		VARCHAR(MAX),	
);


CREATE TABLE Tribes (
name			VARCHAR(50)			NOT NULL	PRIMARY KEY,
art				VARCHAR(350)		NOT NULL,		
description		VARCHAR(MAX),
region_name		VARCHAR(50)			NOT NULL	FOREIGN KEY REFERENCES Region(name)
);


CREATE TABLE Alternate_Universe (
name			VARCHAR(25)			NOT NULL	PRIMARY KEY,
skinLine		VARCHAR(50)			NOT NULL	UNIQUE,
art				VARCHAR(350)		NOT NULL,	
yearCreated		INT					NOT NULL
);


CREATE TABLE Stories (
title			VARCHAR(70)			NOT NULL	PRIMARY KEY,
author			VARCHAR(20)			NOT NULL,
link			VARCHAR(150)		NOT NULL	UNIQUE,
type 			VARCHAR(50)			NOT NULL,
universe_name	VARCHAR(25)			FOREIGN KEY REFERENCES Alternate_Universe(name)
);


CREATE TABLE Secrets (
title			VARCHAR(50)			NOT NULL	PRIMARY KEY,
image			VARCHAR(350)		NOT NULL,
description		VARCHAR(500)		NOT NULL	UNIQUE,
region_name		VARCHAR(50)			FOREIGN KEY REFERENCES Region(name)
);


CREATE TABLE Exists_On (
champion_name		VARCHAR(25)		NOT NULL    FOREIGN KEY REFERENCES Champion(name),
universe_name		VARCHAR(25)		NOT NULL	FOREIGN KEY REFERENCES Alternate_Universe(name),
												PRIMARY KEY (champion_name, universe_name)
);


CREATE TABLE Participates (
champion_name		VARCHAR(25)		NOT NULL    FOREIGN KEY REFERENCES Champion(name),
stories_title		VARCHAR(70)		NOT NULL	FOREIGN KEY REFERENCES Stories(title),
												PRIMARY KEY (champion_name, stories_title)
);

CREATE TABLE Admin (
username			VARCHAR(50)			NOT NULL	PRIMARY KEY,
hashPassword		varbinary(64)		NOT NULL,
);

