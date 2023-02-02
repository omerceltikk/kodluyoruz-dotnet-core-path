// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

try
{
    Console.WriteLine("Bir sayı giriniz:");
    int sayi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("girmiş olduğunuz sayı :" + sayi);
}catch(Exception ex){
    Console.WriteLine("Hata :" + ex.Message.ToString());
}finally
{
    Console.WriteLine("işlem tamamlandı");
}

try{
    int a = int.Parse(null);
    int b = int.Parse("-200000000000000");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Boş değer girdiniz");
    Console.WriteLine(ex);
}
catch (FormatException ex) {
    Console.WriteLine("Format tipi uygun değil");
    Console.WriteLine(ex);
}
catch (OverflowException ex){
    Console.WriteLine("çok küçük veya çok büyük bir değer girdiniz");
    Console.WriteLine(ex);
}