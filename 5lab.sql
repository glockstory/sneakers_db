use  shopsneakers;
-- тест
CREATE VIEW abrand
AS SELECT size, BrandName
from Exemplar e
join sneakers s
on e.id_sneakers = s.id
join brand b
on s.id_brand = b.id
where BrandName = "Nike";
SELECT  * from abrand;
create unique index ind_brandname
on brand (brandname);


-- 1 индекс
select FIO, BrandName
from Customer c
join `Order` ord
on c.id = ord.id_customer
join examplarinorder ex
on ex.id_order = ord.id
join exemplar
on exemplar.id = ex.id_examplar
join sneakers
on exemplar.id_sneakers = sneakers.id
join Brand b
on sneakers.id_brand = b.id
where BrandName = "Nike";

create index idx_brandName on Brand(BrandName);
drop index idx_brandName on Brand;

-- 2 индекс
select model, size
from Sneakers s
join Exemplar e 
on s.id = e.id_sneakers
where size = 43;

create index idx_size on exemplar(size);

-- 3 индекс
select model, size
from sneakers
join exemplar 
on exemplar.id_sneakers=sneakers.id
where model = "Gazelle";

create index idx_model on sneakers(model);

-- 4 индекс
select brandname, exemplar.count, model
from exemplar
join sneakers on sneakers.id = exemplar.id_sneakers
join brand on brand.id = sneakers.id_brand
where exemplar.count = 2;

CREATE INDEX idx_exCount on exemplar(count);

-- 5 индекс
select FIO, datedelivery
from provider
join delivery 
on provider.id = delivery.id_provider
where datedelivery = "2023-02-20";
create index datedeliveryindx on delivery(datedelivery);
create index exemplarid on exemplar(

-- 1. Процедура - каждая существующая модель кроссовок по цене выше 5000 и НЕ адидас помещаются в строчку
DELIMITER //

CREATE PROCEDURE modelsSneakers()
BEGIN 
	select group_concat(model) from sneakers
join brand
on sneakers.id_brand = brand.id
where price > 5000 and brandname not like "Adidas";
END //
DELIMITER ; 

CALL modelsSneakers();


-- 2. Процедура поиска всех брендов, в названии которых есть символ "а"
DELIMITER //

CREATE PROCEDURE brandLikeA()
BEGIN 
	SELECT brandname
    from brand
    where brandname like "%a%";
END //
DELIMITER ;

call brandLikeA();

-- 3. Процедура поиска кроссовок по брендам, у которых размер менее 40
DELIMITER //

CREATE PROCEDURE sizeLess()
BEGIN 
select brandname, size
from brand b
join exemplar e
on b.id = e.id_sneakers
where size < 40;
END //
DELIMITER ;

call sizeLess();

-- 3 функции
-- 1. Функция вычисления кэшбека за товары в определенной ценовой категории и бренда
DELIMITER $$ 
CREATE FUNCTION Sale (
	cashback INT
)
RETURNS  INT
DETERMINISTIC
BEGIN
	IF cashback > 1000 AND cashback < 25000 THEN
		SET cashback = 0.1 * cashback;
	END IF; 
RETURN (cashback); 
END $$; 
DELIMITER $$ 	

SELECT Sale (price)
FROM`sneakers`
join brand on brand.id = sneakers.id_brand
WHERE BrandName = "Adidas";

-- 2. Функция проверка наличия мобильного телефона у клиентов
DELIMITER $$ 
CREATE FUNCTION CountPeopleFor (
	phonenumber varchar(255)
)
RETURNS  INT
DETERMINISTIC
BEGIN
declare HavePhone boolean;
set HavePhone = true;
	IF phonenumber IS NULL THEN
		 SET HavePhone = false;
			else
            set HavePhone = true;
	END IF; 
RETURN (HavePhone); 
END $$; 
DELIMITER $$ 	

SELECT CountPeopleFor(phonenumber) as HavePhoneNumber, FIO
FROM Customer;

-- 3. Функция установки скидки на товары дороже 20000 в размере 10%
DELIMITER $$ 
CREATE FUNCTION SetPriceOnSneakers (
	price int
)
RETURNS  INT
DETERMINISTIC
BEGIN
	IF price > 20000 THEN
			set price = price * 0.9;
	END IF; 
RETURN (price); 
END $$; 
DELIMITER $$ 	

SELECT SetPriceOnSneakers(price), model
FROM Sneakers;
-- 3 представления

-- 1. Вывести ассортимент магазина
CREATE VIEW informationAboutShop
AS SELECT   shopname, count, model, price
from Shop 
join delivery 
on delivery.id_shop = shop.id
join Exemplar
on delivery.id = exemplar.id_delivery
join sneakers
on sneakers.id = exemplar.id_sneakers;

SELECT * FROM informationAboutShop;

-- 2. График работы сотрудников магазина
CREATE VIEW ScheduleWorkers
AS SELECT FIO, workday, TimeStart, TimeEnd
from Worker w
join scheduleworker s
on w.id = s.id_worker
join `Schedule` sc
on sc.id = s.id_schedule;

SELECT * FROM ScheduleWorkers;

-- 3. Модель кроссовок и их тип
CREATE VIEW ModelAndType
as select model, typeSneakers
from Sneakers as `a`
join typesneakerstosneakers as `b`
on a.id = b.id_sneakers
join typesneakers t
on t.id = b.id_typesneakers;

SELECT * FROM ModelAndType;