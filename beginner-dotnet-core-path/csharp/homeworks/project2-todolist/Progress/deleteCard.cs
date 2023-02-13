using TODO.Datas;
namespace TODO.Progress{
    public class deleteCard{
        public void Delete(){
            remove:
            Console.WriteLine("Silmek istediğiniz kart başlığını yazınız");
            string title = Console.ReadLine();
            Card remove = database.defaultCard.FirstOrDefault(x=> x.header==title);
            if (remove!= null){
                database.defaultCard.Remove(remove);
                Console.WriteLine("Kart silindi");
            }else{
                Console.WriteLine("Kart Bulunamadı");
                choice:
                Console.WriteLine("Silmeyi sonlandırmak için (1)");
                Console.WriteLine("Yeniden denemek için (2)");
                int choice = int.Parse(Console.ReadLine());
                if (choice==1)
                {
                    
                }else if(choice==2){
                    Console.Clear();
                    goto remove;
                }else{
                    Console.WriteLine("Hatalı seçim");
                    goto choice;
                }

            }
        }
    }
}