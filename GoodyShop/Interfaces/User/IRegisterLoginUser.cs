using GoodyShop.Models;
using GoodyShop.Utils;

namespace GoodyShop.Interfaces.User
{
    public interface IRegisterLoginUser
    {
        Task<ReturnValue> RegisterUser(UserModelDto model);
    }
}
