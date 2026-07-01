Use ProductMSDB;
GO

CREATE TABLE dbo.Category
(
 Category_Id         Int Identity(1,1) Constraint PK_Category_Category_Id Primary Key,
 Parent_Category_Id  Int Not Null,
 Name                Varchar(100),
 Description         Varchar(Max),
 Is_Active           Int,
 Created_At	         DateTime
)
GO

Select * From dbo.Category;

CREATE TABLE dbo.Brand
(
 Brand_Id Int Identity(1,1) Constraint PK_Brand_Brand_Id Primary Key,
 Name                Varchar(100),
 Description         Varchar(Max),
 Logo_Url	         Varchar(100),
 Is_Active           Int, 
 Created_At	         DateTime
)
GO


CREATE TABLE dbo.ProductMaster
(
 Product_Id         Int Identity(1,1) Constraint PK_ProductMaster_Product_Id Primary Key,
 Category_Id        Int,
 Brand_Id           Int,
 Name               Varchar(100),
 Description        Varchar(Max),
 Status             Int,
 Created_At         DateTime,
 Updated_At         DateTime
 )
 GO

CREATE TABLE dbo.ProductVariant
(
ProductVariant_Id      Int Identity(1,1) Constraint PK_ProductVariant_ProductVariant_Id Primary Key,
Product_Id      Int,
Brand_Id        Int,
SKU             Varchar(50),
BarCode         Varchar(32),
Color           Varchar(50),
Size            Varchar(10),
Price           Decimal(18,2),
Currency        Varchar(10),
Weight          Int
)
GO

CREATE TABLE dbo.ProductImage	
(
Image_Id          Int Identity(1,1) Constraint PK_ProductImage_Image_Id Primary Key,
ProductVariant_Id Int Not Null,
Image_Url         Varchar(100),
Display_Order     Int
)
GO

CREATE TABLE dbo.ProductAttribute	
(
ProductAttribute_Id      Int Identity(1,1) Constraint PK_ProductAttribute_ProductAttribute_Id Primary Key,
Name                     Varchar(100),
Data_Type                Varchar(50),
Unit                     Int
)
GO

CREATE TABLE dbo.ProductAttributeValue	
(
ProductAttributeValue_Id      Int Identity(1,1) Constraint PK_ProductAttributeValue_ProductAttributeValue_Id Primary Key,
ProductVariant_Id             Int Not Null,
ProductAttribute_Id           Int Not Null,
Value                         Int,
Is_Active                     Int
)
GO

CREATE TABLE dbo.Tag	
(
Tag_Id     Int Identity(1,1) Constraint PK_Tag_Tag_Id Primary Key,
Name       Varchar(100)
)
GO

CREATE TABLE dbo.ProductTag	
(
ProductTag_Id     Int Identity(1,1) Constraint PK_ProductTag_Product_Id Primary Key,
Tag_Id            Int
)
GO

CREATE TABLE dbo.InventoryReference	
(
InventoryReference_Id      Int Identity(1,1) Constraint PK_InventoryReference_InventoryReference_Id Primary Key,
Inventory_Service_Key      Int
)
GO
