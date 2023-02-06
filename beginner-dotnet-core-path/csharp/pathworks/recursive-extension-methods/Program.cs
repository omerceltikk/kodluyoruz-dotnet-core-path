// See https://aka.ms/new-console-template for more information
//rekürsif - öz yinelemeli 

int result = 1;
for (int i = 1; i < 5; i++)
{
    result = result * 3;
}
string ifade = "asdasd asdasd asdasd asdasd";
bool sonuc = ifade.CheckSpaces();
Console.WriteLine(sonuc);
if(sonuc)
{
    Console.WriteLine(ifade.RemovewhiteSpaces());
    Console.WriteLine(ifade.MakeUpperCase());
    Console.WriteLine(ifade.MakeLowerCase());
    int[] dizi = {2,6,4,5,8,7,8,9,6,2,4};
    dizi.SortArray();

    Console.WriteLine(ifade.GetFirstCharacter());
}
public class Islemler
{
    public int Expo(int sayi, int üs)
    {
        if (üs < 2)
             return sayi;
        return Expo(sayi, üs - 1) * sayi;
    }

}
    public static class Extension{
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemovewhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("",dizi);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }
        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }
    }