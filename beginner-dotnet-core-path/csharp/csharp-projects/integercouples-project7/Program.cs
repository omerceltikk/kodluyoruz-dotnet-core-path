// See https://aka.ms/new-console-template for more information

Console.WriteLine("Lütfen Çift bir sayı giriniz");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
if(n%2==0){
    Console.WriteLine("Lütfen sayılarınızı giriniz");
    for(int i = 0; i<n; i++){
        Console.WriteLine("{0}. sayınız", i+1);
        arr[i] = int.Parse(Console.ReadLine());
    }
    for(int i = 0; i < arr.Length; i += 2){
        if(arr[i] == arr[i+1]){
            int toplam = arr[i] + arr[i+1];
            Console.WriteLine(Math.Pow(toplam,2));
        }else{
            int toplam = arr[i] + arr[i+1];
            Console.WriteLine(toplam);
        }
    }
}else{
    Console.WriteLine("Hatalı tuşlama");
}