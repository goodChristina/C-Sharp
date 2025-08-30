// Rolls dice until either the Siren or Hero wins.


int hero = 10;
int siren = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    siren -= roll;
    Console.WriteLine($"Siren was damaged and lost {roll} health and now has {siren} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && siren > 0);

Console.WriteLine(hero > siren ? "Hero wins!" : "Siren wins!");
