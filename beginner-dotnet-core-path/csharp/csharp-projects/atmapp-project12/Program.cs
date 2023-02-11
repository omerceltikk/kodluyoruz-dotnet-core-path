using adduser;
using Data;
using Progress;
namespace atmapp_project12;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Atm uygulamasına hoşgeldiniz!");
        Console.WriteLine("Lütfen id giriniz.");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("Şifrenizi Giriniz");
        string password = Console.ReadLine();
        Account control = new Account();//call classes
        InMemory inmemory = new InMemory();//call classes

        bool isfound = control.Controller(id, password);
        if (isfound){
            Console.WriteLine("Giriş Onaylandı!");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz.");
            Console.WriteLine("Para Yatırma (1)");
            Console.WriteLine("Para Çekme (2)");
            int a = int.Parse(Console.ReadLine());
            if(a==1){
                Console.WriteLine("Yatrımak istediğiniz tutarı Giriniz.");
                int cost = int.Parse(Console.ReadLine());

                User user = inmemory.Get(id);
                int total = user.Balance + cost;
                Console.WriteLine("İşlem başarılı. Bakiyeniz:" + total);
                inmemory.UpdateBalance(id,total);
            }
            if(a==2){
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz.");
                int cost = int.Parse(Console.ReadLine());
                User user = inmemory.Get(id);
                if( cost < user.Balance){
                    int total = user.Balance - cost;
                Console.WriteLine("İşlem başarılı. Bakiyeniz:" + total);
                inmemory.UpdateBalance(id,total);
                }else{
                    Console.WriteLine("Bakiyeniz Yetersiz!");
                }
            }

        }

    }
}
