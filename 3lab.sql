drop database shopsneakers;
create database shopsneakers;
use shopsneakers;
SET SQL_SAFE_UPDATES = 0;
CREATE TABLE `Sneakers` (
	`id` INT NOT NULL AUTO_INCREMENT,
	`model` VARCHAR(255) NOT NULL,
	`gender` VARCHAR(255) NOT NULL,
	`price` INT NOT NULL,
	`id_brand` INT NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE `Exemplar` (
	`id` INT NOT NULL AUTO_INCREMENT,
	`count` INT NOT NULL,
	`size` DECIMAL NOT NULL,
	`color` VARCHAR(255) NOT NULL,
	`id_sneakers` INT NOT NULL,
	`id_delivery` INT NOT NULL,
	`id_sale` INT NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE `TypeSneakers` (
	`id` INT NOT NULL AUTO_INCREMENT,
	`typeSneakers` VARCHAR(255) NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE `TypeSneakersToSneakers` (
	`id_sneakers` INT NOT NULL,
	`id_typesneakers` INT NOT NULL,
	PRIMARY KEY (`id_sneakers`,`id_typesneakers`)
);

CREATE TABLE `brand` (
	`id` INT NOT NULL AUTO_INCREMENT,
	`BrandName` VARCHAR(255) NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE `Delivery` (
	`id` INT NOT NULL AUTO_INCREMENT,
	`DateDelivery` DATE NOT NULL,
	`TimeDelivery` TIME NOT NULL,
	`id_provider` INT NOT NULL,
	`id_shop` INT NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE `Provider` (
	`id` INT NOT NULL AUTO_INCREMENT,
	`FIO` VARCHAR(255) NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE `Order` (
	`id` INT NOT NULL AUTO_INCREMENT,
	`TypePayment` VARCHAR(255) NOT NULL,
	`DatePayment` DATETIME NOT NULL,
	`id_customer` INT NOT NULL,
	`id_worker` INT NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE `Sale` (
	`id` INT AUTO_INCREMENT,
	`Size` VARCHAR(255) NOT NULL,
	`SaleName` VARCHAR(255) NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE `Shop` (
	`id` INT NOT NULL AUTO_INCREMENT,
	`address` VARCHAR(255) NOT NULL,
	`ShopName` VARCHAR(255) NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE `ExamplarInOrder` (
	`id_examplar` INT NOT NULL,
	`id_order` INT NOT NULL,
	`count` INT NOT NULL,
	PRIMARY KEY (`id_examplar`,`id_order`)
);

CREATE TABLE Customer (
id int not null auto_increment,
FIO varchar(255) not null,
BirthdayDate date,
PhoneNumber varchar(255),
primary key (id)
);

CREATE TABLE Worker (
id int not null auto_increment,
FIO varchar(255) not null,
salary varchar(255) not null,
post varchar(255) not null,
primary key (id)
);

CREATE TABLE `Schedule` (
id int not null auto_increment,
WorkDay date not null,
TimeStart time not null,
TimeEnd time not null,
primary key (id)
);

create table ScheduleWorker(
id_schedule int not null,
id_worker int not null,
primary key (id_schedule, id_worker)
);

create table ScheduleShop (
id_shop int not null,
id_schedule int not null,
primary key(id_shop, id_schedule)
);

insert into Sneakers 
values
(1,"Gazelle","male",4500,1),
(2,"Yung 1 ","male",5000,2),
(3,"Ultraboost uncased","male",12000,3),
(4,"Campus","male",3000,4),
(5,"Air Force 1","female",7000,5),
(6,"Air Force 1 low","female",6500,6),
(7,"Air Force by Travis Scott","male",30000,7),
(8,"Yeezy boost by Kanye West","male",22000,8),
(9,"Hamburg","female",4000,9),
(10,"Yeezy Boost 350","male",19300,10);

insert into Exemplar
values
(1,2,43,"black",1,1,1),
(2,3,42,"white",2,1,1),
(3,3,44,"grey",3,2,1),
(4,3,44,"black",4,2,1),
(5,3,39,"white",5,2,1),
(6,3,38,"white",6,2,1),
(7,3,44,"orange",7,2,1),
(8,3,44,"green",8,2,1),
(9,3,37,"blue",9,2,1),
(10,3,42,"grey",10,2,1);

insert into TypeSneakers
values
(1,"walking"),
(2,"running"),
(3,"sport");

insert into TypeSneakersToSneakers
values
(1,1),
(2,1),
(2,2),
(3,1),
(4,1),
(5,1),
(6,1),
(6,2),
(7,3),
(8,1),
(9,3),
(10,1);

insert into Brand
values
(1,"Adidas"),
(2,"Adidas"),
(3,"Adidas"),
(4,"Adidas"),
(5,"Nike"),
(6,"Nike"),
(7,"Nike"),
(8,"Adidas"),
(9,"Adidas"),
(10,"Adidas");

insert into Delivery
values
(1,"23.02.2021","15:00",1,1),
(2,"24.02.2021", "9:15",2,1),
(3,"24.06.2021", "9:15",2,1);

insert into Provider
values
(1, "Gjegoj Bjencheshchikevich"),
(2, "Natalia Morskaya Pehota");

insert into `Order`
values 
(1,"VISA Card","24.02.2021",1,1),
(2,"VISA Card","24.02.2021",1,1),
(3,"VISA Card","25.02.2021",2,1),
(4,"VISA Card","25.02.2021",3,1),
(5,"VISA Card","25.02.2021",3,1),
(6,"VISA Card","25.02.2021",4,1),
(7,"VISA Card","26.02.2021",5,2),
(8,"VISA Card","26.02.2021",6,2),
(9,"VISA Card","26.02.2021",7,2),
(10,"VISA Card","26.02.2021",8,1);

insert into Sale
values
(1,"0%","Without sale"),
(2,"15%","New year");

insert into Shop
values
(1,"Ul lenina 44", "Sneakers for people");

insert into ExamplarInOrder
values
(1,1,1),
(2,2,1),
(4,3,1),
(3,4,1),
(10,5,1),
(9,6,1),
(6,7,1),
(7,8,1),
(8,9,1),
(5,10,1);

insert into Customer
values
(1,"Nikolenko Danila Aleksandrovich",null,"89272520629"),
(2,"Lintcov Ivan Nikolaevich",null,"89285241242"),
(3,"Sherbinin Viktor Sergeevich",null,"89249520394"),
(4,"Alugo Alina Alekseevna",null, null),
(5,"Ivanov Viktor Michaelovich",null,null),
(6,"Kravchenya Pavel Dmitrievich",null,null),
(7,"Sychev Oleg Aleksandrovich",null,null),
(8,"Dritrivev Alexey Vladimirocich",null,null);

insert into Worker
values
(1,"Winchester Dean", 14000,"cashier"),
(2,"Winchester Sam", 20000,"cashier");

insert into `Schedule`
values 
(1,"24.02.2001","9:00","22:00"),
(2,"25.02.2001","9:00","22:00"),
(3,"26.02.2001","9:00","22:00"),
(4,"27.02.2001","9:00","22:00"),
(5,"28.02.2001","10:00","20:00");

insert into ScheduleWorker
values
(1,1),
(2,1),
(3,1),
(4,1),
(4,2),
(5,1);

insert into ScheduleShop
values
(1,1),
(1,2),
(1,3),
(1,4),
(1,5);



alter table ScheduleShop add constraint SheduleShop_fk0 foreign key (id_schedule) references `Schedule`(id);
alter table ScheduleShop add constraint SheduleShop_fk1 foreign key (id_shop) references `Shop`(id);

alter table ScheduleWorker add constraint SheduleWorker_fk0 foreign key (id_schedule) references `Schedule`(id);
alter table ScheduleWorker add constraint SheduleWorker_fk1 foreign key (id_worker) references `Worker`(id);

ALTER TABLE `Sneakers` ADD CONSTRAINT `Sneakers_fk0` FOREIGN KEY (`id_brand`) REFERENCES `brand`(`id`);

ALTER TABLE `Exemplar` ADD CONSTRAINT `Exemplar_fk0` FOREIGN KEY (`id_sneakers`) REFERENCES `Sneakers`(`id`);

ALTER TABLE `Exemplar` ADD CONSTRAINT `Exemplar_fk1` FOREIGN KEY (`id_delivery`) REFERENCES `Delivery`(`id`);

ALTER TABLE `Exemplar` ADD CONSTRAINT `Exemplar_fk2` FOREIGN KEY (`id_sale`) REFERENCES `Sale`(`id`);

ALTER TABLE `TypeSneakersToSneakers` ADD CONSTRAINT `TypeSneakersToSneakers_fk0` FOREIGN KEY (`id_sneakers`) REFERENCES `Sneakers`(`id`);

ALTER TABLE `TypeSneakersToSneakers` ADD CONSTRAINT `TypeSneakersToSneakers_fk1` FOREIGN KEY (`id_typesneakers`) REFERENCES `TypeSneakers`(`id`);

ALTER TABLE `Delivery` ADD CONSTRAINT `Delivery_fk0` FOREIGN KEY (`id_provider`) REFERENCES `Provider`(`id`);

ALTER TABLE `Delivery` ADD CONSTRAINT `Delivery_fk1` FOREIGN KEY (`id_shop`) REFERENCES `Shop`(`id`);

ALTER TABLE `Order` ADD CONSTRAINT `Order_fk0` FOREIGN KEY (`id_customer`) REFERENCES `Customer`(`id`);

ALTER TABLE `Order` ADD CONSTRAINT `Order_fk1` FOREIGN KEY (`id_worker`) REFERENCES `Worker`(`id`);

ALTER TABLE `ExamplarInOrder` ADD CONSTRAINT `ExamplarInOrder_fk0` FOREIGN KEY (`id_examplar`) REFERENCES `Exemplar`(`id`);

ALTER TABLE `ExamplarInOrder` ADD CONSTRAINT `ExamplarInOrder_fk1` FOREIGN KEY (`id_order`) REFERENCES `Order`(`id`);

-- SELECT * FROM Sneakers;
-- SELECT * FROM TypeSneakers;
-- SELECT * FROM TypeSneakersToSneakers;
-- SELECT * FROM Brand;
-- SELECT * FROM Delivery;
-- SELECT * FROM Provider;
-- SELECT * FROM `Order`;
-- SELECT * FROM Sale ;
-- SELECT * FROM Shop;
-- SELECT * FROM ExamplarInOrder;
-- SELECT * FROM Customer;
-- SELECT * FROM `Schedule`;
-- SELECT * FROM ScheduleWorker;
-- SELECT * FROM ScheduleShop;

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

-- 23. Удалить поставку 
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
-- проверка)
