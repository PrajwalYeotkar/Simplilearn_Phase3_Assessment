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

CREATE TABLE [Carousels] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NULL,
    [ImageURL] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    CONSTRAINT [PK_Carousels] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Laptops] (
    [Id] int NOT NULL IDENTITY,
    [ModelName] nvarchar(max) NOT NULL,
    [Price] nvarchar(max) NULL,
    [Image] nvarchar(max) NULL,
    [Brand] nvarchar(max) NULL,
    [RamSize] nvarchar(max) NULL,
    [CPUModel] nvarchar(max) NULL,
    [ScreenSize] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    CONSTRAINT [PK_Laptops] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Orders] (
    [Id] int NOT NULL IDENTITY,
    [LaptopId] int NOT NULL,
    [ClientName] nvarchar(max) NOT NULL,
    [Street] nvarchar(max) NULL,
    [City] nvarchar(max) NOT NULL,
    [State] nvarchar(max) NOT NULL,
    [Country] nvarchar(max) NOT NULL,
    [Zip] nvarchar(max) NOT NULL,
    [Phone] nvarchar(max) NOT NULL,
    [Email] nvarchar(max) NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220916085627_InitialMigration', N'6.0.8');
GO

COMMIT;
GO

