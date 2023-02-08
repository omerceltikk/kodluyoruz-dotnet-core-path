
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Dictionary<Key_Veri_Tipi, Value_Veri_Tipi> dictionary_adi = new Dictionary<Key_Veri_Tipi, Value_Veri_Tipi>();

Dictionary<int,string> kullanicilar = new Dictionary<int, string>();
kullanicilar.Add(10,"ayşe");
kullanicilar.Add(12,"ahmet");
kullanicilar.Add(18,"deniz");
kullanicilar.Add(20,"özcan");
Console.WriteLine(kullanicilar[12]);
foreach( var item in kullanicilar)
{
    Console.WriteLine(item);
}

//Count
Console.WriteLine(kullanicilar.Count);
//Contains
Console.WriteLine(kullanicilar.ContainsKey(12));
Console.WriteLine(kullanicilar.ContainsValue("ahmet"));

//remove
kullanicilar.Remove(12);