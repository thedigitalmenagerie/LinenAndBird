CREATE TABLE dbo.Birds
	(
	Id uniqueidentifier NOT NULL Primary Key,
	Type int NOT NULL,
	Color varchar(25) NOT NULL,
	Size varchar(10) NOT NULL,
	Name varchar(50) NULL
	) 
Create Table dbo.Hats 
(
	Id uniqueidentifier NOT NULL Primary Key default(newid()),
	Designer varchar(200) NULL,
	Color varchar(25) NOT NULL,
	Style int NOT NULL,
)

Create Table dbo.Orders 
(
	Id uniqueidentifier NOT NULL Primary Key default(newid()),
	BirdId uniqueidentifier NOT NULL,
	HatId uniqueidentifier NOT NULL,
	Price decimal(18,2),
	CONSTRAINT FK_BirdId_BirdsID FOREIGN KEY (BirdId)
		REFERENCES dbo.Birds (Id),
	CONSTRAINT FK_HatId_HatsID FOREIGN KEY (HatId)
		REFERENCES dbo.Hats (Id)
)