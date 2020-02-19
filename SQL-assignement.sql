USE PoliticalParties
select * from person
-- (1) Remove all rows from Person, Country, PoliticalParties
DELETE FROM Person;
DELETE FROM Country;
DELETE FROM PoliticalParties

SET IDENTITY_INSERT Person ON 
INSERT INTO Person (Id, FirstName, LastName)
VALUES (5000, 'Jonas', 'Sjöstedt')
INSERT INTO Person (Id, FirstName, LastName)
VALUES (5001, 'Ebba', 'Busch Thor')
INSERT INTO Person (Id, FirstName, LastName)
VALUES (5002, 'Ulf', 'Kristersson')
-- (2) Add three people (Jonas, Ebba, Ulf)
SET IDENTITY_INSERT Person OFF

SET IDENTITY_INSERT PoliticalParties ON 
insert into PoliticalParties (Id, Name) values (5000, 'Väntsterpartiet')
insert into PoliticalParties (Id, Name) values (5001, 'Kristdemokraterna')
insert into PoliticalParties (Id, Name) values (5002, 'Moderaterna')
-- (3) Add three political parties 
SET IDENTITY_INSERT PoliticalParties OFF 
select * from Person
select  Person.Id, Name, FirstName, LastName from PoliticalParties join Person on PoliticalParties.Id = Person.Id
-- (4) Write a "select" which gives info about the political parties 
-- Verify that you get exactly the same result as in SQL-output.png
