using LoginProject.Models;

namespace LoginProject.Services
{
    public class SecurityService
    {
        UsersDAO usersDAO = new UsersDAO();

        public SecurityService() 
        {
    
        }

        public bool IsValid(UserModel User)
        {
            return usersDAO.FindUserByNameAndPassword(User);
        }
    }
}
