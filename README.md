Problem 1: Otydliga variabelnamn

Variablerna CelestialWhispers, magicConstant, UnicornSparkle, nanoBanana ocH fool kan vara väldigt vilseledande.
Dessutom bör klassen program skrivas med stort P(Program).
Genom att skriva koden på detta sätt så försämrar det både läsbarheten och förståelsen, man måste även kunna tolka koden inte bara läsa den.
Det bryter även mot Clean Code-Principen, "Names should reveal intent".
Gör det svårare att underhålla och felsöka i framtiden.
Förbättring:
Alla variabler och metoder fick tydliga och konsekventa namn, exempelvis users, Adduser(), Searchuser().

Problem 2: Upprepande och hårdkodad kod

Koden för att söka efter anväändare förekommer både i "ta bort" och "sök"-funktionerna.
Hårdkodad arraystorlek (new string[10]) begränsar antalet användare.
Först och främst bryter detta mot DRY-principen(Don't Repeat Yourself).
Försvårar underhållningsprocessen eftersom man måste göra ändringar på flera olika ställen.
Genom att använda en array blir koden begränsad och svår att utöka.
Förbätttring:
Arrayen ersattes med en List<string>, vilket gör programmet dynamiskt och enklare att hantera.
Jag skapade även en metod för att söka användare, vilket tog bort upprepning i koden.


Problem 3: Dålig struktur

All logik ligger i Main. vilket gör programmet svårtestat och svår att utveckla vidare.
En förbättring skulle vara att flytta användarhanteringen till en egen klass, t ex UserManager, vars funktion är att lägga till, ta bort, söka och visa användare.
Förbättring:
Jag skapade en separat klass UserManager som ansvarar för användarhantering.
Menyn i Program omstrukturerades till en switch-sats för bättre läsbarhet.

Genomförda förbättringar (commits)

1. Förbättrade variabel och metod namn, ökad läsbarhet och konsekvens.
2. Bytte ut array mot list och tog bort duplicerad kod, flexibilitet och DRY.
3. Flyttade logik till UserManager och förenklade menyn, förbättrad struktur och SRP.


Förslag på ytterligare förbättringar:

Införa felhantering med try/catch för ogiltig inmatning.
Genomföra lagring till fil eller databas.
Dela upp klasser i egna filer för bättre struktur.
Införa enhetstester för att säkerställa att varje metod fungerar korrekt.

Reflektion:
Med hjälp av denna uppgift har jag fått en bättre förståelse för hur tydlig kod, rätt struktur och beskrivande namn kan göra stor skillnad för programmets funktionalitet.
Jag lärde mig hur principer som DRY, SRP och Clean Code, bidrar till långsiktig kvalitet och underhållbarhet.
Genom att använda mig utav Git och göra tydliga commits under projektets gång så har det hjälpt mig arbeta strukturerat, vilket i sin tur underlättade mycket med refaktoriseringen.

Efter refaktoriseringen är programmet mycket mer läsbart och lättare att tolka, samt även lättare att bygga vidare på och återanvända.






