﻿CREATE TABLE [dbo].[MeatSeaFood]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductName] NVARCHAR(50) NOT NULL, 
    [ProductDescription] NVARCHAR(50) NOT NULL, 
    [ProductQuantity] NVARCHAR(50) NOT NULL, 
    [ProductPrice] DECIMAL NOT NULL, 
    [ProductDiscount] BIT NULL, 
    [InStock] INT NOT NULL
)
