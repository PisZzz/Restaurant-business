using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_business
{
    public partial class MainForm : Form
    {
        string s;
        public MainForm(string s)
        {
            this.s = s;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Addform addForm = new Addform(s);
            addForm.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Tabls.Text == "Агент")
                {
                    using (Restaurant_businessEntities rb = new Restaurant_businessEntities(s))
                    {
                        dataGridView1.DataSource = (from a in
                                                        rb.agent
                                                    select new
                                                    {
                                                        a.id,
                                                        a.lastmane,
                                                        a.firstname,
                                                        a.midname,
                                                        a.id_company
                                                    }).ToList();
                    }
                }
                else if (Tabls.Text == "Компания")
                {
                    using (Restaurant_businessEntities rb = new Restaurant_businessEntities(s))
                    {
                        dataGridView1.DataSource = (from c in
                                                        rb.company
                                                    select new
                                                    {
                                                        c.id,
                                                        c.name,
                                                        c.index_company
                                                    }).ToList();
                    }
                }
                else if (Tabls.Text == "Заказ")
                {
                    using (Restaurant_businessEntities rb = new Restaurant_businessEntities(s))
                    {
                        dataGridView1.DataSource = (from o in
                                                        rb.order
                                                    select new
                                                    {
                                                        o.id,
                                                        o.id_agent,
                                                        o.id_product
                                                    }).ToList();
                    }
                }
                else if (Tabls.Text == "Продукт")
                {
                    using (Restaurant_businessEntities rb = new Restaurant_businessEntities(s))
                    {
                        dataGridView1.DataSource = (from p in
                                                        rb.product
                                                    select new
                                                    {
                                                        p.id,
                                                        p.name_product,
                                                        p.price,
                                                        p.product_volume,
                                                        p.unit
                                                    }).ToList();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Нет прав");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string str = Tabls.Text;
            if (str == "Агент")
            {

                using (Restaurant_businessEntities rb = new Restaurant_businessEntities(s))
                {
                    try
                    {
                        int a = Convert.ToInt32(numericUpDownMain.Value);
                        List<agent> lists = rb.agent.ToList();
                        agent agent = rb.agent.Where(x => x.id == a).FirstOrDefault();
                        if (agent == null)
                        {
                            MessageBox.Show("Нет такого значения");
                        }
                        else
                        {
                            rb.agent.Remove(agent);
                            rb.SaveChanges();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Нет прав");
                    }
                }
            }
            else if (str == "Компания")
            {
                using (Restaurant_businessEntities rb = new Restaurant_businessEntities(s))
                {
                    company company = rb.company.Where(x => x.id == numericUpDownMain.Value).FirstOrDefault();
                    if (company == null)
                    {
                        MessageBox.Show("Нет такого значения");
                    }
                    else
                    {
                        rb.company.Remove(company);
                        rb.SaveChanges();
                    }
                }
            }
            else if (str == "Заказ")
            {
                using (Restaurant_businessEntities rb = new Restaurant_businessEntities(s))
                {
                    order order = rb.order.Where(x => x.id == numericUpDownMain.Value).FirstOrDefault();
                    if (order == null)
                    {
                        MessageBox.Show("Нет такого значения");
                    }
                    else
                    {
                        rb.order.Remove(order);
                        rb.SaveChanges();
                    }
                }
            }
            else if (str == "Продукт")
            {
                using (Restaurant_businessEntities rb = new Restaurant_businessEntities(s))
                {
                    product product = rb.product.Where(x => x.id == numericUpDownMain.Value).FirstOrDefault();
                    if (product == null)
                    {
                        MessageBox.Show("Нет такого значения");
                    }
                    else
                    {
                        rb.product.Remove(product);
                        rb.SaveChanges();
                    }
                }
            }   
            //Агент   
        }


    }
}
