select * from smjerovi;

--1 ->
use edunovawp8;

insert into smjerovi (naziv,cijena,datumpokretanja,aktivan)
values ('Web programiranje',1200.54,'2025-05-16 17:00:01',1);

insert into smjerovi (naziv) values
--2
('Serviser'),
--3
('Web dizajn'),
--4
('Marketing');

insert into grupe(naziv,smjer)
values
--1
('WP8',1),
--2
('WP7',1),
--3
('S1',2);