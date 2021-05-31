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
(2,"Yung 1 ","male",5000,1),
(3,"Ultraboost uncased","male",12000,1),
(4,"Campus","male",3000,3),
(5,"Air Force 1","female",7000,2),
(6,"Air Force 1 low","female",6500,2),
(7,"Air Force by Travis Scott","male",30000,2),
(8,"Yeezy boost by Kanye West","male",22000,3),
(9,"Hamburg","female",4000,4),
(10,"Yeezy Boost 350","male",19300,5);

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
(2,"Nike"),
(3,"Asics"),
(4,"New Balance"),
(5,"Puma"),
(6,"Bershka"),
(7,"Demix"),
(8,"Zara"),
(9,"H&M"),
(10,"Pull&Bear");

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


