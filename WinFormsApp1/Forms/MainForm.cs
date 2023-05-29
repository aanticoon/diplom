using Microsoft.Extensions.DependencyInjection;
using System.Data.SqlClient;
using WinFormsApp1.Logic;

namespace WinFormsApp1.Forms
{
    public partial class MainForm : Form
    {
        private readonly string _userName;
        private Color AccentColor = Color.FromArgb(44, 62, 80);
        private Color MainColor = Color.FromArgb(52, 152, 219);
        private List<Button> buttons = new List<Button>();

        public MainForm(string userName)
        {
            _userName = userName;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            greetingLabel.Text = $"Добро пожаловать, {_userName}!";
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutGroup first = new AboutGroup();
            SetActiveButton(button1);
            SwitchToForm(first);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentCardForm second = new StudentCardForm();
            SetActiveButton(button2);
            SwitchToForm(second);
        }

        private void OpenAuthForm()
        {
            var authService = Program.ServiceProvider.GetRequiredService<IAuthService>();
            AuthorizationForm authForm = new AuthorizationForm(authService);
            this.Hide();
            authForm.ShowDialog();
            this.Close();
        }

        private void SwitchToForm(Form formToSwitchTo)
        {
            ContentPanel?.Controls.Clear();

            formToSwitchTo.TopLevel = false;
            formToSwitchTo.AutoScroll = true;
            formToSwitchTo.FormBorderStyle = FormBorderStyle.None;
            formToSwitchTo.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(formToSwitchTo);
            formToSwitchTo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenAuthForm();
        }

        private void SetActiveButton(Button activeButton)
        {
            foreach (var button in buttons)
            {
                button.BackColor = MainColor;
            }
            activeButton.BackColor = AccentColor;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StudentFamily third = new StudentFamily();
            SetActiveButton(button4);
            SwitchToForm(third);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Vedomost fourth = new Vedomost();
            SetActiveButton(button5);
            SwitchToForm(fourth);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EventForm fifth = new EventForm();
            SetActiveButton(button6);
            SwitchToForm(fifth);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            InstructionForm sixth = new InstructionForm();
            SetActiveButton(button7);
            SwitchToForm(sixth);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OlympyadForm seventh = new OlympyadForm();
            SetActiveButton(button8);
            SwitchToForm(seventh);
        }
    }
}
