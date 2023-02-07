// See https://aka.ms/new-console-template for more information

Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.Now.Date);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);


Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine(DateTime.Now.DayOfYear);

Console.WriteLine(DateTime.Now.ToLongDateString()); //ay ve günü string olarak yazar
Console.WriteLine(DateTime.Now.ToShortDateString());

Console.WriteLine(DateTime.Now.ToLongTimeString());
Console.WriteLine(DateTime.Now.ToShortTimeString());

Console.WriteLine(DateTime.Now.AddDays(2));
Console.WriteLine(DateTime.Now.AddDays(12));
Console.WriteLine(DateTime.Now.AddSeconds(50));
Console.WriteLine(DateTime.Now.AddMonths(5));

//format
Console.WriteLine(DateTime.Now.ToString("dd"));//24
Console.WriteLine(DateTime.Now.ToString("ddd"));//sat
Console.WriteLine(DateTime.Now.ToString("ddd"));//saturday

Console.WriteLine(DateTime.Now.ToString("MM"));//04
Console.WriteLine(DateTime.Now.ToString("MMM"));//apr
Console.WriteLine(DateTime.Now.ToString("MMMM"));//april

//Math kütüphanesi
Console.WriteLine(Math.Abs(-25));// 25;
Console.WriteLine(Math.Sin(10));// sinüs karşılığı;
Console.WriteLine(Math.Cos(10));// cosinüs karşılığı;
Console.WriteLine(Math.Tan(10));// tanjant karşılığı;

Console.WriteLine(Math.Ceiling(22.3));// yukarı yuvarlama
Console.WriteLine(Math.Round(22.3));// yakın yuvarlama
Console.WriteLine(Math.Floor(22.3));// aşağı yuvarlama

Console.WriteLine(Math.Max(22,3));// 
Console.WriteLine(Math.Min(22,3));// 

Console.WriteLine(Math.Pow(3,4));// 3^4 verir
Console.WriteLine(Math.Sqrt(9));//karekök 

Console.WriteLine(Math.Log(9));//e tabanlı logaritma işlemi 
Console.WriteLine(Math.Exp(3));//e üzeri 3 

Console.WriteLine(Math.Log10(3));//10 tabanlı log
 


