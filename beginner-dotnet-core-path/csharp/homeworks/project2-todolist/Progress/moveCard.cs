using TODO.Datas;
namespace TODO.Progress{

    public class moveCard{
        public void Move(){
            move:
            Console.WriteLine("Durumunu değiştirmek istediğiniz kartın içeriğini yazınız.");
            string header = Console.ReadLine();
            Card move = database.defaultCard.Find(e => e.header ==header);
            if(move != null){
                Console.WriteLine("Kart Bilgileri");
                Console.WriteLine("**************");
                Console.WriteLine("Başlık      :" + move.header);
                Console.WriteLine("İçerik      :" + move.title);
                Console.WriteLine("Büyüklük    :" + move.size);
                Console.WriteLine("Kişi        :" + move.person);
                Console.WriteLine("Line        :" + move.line);
                moveChoice:
                Console.WriteLine("Lütfen Taşımak İstediğiniz line'ı Seçiniz");
                Console.WriteLine("(1) TODO");
                Console.WriteLine("(2) IN PROGRESS");
                Console.WriteLine("(3) DONE");
                int moveChoice = int.Parse(Console.ReadLine());

                switch (moveChoice)
                {
                    case 1:
                    move.line = "TODO";
                    break;
                
                    case 2:
                    move.line = "INPROGRESS";
                    break;
                
                    case 3:
                    move.line = "DONE";
                    break;
                    
                    default:
                    Console.WriteLine("Hatalı Seçim");
                    goto moveChoice;
                    break;
                }
                Console.WriteLine("Kart Durumu Değişirildi");

            }else{
                Console.WriteLine("Aradığınız Kriterlere Uygun Bir Eşleşme Bulunamadı. Lütfen yeni bir seçim yapınız");
                choice:
                Console.WriteLine("Taşımayı sonlandırmak için (1)");
                Console.WriteLine("Yeniden denemek için (1)");
                int choice = int.Parse(Console.ReadLine());
                if(choice == 1){

                }else if(choice == 2){
                    Console.Clear();
                    goto move;
                }else{
                    Console.WriteLine("Hatalı seçim yaptınız.");
                    goto choice;
                }
            }
        }
    }
}