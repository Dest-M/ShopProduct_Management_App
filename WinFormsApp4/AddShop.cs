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
    public partial class AddShop : Form
    {
        private readonly IShopRepository _shopRepository;
        private string _shopName;
        private MainWindow _mainWindow;
        public AddShop(IShopRepository shoprepos, MainWindow mainwindow)
        {
            InitializeComponent();
            _shopRepository = shoprepos;
            _mainWindow = mainwindow;
        }

        private void AddShop_Load(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddShopConfirmBtn_Click(object sender, EventArgs e)
        {
            _shopName = ShopName.Text;
            if (_shopName != null)
            {
                _shopRepository.Create(new Shop() { Name = _shopName });
                _mainWindow.updateShopList();
            }
            this.Close();
        }

        private void AddShopCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
