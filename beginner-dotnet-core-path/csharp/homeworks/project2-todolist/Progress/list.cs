using TODO.Datas;
namespace TODO.Progress{
    public class ListData{
        public void ListCard(){
            string todo = database.defaultCard.FirstOrDefault(x => x.line == "TODO")?.line;
            if (todo != null)
            {
                listInProgress(todo);
            }else{
                todo = "TODO";
                nullProgress(todo);
            }
            string inprogress = database.defaultCard.FirstOrDefault(x => x.line == "INPROGRESS")?.line;
            if (todo != null)
            {
                listInProgress(inprogress);
            }else{
                inprogress = "INPROGRESS";
                nullProgress(inprogress);
            }
            string done = database.defaultCard.FirstOrDefault(x => x.line == "DONE")?.line;
            if (todo != null)
            {
                listInProgress(done);
            }else{
                done="DONE";
                nullProgress(done);
            }
        }
        public void listInProgress(string line){
            if(line != null){
                Console.WriteLine("line " + line);
                Console.WriteLine("*********************");
                foreach (var item in database.defaultCard)
                {
                    if(item.line == line){
                        Console.WriteLine("Başlık               :" + item.header);
                        Console.WriteLine("İçerik               :" + item.title);
                        Console.WriteLine("Kişi                 :" + item.person);
                        Console.WriteLine("Büyüklük             :" + item.size);
                        Console.WriteLine("Line                 :" + item.line);
                        Console.WriteLine("---------");
                    }
                }
            }
        }
        public void nullProgress(string line){
            Console.WriteLine("null line " + line);
                Console.WriteLine("*********************");
                Console.WriteLine("Boş /n");
        }
    }
}