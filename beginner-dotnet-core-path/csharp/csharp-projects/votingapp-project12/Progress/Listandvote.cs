using VOTE.Data;
namespace VOTE.Progress
{
    public class ListData
    {
        public void List()
        {
        stop:
            Console.WriteLine("Lütfen seçmek istediğiniz kategori ismini giriniz");
            Console.WriteLine("Film (1)");
            Console.WriteLine("DC/MARVEL (2)");
            Console.WriteLine("Spor (3)");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                foreach (var item in Database.categories)
                {
                    if (item.categoryName == "Film")
                    {
                        Console.WriteLine("Category Title      :" + item.categoryTitle);
                        Console.WriteLine("Vote                :" + item.Vote);
                    }
                }
                    Console.WriteLine("Oy kullanabilmek için lütfen seçiminizi yazınız");
                    string categorych = Console.ReadLine();
                    string categoryChoice = Database.categories.FirstOrDefault(x => x.categoryTitle.ToLower() == categorych.ToLower()).categoryTitle;
                    if (categoryChoice != null)
                    {
                        Database.categories.Find(x => x.categoryTitle == categoryChoice).Vote += 1;
                    }
                    else
                    {
                        Console.WriteLine("yanlış bir seçim yaptınız");
                        goto stop;
                    }
            }
            if (choice == 2)
            {
                foreach (var item in Database.categories)
                {
                    if (item.categoryName == "DC/MARVEL")
                    {
                        Console.WriteLine("Category Title      :" + item.categoryTitle);
                        Console.WriteLine("Vote                :" + item.Vote);
                    }
                }
                    Console.WriteLine("Oy kullanabilmek için lütfen seçiminizi yazınız");
                    string categorych = Console.ReadLine();
                    string categoryChoice = Database.categories.FirstOrDefault(x => x.categoryTitle.ToLower() == categorych.ToLower()).categoryTitle;
                    if (categoryChoice != null)
                    {
                        Database.categories.Find(x => x.categoryTitle == categoryChoice).Vote += 1;
                    }
                    else
                    {
                        Console.WriteLine("yanlış bir seçim yaptınız");
                        goto stop;
                    }
            }
            if (choice == 3)
            {
                foreach (var item in Database.categories)
                {
                    if (item.categoryName == "Spor")
                    {
                        Console.WriteLine("Category Title      :" + item.categoryTitle);
                        Console.WriteLine("Vote                :" + item.Vote);
                    }
                }
                    Console.WriteLine("Oy kullanabilmek için lütfen seçiminizi yazınız");
                    string categorych = Console.ReadLine();
                    string categoryChoice = Database.categories.FirstOrDefault(x => x.categoryTitle.ToLower() == categorych.ToLower()).categoryTitle;
                    if (categoryChoice != null)
                    {
                        Database.categories.Find(x => x.categoryTitle == categoryChoice).Vote += 1;
                    }
                    else
                    {
                        Console.WriteLine("yanlış bir seçim yaptınız");
                        goto stop;
                    }
            }
        }
    }
}