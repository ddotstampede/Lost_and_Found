USE master;
GO

-- 1. Datenbank löschen, falls vorhanden, und neu anlegen
IF DB_ID(N'LostAndFoundDB') IS NOT NULL
BEGIN
    ALTER DATABASE LostAndFoundDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE LostAndFoundDB;
END
GO

CREATE DATABASE LostAndFoundDB;
GO

USE LostAndFoundDB;
GO

-- 2. Tabellen erstellen

CREATE TABLE Customer (
    CustomerID  INT IDENTITY(1,1) PRIMARY KEY,
    Name        NVARCHAR(100) NOT NULL,
    Age         INT NOT NULL,
    Email       NVARCHAR(150) NOT NULL,
    Phonenumber NVARCHAR(50) NOT NULL,
    Adresse     NVARCHAR(200) NOT NULL
);

CREATE TABLE Employee (
    EmployeeID  INT IDENTITY(1,1) PRIMARY KEY,
    Name        NVARCHAR(100) NOT NULL,
    Age         INT NOT NULL
);

CREATE TABLE Item (
    ItemID      INT IDENTITY(1,1) PRIMARY KEY,
    Type        NVARCHAR(100) NOT NULL,
    Description NVARCHAR(255) NOT NULL
);

CREATE TABLE Ticket (
    TicketID    INT IDENTITY(1,1) PRIMARY KEY,
    Type        NVARCHAR(100) NOT NULL,
    Description NVARCHAR(255) NOT NULL,
    DateTime    DATETIME2 NOT NULL,
    IsOpen      BIT NOT NULL,
    CustomerID  INT NOT NULL,
    EmployeeID  INT NULL,
    ItemID      INT NULL,
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID),
    FOREIGN KEY (ItemID)     REFERENCES Item(ItemID)
);
GO

-- 3. Beispieldaten einfügen (5 Datensätze pro Tabelle)

INSERT INTO Customer (Name, Age, Email, Phonenumber, Adresse) VALUES
(N'Geralt', 55, N'geralt@rivia.com',       N'0171-1048596', N'Kovstrasse 576'),
(N'Tav Balge', 19, N'Tbalge@faerun.com', N'0151-1234567', N'Teststreet 123'),
(N'Bruce Wayne', 32, N'Bwayne@gotham.de',     N'0176-8844221', N'Lindenweg 14'),
(N'Okabe Rintarou', 41, N'Hkyouma@stgate.de',    N'0160-9922334', N'Bahnhofstrasse 8'),
(N'Klein Moretti', 27, N'Thefool@Tarclub.de',    N'0172-5566778', N'Marktplatz 3');

INSERT INTO Employee (Name, Age) VALUES
(N'Roche', 29),
(N'Sung Jiwoo', 28),
(N'Joe Kerr', 44),
(N'Christina Kurisu', 21),
(N'Dunn Smith', 38);

INSERT INTO Item (Type, Description) VALUES
(N'Schlüssel', N'Einzelner Schlüssel mit rotem Anhänger'),
(N'Geldbörse', N'Schwarze Ledergeldbörse'),
(N'Handy',     N'Blaues Smartphone mit Hülle'),
(N'Rucksack',  N'Grauer Wanderrucksack'),
(N'Brille',    N'Lesebrille im braunen Etui');

INSERT INTO Ticket (Type, Description, DateTime, IsOpen, CustomerID, EmployeeID, ItemID) VALUES
(N'Schlüssel', N'Haustürschlüssel auf dem Parkplatz verloren','2026-11-20T09:00:00', 0, 1, 1, 1)
GO

-- 4. Beispielausgabe mit SELECT und JOIN

SELECT
    t.TicketID,
    c.Name        AS Kunde,
    t.Type        AS Gesucht,
    t.Description AS TicketBeschreibung,
    t.IsOpen      AS IstOffen,
    e.Name        AS Mitarbeiter,
    i.Description AS PassendesFundstueck
FROM Ticket t
INNER JOIN Customer c ON t.CustomerID = c.CustomerID
LEFT JOIN Employee e  ON t.EmployeeID = e.EmployeeID
LEFT JOIN Item i      ON t.ItemID = i.ItemID;
GO