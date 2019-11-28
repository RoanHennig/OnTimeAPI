using DOTNETCore3.Model.Entities;

namespace DOTNETCore3.Data.Abstract
{
    public interface IUserRepository : IEntityBaseRepository<User>
    {
        bool IsEmailUnique(string email);
    }
}
