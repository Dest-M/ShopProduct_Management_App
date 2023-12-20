using WinFormsApp4.Repositories;

namespace WinFormsApp4
{
    public partial class AuthorizeForm : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly MainWindow _mainWindow;
        public AuthorizeForm( 
            IUserRepository userRepository,
            MainWindow mainWindow)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _mainWindow = mainWindow;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Authorize_Click(object sender, EventArgs e)
        {
            var login = LoginTextBox.Text;
            var password = PasswordTextBox.Text;
            var users = _userRepository.GetUsers();
            var user = users.FirstOrDefault(u => u.Login.Trim() == login);

         

            if(user == null)
            {
                MessageBox.Show("�� ����� ����������� ������", "�� ������ ������������", MessageBoxButtons.OK);
                return;
            }
            MessageBox.Show("�� ����� ��������� ������", "������ ������������", MessageBoxButtons.OK);

            _mainWindow.Show();
            this.Hide(); 
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}