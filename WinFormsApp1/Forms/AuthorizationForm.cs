using WinFormsApp1.Forms;
using WinFormsApp1.Logic;

namespace WinFormsApp1
{
	public partial class AuthorizationForm : Form
	{
		private readonly IAuthService _authService;
		public AuthorizationForm(IAuthService authService)
		{
			_authService = authService;

			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string userName = "";
			var login = loginInput.Text;
			var password = passwordInput.Text;

			MessageBoxButtons buttons = MessageBoxButtons.OK;

			if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
			{
				MessageBox.Show("Заполните поля логин/пароль", "Внимание!", buttons);
				return;
			}

			try
			{
				userName = _authService.AuthorizeUser(login, password);
				MessageBox.Show($"Добро пожаловать в систему, {userName}!", "Авторизация успешна", buttons);
				OpenMainForm(userName);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Внимание!", buttons);
			}
		}

		private void OpenMainForm(string userName)
		{
			MainForm mainForm = new MainForm(userName);
			this.Hide();
			mainForm.ShowDialog();
			this.Close();
		}
	}
}