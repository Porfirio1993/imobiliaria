
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/03/2022 12:13:30
-- Generated from EDMX file: C:\Users\porfi\Documents\C#\empresa-imobiliaria\imobiliaria\imobiliaria\db.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [imobiliaria];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[cliente];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'cliente'
CREATE TABLE [dbo].[cliente] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nome_completo] varchar(90)  NOT NULL,
    [cpf] varchar(15)  NOT NULL,
    [data_nascimento] datetime  NULL,
    [sexo] varchar(1)  NULL,
    [tipo_de_pessoa] varchar(10)  NOT NULL,
    [status] bit  NOT NULL,
    [login] varchar(50)  NOT NULL,
    [senha] varchar(50)  NOT NULL
);
GO

-- Creating table 'imoveisSet'
CREATE TABLE [dbo].[imoveisSet] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'cliente'
ALTER TABLE [dbo].[cliente]
ADD CONSTRAINT [PK_cliente]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Id] in table 'imoveisSet'
ALTER TABLE [dbo].[imoveisSet]
ADD CONSTRAINT [PK_imoveisSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------