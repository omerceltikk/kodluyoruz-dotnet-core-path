// See https://aka.ms/new-console-template for more information
double pi = 3.14;

Console.WriteLine("Lütfen Tanımlamak istediğiniz geometrik şekili seçiniz");
Console.WriteLine("Daire (1)");
Console.WriteLine("Dikdörtgen (2)");
Console.WriteLine("Kare (3)");
Console.WriteLine("Üçgen (4)");

int value = int.Parse(Console.ReadLine());

Console.WriteLine("Lütfen hesaplamak istediğiniz metodu seçiniz");
Console.WriteLine("Alan (1)");
Console.WriteLine("Çevre (2)");
int value2 = int.Parse(Console.ReadLine());


if(value == 1){
    switch (value2)
    {
        case 1:
        Console.WriteLine("Dairenin yarıçapını giriniz");
        int r = int.Parse(Console.ReadLine());
        double circleResult = r*r*pi;
        Console.WriteLine("Dairenin alanı:" + circleResult);
        break;
         
        case 2:
        Console.WriteLine("Dairenin yarıçapını giriniz");
        int r2 = int.Parse(Console.ReadLine());
        double circleResult2 = 2*pi*r2;
        Console.WriteLine("Dairenin çevresi:" + circleResult2);
        break;
        default:
        Console.WriteLine("Yanlış bir değer girdiniz");
        break;
    }
}
else if(value == 2){
    switch (value2)
    {
        case 1:
        Console.WriteLine("Dikdörtgenin Uzun Kenarını Giriniz");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Dikdörtgenin Kısa Kenarını Giriniz");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Dikdörtgenin Alanı: "+ a*b);
        break;
        case 2:
        Console.WriteLine("Dikdörtgenin Uzun Kenarını Giriniz");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Dikdörtgenin Kısa Kenarını Giriniz");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine("Dikdörtgenin Çevresi: "+ (2*(x+y)));
        break;
        default:
         Console.WriteLine("Yanlış bir değer girdiniz");
        break;
    }
}
else if(value == 3){
    switch (value2)
    {
        case 1:
        Console.WriteLine("Karenin kenar uzunluğunu Giriniz");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Dikdörtgenin Alanı: "+ a*a);
        break;
        case 2:
        Console.WriteLine("Karenin kenar uzunluğunu Giriniz");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Dikdörtgenin Çevresi: "+ (4*x));
        break;
        default:
         Console.WriteLine("Yanlış bir değer girdiniz");
        break;
    }
}
else if(value == 4){
    switch (value2)
    {
        case 1:
        Console.WriteLine("Üçgenin taban uzunluğu ve yüksekliğini giriniz");
        Console.Write("taban: "); int x = int.Parse(Console.ReadLine());
        Console.Write("yükseklik: "); int y = int.Parse(Console.ReadLine());
        Console.WriteLine("Üçgenin Alanı: "+ (x*y/2));
        break;
        case 2:
        Console.WriteLine("Üçgenin kenar uzunluklarını Giriniz");
        Console.Write("1.Kenar"); int a = int.Parse(Console.ReadLine());
        Console.Write("2.Kenar"); int b = int.Parse(Console.ReadLine());
        Console.Write("3.Kenar"); int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Üçgenin Çevresl: "+ (a+b+c));
        break;
        default:
         Console.WriteLine("Yanlış bir değer girdiniz");
        break;
    }
}else{
    Console.WriteLine("yanlış bir değer girdiniz");
}