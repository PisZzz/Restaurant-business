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
    public partial class Addform : Form
    {
        string s;
        public Addform(string s)
        {
            this.s = s;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Restaurant_businessEntities rb = new Restaurant_businessEntities(s))
            {
                try
                {
                    rb.agent.Add(new agent
                    {
                        firstname = fnameAgent.Text,
                        lastmane = nameAgent.Text,
                        midname = onameAgent.Text,
                        id_company = Convert.ToInt32(label19.Text)
                    });
                    rb.SaveChanges();
                    MessageBox.Show("Запись добавлена");
                }
                catch { MessageBox.Show("Ошибка"); }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Restaurant_businessEntities rb = new Restaurant_businessEntities(s))
            {
                company company = rb.company.Where(x => x.index_company == maskedTextIndexCompany.Text).FirstOrDefault();
                if (company == null)
                {
                    MessageBox.Show("Нет такого индекса");
                }
                else
                {
                    textNameCompany.Text = company.name;
                    maskedTextIndexCompany.Text = company.index_company;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (Restaurant_businessEntities rb = new Restaurant_businessEntities(s))
            {
                company company = rb.company.Where(x => x.index_company == maskedTextIndexCompany.Text).FirstOrDefault();
                if (company == null)
                {
                    MessageBox.Show("Ошибка");
                }
                else
                {
                    rb.company.Where(x => x.index_company == maskedTextIndexCompany.Text).FirstOrDefault().name = textNameCompany.Text;
                    rb.company.Where(x => x.index_company == maskedTextIndexCompany.Text).FirstOrDefault().index_company = maskedTextIndexCompany.Text;
                    rb.SaveChanges();
                    MessageBox.Show("Запись изменена");
                }

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            using (Restaurant_businessEntities rb = new Restaurant_businessEntities(s))
            {
                agent agent = rb.agent.Where(x => x.id == numericIDAgent.Value).FirstOrDefault();
                if (agent == null)
                {
                    MessageBox.Show("Ошибка");
                }
                else
                {
                    fnameAgent.Text = agent.lastmane;
                    nameAgent.Text = agent.firstname;
                    onameAgent.Text = agent.midname;
                    label19.Text = Convert.ToString(agent.id_company);
                    CompanuAgent.Text = rb.company.Find(Convert.ToInt32(label19.Text)).name;
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Restaurant_businessEntities rb = new Restaurant_businessEntities(s))
            {
                agent agent = rb.agent.Where(x => x.id == numericIDAgent.Value).FirstOrDefault();
                if (agent == null)
                {
                    MessageBox.Show("Ошибка");
                }
                else
                {
                    rb.agent.Where(x => x.id == numericIDAgent.Value).FirstOrDefault().lastmane = fnameAgent.Text;
                    rb.agent.Where(x => x.id == numericIDAgent.Value).FirstOrDefault().firstname = nameAgent.Text;
                    rb.agent.Where(x => x.id == numericIDAgent.Value).FirstOrDefault().midname = onameAgent.Text;
                    rb.SaveChanges();
                    MessageBox.Show("Запись изменена");
                }
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            using (Restaurant_businessEntities rb = new Restaurant_businessEntities(s))
            {
                product product = rb.product.Where(x => x.id == numericUpDownProduct.Value).FirstOrDefault();

                if (product == null)
                {
                    textNameProduct.Text = "";
                    textPriceProduct.Text = "";
                    textAmntProduct.Text = "";
                    comboBoxProduct.Text = "";
                }
                else
                {
                    textNameProduct.Text = product.name_product;
                    textPriceProduct.Text = Convert.ToString(product.price);
                    textAmntProduct.Text = Convert.ToString(product.product_volume);
                    comboBoxProduct.Text = product.unit;
                }

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
             
            using (Restaurant_businessEntities rb = new Restaurant_businessEntities(s))
            {
                product product = rb.product.Where(x => x.id == numericUpDownProduct.Value).FirstOrDefault();
                try
                {
                    if (product == null)
                    {
                        MessageBox.Show("нет такого id");
                    }
                    else
                    {
                        rb.product.Where(x => x.id == numericUpDownProduct.Value).FirstOrDefault().name_product = textNameProduct.Text;
                        rb.product.Where(x => x.id == numericUpDownProduct.Value).FirstOrDefault().price = Convert.ToDecimal(textPriceProduct.Text);
                        rb.product.Where(x => x.id == numericUpDownProduct.Value).FirstOrDefault().product_volume = Convert.ToInt32(textAmntProduct.Text);
                        rb.product.Where(x => x.id == numericUpDownProduct.Value).FirstOrDefault().unit = comboBoxProduct.Text;
                        rb.SaveChanges();
                        MessageBox.Show("Запись изменена");
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка ввода");
                }
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            using (Restaurant_businessEntities rb = new Restaurant_businessEntities(s))
            {
                order order = rb.order.Where(x => x.id == numericUpDownOrder.Value).FirstOrDefault();

                if (order == null)
                {
                    textIdAgentOrder.Text = "";
                    textProductOrder.Text = "";
                }
                else
                {
                    textIdAgentOrder.Text = Convert.ToString(order.id_agent);
                    textProductOrder.Text = Convert.ToString(order.id_product);
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (Restaurant_businessEntities rb = new Restaurant_businessEntities(s))
            {
                order order = rb.order.Where(x => x.id == numericUpDownOrder.Value).FirstOrDefault();
                if (company == null)
                {
                    MessageBox.Show("Нет такого id");
                }
                else
                {
                    try
                    {
                        rb.order.Where(x => x.id == numericUpDownOrder.Value).FirstOrDefault().id_agent = Convert.ToInt32(textIdAgentOrder.Text);
                        rb.order.Where(x => x.id == numericUpDownOrder.Value).FirstOrDefault().id_product = Convert.ToInt32(textProductOrder.Text);
                        rb.SaveChanges();
                        MessageBox.Show("Запись изменена");
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка ввода");
                    }
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (Restaurant_businessEntities rb = new Restaurant_businessEntities(s))
            {
                product product = rb.product.Where(x => x.name_product == textProductOrder.Text).FirstOrDefault();
                try
                {
                    rb.order.Add(new order
                    {
                        id_agent = Convert.ToInt32(textIdAgentOrder.Text),
                        id_product = product.id
                    });
                    rb.SaveChanges();
                    MessageBox.Show("Запись добавлена");
                }
                catch
                {
                    MessageBox.Show("Ошибка ввода");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Restaurant_businessEntities rb = new Restaurant_businessEntities(s))
            {

                if (textNameCompany.Text == "" || maskedTextIndexCompany.Text == "")
                {
                    MessageBox.Show("Ошибка");
                }
                else
                {
                    company company = rb.company.Where(x => x.index_company == maskedTextIndexCompany.Text).FirstOrDefault();
                    if (company != null)
                    {
                        MessageBox.Show("Такой индекс уже есть");
                    }
                    else
                    {
                        try
                        {
                            rb.company.Add(new company
                            {
                                name = textNameCompany.Text,
                                index_company = maskedTextIndexCompany.Text
                            });
                            rb.SaveChanges();
                            MessageBox.Show("Запись добавлена");
                        }
                        catch
                        {
                            MessageBox.Show("Совпадение названия");
                        }
                    }
                }
                
            }
        }

        

        private void button8_Click(object sender, EventArgs e)
        {
            using (Restaurant_businessEntities rb = new Restaurant_businessEntities(s))
            {
                try
                {
                    rb.product.Add(new product
                    {
                        name_product = textNameProduct.Text,
                        price = Convert.ToDecimal(textPriceProduct.Text),
                        product_volume = Convert.ToInt32(textAmntProduct.Text),
                        unit = comboBoxProduct.Text

                    });
                    rb.SaveChanges();
                    MessageBox.Show("Запись добавлена");
                }
                catch { MessageBox.Show("Ошибка"); }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (Restaurant_businessEntities rb = new Restaurant_businessEntities(s))
            {
                try
                {
                    company company = rb.company.Where(x => x.name == CompanuAgent.Text).FirstOrDefault();
                    if (company == null)
                    {
                        label19.Text = "";
                        MessageBox.Show("нет такой компании");
                    }
                    else
                    {
                        label19.Text = Convert.ToString(company.id);
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }
    }
}
