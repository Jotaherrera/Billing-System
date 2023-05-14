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
    public partial class PrincipalScreen : Form
    {
        private int aux;
        private bool userConfirmation;
        private int chocolateCake = 20000;
        private int miloCake = 25000;
        private int chocolateBread = 8000;
        private int coffee = 2300;
        private int orangeJuice = 3500;
        private int water = 3200;
        private int cheeseStick = 2000;
        private int pastry = 4000;
        private int croissant = 4500;

        private List<double> LchocolateCake = new List<double>();
        private List<double> LmiloCake = new List<double>();
        private List<double> LchocolateBread = new List<double>();
        private List<double> Lcoffee = new List<double>();
        private List<double> LorangeJuice = new List<double>();
        private List<double> Lwater = new List<double>();
        private List<double> LcheeseStick = new List<double>();
        private List<double> Lpastry = new List<double>();
        private List<double> Lcroissant = new List<double>();

        private int prodAux = 0;

        private int acumChocolateCake;
        private int acumMiloCake;
        private int acumChocolateBread;
        private int acumCoffee;
        private int acumOrangeJuice;
        private int acumWater;
        private int acumCheeseStick;
        private int acumPastry;
        private int acumCroissant;

        private int subtotal;
        private double taxes;
        private double total;
        private double grandTotal;
        private double service;

        private string[] userarr = new string[5];
        private string[] passarr = new string[5];

        public PrincipalScreen(string[] userarr, string[] passarr, int aux, bool userConfirmation)
        {
            this.userarr = userarr;
            this.passarr = passarr;
            this.aux = aux;
            this.userConfirmation = userConfirmation;

            InitializeComponent();
        }

        private void PrincipalScreen_Load(object sender, EventArgs e)
        {
            if (userConfirmation == false)
            {
                usersToolStripMenuItem.Enabled = false;
            }
            else if (userConfirmation == true)
            {
                usersToolStripMenuItem.Enabled = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void LabelService_Click(object sender, EventArgs e)
        {
        }

        private void LabelTotal_Click(object sender, EventArgs e)
        {
        }

        private void Subtotal_Click(object sender, EventArgs e)
        {
        }

        /*=================================== Code ==================================*/

        public void PreviewPurchase()
        {
            subtotal = acumChocolateCake + acumMiloCake + acumChocolateBread + acumCoffee + acumOrangeJuice + acumWater + acumCheeseStick + acumPastry + acumCroissant;
            Subtotal.Text = $"${subtotal}";

            taxes = subtotal * 0.08; //Coffee shop tax
            Taxes.Text = $"${taxes}";

            total = subtotal + taxes;

            service = Math.Floor(total * 0.10);

            grandTotal = total + service;

            if (CheckBoxService.Checked == true)
            {
                Service.Text = $"${service}";
                LabelTotal.Text = $"${grandTotal}";
            }
            else
            {
                Service.Text = "";
                LabelTotal.Text = $"${total}";
            }
        }

        /*----------------------------------- PAIRS --------------------------------------*/

        /*-------------------------------Chocolate Cake-----------------------------------*/

        public void CheckBoxChocolateCake_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxChocolateCake.Checked == true)
            {
                ChocolateCakeCounter.Visible = true;
            }
            else
            {
                ChocolateCakeCounter.Visible = false;
                acumChocolateCake = 0;
                ChocolateCakeCounter.Value = 0;
            }
        }

        public void ChocolateCakeCounter_ValueChanged(object sender, EventArgs e)
        {
            acumChocolateCake = chocolateCake * Convert.ToInt32(ChocolateCakeCounter.Value);
            PreviewPurchase();
        }

        /*-------------------------------Milo Cake-----------------------------------*/

        private void CheckBoxMiloCake_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxMiloCake.Checked == true)
            {
                MiloCakeCounter.Visible = true;
            }
            else
            {
                MiloCakeCounter.Visible = false;
                acumMiloCake = 0;
                MiloCakeCounter.Value = 0;
            }
        }

        private void MiloCakeCounter_ValueChanged(object sender, EventArgs e)
        {
            acumMiloCake = miloCake * Convert.ToInt32(MiloCakeCounter.Value);
            PreviewPurchase();
        }

        /*-------------------------------Chocolate Bread-----------------------------------*/

        private void CheckBoxChocolateBread_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxChocolateBread.Checked == true)
            {
                ChocolateBreadCounter.Visible = true;
            }
            else
            {
                ChocolateBreadCounter.Visible = false;
                acumChocolateBread = 0;
                ChocolateBreadCounter.Value = 0;
            }
        }

        private void ChocolateBreadCounter_ValueChanged(object sender, EventArgs e)
        {
            acumChocolateBread = chocolateBread * Convert.ToInt32(ChocolateBreadCounter.Value);
            PreviewPurchase();
        }

        /*------------------------------- Coffee -----------------------------------*/

        private void CheckBoxCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxCoffee.Checked == true)
            {
                CoffeeCounter.Visible = true;
            }
            else
            {
                CoffeeCounter.Visible = false;
                acumCoffee = 0;
                CoffeeCounter.Value = 0;
            }
        }

        private void CoffeeCounter_ValueChanged(object sender, EventArgs e)
        {
            acumCoffee = coffee * Convert.ToInt32(CoffeeCounter.Value);
            PreviewPurchase();
        }

        /*------------------------------- Water -----------------------------------*/

        private void CheckBoxOrangeJuice_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxOrangeJuice.Checked == true)
            {
                OrangeJuiceCounter.Visible = true;
            }
            else
            {
                OrangeJuiceCounter.Visible = false;
                acumOrangeJuice = 0;
                OrangeJuiceCounter.Value = 0;
            }
        }

        private void OrangeJuiceCounter_ValueChanged(object sender, EventArgs e)
        {
            acumOrangeJuice = orangeJuice * Convert.ToInt32(OrangeJuiceCounter.Value);
            PreviewPurchase();
        }

        /*------------------------------- Water -----------------------------------*/

        private void CheckBoxWater_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxWater.Checked == true)
            {
                WaterCounter.Visible = true;
            }
            else
            {
                WaterCounter.Visible = false;
                acumWater = 0;
                WaterCounter.Value = 0;
            }
        }

        private void WaterCounter_ValueChanged(object sender, EventArgs e)
        {
            acumWater = water * Convert.ToInt32(WaterCounter.Value);
            PreviewPurchase();
        }

        /*------------------------------- Cheese Stick -----------------------------------*/

        private void CheckBoxCheeseStick_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxCheeseStick.Checked == true)
            {
                CheeseStickCounter.Visible = true;
            }
            else
            {
                CheeseStickCounter.Visible = false;
                acumCheeseStick = 0;
                CheeseStickCounter.Value = 0;
            }
        }

        private void CheeseStickCounter_ValueChanged(object sender, EventArgs e)
        {
            acumCheeseStick = cheeseStick * Convert.ToInt32(CheeseStickCounter.Value);
            PreviewPurchase();
        }

        /*------------------------------- Pastry -----------------------------------*/

        private void CheckBoxPastry_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxPastry.Checked == true)
            {
                PastryCounter.Visible = true;
            }
            else
            {
                PastryCounter.Visible = false;
                acumPastry = 0;
                PastryCounter.Value = 0;
            }
        }

        private void PastryCounter_ValueChanged(object sender, EventArgs e)
        {
            acumPastry = pastry * Convert.ToInt32(PastryCounter.Value);
            PreviewPurchase();
        }

        /*------------------------------- Croissant -----------------------------------*/

        private void CheckBoxCroissant_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxCroissant.Checked == true)
            {
                CroissantCounter.Visible = true;
            }
            else
            {
                CroissantCounter.Visible = false;
                acumCroissant = 0;
                CroissantCounter.Value = 0;
            }
        }

        private void CroissantCounter_ValueChanged(object sender, EventArgs e)
        {
            acumCroissant = croissant * Convert.ToInt32(CroissantCounter.Value);
            PreviewPurchase();
        }

        /*------------------------------- BUTTONS -----------------------------------*/

        private void ResetButton_Click(object sender, EventArgs e)
        {
            CheckBoxService.Checked = false;
            CheckBoxChocolateCake.Checked = false;
            CheckBoxMiloCake.Checked = false;
            CheckBoxChocolateBread.Checked = false;
            CheckBoxCoffee.Checked = false;
            CheckBoxWater.Checked = false;
            CheckBoxOrangeJuice.Checked = false;
            CheckBoxCheeseStick.Checked = false;
            CheckBoxPastry.Checked = false;
            CheckBoxCroissant.Checked = false;

            ReceiptTextBox.Text = "";
            LabelTotal.Text = "$00000";
            Service.Text = "";
            Subtotal.Text = "";
            Taxes.Text = "";
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users usersScreen = new Users(userarr, passarr, aux);
            usersScreen.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            userConfirmation = false;
            LoginScreen loginscreen = new LoginScreen(this.userarr, this.passarr, this.aux);
            loginscreen.Show();
            this.Hide();
        }

        private void ReceiptTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void CheckBoxService_CheckedChanged(object sender, EventArgs e)
        {
            PreviewPurchase();
        }

        private void ReceiptButton_Click(object sender, EventArgs e)
        {
            LchocolateCake.Add(Convert.ToDouble(ChocolateCakeCounter.Value));
            LmiloCake.Add(Convert.ToDouble(MiloCakeCounter.Value));
            LchocolateBread.Add(Convert.ToDouble(ChocolateBreadCounter.Value));
            Lcoffee.Add(Convert.ToDouble(CoffeeCounter.Value));
            Lwater.Add(Convert.ToDouble(WaterCounter.Value));
            LorangeJuice.Add(Convert.ToDouble(OrangeJuiceCounter.Value));
            LcheeseStick.Add(Convert.ToDouble(CheeseStickCounter.Value));
            Lpastry.Add(Convert.ToDouble(PastryCounter.Value));
            Lcroissant.Add(Convert.ToDouble(CroissantCounter.Value));

            prodAux += 1;

            string date = DateTime.UtcNow.ToString("dd-MM-yyyy");
            string hour = DateTime.Now.ToString("hh:mm:ss");
            ReceiptTextBox.Clear();

            ReceiptTextBox.AppendText("\t\tRESTAURANT NAME" + Environment.NewLine);
            ReceiptTextBox.AppendText("\t" + "            RESTAURANT LOCATION" + Environment.NewLine);
            ReceiptTextBox.AppendText("\t" + "                     NIT: 00000000-0" + Environment.NewLine);
            ReceiptTextBox.AppendText("\t" + "                   DIR: CR 00 #00 - 00" + Environment.NewLine);
            ReceiptTextBox.AppendText("\t" + "                    TEL: 0000000 OP 0" + Environment.NewLine);
            ReceiptTextBox.AppendText(Environment.NewLine);
            ReceiptTextBox.AppendText("-----------------------------------------------------------" + Environment.NewLine);
            ReceiptTextBox.AppendText("PRINT: 1\t\t\t Cash Register No: 1" + Environment.NewLine);
            ReceiptTextBox.AppendText("SALES INVOICE #M0: \t 000000" + Environment.NewLine);
            ReceiptTextBox.AppendText("ORDER:    7" + Environment.NewLine);
            ReceiptTextBox.AppendText($"DATE:    {date}\t HOUR:    {hour}" + Environment.NewLine);
            ReceiptTextBox.AppendText("ATTENDED BY: JUAN" + Environment.NewLine);
            ReceiptTextBox.AppendText(Environment.NewLine);
            ReceiptTextBox.AppendText("====================================" + Environment.NewLine);
            ReceiptTextBox.AppendText("CANT\tDESCRIPTION\t\tPRICE\t    TOTAL" + Environment.NewLine);
            if (CheckBoxChocolateCake.Checked == true)
            {
                ReceiptTextBox.AppendText($"{ChocolateCakeCounter.Value}\tChocolate Cake\t\t{chocolateCake}\t    {acumChocolateCake}" + Environment.NewLine);
            }
            else
            {
            }
            if (CheckBoxMiloCake.Checked == true)
            {
                ReceiptTextBox.AppendText($"{MiloCakeCounter.Value}\tMilo Cake\t\t{miloCake}\t    {acumMiloCake}" + Environment.NewLine);
            }
            else
            {
            }
            if (CheckBoxChocolateBread.Checked == true)
            {
                ReceiptTextBox.AppendText($"{ChocolateBreadCounter.Value}\tChocolate Bread\t\t{chocolateBread}\t    {acumChocolateBread}" + Environment.NewLine);
            }
            else
            {
            }
            if (CheckBoxCoffee.Checked == true)
            {
                ReceiptTextBox.AppendText($"{CoffeeCounter.Value}\tCoffee\t\t\t{coffee}\t    {acumCoffee}" + Environment.NewLine);
            }
            else
            {
            }
            if (CheckBoxOrangeJuice.Checked == true)
            {
                ReceiptTextBox.AppendText($"{OrangeJuiceCounter.Value}\tOrange Juice\t\t{orangeJuice}\t    {acumOrangeJuice}" + Environment.NewLine);
            }
            else
            {
            }
            if (CheckBoxWater.Checked == true)
            {
                ReceiptTextBox.AppendText($"{WaterCounter.Value}\tWater\t\t\t{water}\t    {acumWater}" + Environment.NewLine);
            }
            else
            {
            }
            if (CheckBoxCheeseStick.Checked == true)
            {
                ReceiptTextBox.AppendText($"{CheeseStickCounter.Value}\tCheese Stick\t\t{cheeseStick}\t    {acumCheeseStick}" + Environment.NewLine);
            }
            else
            {
            }
            if (CheckBoxPastry.Checked == true)
            {
                ReceiptTextBox.AppendText($"{PastryCounter.Value}\tPastry\t\t\t{pastry}\t    {acumPastry}" + Environment.NewLine);
            }
            else
            {
            }
            if (CheckBoxCroissant.Checked == true)
            {
                ReceiptTextBox.AppendText($"{CroissantCounter.Value}\tCroissant\t\t{croissant}\t    {acumCroissant}" + Environment.NewLine);
            }
            else
            {
            }
            ReceiptTextBox.AppendText("====================================" + Environment.NewLine);
            ReceiptTextBox.AppendText("\t\t" + "TAX DISCRIMINATION" + Environment.NewLine);
            ReceiptTextBox.AppendText("====================================" + Environment.NewLine);
            ReceiptTextBox.AppendText("\t\t\tBASE\t\tTAXES  8%" + Environment.NewLine);
            ReceiptTextBox.AppendText($"\t\t\t{subtotal}\t\t{taxes}" + Environment.NewLine);
            ReceiptTextBox.AppendText($"\t\t  TOTAL TAXES\t\t{taxes}" + Environment.NewLine);
            ReceiptTextBox.AppendText(Environment.NewLine);
            ReceiptTextBox.AppendText("====================================" + Environment.NewLine);
            ReceiptTextBox.AppendText($"\t\t\tTOTAL:\t\t{total}" + Environment.NewLine);
            ReceiptTextBox.AppendText($"\t\t\tDISC:\t\t0" + Environment.NewLine);
            if (CheckBoxService.Checked == true)
            {
                ReceiptTextBox.AppendText($"\t\t\tSERVICE:\t\t{service}" + Environment.NewLine);
                ReceiptTextBox.AppendText($"\t\t\tTOTAL:\t\t{grandTotal}" + Environment.NewLine);
            }
            else
            {
                ReceiptTextBox.AppendText($"\t\t\tTOTAL:\t\t{total}" + Environment.NewLine);
            }
            ReceiptTextBox.AppendText("====================================" + Environment.NewLine);
            ReceiptTextBox.AppendText("\t\t       VISIT US AT" + Environment.NewLine);
            ReceiptTextBox.AppendText("\t          www.restaurantname.com" + Environment.NewLine);
        }

        private void closeCashRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseCashRegister closeCashRegister = new CloseCashRegister(chocolateCake, miloCake, chocolateBread, coffee, orangeJuice, water, cheeseStick, pastry, croissant, prodAux, LchocolateCake, LmiloCake, LchocolateBread, Lcoffee, LorangeJuice, Lwater, LcheeseStick, Lpastry, Lcroissant);
            closeCashRegister.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(ReceiptTextBox.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void toolStripPrintButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void ToolStripCopyButton_Click(object sender, EventArgs e)
        {
            ReceiptTextBox.SelectAll();
            ReceiptTextBox.Focus();
            ReceiptTextBox.Copy();
        }

        private void ToolStripCutButton_Click(object sender, EventArgs e)
        {
            ReceiptTextBox.SelectAll();
            ReceiptTextBox.Focus();
            ReceiptTextBox.Cut();
        }

        private void toolStripSaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Receipt";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                    sw.WriteLine(ReceiptTextBox.Text);
            }
        }
    }
}