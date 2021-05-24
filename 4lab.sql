-- --------------------------- 4 лаба --------------------------------------

-- 15 функциональных требований

-- 1. Показать список экземпляров 
SELECT * FROM Exemplar;

-- 2. Показать список покупателей
Select * from Customer;

-- 3. Показать ФИО покупателя
Select FIO
From Customer;

-- 4. Изменить дату рождения покупателя
update Customer
set BirthdayDate = "2001.02.25"
WHERE Customer.FIO = "Nikolenko Danila Aleksandrovich";

-- 5. Показать количество кроссовок
Select count(*) from Sneakers;

-- 6. Показать список работников у кого ЗП от 10000 до 30000
select * from Worker
where salary between 10000 and 30000;

-- 7. Вывести покупателz, у которого FIO Сычев Олег Александрович
select * from Customer
where FIO = "Sychev Oleg Aleksandrovich";

-- 8. Добавим нового работника 
insert into Worker
values (3,"Julia Snegova", 40000,"cashier");

-- 9. Изменить FIO клиента под id = 4
update Customer
set FIO = "Glavatskay Sofia Vladimirovna"
where id = 4;

-- 10. Добавить поставку
insert into Delivery
values (4,"27.06.2021","15:00",1,1);

-- 11. Добавить номер телефона клиенту под id = 4
update Customer 
set PhoneNumber = "89954035523"
where id = 4;

-- 12. Удалить поставку запланированную на дату 27.06.2021
delete from Delivery
where DateDelivery = "27.06.2021";

-- 13. Добавим нового покупателя 
insert into Customer 
values (9,"Petro Viktor Anatolevich",null,null);

-- 14. Добавим номер телефона новому покупателю
update Customer 
set PhoneNumber = "89256784565"
where FIO = "Petro Viktor Anatolevich";

-- 15. Показать экземпляры у которых размер больше 42 
SELECT * FROM Exemplar WHERE size > 42;

-- UPDATE. 5 штук

-- 16. Изменить зарплату сотруднику в связи с повышением
update Worker
set salary = 60000
where id = 3;

-- 17. Изменить номер телефона покупателя
update Customer
set PhoneNumber = "89255320394"
where FIO = "Petro Viktor Anatolevich";

-- 18. Изменить адрес магазина 
update `Shop`
set address = "Ul lenina 50"
where address = "Ul lenina 44";

-- 19. Добавить дату рождения покупателю
update Customer
set BirthdayDate = "2001.02.25"
where FIO = "Nikolenko Danila Aleksandrovich";

-- 20. Изменить цену на экземпляр
update Sneakers
set price = "10000"
where model = "Hamburg";

-- DELETE. 5 штук

-- 21. Удалить случайно созданную таблицу
create table Private (
hotdog varchar(255)
);
delete from Private;

-- 22. Удалить случайно созданного клиента
insert into Customer
values (14,"Dushov Alexey Vladimirocich",null,null);
delete from Customer
where FIO = "Dushov Alexey Vladimirocich";

-- 23. Удалить поставку 27 числа
delete from Delivery
where DateDelivery = "27.06.2021";

-- 24. Удалить случайно созданного работника
insert into Worker
values (4,"Peter Yan", 100000,"cashier");
delete from Worker
where FIO = "Peter Yan";

-- 25. Удалить клиента с номером телефона "89255320394"
delete from Customer
where PhoneNumber = "89255320394";

--  SELECT в разных вариациях. 20 запросов.

-- 26. Показать всех клиентов
select * from Customer;

-- 27. Показать всех работников
select * from Worker;

-- 28. Показать всех работников с зарплатой выше 40000
select * from Worker
where salary > 40000;

-- 29. Показать всех клиентов с имеющимся номером телефона
select * from Customer
where PhoneNumber > 0;

-- 29. Показать всех клиентов с имеющейся датой рождения
select * from Customer
where BirthdayDate > 0;

-- 30. Показать все экземпляры у которых размер больше 40
select * from Exemplar
where size > 40;

-- 31. Показать все экземпляры у которых цвет - черный
select * from Exemplar 
where color = "black";

-- 32. Показать все id кроссовок с брендом адидас
select * from Brand
where brandname = "Adidas";

-- 33. Показать все кроссовки ценой ниже 5000
select * from Sneakers 
where price < 5000;

-- 34. Показать все мужские кроссовки
select * from Sneakers
where gender = "male";

-- 35. Показать все заказы где оплата проведена с помощью карты виза
select * from `Order`
where TypePayment = "VISA Card";

-- 36. Показать уникальные значения ЗП
Select distinct salary from Worker;

