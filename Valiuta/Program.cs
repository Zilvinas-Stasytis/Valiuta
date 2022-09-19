Console.WriteLine("Valiutos keitykla");
Console.WriteLine("M E N I U");
Console.WriteLine("---------------------------------");
Console.WriteLine("1. Į JAV dolerius");
Console.WriteLine("2. Į Lenkijos zlotus");
Console.WriteLine("3. Į Baltarusijos rublius");
Console.WriteLine("4. Pabaiga");
Console.WriteLine("Įveskite keičiamą sumą EUR");
double Total;
string e = Console.ReadLine();
double euras = Convert.ToDouble(e);
Console.WriteLine("Dabar įvesk pasirinkimą");
string pasirinkimas = Console.ReadLine();
double choose = Convert.ToInt32(pasirinkimas); 
switch (choose)
{
    case 1: BuyingDollar(euras); break;
    case 2: BuyingZlot(euras); break;
    case 3: BuyingBYRouble(euras); break;
    default:return;
}

void BuyingDollar(double euro){
    string c;
    Console.WriteLine("Įveskite dolerio kurso koeficientą");
    c = Console.ReadLine();
    double course = Convert.ToDouble(c);
    Total = course * euro;
    Console.WriteLine("Jums priklauso {0:F4} dollars", Total);
}
void BuyingZlot(double euro){
    string c;
    double Total;
    Console.WriteLine("Įveskite zloto kurso koeficientą");
    c = Console.ReadLine();
    double course = Convert.ToDouble(c);
   Total = course * euro;
    Console.WriteLine("Jums priklauso {0:F4} zlots", Total);
}
void BuyingBYRouble(double euro){
    string c;
    double Total;
    Console.WriteLine("Įveskite dolerio kurso koeficientą");
    c = Console.ReadLine();
    double course = Convert.ToDouble(c);
    Total = course * euro;
    Console.WriteLine("Jums priklauso {0:F4} BYroubles", Total);
}
