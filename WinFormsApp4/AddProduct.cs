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
using static System.Formats.Asn1.AsnWriter;

namespace WinFormsApp4
{
    public partial class AddProduct : Form
    {
        private readonly IShopRepository _shopRepository;
        private List<Shop> shops;
        private readonly MainWindow _mainWindow;
        public AddProduct(IShopRepository shopRepository, MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            _shopRepository = shopRepository;


            shops = _shopRepository.GetShops();
            ShopComboBox.DataSource = shops;
            ShopComboBox.DisplayMember = "Name";
            ShopComboBox.ValueMember = "ShopId";

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void AddProductConfirmBtn_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            Shop shop;

            product.Name = ProductName.Text;
            shop = shops.Where(x => x.Name == ShopComboBox.Text).First();
            _shopRepository.AddProduct(product, shop);
            _mainWindow.updateShopList();
        }

        private void AddProductCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
