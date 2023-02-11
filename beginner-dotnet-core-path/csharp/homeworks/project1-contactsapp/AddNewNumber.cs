using userinfo;
namespace UserBooking
{
    public class Booking
{ 
    List<User> _users;
    public Booking(){
         _users = new List<User>{
            new User { name = "Ahmet",  surname = "ASD",phone_number="22222222" },
         new User { name = "Cevdet",  surname = "DFG",phone_number="33322222" },
         new User { name = "Nuri",  surname = "HJK",phone_number="00022211" },
         new User { name = "Mahmut",  surname = "ZXC",phone_number="5550011" },
         new User { name = "Gül",  surname = "CVB",phone_number="7778899" },
                
         };
    }  
    public void Add(string name, string surname,string phone_number){
        User user = new User();
        user.name = name;
        user.surname = surname;
        user.phone_number= phone_number;
        _users.Add(user);
        Console.WriteLine("Kaydetme işlemi tamamlandı. Bilgileriniz:");
        Console.WriteLine(user);
    }
    public void GetUsers(){
         foreach (var item in _users)
        {
            Console.WriteLine( "İsim: "+ item.name);
            Console.WriteLine("Soyisim: "+ item.surname);
            Console.WriteLine("Telefon Numarası: "+  item.phone_number);
        }
    }
    public void Get(string name){
        User user1 = _users.Find(e => e.name.ToLower() == name.ToLower());
        Console.WriteLine("Arama Sonucu: ");
        Console.WriteLine("İsim: " +user1.name);
        Console.WriteLine("Soyisim: " + user1.surname);
        Console.WriteLine("Telefon Numarası: " + user1.phone_number);
    }
    public void Delete(string name,string surname){
       User user1 = _users.Find(e => e.name.ToLower() ==name.ToLower() && e.surname.ToLower() ==surname.ToLower());
       Console.WriteLine("Silmek istediğinize emin misiniz /evet (y)/hayır(n)");
       string answer = Console.ReadLine();
       if(answer=="y"){
        _users.Remove(user1);
       Console.WriteLine("Silme işlemi tamamlandı.");
       }else{
       Console.WriteLine("Silme işlemi iptal edildi.");
       }
    }
    public void Update(string name, string surname,string phone_number){
       User user1 = _users.Find(e => e.name.ToLower() ==name.ToLower() && e.surname.ToLower() ==surname.ToLower());
       Console.WriteLine(user1);
       if(phone_number.Length == 8){
         user1.name = name;
         user1.surname = surname;
         user1.phone_number = phone_number;

         Console.WriteLine("Güncellenen Bilgiler:");
         Console.WriteLine("İsim: " + user1.name);
         Console.WriteLine("Soyisim: " + user1.surname);
         Console.WriteLine("Telefon Numarası: " + user1.phone_number);
       }else{ 
        Console.WriteLine("Telefon numarası 8 karakterden uzun veya kısa olamaz.");
       }
    }
}
}

