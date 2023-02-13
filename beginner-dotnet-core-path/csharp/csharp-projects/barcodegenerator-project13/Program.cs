// See https://aka.ms/new-console-template for more information
using BarcodeLib;
using Barcode_Generator;

Barcode barcode = Process.GenerateAndSave("123");
Console.WriteLine(Process.ReadBarcode(barcode));

barcode = Process.GenerateAndSave("8799");
Console.WriteLine(Process.ReadBarcode(barcode));

barcode = Process.GenerateAndSave("456");
Console.WriteLine(Process.ReadBarcode(barcode));
