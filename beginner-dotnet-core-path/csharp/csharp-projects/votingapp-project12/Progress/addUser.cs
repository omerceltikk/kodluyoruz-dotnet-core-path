using VOTE.Data;

namespace VOTE.Progress{
    public class addUser{
        public void Add(){
            User user = new User();
            Console.WriteLine("UserName giriniz!");
            string _username = Console.ReadLine();
           user.Id = Database.users.Count+1;
           user.userName = _username;
           Database.users.Add(user);
           Console.WriteLine("Kullanıcı Kaydı Tamamlandı");
        }
    }
}