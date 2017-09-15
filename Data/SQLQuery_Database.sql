CREATE TABLE [Candidato] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NOT NULL,
	[Email] nvarchar(50) NOT NULL,
	[HTML] int,
	[Javascript] int,
	[CSS] int,
	[Python] int,
	[Django] int,
	[Android] int,
	[Ios]int,
    CONSTRAINT [PK_Candidato] PRIMARY KEY (Id)
);
GO