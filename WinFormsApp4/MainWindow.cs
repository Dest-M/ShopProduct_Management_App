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
        private AddProduct _addproduct;
        private AddShop _addshop;
        private DeleteShop _delshop;
        private DeleteProduct _delproduct;
        

        public MainWindow(IShopRepository shopRepository)
        {
            InitializeComponent();
            _shopRepository = shopRepository;
            shops = _shopRepository.GetShops();
            ShopsListBox.DataSource = shops;
            ShopsListBox.DisplayMember = "Name";
            ShopsListBox.ValueMember = "ShopId";
            _delshop = new DeleteShop(_shopRepository, this);
            _delproduct = new DeleteProduct(_shopRepository, this);
            _addshop = new AddShop(_shopRepository, this);
            _addproduct = new AddProduct(_shopRepository, this);
            

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
                ProductsListBox.ValueMember = "ProductId";
            }

        }
        public void updateShopList()
        {
            shops = _shopRepository.GetShops();
            ShopsListBox.DataSource = shops;
            ShopsListBox.DisplayMember = "Name";
            ShopsListBox.ValueMember = "ShopId";

            _addshop = new AddShop(_shopRepository, this);
            _addproduct = new AddProduct(_shopRepository, this);
        }
        private void Products_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            _addproduct.Show();

        }

        private void AddShopBtn_Click(object sender, EventArgs e)
        {
            _addshop.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            _delproduct.Show();
        }

        private void DeleteShopBtn_Click(object sender, EventArgs e)
        {
            _delshop.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is InputWindow);
            if (formToShow != null)
            {
                formToShow.Show();
            };
            this.Close();
        }
    }
}