-- 37. Показать уникальные номера телефонов у клиентов
select distinct PhoneNumber from Customer;

-- 38. Показать количество клиентов
select count(*) from Customer;

-- 39. Показать фио и даты рождения клиентов
select CONCAT(FIO, " " , BirthdayDate) as FioAndDate
from Customer;

-- 40. Показать модель и цену кроссовок
select concat(model, " - ", price) as ModelPrice
from Sneakers;

-- 41. Показать все кроссовки по возрастанию цены
select id, price
from Sneakers
order by price;

-- 42. Показать самый минимальный размер кроссовок
select id, min(size)
from Exemplar;

-- 43. Показать самую дорогую модель кроссовок
select model, max(price)
from Sneakers;

-- 44. Отсортировать работников по ЗП от большей к меньшей
select fio, salary
from Worker
order by salary desc;

-- 45. Отсортировать экземпляры по размеру от меньшей к большей
select id, size
from Exemplar
order by size;

-- LIKE и другие функции работы со строками

-- 46. Отобразить клиентов с фамилией Nikolenko
select * from Customer where FIO like "%Nikolenko%";

-- 47. Показать всех работников с фамилией Winchester
select * from Worker where FIO like "%Winchester%";

-- 48. Показать всех работников - кассиров
select * from Worker where post like "cashier";

-- 49. Показать всех клиентов без буквы A
select * from Customer where FIO not like "%A%";

-- 50. Вывести все бренды без адидаса
select * from Brand where BrandName not like "Adidas";

-- SELECT INTO, INSERT SELECT

-- 51. Создадим пустую тестовую таблицу. В переменную созданной таблицы перенесем размеры из существующей таблицы.
CREATE TABLE New_Exemplar(
	str VARCHAR (100)
);
INSERT INTO New_Exemplar (str)
SELECT size FROM Exemplar;
SELECT *from New_Exemplar;

-- 52. Выведем в переменные значения id и бренда по нашему бренду - "Adidas"
SELECT BrandName,id  INTO @newbrand, @newid
FROM brand
WHERE BrandName = 'Nike'; 
SELECT @newbrand, @newid;
-- JOIN. 20 запросов

-- 53. INNER JOIN. Выведем модель и тип кроссовок 11111111111111
select model, typeSneakers
from Sneakers as `a`
join TypeSneakers as `b`
on a.id = b.id;

-- 54. INNER JOIN. Выведем Сотрудника и график работы 11111111111
select FIO, TimeStart, TimeEnd
from Worker
join `Schedule`
on Worker.id = `Schedule`.id;

-- 55. INNER JOIN. Выведем клиента и заказы 111111111111111
select FIO, TypePayment, DatePayment
from Customer
join `Order`
on Customer.id = `Order`.id;

-- 56. Кроссовки и экземпляры - вся информация
SELECT *
from Sneakers
left join Exemplar
on Sneakers.id = Exemplar.id;

-- 57. Выведем доставку и поставщика
select *
from Provider
left join Delivery
on Provider.id = Delivery.id;

-- 58. Выведем модели кроссовок, у которых бренд adidas
select model, BrandName 
from Sneakers
left join Brand
on sneakers.id = brand.id
where BrandName = "Adidas";

-- 59. Выведем клиентов, которые купили кроссовки nike
select FIO, BrandName
from Customer c
left join Brand b
on c.id = b.id
where BrandName = "Nike";

-- 60. Выведем размеры кроссовок, у которых бренд Nike
select size, BrandName
from Exemplar e
join Brand b
on e.id = b.id
where BrandName = "Nike";

-- 61. Выведем информацию о магазине и о экземплярах 
select * from Shop
join Exemplar;

-- 62. Вывести информацию о сотрудниках и магазинеalter
select * from shop
join Worker;

-- 63. Вывести модели кроссовок, у которых размер = 43
select model, size
from Sneakers s
join Exemplar e 
on s.id = e.id
where size = 43;

-- 64. СROSS JOIN (63) результат одинаковый
select model, size
from Sneakers s
cross join Exemplar e 
on s.id = e.id
where size = 43;

-- 65. Декартово объединение таблиц
select * from shop
join worker
join `Schedule`;

-- 66. Одинаковые таблицы появляются 1 раз
select * from shop
natural join worker;

-- 67. Выведем бренд кроссовок с размерами меньше 40
select brandname, size
from brand b
join exemplar e
on b.id = e.id
where size < 40;

-- 68. Выведем всю информацию о графике работы магазина
select * from shop
join `Schedule`;

-- 69. Декартово объедение
select *
from sneakers
join brand;

