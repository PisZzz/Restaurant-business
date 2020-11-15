using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_business
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyApplicationContext(() => new AuthorizationForm()));
        }
        public class MyApplicationContext : ApplicationContext
        {
            public MyApplicationContext(Func<Form> formFactory)
            {
                Form startupForm = formFactory();
                startupForm.FormClosed += OnFormClosed;
                startupForm.Show();
            }

            private void OnFormClosed(object sender, FormClosedEventArgs e)
            {
                if (Application.OpenForms.Count > 0)
                {
                    foreach (Form form in Application.OpenForms)
                    {
                        form.FormClosed -= OnFormClosed;
                        form.FormClosed += OnFormClosed;
                    }
                }
                else ExitThread();
            }
        }
    }
}
