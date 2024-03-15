IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = "TODO")
BEGIN
    CREATE DATABASE [TODO]
    PRINT "DATABASE CREATED"
END

IF EXISTS (SELECT * FROM sys.databases WHERE name = "TODO")
BEGIN
    USE [TODO]

    IF NOT EXISTS (SELECT * FROM sysobjects WHERE name="ITEM" and xtype="U")
    BEGIN
        CREATE TABLE ITEM (
            Id INT PRIMARY KEY IDENTITY (1, 1),
            Title VARCHAR(255),
            Description VARCHAR(255),
            Due datetime,
            Done bit,
            CreatedAt datetime,
            UpdatedAt datetime,
            Active bit
        )
        PRINT "TABLE CREATED"
    END
END
