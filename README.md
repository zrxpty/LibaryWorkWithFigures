## 1 TASK

Напишите библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

    Юнит-тесты
    Легкость добавления других фигур
    Вычисление площади фигуры без знания типа фигуры
    Проверку на то, является ли треугольник прямоугольным


## 2 Task
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
По возможности — положите ответ рядом с кодом из первого вопроса.

```sql
CREATE TABLE Product (
	Id INT PRIMARY KEY,
	"Name" TEXT
);
INSERT INTO Product
VALUES
	(1, 'Milka'),
	(2, 'tesla'),
	(3, 'Logitech 102');
CREATE TABLE Category (
	Id INT PRIMARY KEY,
	"Name" TEXT
);
INSERT INTO Category
VALUES
	(1, 'Cat'),
	(2, 'Car'),
	(3, 'Mouse');
CREATE TABLE ProductCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);
INSERT INTO ProductCategory
VALUES
	(1, 1),
	(1, 3),
	(2, 2);
SELECT P."Name", C."Name"
FROM Product P
LEFT JOIN ProductCategory PC
	ON P.Id = PC.ProductId
LEFT JOIN Category C
	ON PC.CategoryId = C.Id;
