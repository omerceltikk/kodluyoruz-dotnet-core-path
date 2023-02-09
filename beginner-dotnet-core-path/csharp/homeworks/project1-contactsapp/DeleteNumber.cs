namespace project1_phone_book
{
    class DeletePerson 
{
    public void Delete(List<People> personList){
         Console.Write("Please Enter name or surname who want to delete:");
        string search = Console.ReadLine().ToLower();
        if(personList.Contains(search));


    }
}
}