--Select
--ANSI standardı
-- case insensitive
select * from Customers -- * kolanlar anlamına gelir

select contactName, companyName,City from Customers -- bellekte fake bir tablo oluşturup onu gösteriyor.

select contactName Adi, companyName SirketAdi,City Sehir from Customers  -- istediğimiz ad ile getirebiliyoruz

select * from Customers where city='London'

select * from Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=1 and UnitPrice>10 -- kategorisi bir olanları ve 10 dan büyük olanları getir.

select * from Products order by CategoryID, ProductName

select * from Products order by UnitPrice -- ürünleri fiyata göre sırala default asc

select * from Products order by UnitPrice asc -- ascending artan demek

select * from Products order by UnitPrice desc --descending azalan, düşen demek

select * from Products where categoryId=1 order by UnitPrice desc

select count(*) from products

select count(*) adet from products where CategoryID=2

select categoryId from products group by CategoryID -- bütün kategorileri tekrar etmeyecek şekilde listele

select categoryId, count(*) from products group by CategoryID 

select categoryId, count(*) from products group by CategoryID having count(*)<10

select * from Products inner join Categories on Products.CategoryID=Categories.CategoryID

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories on Products.CategoryID=Categories.CategoryID -- kendi istediğimiz bilgileri listedik

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories on Products.CategoryID=Categories.CategoryID where products.UnitPrice>10

select * from products inner join [Order Details] --boşluk olduğu için köşeli parantez kullanılır.

select * from products p left join [Order Details] od on p.ProductID=od.ProductID

select * from Customers c left join Orders o on c.CustomerID=o.CustomerID where o.CustomerID is null

select * from Products p inner join [Order details] od on p.ProductID=od.ProductID inner join orders o on o.OrderID=od.OrderID
