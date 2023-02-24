using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restraunt_Order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Nametextbox_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        static string calculateprice(int drinkprice, int mealprice, int sideprice)
        {
            int totalprice = drinkprice + mealprice + sideprice;
            string strtotalprice = string.Format("Total cost: {0:C}", totalprice.ToString("C"));
            return strtotalprice;
        }
        private void Ordercreator_Click(object sender, EventArgs e)
        {
            string complete_order = "";
            if (nametextbox.Text == "Enter Your Name" || nametextbox.Text == "")
            {
                MessageBox.Show("Please enter your name.");
            }
            else
            {
                string user_name = nametextbox.Text;
                complete_order = "Hello " + user_name + "!";
                int drinkprice = 0;
                int mealprice = 0;
                int sideprice = 0;
                if (radioButton1.Checked == true)
                {
                    complete_order += Environment.NewLine + "You ordered a " + radioButton1.Text + ".";
                    drinkprice = 1;
                }
                else if (radioButton2.Checked == true)
                {
                    complete_order += Environment.NewLine + "You ordered a " + radioButton2.Text + ".";
                    drinkprice = 1;
                }
                else if (radioButton3.Checked == true)
                {
                    complete_order += Environment.NewLine + "You ordered a " + radioButton3.Text + ".";
                    drinkprice = 2;
                }
                else if (radioButton4.Checked == true)
                {
                    complete_order += Environment.NewLine + "You ordered a " + radioButton4.Text + ".";
                    drinkprice = 2;
                }
                else
                {
                    complete_order += Environment.NewLine + "You ordered a " + radioButton5.Text + ".";
                    drinkprice = 2;
                }
                complete_order += Environment.NewLine + "You ordered " + mealcombobox.Text + ". ";
                if (mealcombobox.SelectedItem == "Burger- $7")
                {
                    mealprice = 7;
                }
                else if (mealcombobox.SelectedItem == "Fries- $4")
                {
                    mealprice = 4;
                }
                else if (mealcombobox.SelectedItem == "Pasta- $5")
                {
                    mealprice = 5;
                }
                else if (mealcombobox.SelectedItem == "Taco- $4")
                {
                    mealprice = 4;
                }
                else if (mealcombobox.SelectedItem == "Spaghetti- $5")
                {
                    mealprice = 5;
                }
                else
                {
                    mealprice = 10;
                }
                if (radioButton6.Checked == true)
                {
                    complete_order += Environment.NewLine + "You ordered a " + radioButton6.Text + ".";
                    sideprice = 3;
                }
                else if (radioButton7.Checked == true)
                {
                    complete_order += Environment.NewLine + "You ordered a " + radioButton7.Text + ".";
                    sideprice = 3;
                }
                else if (radioButton8.Checked == true)
                {
                    complete_order += Environment.NewLine + "You ordered a " + radioButton8.Text + ".";
                    sideprice = 2;
                }
                else if (radioButton9.Checked == true)
                {
                    complete_order += Environment.NewLine + "You ordered a " + radioButton9.Text + ".";
                    sideprice = 4;
                }
                else if (radioButton10.Checked == true)
                {
                    complete_order += Environment.NewLine + "You ordered a " + radioButton10.Text + ".";
                    sideprice = 5;
                }
                else
                {
                    complete_order += Environment.NewLine + "You ordered a " + radioButton11.Text + ".";
                    sideprice = 4;
                }
                string price = calculateprice(drinkprice, mealprice, sideprice);
                completeordertextbox.Text = complete_order + Environment.NewLine + price + ".";
            }
        }
    }
}
