// See https://aka.ms/new-console-template for more information

int n = int.Parse(Console.ReadLine());
int[] fibonacci = new int[n];
double total = 0;
for(int i =0; i < n; i++){
    fibonacci[0]=1;
    fibonacci[1]=1;
    if(i+2 >= 2 && i+2<n){
    fibonacci[i+2] = fibonacci[i+1]+fibonacci[i];
    }else{
        break;
    }
}
foreach(var item in fibonacci){
    total += item;
}
Console.WriteLine((total/n));
