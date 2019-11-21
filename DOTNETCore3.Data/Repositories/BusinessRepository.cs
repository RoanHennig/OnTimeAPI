using DOTNETCore3.Model.Entities;

namespace DOTNETCore3.Data.Repositories
{
    public class BusinessRepository : EntityBaseRepository<Business>, IBusinessRepository
    {
        public BusinessRepository(BusinessPortalContext context) : base(context) { }
    }
}
