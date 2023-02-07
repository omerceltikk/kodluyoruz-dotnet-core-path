using System;  
using System.Collections;  
using System.Linq;  
internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList arlist = new ArrayList();
        arlist.Add("ayşe");
        arlist.Add(2);
        arlist.Add(true);
        arlist.Add('A');

        Console.WriteLine(arlist[1]);

        //AddRange - collection tipini ekleyebiliyoruz
        string[] renkler = {"kırmızı","sarı","mavi"};
        arlist.AddRange(renkler);
        List<int> sayılar = new List<int>(){1,8,5,6,874,1,5,6,8,7,4};    
        arlist.AddRange(sayılar);
        
        //Sort-arraydeki iki elemanı sortlayamıyor çünkü int32 bulmaya çalışıyor sadec sayılar olması mantıklı sortlamak için

         //Binary Search -binary search için ilk olarak sortlamamız lazım  
         arlist.BinarySearch(9);
         //reverse
         arlist.Reverse();
         //Clear
         arlist.Clear();
}
}