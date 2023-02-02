// See https://aka.ms/new-console-template for more information


int time = DateTime.Now.Hour;

if(time >= 6 && time < 11){
    Console.WriteLine("günaydın");
}else if(time <= 18){
    Console.WriteLine("iyi günler");
}
else{
    Console.WriteLine("iyi geceler");
}
