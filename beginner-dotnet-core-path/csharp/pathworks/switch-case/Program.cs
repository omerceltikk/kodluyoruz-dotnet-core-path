// See https://aka.ms/new-console-template for more information

int month = DateTime.Now.Month;

//expression 
switch (month)
{
    case 1:
    Console.WriteLine("Ocak ayındasınız");
    break;
    case 2:
    Console.WriteLine("Şubat ayındasınız.");
    break;
    case 4:
    Console.WriteLine("nisan ayındasınız.");
    break;
    case 3:
    Console.WriteLine("mart ayındasınız.");
    break;

    default:
    break;
}
switch (month)
{   case 12:
    case 1:
    case 2:
     Console.WriteLine("Kış mevisimi");
     break;
     case 3:
    case 4:
    case 5:
     Console.WriteLine("ilkbahar mevisimi");
     break;

    default:
    break;
}
