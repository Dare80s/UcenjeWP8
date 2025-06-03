use kolokvij_vjezba_1;

insert into sestra (sifra, introvertno, haljina, narukvica, maraka, hlace)values
(1, 1, 'Plava haljina', 2, 150.50, 'Traperice'),
(2, 0, 'Crvena haljina', 3, 200.75, 'Suknja'),
(3, NULL, 'Zelena haljina', NULL, 180.00, 'Hlače');

insert into zena (sifra, treciputa, hlace, kratkamajica, jmbag, bojaociju, haljina, sestra)values
(1, '2025-05-30 10:00:00', 'Crne hlače', 'Bijela majica', '12345678901', 'Plave', 'Plava haljina', 1),
(2, '2025-05-29 14:30:00', 'Sive hlače', 'Crna majica', '23456789012', 'Zelene', 'Crvena haljina', 2),
(3, NULL, 'Bež hlače', 'Siva majica', '34567890123', 'Smeđe', 'Zelena haljina', 3);

insert into muskarac (sifra, bojaociju, hlace, modelnaocala, maraka, zena)values
(1, 'Plave', 'Crne hlače', 'Ray-Ban', 300.00, 1),
(2, 'Zelene', 'Sive hlače', 'Oakley', 250.50, 2),
(3, 'Smeđe', 'Bež hlače', 'Gucci', 400.75, 3);

insert into svekar (sifra, bojaociju, prstena, dukserica, lipa, eura, majica)values
(1, 'Plave', 2, 'Crna dukserica', 50.25, 100.75, 'Bijela majica'),
(2, 'Zelene', 1, 'Siva dukserica', 60.00, 120.50, 'Crna majica'),
(3, 'Smeđe', 3, 'Bež dukserica', 70.75, 150.00, 'Siva majica');

insert sestra_svekar (sifra, sestra, svekar)values
(1, 1, 1),
(2, 2, 2),
(3, 3, 3);

select * from sestra;

select * from zena;

select * from muskarac;

select * from svekar;

select * from sestra_svekar;

update cura 
set gustoca = 15.77;

select sifra, gustoca from cura;

delete from mladic 
where kuna > 15.78;

select * from mladic where kuna > 15.78;

select kratkamajica from zena
where hlace like '%ana%';

-- ne postoji izravna veza između tablica mladic i zena
select svekar.dukserica, mladic.asocijalno, muskarac.hlace
from mladic
join muskarac on mladic.muskarac = muskarac.sifra
join zena on muskarac.zena = zena.sifra
join sestra on zena.sestra = sestra.sifra
join sestra_svekar on sestra.sifra = sestra_svekar.sestra
join svekar on sestra_svekar.svekar = svekar.sifra
where zena.hlace like 'a%' and sestra.haljina like '%ba%'
order by muskarac.hlace desc;

select sestra.haljina, sestra.maraka 
from sestra
left join sestra_svekar on sestra.sifra = sestra_svekar.sestra
where sestra_svekar.sestra is null;
