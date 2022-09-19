Console.WriteLine("Valiutos keitykla");
Console.WriteLine("M E N I U");
Console.WriteLine("---------------------------------");
Console.WriteLine("1. Į JAV dolerius");
Console.WriteLine("2. Į Lenkijos zlotus");
Console.WriteLine("3. Į Baltarusijos rublius");
Console.WriteLine("4. Pabaiga");
string e;
Console.WriteLine("Įveskite keičiamą sumą EUR");
double euras = Console.ReadLine(Convert.ToDouble(e));
string pasirinkimas;
Console.ReadLine(pasirinkimas);
switch (pasirinkimas) {
    case "1": BuyingDollar(euras);break;
    case "2": BuyingZlot(euras);break;
    case "3": BuyingBYRouble(euras);break;
    default: break;
}
void BuyingDollar(double euro){
    string c;
    double Total;
    Console.WriteLine("Įveskite dolerio kurso koeficientą");
    double course = Console.ReadLine(Convert.ToDouble(c));
    Total = course * euro;
    Console.WriteLine("Jums priklauso {0:F4) dollars", Total);
}
void BuyingZlot(double euro){
    string c;
    double Total;
    Console.WriteLine("Įveskite dolerio kurso koeficientą");
    double course = Console.ReadLine(Convert.ToDouble(c));
    Total = course * euro;
    Console.WriteLine("Jums priklauso {0:F4) zlots", Total);
}
void BuyingBYRouble(double euro){
    string c;
    double Total;
    Console.WriteLine("Įveskite dolerio kurso koeficientą");
    double course = Console.ReadLine(Convert.ToDouble(c));
    Total = course * euro;
    Console.WriteLine("Jums priklauso {0:F4) BYroubles", Total);
}
