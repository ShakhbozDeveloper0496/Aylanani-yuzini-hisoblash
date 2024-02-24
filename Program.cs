
// Doira yuzi va aylana uzunligini hisoblash

Console.WriteLine("Radiusni kiriting: ");
double radFirst = Convert.ToDouble(Console.ReadLine());
decimal rad = (decimal)radFirst;
double pi = Math.PI;
decimal piBig = (decimal)pi;
decimal aylanaS = piBig * rad * rad;
decimal aylanaL = 2 * piBig * rad;
Console.WriteLine($"S= {aylanaS}");
Console.WriteLine($"L= {aylanaL}");







