// See https://aka.ms/new-console-template for more information

int n = int.Parse(Console.ReadLine());

for(int i = 0; i<n ; i++){
   for(int k = i; k<n ; k++){
    Console.Write(" ");
   }
   for(int x=0; x <= i; x++){
    Console.Write("*");
    Console.Write(" ");
   }
   Console.WriteLine();
}
Console.Read();