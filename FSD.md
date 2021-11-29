# Top 5 Asteroids

### Verze 1.1

Pejsar Vojtěch  
pejsar.vojtech.2018@ssps.cz  
poslední úprava 29.11.2021

## Úvod
### Účel
- Program bude pomocí navigace shell zobrazovat hlávní stránku na které bude NASA APOD obrázek. Z hlávní stránky se pomocí shell menu bude možné dostat na stránku ve které se budou zobrazovat asteroidy pro daný den.
### Konvence dokumentu
- Důležité informace jsou napsány **tučně**
### Odkazy 
- odkaz
## Specifikace
### Základní funkce programu
- Zobrazování asteroidů podle data po dnech podle vzdálenosti od země v dané datum.
- Zobrazení obrázku APOD na úvodní obrazovce.
- Stránka s grafy bude zobrazovat jednoduché grafy o počtech výskytů asteroidů v daný den.
### Uživatelské role 
- Program je určený pro uživatele který chce vědět jaké mu dnes nebo v další dny bude hrozit nebezpečí.
### Vymezení rozsahu
- Program bude zobrazovat asteroidy pouze po dnech. Delší datové rozmezí nebude k dispozici.
### Nižší priorita
- Stránka s grafy bude jednodušší. Nejsíš bude obsahovat jen jeden graf.
## Scénáře
1. Hlavní stránka
2. Asteroidy po dnech
3. Graf stránka
### Hlavní stránka
- Název aplikace
- Popis aplikace
- Obrázek na pozadí
#### Akce
- Stránka bude pouze grafická
### Asteroidy po dnech
- Stránka na které se budou zobrazovat asteroidy které budou ten den nejblíže zemi
#### Akce
- Swipe pohybem bude možné posunout se na další den
- Kliknutím na jednotlivé asteroidy se objeví další informace o asteroidu
#### Možné chyby
- Asteroidy se nebudou načítat dostatečně rychle z databáze
### Graf stránka
- Stránka s grafem zobrazující informace o dnešním dni v grafu
#### Akce
- Zadáním jiného data se zobrazí informace o daném dni
