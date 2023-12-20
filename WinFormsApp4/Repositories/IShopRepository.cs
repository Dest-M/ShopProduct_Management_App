using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp4.Models;

namespace WinFormsApp4.Repositories
{
    public interface IShopRepository
    {
        List<Shop> GetShops();
        void Create(Shop shop);
        void DeleteProduct(Product product, Shop shop);
        void InitialiseShopProcedures();
        void DeleteShop(Shop shop);
        void AddProduct(Product product, Shop shop);
    }
}
