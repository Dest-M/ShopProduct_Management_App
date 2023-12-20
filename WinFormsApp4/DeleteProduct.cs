using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp4.Models;
using WinFormsApp4.Repositories;

namespace WinFormsApp4
{

    public partial class DeleteProduct : Form
    {
        private readonly IShopRepository _shopRepository;
        private List<Shop> shops;
        private readonly MainWindow _mainWindow;
        public DeleteProduct(IShopRepository shopRepository, MainWindow mainWindow)
        {
            InitializeComponent();

            _mainWindow = mainWindow;
            _shopRepository = shopRepository;


            shops = _shopRepository.GetShops();
            ShopComboBox.DataSource = shops;
            ShopComboBox.DisplayMember = "Name";
            ShopComboBox.ValueMember = "ShopId";
        }

        private void DeleteProductConfirmBtn_Click(object sender, EventArgs e)
        {
            Product product;
            Shop shop;

            shop = shops.Where(x => x.Name == ShopComboBox.Text).First();
            product = shop.Products.Where(x => x.Name== ProductComboBox.Text).First();
            _shopRepository.DeleteProduct(product, shop);
            _mainWindow.updateShopList();
        }

        private void ShopComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var shop = shops.Where(x => x.ShopId == ((Shop)ShopComboBox.SelectedItem).ShopId).FirstOrDefault();
            if (shop != null)
            {
                ProductComboBox.DataSource = shop.Products;
                ProductComboBox.DisplayMember = "Name";
                ProductComboBox.ValueMember = "ProductId";
            }
        }


        private void DeleteProductCancelBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
