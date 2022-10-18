IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Cursos] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NOT NULL,
    [DescricionCorta] nvarchar(280) NOT NULL,
    [DescricionLarga] nvarchar(max) NOT NULL,
    [PublicoObjetivo] nvarchar(max) NOT NULL,
    [Objetivo] nvarchar(max) NOT NULL,
    [Requisitos] nvarchar(max) NOT NULL,
    [Nivel] int NOT NULL,
    [CreatedBy] nvarchar(max) NOT NULL,
    [CreatedAt] datetime2 NOT NULL,
    [UpdateBy] nvarchar(max) NOT NULL,
    [UpdatedAt] datetime2 NULL,
    [DeletedAt] datetime2 NULL,
    [DeletedBy] nvarchar(max) NOT NULL,
    [IsDeleted] bit NOT NULL,
    CONSTRAINT [PK_Cursos] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221018015821_Create User Table', N'6.0.10');
GO

COMMIT;
GO

