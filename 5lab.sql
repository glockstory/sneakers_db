use  shopsneakers;

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
select model, size
from Sneakers s
join Exemplar e 
on s.id = e.id_sneakers
where size = 43;

create index idx_size on exemplar(size);

select model, size
from sneakers
join exemplar 
on exemplar.id_sneakers=sneakers.id
where model = "Gazelle";

create index idx_model on sneakers(model);

select phonenumber
from customer
where phonenumber = "89272520629"; 
create index idx_phonenumber on customer(phonenumber);

select FIO, datedelivery
from provider
join delivery 
on provider.id = delivery.id_provider
where datedelivery = "2023-02-20";
create index datedeliveryindx on delivery(datedelivery);
create index exemplarid on exemplar(

-- 1. Процедура 
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


-- 2. Процедура
DELIMITER //

CREATE PROCEDURE brandLikeA()
BEGIN 
	SELECT brandname
    from brand
    where brandname like "%a%";
END //
DELIMITER ;

call brandLikeA();

-- 3. Процедура 
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

