using BarcodeLib;
using System.Text.Json;

namespace Barcode_Generator
{
    class Process{
        static TYPE type = TYPE.PHARMACODE;
        public static Barcode GenerateAndSave(string data){
            Barcode barcode = new Barcode(data,type);
            barcode.Encode(type,data);
            barcode.SaveImage(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+@"/barcode.png", BarcodeLib.SaveTypes.PNG);
            Console.WriteLine("Barkod oluşturuldu. Kaydedilen veri -> {0}",data);
            return barcode;
        }
        public static string ReadBarcode(Barcode barcode){
            return "Barkod değeri ="+ barcode.RawData + "/n";
        }
        
    }
}