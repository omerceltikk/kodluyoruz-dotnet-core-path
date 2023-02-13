using System.Collections.Generic;
namespace TODO.Datas{
    public class database{
        private static List<Card> _defaultCard;
        private static List<Person> _person;
        static database(){
            _person = new List<Person>(){
                new Person{Id=1,name="Ahmet SDF"},
                new Person{Id=2,name="Mustafa ASD"},
                new Person{Id=3,name="Cevdet DEF"},
                new Person{Id=4,name="Aysu ZXC"},
            };
            _defaultCard = new List<Card>(){
                new Card{header="Ödev",title="Project 2 ToDo list tamamlanacak",person="Ahmet SDF",size="XL",line="TODO"},
                new Card{header="Günlük",title="Su iç",person="Mustafa ASD",size="L",line="INPROGRESS"},
                new Card{header="Oku",title="C# üzerine okumalar yapılacak.",person="Cevdet DEF",size="S",line="DONE"},
                new Card{header="Yaz",title="Makale tamamlanacak.",person="Aysu ZXC",size="M",line="TODO"},
                new Card{header="Ziyaret",title="Öğrenci işlerine gidilecek",person="Ahmet SDF",size="L",line="TODO"}
            };
        }
        public static List<Card> defaultCard => _defaultCard;
        public static List<Person> person => _person;

    }
}