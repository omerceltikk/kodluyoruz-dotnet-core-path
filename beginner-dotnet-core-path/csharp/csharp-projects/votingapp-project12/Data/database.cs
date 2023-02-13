namespace VOTE.Data{
    public class Database{
        private static List<Categories> _categories;
        private static List<User> _users;
        static Database(){
            _users = new List<User>(){
                new User{Id=1 ,userName="omerceltikk"},
                new User{Id=2 ,userName="omerCeltikk"},
                new User{Id=3 ,userName="omerCeltiKK"},
                new User{Id=4 ,userName="ahmetCev"},
                new User{Id=5 ,userName="recepTan"},
                new User{Id=6 ,userName="alpTan"},
                new User{Id=7 ,userName="mehmetGunduz"},
            };
            _categories = new List<Categories>(){
                new Categories{categoryName="Film",categoryTitle="La vita e bella/Roberto Benigni",Vote=5},
                new Categories{categoryName="Film",categoryTitle="Once Upon A Time In Anatolia/Nuri Bilge Ceylan",Vote=10},
                new Categories{categoryName="Film",categoryTitle="Godfather/Coppola",Vote=8},
                new Categories{categoryName="Film",categoryTitle="A Seperation/Farhadi",Vote=4},
                
                new Categories{categoryName="Spor",categoryTitle="Barcelona",Vote=21},
                new Categories{categoryName="Spor",categoryTitle="Real Madrid",Vote=30},
                new Categories{categoryName="Spor",categoryTitle="PSG",Vote=45},
                
                new Categories{categoryName="DC/MARVEL",categoryTitle="DC",Vote=70},
                new Categories{categoryName="DC/MARVEL",categoryTitle="MARVEL",Vote=81},
            };
        }
        public static List<Categories> categories => _categories;
        public static List<User> users => _users;
    }
}