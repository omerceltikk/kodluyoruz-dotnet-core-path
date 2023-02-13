using TODO.Datas;

namespace TODO.Progress{
    public class AddCard{
        public void Add(){
            Card card = new();
            Console.WriteLine("Başlık Giriniz                    :");
            card.header = Console.ReadLine();
            Console.WriteLine("İçerik Giriniz                    :");
            card.title = Console.ReadLine();
            size:
            Console.WriteLine("Büyüklük Seçiniz-> XS(1),S(2),M(3),L(4),XL(5)    :");
            int entry = int.Parse(Console.ReadLine());
            Size size = (Size)entry;
            switch (size)
            {
                case Size.XS:
                card.size ="XS";
                break;

                case Size.S:
                card.size ="S";
                break;
        
                case Size.M:
                card.size ="M";
                break;
            
                case Size.L:
                card.size ="L";
                break;
            
                case Size.XL:
                card.size ="XL";
                break;
                default:
                Console.WriteLine("Hatalı Giriş Yaptınız.");
                goto size;
                break;

        }
            person:
            Console.WriteLine("Kişi Seçiniz                      :");
            string IdEntry = Console.ReadLine();
            int personId;
            if(int.TryParse(IdEntry,out personId)&& 0<personId &&personId<= database.person.Count){
                card.person = database.person.FirstOrDefault(x => x.Id == personId).name;
                database.defaultCard.Add(card);
                Console.WriteLine("card başarıyla eklendi");
            }else{
                Console.WriteLine("Hatalı Giriş Yaptınız");
                goto person;
        }


}
         
         
         enum Size
        {
            XS = 1,
            S,
            M,
            L,
            XL
        }
    }
}