use kolokvij_vjezba_2

insert into decko (sifra, indiferentno, vesta, asocijalno) values
(1, 0, 'Plava vesta', 1),
(2, 1, 'Crvena vesta', 0),
(3, 0, 'Zelena vesta', 1);

insert into cura (sifra, haljina, drugiputa, suknja, narukvica, introvertno, majica, decko) values
(1, 'Haljina A', '2025-06-01 10:00:00', 'Suknja A', 101, 1, 'Majica A', 1),
(2, 'Haljina B', '2025-06-02 11:00:00', 'Suknja B', 102, 0, 'Majica B', 2),
(3, 'Haljina C', '2025-06-03 12:00:00', 'Suknja C', 103, 1, 'Majica C', 3);

Insert into neprijatelj (sifra, majica, haljina, lipa, modelnaocala, kuna, jmbag, cura) values
(1, 'Majica X', 'Haljina X', 12.34567890, 'Model X', 123.456789, '12345678901', 1),
(2, 'Majica Y', 'Haljina Y', 23.45678901, 'Model Y', 234.567890, '23456789012', 2),
(3, 'Majica Z', 'Haljina Z', 34.56789012, 'Model Z', 345.678901, '34567890123', 3);

insert into zarucnica (sifra, narukvica, bojakose, novcica, lipa, indiferentno) values
(1, 201, 'Plava', 123.456789123, 12.34567890, 1),
(2, 202, 'Crvena', 234.567891234, 23.45678901, 0),
(3, 203, 'Zelena', 345.678912345, 34.56789012, 1);

insert into decko_zarucnica (sifra, decko, zarucnica) values
(1, 1, 1),
(2, 2, 2),
(3, 3, 3);

select * from decko;

select * from cura;

select * from neprijatelj;

select * from zarucnica;



update prijatelj
set treciputa = '2020-04-30 00:00:00';

delete from brat
where ogrlica <> 14 or ogrlica is null;

select * from brat
where ogrlica <> 14 or ogrlica is null;

select suknja from cura
where drugiputa is null;

select z.novcica, b.neprijatelj, n.haljina
from cura c
join decko d on c.decko = d.sifra
join decko_zarucnica dz on d.sifra = dz.decko
join zarucnica z on dz.zarucnica = z.sifra
join neprijatelj n on c.sifra = n.cura
join brat b on n.sifra = b.neprijatelj
where c.drugiputa is null
and d.vesta like '%ba%'
order by n.haljina desc;

select d.vesta, d.asocijalno
from decko d
left join decko_zarucnica dz on d.sifra = dz.decko
where dz.decko is null;