// See https://aka.ms/new-console-template for more information
using UserBooking;
using userinfo;

Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz.");
    Console.WriteLine("(1) Yeni Numara Kaydetmek");
    Console.WriteLine("(2) Varolan Kişiyi Silmek");
    Console.WriteLine("(3) Varolan Kişiyi Güncelleme");
    Console.WriteLine("(4) Rehberi Listelemek");
    Console.WriteLine("(5) Rehberde Arama Yapmak");
    int islem = int.Parse(Console.ReadLine());
    Booking booking = new Booking();

if(islem ==1){
       Console.WriteLine("Lütfen İsminizi Giriniz.");
    string name = Console.ReadLine();
    Console.WriteLine("Lütfen Soyisminizi Giriniz.");
    string surname = Console.ReadLine();
    Console.WriteLine("Lütfen Telefon numaranızı Giriniz.");
    string phone_number = Console.ReadLine();
    if(phone_number.Length==8){
      booking.Add(name,surname,phone_number);
    }
}
else if(islem==2)
{
     Console.WriteLine("Silme işlemi için Lütfen İsminizi Giriniz.");
    string name = Console.ReadLine();
    Console.WriteLine(" Silme işlemi için Lütfen Soyisminizi Giriniz.");
    string surname = Console.ReadLine();
    booking.Delete(name,surname);
}
else if(islem == 3)
{
    Console.WriteLine("Lütfen Verilerinizin Güncellenmesi İçin İsminizi Giriniz.");
    string name = Console.ReadLine();
    Console.WriteLine("Lütfen Verilerinizin Güncellenmesi İçin Soyisminizi Giriniz.");
    string surname = Console.ReadLine();
    Console.WriteLine("Lütfen Verilerinizin Güncellenmesi İçin Telefon numaranızı Giriniz.");
    string phone_number = Console.ReadLine();
    booking.Update(name,surname,phone_number);
}
else if(islem == 4)
{
    Console.WriteLine("Kullanıcı Listesi");
    booking.GetUsers();
}
else if(islem == 5)
{
    Console.WriteLine("Lütfen Aramak İstediğiniz Kişinin İsmini Giriniz.");
    string name = Console.ReadLine();
    booking.Get(name);
}
