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
    public partial class MainWindow : Form
    {
        private readonly IShopRepository _shopRepository;
        private List<Shop> shops;

        public MainWindow(IShopRepository shopRepository)
        {
            InitializeComponent();
            _shopRepository = shopRepository;
            shops = _shopRepository.GetShops();
            ShopsListBox.DataSource = shops;
            ShopsListBox.DisplayMember = "Name";
            ShopsListBox.ValueMember = "Id";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var shop = shops.Where(x => x.ShopId == ((Shop)ShopsListBox.SelectedItem).ShopId).FirstOrDefault();
            if (shop != null)
            {
                ProductsListBox.DataSource = shop.Products;
                ProductsListBox.DisplayMember = "Name";
                ProductsListBox.ValueMember = "Id";
            }

        }

        private void Products_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
