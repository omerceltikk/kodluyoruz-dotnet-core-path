// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bir sayı giriniz");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
int kucukToplam = 0;
int buyukToplam = 0;
Console.WriteLine("Lütfen sayılarınızı giriniz");

for (int i = 0; i < n; i++)
{
    Console.WriteLine("{0}. sayınız", i + 1);
    arr[i] = int.Parse(Console.ReadLine());
}
for(int i = 0; i <arr.Length; i++){
    if(arr[i] > 67){
        int fark = arr[i]-67;
        buyukToplam += fark*fark;
    }
    else if(arr[i] < 67){
        kucukToplam += 67-arr[i];
    }
}
Console.WriteLine("67den büyük sayıların mutlak kareleri toplamı:"+buyukToplam);
Console.WriteLine("67den küçük sayıların 67 ile farkları toplamı:"+kucukToplam);

