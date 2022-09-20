Console.WriteLine("Valiutos keitykla");
Console.WriteLine("M E N I U");
Console.WriteLine("---------------------------------");
Console.WriteLine("1. Į JAV dolerius");
Console.WriteLine("2. Į Lenkijos zlotus");
Console.WriteLine("3. Į Baltarusijos rublius");
Console.WriteLine("4. Pabaiga");
Console.WriteLine("Įveskite keičiamą sumą EUR");
double Total;
double euras = Convert.ToDouble(Console.ReadLine());
string currency;
Console.WriteLine("Dabar įvesk pasirinkimą");
double choose = Convert.ToInt32(Console.ReadLine());
if (choose == 4)
{
    return;
}
Console.WriteLine("Įvesk kurso koeficientą");
double course = Convert.ToDouble(Console.ReadLine());
switch (choose)
{
    case 1: currency = "dollars"; Buying(euras,course,currency);  break;
    case 2:currency = "zlotych"; Buying(euras, course, currency); break;
    case 3: currency = "rubley"; Buying(euras, course, currency); break;
    
}

void Buying(double euro,double cours,string geld){
    Total = cours * euro;
    Console.WriteLine("Jums priklauso {0:F4} {1}", Total,geld);
}
