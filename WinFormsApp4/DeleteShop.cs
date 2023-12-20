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
    public partial class DeleteShop : Form
    {

        private readonly IShopRepository _shopRepository;
        private List<Shop> shops;
        private readonly MainWindow _mainWindow;
        public DeleteShop(IShopRepository shopRepository, MainWindow mainWindow)
        {
            InitializeComponent();

            _mainWindow = mainWindow;
            _shopRepository = shopRepository;


            shops = _shopRepository.GetShops();
            ShopComboBox.DataSource = shops;
            ShopComboBox.DisplayMember = "Name";
            ShopComboBox.ValueMember = "ShopId";
        }

        private void ShopComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteProductConfirmBtn_Click(object sender, EventArgs e)
        {
            Shop shop;

            shop = shops.Where(x => x.Name == ShopComboBox.Text).First();
            _shopRepository.DeleteShop(shop);
            _mainWindow.updateShopList();
        }

        private void DeleteProductCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
