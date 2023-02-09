namespace project1_phone_book
{
    class AddNewPerson 
{   
    public void Add(List<People> personList){
        Console.WriteLine("Please Enter a Name:");
        string name = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Please Enter a SurName:");
        string surname = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Please Enter a PhoneNumber:");
        int phone_number = Convert.ToInt32(Console.ReadLine());
        People person = new People {Name = name, surname = surname, phone_number=phone_number = phone_number};
    
    }
}
}

