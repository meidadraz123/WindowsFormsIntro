﻿Imports Data

Public Class ObjectSource
    Implements ISource
    Private _categories As List(Of Category)
    Private _products As List(Of Product)

    Public Sub New()
        _categories = New List(Of Category)
        _categories.Add(New Category(1, "Beverages"))
        _categories.Add(New Category(2, "Condiments"))
        _categories.Add(New Category(3, "Confections"))
        _categories.Add(New Category(4, "Dairy Products"))
        _categories.Add(New Category(5, "Grains/Cereals"))
        _categories.Add(New Category(6, "Meat/Poultry"))
        _categories.Add(New Category(7, "Produce"))
        _categories.Add(New Category(8, "Seafood"))

        _products = New List(Of Product)
        _products.Add(New Product(1, "Chai", 1, "10 boxes x 20 bags", 18.0, 39, 0, False))
        _products.Add(New Product(2, "Chang", 1, "24 - 12 oz bottles", 19.0, 17, 40, False))
        _products.Add(New Product(3, "Aniseed Syrup", 2, "12 - 550 ml bottles", 10.0, 13, 70, False))
        _products.Add(New Product(4, "Chef Anton's Cajun Seasoning", 2, "48 - 6 oz jars", 22.0, 53, 0, False))
        _products.Add(New Product(5, "Chef Anton's Gumbo Mix", 2, "36 boxes", 21.35, 0, 0, True))
        _products.Add(New Product(6, "Grandma's Boysenberry Spread", 2, "12 - 8 oz jars", 25.0, 120, 0, False))
        _products.Add(New Product(7, "Uncle Bob's Organic Dried Pears", 7, "12 - 1 lb pkgs.", 30.0, 15, 0, False))
        _products.Add(New Product(8, "Northwoods Cranberry Sauce", 2, "12 - 12 oz jars", 40.0, 6, 0, False))
        _products.Add(New Product(9, "Mishi Kobe Niku", 6, "18 - 500 g pkgs.", 97.0, 29, 0, True))
        _products.Add(New Product(10, "Ikura", 8, "12 - 200 ml jars", 31.0, 31, 0, False))
        _products.Add(New Product(11, "Queso Cabrales", 4, "1 kg pkg.", 21.0, 22, 30, False))
        _products.Add(New Product(12, "Queso Manchego La Pastora", 4, "10 - 500 g pkgs.", 38.0, 86, 0, False))
        _products.Add(New Product(13, "Konbu", 8, "2 kg box", 6.0, 24, 0, False))
        _products.Add(New Product(14, "Tofu", 7, "40 - 100 g pkgs.", 23.25, 35, 0, False))
        _products.Add(New Product(15, "Genen Shouyu", 2, "24 - 250 ml bottles", 15.5, 39, 0, False))
        _products.Add(New Product(16, "Pavlova", 3, "32 - 500 g boxes", 17.45, 29, 0, False))
        _products.Add(New Product(17, "Alice Mutton", 6, "20 - 1 kg tins", 39.0, 0, 0, True))
        _products.Add(New Product(18, "Carnarvon Tigers", 8, "16 kg pkg.", 62.5, 42, 0, False))
        _products.Add(New Product(19, "Teatime Chocolate Biscuits", 3, "10 boxes x 12 pieces", 9.2, 25, 0, False))
        _products.Add(New Product(20, "Sir Rodney's Marmalade", 3, "30 gift boxes", 81.0, 40, 0, False))
        _products.Add(New Product(21, "Sir Rodney's Scones", 3, "24 pkgs. x 4 pieces", 10.0, 3, 40, False))
        _products.Add(New Product(22, "Gustaf's Knäckebröd", 5, "24 - 500 g pkgs.", 21.0, 104, 0, False))
        _products.Add(New Product(23, "Tunnbröd", 5, "12 - 250 g pkgs.", 9.0, 61, 0, False))
        _products.Add(New Product(24, "Guaraná Fantástica", 1, "12 - 355 ml cans", 4.5, 20, 0, True))
        _products.Add(New Product(25, "NuNuCa Nuß-Nougat-Creme", 3, "20 - 450 g glasses", 14.0, 76, 0, False))
        _products.Add(New Product(26, "Gumbär Gummibärchen", 3, "100 - 250 g bags", 31.23, 15, 0, False))
        _products.Add(New Product(27, "Schoggi Schokolade", 3, "100 - 100 g pieces", 43.9, 49, 0, False))
        _products.Add(New Product(28, "Rössle Sauerkraut", 7, "25 - 825 g cans", 45.6, 26, 0, True))
        _products.Add(New Product(29, "Thüringer Rostbratwurst", 6, "50 bags x 30 sausgs.", 123.79, 0, 0, True))
        _products.Add(New Product(30, "Nord-Ost Matjeshering", 8, "10 - 200 g glasses", 25.89, 10, 0, False))
        _products.Add(New Product(31, "Gorgonzola Telino", 4, "12 - 100 g pkgs", 12.5, 0, 70, False))
        _products.Add(New Product(32, "Mascarpone Fabioli", 4, "24 - 200 g pkgs.", 32.0, 9, 40, False))
        _products.Add(New Product(33, "Geitost", 4, "500 g", 2.5, 112, 0, False))
        _products.Add(New Product(34, "Sasquatch Ale", 1, "24 - 12 oz bottles", 14.0, 111, 0, False))
        _products.Add(New Product(35, "Steeleye Stout", 1, "24 - 12 oz bottles", 18.0, 20, 0, False))
        _products.Add(New Product(36, "Inlagd Sill", 8, "24 - 250 g  jars", 19.0, 112, 0, False))
        _products.Add(New Product(37, "Gravad lax", 8, "12 - 500 g pkgs.", 26.0, 11, 50, False))
        _products.Add(New Product(38, "Côte de Blaye", 1, "12 - 75 cl bottles", 263.5, 17, 0, False))
        _products.Add(New Product(39, "Chartreuse verte", 1, "750 cc per bottle", 18.0, 69, 0, False))
        _products.Add(New Product(40, "Boston Crab Meat", 8, "24 - 4 oz tins", 18.4, 123, 0, False))
        _products.Add(New Product(41, "Jack's New England Clam Chowder", 8, "12 - 12 oz cans", 9.65, 85, 0, False))
        _products.Add(New Product(42, "Singaporean Hokkien Fried Mee", 5, "32 - 1 kg pkgs.", 14.0, 26, 0, True))
        _products.Add(New Product(43, "Ipoh Coffee", 1, "16 - 500 g tins", 46.0, 17, 10, False))
        _products.Add(New Product(44, "Gula Malacca", 2, "20 - 2 kg bags", 19.45, 27, 0, False))
        _products.Add(New Product(45, "Rogede sild", 8, "1k pkg.", 9.5, 5, 70, False))
        _products.Add(New Product(46, "Spegesild", 8, "4 - 450 g glasses", 12.0, 95, 0, False))
        _products.Add(New Product(47, "Zaanse koeken", 3, "10 - 4 oz boxes", 9.5, 36, 0, False))
        _products.Add(New Product(48, "Chocolade", 3, "10 pkgs.", 12.75, 15, 70, False))
        _products.Add(New Product(49, "Maxilaku", 3, "24 - 50 g pkgs.", 20.0, 10, 60, False))
        _products.Add(New Product(50, "Valkoinen suklaa", 3, "12 - 100 g bars", 16.25, 65, 0, False))
        _products.Add(New Product(51, "Manjimup Dried Apples", 7, "50 - 300 g pkgs.", 53.0, 20, 0, False))
        _products.Add(New Product(52, "Filo Mix", 5, "16 - 2 kg boxes", 7.0, 38, 0, False))
        _products.Add(New Product(53, "Perth Pasties", 6, "48 pieces", 32.8, 0, 0, True))
        _products.Add(New Product(54, "Tourtière", 6, "16 pies", 7.45, 21, 0, False))
        _products.Add(New Product(55, "Pâté chinois", 6, "24 boxes x 2 pies", 24.0, 115, 0, False))
        _products.Add(New Product(56, "Gnocchi di nonna Alice", 5, "24 - 250 g pkgs.", 38.0, 21, 10, False))
        _products.Add(New Product(57, "Ravioli Angelo", 5, "24 - 250 g pkgs.", 19.5, 36, 0, False))
        _products.Add(New Product(58, "Escargots de Bourgogne", 8, "24 pieces", 13.25, 62, 0, False))
        _products.Add(New Product(59, "Raclette Courdavault", 4, "5 kg pkg.", 55.0, 79, 0, False))
        _products.Add(New Product(60, "Camembert Pierrot", 4, "15 - 300 g rounds", 34.0, 19, 0, False))
        _products.Add(New Product(61, "Sirop d'érable", 2, "24 - 500 ml bottles", 28.5, 113, 0, False))
        _products.Add(New Product(62, "Tarte au sucre", 3, "48 pies", 49.3, 17, 0, False))
        _products.Add(New Product(63, "Vegie-spread", 2, "15 - 625 g jars", 43.9, 24, 0, False))
        _products.Add(New Product(64, "Wimmers gute Semmelknödel", 5, "20 bags x 4 pieces", 33.25, 22, 80, False))
        _products.Add(New Product(65, "Louisiana Fiery Hot Pepper Sauce", 2, "32 - 8 oz bottles", 21.05, 76, 0, False))
        _products.Add(New Product(66, "Louisiana Hot Spiced Okra", 2, "24 - 8 oz jars", 17.0, 4, 100, False))
        _products.Add(New Product(67, "Laughing Lumberjack Lager", 1, "24 - 12 oz bottles", 14.0, 52, 0, False))
        _products.Add(New Product(68, "Scottish Longbreads", 3, "10 boxes x 8 pieces", 12.5, 6, 10, False))
        _products.Add(New Product(69, "Gudbrandsdalsost", 4, "10 kg pkg.", 36.0, 26, 0, False))
        _products.Add(New Product(70, "Outback Lager", 1, "24 - 355 ml bottles", 15.0, 15, 10, False))
        _products.Add(New Product(71, "Flotemysost", 4, "10 - 500 g pkgs.", 21.5, 26, 0, False))
        _products.Add(New Product(72, "Mozzarella di Giovanni", 4, "24 - 200 g pkgs.", 34.8, 14, 0, False))
        _products.Add(New Product(73, "Röd Kaviar", 8, "24 - 150 g jars", 15.0, 101, 0, False))
        _products.Add(New Product(74, "Longlife Tofu", 7, "5 kg pkg.", 10.0, 4, 20, False))
        _products.Add(New Product(75, "Rhönbräu Klosterbier", 1, "24 - 0.5 l bottles", 7.75, 125, 0, False))
        _products.Add(New Product(76, "Lakkalikööri", 1, "500 ml", 18.0, 57, 0, False))
        _products.Add(New Product(77, "Original Frankfurter grüne Soße", 2, "12 boxes", 13.0, 32, 0, False))
    End Sub

    Public Function GetCategories() As Object Implements ISource.GetCategories
        Return _categories
    End Function

    Public Function GetProducts(categoryId As Integer) As Object Implements ISource.GetProducts
        Dim result = From p In _products
                     Where p.CategoryID = categoryId
                     Select p

        Return result.ToList()
    End Function

    Public Sub DeleteProduct(bindingSource As BindingSource, productId As Integer) Implements ISource.DeleteProduct
        Dim query = From p In _products
                    Where p.ProductID = productId
                    Select p

        Dim product = query.Single()
        bindingSource.Remove(product)
    End Sub

    Public Sub AddProduct(bindingSource As BindingSource, product As Product) Implements ISource.AddProduct
        Dim maxId = Aggregate p In _products
                    Into Max(p.ProductID)
        product.ProductID = maxId + 1
        bindingSource.Add(product)
    End Sub

    Public Sub Save() Implements ISource.Save
        'Nothing to do
    End Sub
End Class
