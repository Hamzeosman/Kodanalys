Problem 1: Otydliga variabelnamn
Variablerna CelestialWhispers, magicConstant, UnicornSparkle, nanoBanana ocH fool kan vara väldigt vilseledande.
Dessutom bör klassen program skrivas med stort P(Program).
Genom att skriva koden på detta sätt så försämrar det både läsbarheten och förståelsen, man måste även kunna tolka koden på bästa sätt inte bara läsa den.
Det bryter även mot Clean Code-Principen, "Names should reveal intent".
Gör det svårare att underhålla och felsöka i framtiden.
Ett exempel på förbättring av koden är att använda mer passande namn som t.ex:
List<string> users = new();
int userCount = 0;
string userChoice;
bool isRunning = true;
Problem 2: Upprepande och hårdkodad kod
Koden för att söka efter anväändare förekommer både i "ta bort" och "sök"-funktionerna.
Hårdkodad arraystorlek (new string[10]) begränsar antalet användare.
Först och främst bryter detta mot DRY-principen(Don't Repeat Yourself).
Försvårar underhållningsprocessen eftersom man måste göra ändringar på flera olika ställen.
Genom att använda en array blir koden begränsad och svår att utöka.
En förbättring av koden skulle vara att skapa en metod för att söka användare och använd en List<string> istället för en array.
static List<string> users = new();

static int FindUserIndex(string name)
{
    return users.IndexOf(name);
}
Problem 3: Dålig struktur
All logik ligger i Main. vilket gör programmet svårtestat och svår att utveckla vidare.
En förbättring skulle vara att flytta användarhanteringen till en egen klass, t ex UserManager, vars funktion är att lägga till, ta bort, söka och visa användare.




