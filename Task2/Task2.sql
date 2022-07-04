
/*
ProductInCategory is a table containing pairs of product and the category to which it belongs
*/
Select Product.name, Category.name 
From Product 
		Left Join (Category  Inner Join ProductInCategory   
					On Category.ID = ProductInCategory.CategoryID) 
		On Product.ID = ProductInCategory.ProductID


