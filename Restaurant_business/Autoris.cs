using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_business
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string st = $"metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=\"data source=DESKTOP-KHR5ON4\\SQLEXPRESS;initial catalog=Restaurant_business;integrated security=False;MultipleActiveResultSets=True;App=EntityFramework;User ID={textBox1.Text};Password={textBox2.Text}\"";
            using (SqlConnection sqlConnection = new SqlConnection($"data source=DESKTOP-KHR5ON4\\SQLEXPRESS;initial catalog=Restaurant_business;integrated security=False;MultipleActiveResultSets=True;App=EntityFramework;User ID={textBox1.Text};Password={textBox2.Text}"))
            {
                try
                {
                    sqlConnection.Open();
                }
                catch
                {
                    MessageBox.Show("Неправильный логин или пароль");
                    return;
                }
            }
            MainForm mainForm = new MainForm($"metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=\"data source=DESKTOP-KHR5ON4\\SQLEXPRESS;initial catalog=Restaurant_business;integrated security=False;MultipleActiveResultSets=True;App=EntityFramework;User ID={textBox1.Text};Password={textBox2.Text}\"");
            mainForm.Show();
            Close();
        }


    }
}
