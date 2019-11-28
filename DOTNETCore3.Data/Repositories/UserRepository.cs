using DOTNETCore3.Data.Abstract;
using DOTNETCore3.Model.Entities;

namespace DOTNETCore3.Data.Repositories
{
    public class UserRepository : EntityBaseRepository<User>, IUserRepository
    {
        public UserRepository(BusinessPortalContext context) : base(context) { }

        public bool IsEmailUnique(string email)
        {
            var user = GetSingle(u => u.Email == email);
            return user == null;
        }
    }
}
