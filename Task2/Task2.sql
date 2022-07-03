
/*
ProductInCategory - таблица, содержащая пары продукт и категория, к которой он принадлежит
*/
Select Product.name, Category.name 
From Product 
		Left Join (Category  Inner Join ProductInCategory   
					On Category.f2 = ProductInCategory.CategoryID) 
		ON Product.ID = ProductInCategory.ProductID