-- 70. Столбцы используются 1 раз
select * 
from shop
natural join `Schedule`;

-- 71. То же самое с другими таблицами
select * 
from sneakers
natural join brand;

-- 72. Тип и кроссовки
select * 
from sneakers;
-- natural join typesneakers;

-- 73. Модель кроссовок у которых бренд не найк
select model, brandname
from sneakers s
join brand b
on s.id = b.id
where brandname not like "Nike";

-- GROUP BY. 10 штук

-- 74. Мин зарплата
select fio, min(salary) as minSalary
from worker
group by fio;

-- 75. макс зарплата
select fio, max(salary) as maxSalary
from worker
group by fio;

-- 76. выведем информацию только о двух кроссовках
select *
from sneakers
group by model limit 2;

-- 77. округление цены для конкретных кроссовок
select model, avg(price)
from sneakers
group by model;

-- 78. выведем количество кроссовок адидас
select count(sneakers.id) as count
from sneakers
join brand
on sneakers.id = brand.id
where brandname = "Adidas"
order by sneakers.id;

-- 79. Выведем работников по возрастанию зарплаты
select fio, salary
from worker
group by salary
order by salary;

-- 80. Выведем работников по убыванию зарплаты
select fio, salary
from worker
group by salary
order by salary desc;

-- 81. Выведем среднюю зарпллату работников
select avg(salary)
from worker
group by fio;

-- 82. Выведем количество работников у которых зарплата больше 50000
select count(worker.id) count
from worker
where salary > 50000
group by fio;

-- 83. Отсортируем кроссовки по цене по убыванию
select model, price
from sneakers
group by price
order by price desc;

-- 84. Отсортируем клиентов по фамилии
select fio
from customer
group by fio
order by fio;

-- UNION, GROUP_CONCAT
-- 85. Выдадим премию работникам
SELECT `fio`, salary * 0.5 AS `prize`
FROM `worker`
WHERE salary <= 100000
UNION SELECT `fio`, salary * 0.25 AS `prize`
FROM `worker` 
WHERE salary <= 500000;

-- 86. Выведем значения модели кроссовок и размера экземпляров 
select model from sneakers
union all
select size from exemplar;

-- 87. Объединим фио сотрудников и клиентов в общий список
select fio from worker
union
select fio from customer;

-- GROUP_CONCAT 

-- 88. Вывести в одну строку все размеры экземпляров
select group_concat(size) from exemplar;

-- 89. Вывести в одну строку каждую модель кроссовок, цена которой будет выше 5000, а также чтобы она не имела бренд адидас
select group_concat(model) from sneakers
join brand
on sneakers.id = brand.id
where price > 5000 and brandname not like "Adidas";

-- 90. Вывести каждого клиента в одну строку, который имеет свой номер телефона
select group_concat(fio) from customer
where phonenumber > 0;

-- 91. Сложение строк: полная информация у работников
select *,
concat(fio, salary, post) as result
from worker;

-- 92. сложение строк с разделителем
select *,
concat_ws(' - ', model, price, gender) as result
from sneakers;

-- 93. Добавим к ФИО клиента подпись: необходимо ввести дату рождения, если ее нет
select *,
concat(fio, ', Внимание: необходимо ввести данные о рождении') as result
from customer
where birthdaydate is null;

-- 94. посчитаем длину строки
select *,
length(address) as length
from shop;

-- 95. Посчитать сумму всех зарплат работников
select sum(salary) from worker;

-- 96. Посчитать количество кроссовок с черным цветом
select count(id) from exemplar
where color = "black";

-- 97. Вывести всех клиентов не имеющих номер телефона и попросить их ввести его
select *,
concat('Введите пожалуйста номер телефона') as message
from customer
where phonenumber is null;

-- 98. Вывести отсортированный по возрастанию список кроссовок по цене, где гендер мужской, а цена не превышает 6000 и бренд адидас
select model, price from sneakers
join brand
on sneakers.id = brand.id
where gender = "male" and price <=6000 and brandname = "Adidas"
order by price;

-- 99. Вывести самую дорогую пару кроссовок 
select * from sneakers
order by price desc limit 1;

-- 100. Вывести ФИО покупателей, посчитать длину каждого ФИО
select fio, length(fio) from customer;

-- 1) Для заданного пользователя для заданного заказа по дате вывести суммарную стоимость заказа
-- 2) Для заданного магазина вывести для каждого бренда количество кроссовок в нем (бренд - количество) по убыванию топ 5
-- 3) Вывести для магазина весь его ассортимент
-- Поправить join связки 