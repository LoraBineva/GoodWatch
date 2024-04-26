using Final_Eda;
using Register_page;

namespace FinalEda
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void create_acc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
        }

        private void log_in_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_In log_In = new Log_In();
            log_In.ShowDialog();
        }
    }
}