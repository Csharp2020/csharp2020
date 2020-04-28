CREATE TABLE [Mediji] (
    [id] int NOT NULL IDENTITY,
    [naziv] varchar(120) NOT NULL,
    [vrsta] bit NOT NULL,
    CONSTRAINT [PK_Mediji] PRIMARY KEY ([id])
);
GO


CREATE TABLE [Prijatelji] (
    [id] int NOT NULL IDENTITY,
    [ime] varchar(50) NOT NULL,
    [prezime] varchar(50) NOT NULL,
    CONSTRAINT [PK_Prijatelji] PRIMARY KEY ([id])
);
GO


CREATE TABLE [Evidencije] (
    [prijatelji_id] int NOT NULL,
    [mediji_id] int NOT NULL,
    [datum_posudbe] date NOT NULL,
    [datum_vracanja] date NULL,
    CONSTRAINT [PK_Evidencije] PRIMARY KEY ([prijatelji_id], [mediji_id]),
    CONSTRAINT [FK_Evidencije_Mediji] FOREIGN KEY ([mediji_id]) REFERENCES [Mediji] ([id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Evidencije_Prijatelji] FOREIGN KEY ([prijatelji_id]) REFERENCES [Prijatelji] ([id]) ON DELETE NO ACTION
);
GO


CREATE INDEX [IX_Evidencije_mediji_id] ON [Evidencije] ([mediji_id]);
GO


