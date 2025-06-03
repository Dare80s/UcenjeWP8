use kolokvij_vjezba_3;


insert into prijatelj (sifra, kuna, haljina, lipa, dukserica, indiferentno) values
(1, 100.00, 'Haljina A', 50.00, 'Dukserica A', 1),
(2, 150.00, 'Haljina B', 75.00, 'Dukserica B', 0),
(3, 200.00, 'Haljina C', 100.00, 'Dukserica C', 1);

insert into brat (sifra, jmbag, ogrlica, ekstroventno) values
(1, '12345678901', 1, 1),
(2, '23456789012', 2, 0),
(3, '34567890123', 3, 1);

insert into ostavljena (sifra, kuna, lipa, majica, modelnaocala, prijatelj) values
(1, 100.00, 50.00, 'Majica A', 'Model A', 1),
(2, 150.00, 75.00, 'Majica B', 'Model B', 2),
(3, 200.00, 100.00, 'Majica C', 'Model C', 3);

insert into snasa (sifra, introvertno, kuna, eura, treciputa, ostavljena) values
(1, 1, 100.00, 50.00, '2025-06-01 10:00:00', 1),
(2, 0, 150.00, 75.00, '2025-06-02 11:00:00', 2),
(3, 1, 200.00, 100.00, '2025-06-03 12:00:00', 3);

select * from prijatelj;

select *from brat;

select * from ostavljena;

select * from snasa;

update svekar
set suknja = 'Osijek';

delete from punica
where kratkamajica = 'AB';

select brat.ekstroventno, punica.vesta, snasa.kuna
from brat
join prijatelj_brat on brat.sifra = prijatelj_brat.brat
join prijatelj on prijatelj_brat.prijatelj = prijatelj.sifra
join ostavljena on prijatelj.sifra = ostavljena.prijatelj
join snasa on ostavljena.sifra = snasa.ostavljena
join punica on snasa.sifra = punica.snasa
where ostavljena.lipa <> 91
and prijatelj.haljina like '%ba%'
order by
snasa.kuna desc;

select p.haljina, p.lipa
from prijatelj p 
left join prijatelj_brat pb on p.sifra = pb.prijatelj
where pb.prijatelj is null;
