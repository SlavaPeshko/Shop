using System.Threading.Tasks;
using Shop.Common.Model;
using Shop.DAL.Context;
using Shop.DAL.Infra;

namespace Shop.DAL.Repository
{
	public class GadgetRepository : BaseRepository<Gadget>, IGadgetRepository
	{
		public GadgetRepository(ShopContext shopContext) : base(shopContext)
		{
		}
	}
}