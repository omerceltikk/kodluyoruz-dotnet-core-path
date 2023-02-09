// See https://aka.ms/new-console-template for more information
 Console.WriteLine("Lütfen bir kelime giriniz ve ardından çıkarmak istediğiniz karakterin sayısını giriniz(Aralarında virgül kullanınız.):");
string word = Console.ReadLine();
string[] arr = word.Split(",");
string word2 = Convert.ToString(arr[0]);
int numb = Convert.ToInt32(arr[1]);
string lastOut = word2.Remove(numb-1,1);

Console.WriteLine(lastOut);


