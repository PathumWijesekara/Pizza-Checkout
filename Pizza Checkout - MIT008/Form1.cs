using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Checkout___MIT008
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string paidBy = "";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            paidBy = "Master  Card";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            paidBy = "Visa";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (phoneTextbox1.Text.Length >= 3)
            {
                phoneTextbox2.Focus();
            }

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            paidBy = "Cash";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            paidBy = "Chque";
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "\\Small-Pizza.png");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "\\Medium-Pizza.jpg");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "\\Large-Pizza.jpg");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "\\Supreme-Pizza.jpg");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nameTextbox.Text = String.Empty;
            phoneTextbox1.Text = String.Empty;
            phoneTextbox2.Text = String.Empty;
            addressTextbox.Text = String.Empty;
            visaRadioButton.Checked = true;
            creditOrChequeTextbox.Text = String.Empty;
            smallRadioButton.Checked = true;
            extraCheeseCheckBox.Checked = false;
            pepperoniCheckBox.Checked = false;
            italianSausageCheckBox.Checked = false;
            groundBeefCheckBox.Checked = false;
            jalapenoCheckBox.Checked = false;
            hamCheckBox.Checked = false;
            anchoviesCheckBox.Checked = false;
            baconCheckBox.Checked = false;
            onionCheckBox.Checked = false;
            oliveCheckBox.Checked = false;
            mushroomsCheckBox.Checked = false;
            greenPepperCheckBox.Checked = false;
            orderPizzaTextbox.Text = String.Empty;
            orderToppingsTextbox.Text = String.Empty;
            orderSubTotalTextbox.Text = String.Empty;
            orderTaxTextbox.Text = String.Empty;
            orderTotalTextbox.Text = String.Empty;
            nameTextbox.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "", phone1 = "", phone2 = "", address = "", chequeOrCCNo = "", toppings = "\n", pizzaSize = "";
            double pizzaPrize = 0.0d, pizzaTopping = 0.0d, subTotal = 0.0d, tax = 0.0d, total = 0.0d;
            //Validate  data  entry
            if (nameTextbox.Text == "")
            {
                MessageBox.Show("Name  cannot  be  blank!", "Blank  Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nameTextbox.Focus();
                return;
            }
            else if (phoneTextbox1.Text == "")
            {
                MessageBox.Show("Phone  Number  cannot  be  blank!", "Blank  Phone  Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phoneTextbox1.Focus();
                return;
            }
            else if (phoneTextbox2.Text == "")
            {
                MessageBox.Show("Phone  Number  cannot  be  blank!", "Blank  Phone  Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phoneTextbox2.Focus();
                return;
                if (addressTextbox.Text == "")


                {
                    MessageBox.Show("Address  cannot  be  blank!", "Blank  Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    addressTextbox.Focus();
                    return;
                }
                if (((masterCardRadioButton.Checked) || (visaRadioButton.Checked) || (chequeRadioButton.Checked)) &&
                    (creditOrChequeTextbox.Text == ""))
                {
                    MessageBox.Show("Please  Enter  Credit  Card  or  Cheque  Number!", "Credit  Card#  or  Cheque#", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    creditOrChequeTextbox.Focus(); return;
                }

                try
                {
                    //Assignment  of  values name  =  nameTextbox.Text;
                    phone1 = phoneTextbox1.Text;
                    phone2 = phoneTextbox2.Text;
                    address = addressTextbox.Text;
                    chequeOrCCNo = creditOrChequeTextbox.Text;
                    name = nameTextbox.Text;
                    phone1 = phoneTextbox1.Text;
                    phone2 = phoneTextbox2.Text;
                    address = addressTextbox.Text;
                    chequeOrCCNo = creditOrChequeTextbox.Text;

                    //Processing  of  Pizza  size
                    if (smallRadioButton.Checked)
                    {
                        pizzaPrize = 7.95;
                    }
                    else if (mediumRadioButton.Checked)
                    {
                        pizzaPrize = 11.95;
                        pizzaSize = "Medium";
                    }
                    else if (largeRadioButton.Checked)
                    {
                        pizzaPrize = 14.95; pizzaSize = "Large";
                    }
                    else if (supremeRadioButton.Checked)
                    {
                        pizzaPrize = 18.95; pizzaSize = "Supreme";
                    }

                    //Calculation  of  Toppings
                    if (extraCheeseCheckBox.Checked)
                    {
                        pizzaTopping += .95;
                        toppings += "\t  Extra  Cheese  \n";
                    }
                    if (groundBeefCheckBox.Checked)
                    {
                        pizzaTopping += .95;
                        toppings += "\t  Ground  Beef  \n";
                    }
                    if (anchoviesCheckBox.Checked)
                    {
                        pizzaTopping += .95;
                        toppings += "\t  Anchovies  \n";
                    }
                    if (oliveCheckBox.Checked)
                    {
                        pizzaTopping += .95; toppings += "\t  Olive  \n";
                    }
                    if (pepperoniCheckBox.Checked)
                    {
                        pizzaTopping += .95;
                        toppings += "\t  Pepperoni  \n";
                    }
                    if (jalapenoCheckBox.Checked)
                    {
                        pizzaTopping += .95;
                        toppings += "\t  Jalapeno  \n";
                    }
                    if (baconCheckBox.Checked)
                    {
                        pizzaTopping += .95; toppings += "\t  Bacon  \n";
                    }
                    if (mushroomsCheckBox.Checked)
                    {
                        pizzaTopping += .95;
                        toppings += "\t  Mushrooms  \n";
                    }
                    if (italianSausageCheckBox.Checked)
                    {
                        pizzaTopping += .95;
                        toppings += "\t  Italian  Sausage  \n";
                    }
                    if (hamCheckBox.Checked)
                    {
                        pizzaTopping += .95; toppings += "\t  Ham  \n";
                    }
                    if (onionCheckBox.Checked)
                    {
                        pizzaTopping += .95; toppings += "\t  Onion  \n";
                    }
                    if (greenPepperCheckBox.Checked)
                    {
                        pizzaTopping += .95;
                        toppings += "\t  Green  Pepper  \n";
                    }
                    //Calculations
                    orderPizzaTextbox.Text = pizzaPrize.ToString(); 
                    orderToppingsTextbox.Text = pizzaTopping.ToString(); 
                    subTotal = pizzaPrize + pizzaTopping; 
                    orderSubTotalTextbox.Text = subTotal.ToString();
                    tax = subTotal * 0.14;  
                    //Tax  Rate  is  calculated  from  the  sample  screenshot.
                    //total  =  subTotal  +  tax;
                    orderTaxTextbox.Text = tax.ToString("n2"); 
                    orderTotalTextbox.Text = total.ToString();

                    //Preparation  of  output  to  messagebox
                    string  orderDetails  =  "";
                    orderDetails += "Sold  To:  " + name + "\n"; 
                    orderDetails += "Address:  " + address + "\n";
                    orderDetails += "Telephone:  " + phone1 + "-" + phone2 + "\n"; orderDetails += "\n";
                    orderDetails += "Paid  by:  " + paidBy + "\n"; 
                    orderDetails += "\n";
                    orderDetails += "Pizza  Size:  " + pizzaSize + "\n"; orderDetails += "Toppings:  " + toppings + "\n";
                    //orderDetails  +=  "\n";
                    orderDetails += "Pizza:  " + pizzaPrize.ToString() + "\n"; 
                    orderDetails += "Topping:  " + pizzaTopping.ToString() + "\n"; 
                    orderDetails += "Subtotal:  " + subTotal.ToString() + "\n"; 
                    orderDetails += "Taxes:  " + tax.ToString() + "\n"; 
                    orderDetails += "Total:  " + total.ToString();

                    MessageBox.Show(orderDetails, "Order  Details...", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An  error  has  occurred!  The  message  is:  \n" + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
        }

      
    }


}

