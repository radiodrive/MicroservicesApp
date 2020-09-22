using BasketAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketAPI.Repositories.Interface
{
    public interface IBasketRepository
    {
        Task<BasketCart> GetBasket(String username);
        Task<BasketCart> UpdateBasket(BasketCart basket);
        Task<bool> DeleteBasket(String username);
    }
}
