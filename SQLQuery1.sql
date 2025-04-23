---- Table for Students
CREATE TABLE Student (
    RollNum INT PRIMARY KEY,
   "Name" VARCHAR(255),
   "Password" VARCHAR(255),
    Phone VARCHAR(255)

);
select * from Student

CREATE TABLE Faculty (
   FacultyID INT PRIMARY KEY,
  Username VARCHAR(255),
   "Password" VARCHAR(255),
   "role" VARCHAR(255),
    Phone VARCHAR(255),
    Discount int
);

CREATE TABLE CafeteriaStaff (
   StaffID INT IDENTITY(1,1) PRIMARY KEY,
   "Username" VARCHAR(255),
   "Password" VARCHAR(255)
);


select * from CafeteriaStaff

CREATE TABLE MenuItem (
    MenuItemID INT PRIMARY KEY IDENTITY(1,1),
    ItemName VARCHAR(255),
    Price DECIMAL,
    "Availability" BIT,
    "Description" TEXT,
	Category Text
);
select * from Student
CREATE TABLE Inventory (
    InventoryItemID INT PRIMARY KEY,
    ItemName VARCHAR(255),
    Category VARCHAR(255),
    ExpirationDate DATE,
    Quantity INT,
    Units VARCHAR(255)

);
-- Inserting chicken
INSERT INTO Inventory (InventoryItemID, ItemName, Category, ExpirationDate, Quantity, Units)
VALUES (1, 'chicken', 'Food', '2023-12-31', 2, 'kgs');

-- Inserting buns
INSERT INTO Inventory (InventoryItemID, ItemName, Category, ExpirationDate, Quantity, Units)
VALUES (2, 'buns', 'Bakery', '2023-12-31', 2, 'units');



CREATE TABLE Ingredient (
    IngredientID INT PRIMARY KEY,
    Name VARCHAR(255),
    MenuItemID INT,
    FOREIGN KEY (MenuItemID) REFERENCES MenuItem(MenuItemID)
);

-- Assuming IDENTITY_INSERT is ON, and Zinger Burger has MenuItemID 1
-- Inserting ingredients for Zinger Burger (assuming MenuItemID is 1)
INSERT INTO Ingredient (IngredientID, Name, MenuItemID)
VALUES
    (1, 'Chicken', 1),
    (2, 'Lettuce', 1),
    (3, 'Tomato', 1),
    (4, 'Mayonnaise', 1),
    (5, 'Bun', 1);
	delete from Ingredient
select* from Ingredient
SELECT 
    M.MenuItemID,
    M.ItemName,
    M.Price,
    M.Availability,
    M.Description,
    M.Category,
    I.IngredientID,
    I.Name AS IngredientName
FROM
    MenuItem M
JOIN
    Ingredient I ON M.MenuItemID = I.MenuItemID;






select * from Ingredient
drop table Ingredient

select* from Student
---- Table for Faculty

select* from Faculty
drop table Faculty

---- Table for CafeteriaStaff



drop table CafeteriaStaff

INSERT INTO CafeteriaStaff ( Username, "Password")
VALUES ('Admin', '123456789');
INSERT INTO CafeteriaStaff (Username, "Password")
VALUES ('Manager', '987');
INSERT INTO CafeteriaStaff (Username, "Password")
VALUES ('Cheff', '123');
DELETE FROM CafeteriaStaff;

select* FROM CafeteriaStaff;


-- Table for MenuItems

SET IDENTITY_INSERT MenuItem ON;
drop table MenuItem;
select * from MenuItem;
INSERT INTO MenuItem (MenuItemID, ItemName, Price, Availability, Description, Category)
VALUES (1, 'Zinger Burger', 5.99, 1, 'Spicy chicken burger with lettuce and mayo', 'Burger');


-- Table for Ingredients

drop table Ingredient




--3 table join
SELECT
    M.MenuItemID,
    M.ItemName AS MenuItemName,
    M.Price,
    M.Availability,
    M.Description AS MenuItemDescription,
    M.Category AS MenuItemCategory,
    I.IngredientID,
    I.Name AS IngredientName,
    I.MenuItemID AS IngredientMenuItemID,
    Inv.InventoryItemID,
    Inv.ItemName AS InventoryItemName,
    Inv.Category AS InventoryCategory,
    Inv.ExpirationDate,
    Inv.Quantity,
    Inv.Units
FROM
    MenuItem M
JOIN
    Ingredient I ON M.MenuItemID = I.MenuItemID
JOIN
    Inventory Inv ON I.Name = Inv.ItemName;

	----------------------------------------------------------------------------------

	-- Table for Orders
CREATE TABLE "Order" (
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    TotalPrice DECIMAL,
    Status VARCHAR(255)
);

select * from "Order"
