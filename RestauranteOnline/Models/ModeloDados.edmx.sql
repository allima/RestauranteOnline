
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/19/2016 20:06:06
-- Generated from EDMX file: C:\Users\Alexandre de Lima\Source\Repos\RestauranteOnline\RestauranteOnline\Models\ModeloDados.edmx
-- --------------------------------------------------
create database RestauranteBD;
SET QUOTED_IDENTIFIER OFF;
GO
USE [RestauranteBD];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[fk_restaurante_bairro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Restaurante] DROP CONSTRAINT [fk_restaurante_bairro];
GO
IF OBJECT_ID(N'[dbo].[fk_restaurante_genero]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Restaurante] DROP CONSTRAINT [fk_restaurante_genero];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Bairro]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bairro];
GO
IF OBJECT_ID(N'[dbo].[Genero]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Genero];
GO
IF OBJECT_ID(N'[dbo].[Restaurante]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Restaurante];
GO
IF OBJECT_ID(N'[dbo].[Usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuario];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Bairro'
CREATE TABLE [dbo].[Bairro] (
    [IDBairro] int IDENTITY(1,1) NOT NULL,
    [Nome] varchar(50)  NOT NULL
);
GO

-- Creating table 'Genero'
CREATE TABLE [dbo].[Genero] (
    [IDGenero] int IDENTITY(1,1) NOT NULL,
    [Descricao] varchar(40)  NOT NULL
);
GO

-- Creating table 'Restaurante'
CREATE TABLE [dbo].[Restaurante] (
    [IDRestaurante] int IDENTITY(1,1) NOT NULL,
    [Nome] varchar(30)  NOT NULL,
    [Endereco] varchar(50)  NOT NULL,
    [Telefone] varchar(11)  NOT NULL,
    [Site] varchar(40)  NULL,
    [DisqueEntrega] bit  NOT NULL,
    [IDGenero] int  NOT NULL,
    [IDBairro] int  NOT NULL
);
GO

-- Creating table 'Usuario'
CREATE TABLE [dbo].[Usuario] (
    [IDUsuario] int IDENTITY(1,1) NOT NULL,
    [Nome] varchar(50)  NOT NULL,
    [Login] varchar(30)  NOT NULL,
    [Senha] varchar(100)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IDBairro] in table 'Bairro'
ALTER TABLE [dbo].[Bairro]
ADD CONSTRAINT [PK_Bairro]
    PRIMARY KEY CLUSTERED ([IDBairro] ASC);
GO

-- Creating primary key on [IDGenero] in table 'Genero'
ALTER TABLE [dbo].[Genero]
ADD CONSTRAINT [PK_Genero]
    PRIMARY KEY CLUSTERED ([IDGenero] ASC);
GO

-- Creating primary key on [IDRestaurante] in table 'Restaurante'
ALTER TABLE [dbo].[Restaurante]
ADD CONSTRAINT [PK_Restaurante]
    PRIMARY KEY CLUSTERED ([IDRestaurante] ASC);
GO

-- Creating primary key on [IDUsuario] in table 'Usuario'
ALTER TABLE [dbo].[Usuario]
ADD CONSTRAINT [PK_Usuario]
    PRIMARY KEY CLUSTERED ([IDUsuario] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IDBairro] in table 'Restaurante'
ALTER TABLE [dbo].[Restaurante]
ADD CONSTRAINT [fk_restaurante_bairro]
    FOREIGN KEY ([IDBairro])
    REFERENCES [dbo].[Bairro]
        ([IDBairro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_restaurante_bairro'
CREATE INDEX [IX_fk_restaurante_bairro]
ON [dbo].[Restaurante]
    ([IDBairro]);
GO

-- Creating foreign key on [IDGenero] in table 'Restaurante'
ALTER TABLE [dbo].[Restaurante]
ADD CONSTRAINT [fk_restaurante_genero]
    FOREIGN KEY ([IDGenero])
    REFERENCES [dbo].[Genero]
        ([IDGenero])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_restaurante_genero'
CREATE INDEX [IX_fk_restaurante_genero]
ON [dbo].[Restaurante]
    ([IDGenero]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------