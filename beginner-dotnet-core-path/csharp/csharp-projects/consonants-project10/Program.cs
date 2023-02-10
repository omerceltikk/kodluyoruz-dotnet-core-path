// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bir cümle yazınız");
string letter = Console.ReadLine();
string[] arr = letter.Split(" ");
char[] arr2;
for(int i = 0; i<arr.Length; i++){
   arr2 = arr[i].ToCharArray();
    bool contrl = false;
   for(int j = 1; j< arr2.Length;j++){
    if(vovels(arr2[j]) && vovels(arr2[j-1])){
    contrl = true;
    }
   }
    Console.Write(contrl+" ",i+1);
   bool vovels(char c){
    return !"aeıioöuü".ToCharArray().Contains(c);
   }
}
