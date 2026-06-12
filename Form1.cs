using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PizzaCheckout
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void placeOrderButton_Click_1(object sender, EventArgs e)
        {
            String payment="";
            if (visaRadioButton.Checked)
            {
                payment = "Visa";
            }
            else if (masterRadioButton.Checked)
            {
                payment = "Mastra Card";
            }
            else if (chequeRadioButton.Checked)
            {
                payment = "Cheque";
            }
            else if (cashRadioButton.Checked)
            {
                payment = "Cash";
            }

            String size="";
            double price = 0.0;

            if (smallRadioButton.Checked)
            {
                size = "Small";
                price = 7.95;
                pictureBox.Image = Properties.Resources.small;
            }
            else if (mediumRadioButton.Checked)
            {
                size = "Medium";
                price = 11.95;
                pictureBox.Image = Properties.Resources.medium;
            }
            else if (largeRadioButton.Checked)
            {
                size = "Large";
                price = 14.95;
                pictureBox.Image = Properties.Resources.large;
            }

            else if (supremeRadioButton.Checked)
            {
                size = "Supreme";
                price = 18.95;
                pictureBox.Image = Properties.Resources.supreme;
            }

            double topping = 0;
            String toppingname = "";

            if (extracheesecheckBox.Checked)
            {
                topping += 0.95;
                toppingname += "Extra cheese\n";
            }
            if (PepperonicheckBox.Checked)
            {
                topping += 0.95;
                toppingname += "Pepperoni\n";
            }
            if (ItaliansausagecheckBox.Checked)
            {
                topping += 0.95;
                toppingname += "Italian Sausage\n";
            }
            if (GroundBeefcheckBox.Checked)
            {
                topping += 0.95;
                toppingname += "Ground Beef\n";
            }
            if (JalapenocheckBox.Checked)
            {
                topping += 0.95;
                toppingname += "Jalapeno\n";
            }
            if (HamcheckBox.Checked)
            {
                topping += 0.95;
                toppingname += "Ham\n";
            }
            if (AnchoviescheckBox.Checked)
            {
                topping += 0.95;
                toppingname += "Anchovies\n";
            }
            if (BaconcheckBox.Checked)
            {
                topping += 0.95;
                toppingname += "Bacon\n";
            }
            if (OnioncheckBox.Checked)
            {
                topping += 0.95;
                toppingname += "Onion\n";
            }
            if (OlivecheckBox.Checked)
            {
                topping += 0.95;
                toppingname += "Olive\n";
            }
            if (MushroomscheckBox.Checked)
            {
                topping += 0.95;
                toppingname += "Mushrooms\n";
            }
            if (GreenPeppercheckBox.Checked)
            {
                topping += 0.95;
                toppingname += "Green Pepper\n";
            }

            pizzaTextbox.Text = price.ToString();
            toppingsTextbox.Text = topping.ToString();
            double subtotal = price + topping;
            subtotalTextbox.Text = subtotal.ToString();
            double tax = 2.89;
            texTextbox.Text = tax.ToString();
            double total = subtotal + tax;
            totalTextbox.Text = total.ToString("c");

            String details="Sold To : "+nameTextbox.Text+"\n Address :  "+addressTextbox.Text+
                "\n Telephone : "+telTextbox.Text+ " \n Paid By : "+ payment+
                "\n \n Pizza Size :  "+ size + "\n \n Toppings : "+"\n"+toppingname+
                "\n\n\n Pizza : "+pizzaTextbox.Text+
                "\n Topping : "+toppingsTextbox.Text+
                "\n Subtotal : "+subtotalTextbox.Text+
                "\nTaxes : "+texTextbox.Text+
                "\n \n Total"+totalTextbox.Text;

            MessageBox.Show(details,"Order Details");

        }

        private void masterRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pepperonicheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
           nameTextbox.Clear();
            telTextbox.Clear();
            addressTextbox.Clear();
          
            
            foreach(Control ctrl in paymentgroupBox.Controls)
            {
                if (ctrl is System.Windows.Forms.RadioButton radio)
                    radio.Checked = false;
            }
            foreach (Control ctrl in sizegroupBox.Controls)
            {
                if (ctrl is System.Windows.Forms.RadioButton radio)
                    radio.Checked = false;
            }

            foreach (Control ctrl in toppingsgroupBox.Controls)
            {
                if (ctrl is System.Windows.Forms.CheckBox check)
                    check.Checked = false;   
            }
            foreach (Control ctrl in ordergroupBox.Controls)
            {
                if (ctrl is System.Windows.Forms.TextBox)
                    ((TextBox)ctrl).Clear();
                  
            }


        }
    }
}
