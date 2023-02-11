using Data;
using adduser;
namespace Progress 
{
    public class Account
    {
        InMemory inmemory = new InMemory();
        public bool Controller(int id, string Password){
            User user = inmemory.Get(id);

            if(user.Password == Password){
                return true;
            }else{
                return false;
            }
        }
    }
}