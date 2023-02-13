using TODO.Datas;
using TODO.Progress;
// See https://aka.ms/new-console-template for more information
database datas = new();
mainMenu:
Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz.");
    Console.WriteLine("(1) Board Listelemek");
    Console.WriteLine("(2) Board'a Kart Eklemek");
    Console.WriteLine("(3) Board'dan Kart Silmek");
    Console.WriteLine("(4) Kart Taşımak");
    int islem = int.Parse(Console.ReadLine());
    
    switch (islem)
    {
        case 1:
        ListData list = new();
        list.ListCard();
        goto mainMenu;
        
        case 2: 
        AddCard add = new();
        add.Add();
        goto mainMenu;
        case 3:
        deleteCard del = new();
        del.Delete();
        goto mainMenu;
        case 4:
        moveCard card = new();
        card.Move();
       goto mainMenu;

        default:
        Console.WriteLine("Hatalı Seçim Yaptınız");
        goto mainMenu;
    }