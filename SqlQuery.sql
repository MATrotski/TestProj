SELECT p.Name, c.Name
FROM Products p 
	JOIN ProductCategories pc 
	ON p.Id = pc.ProductId
	JOIN Categories c 
	ON  pc.CategoryId = c.Id