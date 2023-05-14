using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class CloseCashRegister : Form
    {
        int chocolateCake;
        int miloCake;
        int chocolateBread;
        int coffee;
        int orangeJuice;
        int water;
        int cheeseStick;
        int pastry;
        int croissant;

        List<double> LchocolateCake = new List<double>();
        List<double> LmiloCake = new List<double>();
        List<double> LchocolateBread = new List<double>();
        List<double> Lcoffee = new List<double>();
        List<double> LorangeJuice = new List<double>();
        List<double> Lwater = new List<double>();
        List<double> LcheeseStick = new List<double>();
        List<double> Lpastry = new List<double>();
        List<double> Lcroissant = new List<double>();

        double totalItems;
        double totalSold;

        int prodAux = 0;
        public CloseCashRegister(int chocolateCake, int miloCake, int chocolateBread, int coffee, int orangeJuice, int water, int cheeseStick, int pastry, int croissant, int prodAux, List<double> LchocolateCake, List<double> LmiloCake, List<double> LchocolateBread, List<double> Lcoffee, List<double> LorangeJuice, List<double> Lwater, List<double> LcheeseStick, List<double> Lpastry, List<double> Lcroissant)
        {
            InitializeComponent();
            this.chocolateCake = chocolateCake;
            this.miloCake = miloCake;
            this.chocolateBread = chocolateBread;
            this.coffee = coffee;
            this.orangeJuice = orangeJuice;
            this.water = water;
            this.cheeseStick = cheeseStick;
            this.pastry = pastry;
            this.croissant = croissant;


            this.LchocolateCake = LchocolateCake;
            this.LmiloCake = LmiloCake;
            this.LchocolateBread = LchocolateBread;
            this.Lcoffee = Lcoffee;
            this.LorangeJuice = LorangeJuice;
            this.Lwater = Lwater;
            this.LcheeseStick = LcheeseStick;
            this.Lpastry = Lpastry;
            this.Lcroissant = Lcroissant;

            this.prodAux = prodAux;

            for (int i = 0; i < prodAux; i++)
            {
                ListViewItem item = new ListViewItem();
                item = lvwCerrar.Items.Add(Convert.ToString(LchocolateCake[i]));
                item.SubItems.Add(Convert.ToString(LmiloCake[i]));
                item.SubItems.Add(Convert.ToString(LchocolateBread[i]));
                item.SubItems.Add(Convert.ToString(Lcoffee[i]));
                item.SubItems.Add(Convert.ToString(LorangeJuice[i]));
                item.SubItems.Add(Convert.ToString(Lwater[i]));
                item.SubItems.Add(Convert.ToString(LcheeseStick[i]));
                item.SubItems.Add(Convert.ToString(Lpastry[i]));
                item.SubItems.Add(Convert.ToString(Lcroissant[i]));
            }

        }

        private void BackButton_Click(object sender, EventArgs e)
        {

        }

        private void RecordRegisterButton_Click(object sender, EventArgs e)
        {

        }

        private void CloseCashRegister_Load(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (prodAux != 0)
                {
                    string registers = Application.StartupPath + @".\Registers";
                    try
                    {
                        if (!Directory.Exists(registers))
                        {
                            Directory.CreateDirectory(registers);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    StreamWriter sw = new StreamWriter(@".\Registers\caja.txt");
                    sw.Write("Today were sold:" + Environment.NewLine);
                    sw.Write("Chocolate Cake    Milo Cake    Chocolate Bread    Coffee    Water    Orange Juice    Cheese Stick    Pastry    Croissant" + Environment.NewLine);
                    for (int i = 0; i < prodAux; i++)
                    {
                        sw.Write(LchocolateCake[i] + "                 " + LmiloCake[i] + "            " + LchocolateBread[i] + "                  " + Lcoffee[i] + "         " + Lwater[i] + "        " + LorangeJuice[i] + "               " + LcheeseStick[i] + "               " + Lpastry[i] + "         " + Lcroissant[i] + Environment.NewLine);
                        sw.Write(Environment.NewLine);
                        totalItems = totalItems + LchocolateCake[i] + LmiloCake[i] + LchocolateBread[i] + Lcoffee[i] + Lwater[i] + LorangeJuice[i] + LcheeseStick[i] + Lpastry[i] + Lcroissant[i];
                        totalSold = totalSold + (LchocolateCake[i] * chocolateCake) + (LmiloCake[i] * miloCake) + (LchocolateBread[i] * chocolateBread) + (Lcoffee[i] * coffee) + (Lwater[i] * water) + (LorangeJuice[i] * orangeJuice) + (LcheeseStick[i] * cheeseStick) + (Lpastry[i] * pastry) + (Lcroissant[i] * croissant);
                    }
                    sw.Write($"Total items sold: {totalItems}" + Environment.NewLine);
                    sw.Write($"Total money earned: ${totalSold}" + Environment.NewLine);
                    MessageBox.Show("Register recorded.");
                    sw.Close();
                }
                else
                {
                    MessageBox.Show("Empty list.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
