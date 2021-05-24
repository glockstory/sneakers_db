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

DELIMITER //

CREATE PROCEDURE FirstProcedure()
BEGIN 
	SELECT 'This is my first procedure';
END //
DELIMITER ; 

CALL FirstProcedure();

DELIMITER //

CREATE PROCEDURE brandLikeA()
BEGIN 
	SELECT brandname
    from brand
    where brandname like "%a%";
END //
DELIMITER ;

call brandLikeA();