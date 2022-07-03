
/*
ProductInCategory is a table containing pairs of product and the category to which it belongs
*/
Select Product.name, Category.name 
From Product 
		Left Join (Category  Inner Join ProductInCategory   
					On Category.f2 = ProductInCategory.CategoryID) 
		ON Product.ID = ProductInCategory.ProductID


