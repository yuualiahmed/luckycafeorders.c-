using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace luckycafeorders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtname.Clear();

            txtquantity.Clear();

            orderedlist.Items.Clear();

            lbltotal.Text = "";

            lbllucky.Text = "";

            ckbstudent.Checked = false;

            rdbtea.Checked = false;
            rdbcoffe.Checked = false;
            rdbjuice.Checked = false;
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text == "")
                {
                    MessageBox.Show("fadlan magac soo geli");
                    return;
                }

                int quantity = int.Parse(txtquantity.Text);
                if (quantity <= 0)
                {
                    MessageBox.Show("Fadlan geli tiro ka bilaabanta 1 ama ka badan!");
                    return;
                }

                double unitPrice = 0.00;
                string drinkName = "";


                if (rdbtea.Checked)
                {
                    unitPrice = 1.00;
                    drinkName = "Tea";
                }
                else if (rdbcoffe.Checked)
                {
                    unitPrice = 2.00;
                    drinkName = "Coffee";
                }
                else if (rdbjuice.Checked)
                {
                    unitPrice = 3.00;
                    drinkName = "Juice";
                }
                else
                {
                    MessageBox.Show("Fadlan dooro nooca cabitaanka!");
                    return;
                }

                orderedlist.Items.Clear();

                Random random = new Random();
                bool lucky = false;

                for (int i = 1; i <= quantity; i++)
                {
                    int luckyNumber = random.Next(1, 51);

                    if (luckyNumber == 7 || luckyNumber == 17)
                    {
                        lucky = true;
                    }

                    orderedlist.Items.Add(
                        i + ") " + txtname.Text +
                        " - " + drinkName +
                        " - Lucky: " + luckyNumber +
                        " - $" + unitPrice.ToString("0.00"));
                }

                double total = unitPrice * quantity;

                if (ckbstudent.Checked)
                {
                    total = total - (total * 0.10);
                }

                lbltotal.Text = "Total Price: $" + total.ToString("0.00");

                if (lucky)
                {
                    lbllucky.Text = "You got a Free Cookie!";
                }
                else
                {
                    lbllucky.Text = "No prize this time.";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fadlan geli quantity tiro sax ah!");
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (orderedlist.Items.Count == 0)
            {
                MessageBox.Show("No order to save.");
                return;
            }

            StreamWriter writer = File.AppendText("orders.txt");

            for (int i = 0; i < orderedlist.Items.Count; i++)
            {
                writer.WriteLine(orderedlist.Items[i]);
            }

            writer.WriteLine(lbltotal.Text);
            writer.WriteLine(lbllucky.Text);

            writer.WriteLine("----------------------");

            writer.Close();

            MessageBox.Show("Order saved.");
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            if (!File.Exists("orders.txt"))
            {
                MessageBox.Show("No file found.");
                return;
            }

            orderedlist.Items.Clear();

            StreamReader reader = File.OpenText("orders.txt");

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                orderedlist.Items.Add(line);
            }

            reader.Close();
        }
    }
}
