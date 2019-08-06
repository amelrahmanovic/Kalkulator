using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitron
{
    public partial class Form1 : Form
    {
        double firstNumber = 0;
        string Operation = "";
        double SecondNumber = 0;
        bool daLiJeJednako = false;
        bool kliknuta_operacija = false;
        decimal MemoryStore = 0;
        decimal EndResult = 0;
        double Result;
        bool unesiJednom = false;
        bool unesiJednomZazarez = false;


        public Form1()
        {
            InitializeComponent();
        }



        private void button30_Click(object sender, EventArgs e)
        {
            if (daLiJeJednako)
                textBox1.Text = "";
            daLiJeJednako = false;
            if (kliknuta_operacija)
                textBox1.Text = "";
            kliknuta_operacija = false;
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "1";
            else
                textBox1.Text = textBox1.Text + "1";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (daLiJeJednako)
                textBox1.Text = "";
            daLiJeJednako = false;
            if (kliknuta_operacija)
                textBox1.Text = "";
            kliknuta_operacija = false;
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "2";
            else
                textBox1.Text = textBox1.Text + "2";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (daLiJeJednako)
                textBox1.Text = "";
            daLiJeJednako = false;
            if (kliknuta_operacija)
                textBox1.Text = "";
            kliknuta_operacija = false;
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "3";
            else
                textBox1.Text = textBox1.Text + "3";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (daLiJeJednako)
                textBox1.Text = "";
            daLiJeJednako = false;
            if (kliknuta_operacija)
                textBox1.Text = "";
            kliknuta_operacija = false;
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "4";
            else
                textBox1.Text = textBox1.Text + "4";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (daLiJeJednako)
                textBox1.Text = "";
            daLiJeJednako = false;
            if (kliknuta_operacija)  // provera da li ja zadnje pokrenuta operacija - ako jeste onda se ponistava ekran i ispusuje se novi broj
                textBox1.Text = "";
            kliknuta_operacija = false;
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "5";
            else
                textBox1.Text = textBox1.Text + "5";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (daLiJeJednako)
                textBox1.Text = "";
            daLiJeJednako = false;
            if (kliknuta_operacija)
                textBox1.Text = "";
            kliknuta_operacija = false;
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "6";
            else
                textBox1.Text = textBox1.Text + "6";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (daLiJeJednako)
                textBox1.Text = "";
            daLiJeJednako = false;
            if (kliknuta_operacija)
                textBox1.Text = "";
            kliknuta_operacija = false;
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "7";
            else
                textBox1.Text = textBox1.Text + "7";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (daLiJeJednako)
                textBox1.Text = "";
            daLiJeJednako = false;
            if (kliknuta_operacija)
                textBox1.Text = "";
            kliknuta_operacija = false;
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "8";
            else
                textBox1.Text = textBox1.Text + "8";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (daLiJeJednako)
                textBox1.Text = "";
            daLiJeJednako = false;
            if (kliknuta_operacija)
                textBox1.Text = "";
            kliknuta_operacija = false;
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "9";
            else
                textBox1.Text = textBox1.Text + "9";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            daLiJeJednako = false;
            kliknuta_operacija = false;
            if (textBox1.Text!="0")
                textBox1.Text = textBox1.Text + "0";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (!kliknuta_operacija)
            {
                unesiJednomZazarez = false;
                if (Operation == "")
                {
                    unesiJednomZazarez = false;

                    if (!unesiJednom)
                    {
                        daLiJeJednako = false;
                        firstNumber = Convert.ToDouble(textBox1.Text);
                        Operation = "+";
                        kliknuta_operacija = true;
                        unesiJednom = true;
                    }
                    else
                    {
                        SecondNumber = Convert.ToDouble(textBox1.Text);
                        Izvrsioperaciju();
                        textBox1.Text = "";
                    }
                }
            }
        }
        private void button27_Click(object sender, EventArgs e)
        {
            if (!kliknuta_operacija)
            {
                unesiJednomZazarez = false;
                if (Operation == "")
                {
                    if (!unesiJednom)
                    {
                        daLiJeJednako = false;
                        firstNumber = Convert.ToDouble(textBox1.Text);
                        Operation = "-";
                        kliknuta_operacija = true;
                        unesiJednom = true;
                    }
                    else
                    {
                        SecondNumber = Convert.ToDouble(textBox1.Text);
                        Izvrsioperaciju();
                        textBox1.Text = "";
                    }
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!kliknuta_operacija)
            {
                unesiJednomZazarez = false;
                if (Operation == "")
                {
                    if (!unesiJednom)
                    {
                        daLiJeJednako = false;
                    firstNumber = Convert.ToDouble(textBox1.Text);
                    Operation = "*";
                    kliknuta_operacija = true;
                    unesiJednom = true;
                }
                else
                {
                    SecondNumber = Convert.ToDouble(textBox1.Text);
                    Izvrsioperaciju();
                    textBox1.Text = "";
                   
                    }
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!kliknuta_operacija)
            {

                if (Operation == "")
                {
                    if (!unesiJednom)
                    {
                        daLiJeJednako = false;
                        firstNumber = Convert.ToDouble(textBox1.Text);
                        Operation = "/";
                        kliknuta_operacija = true;
                        unesiJednom = true;
                        textBox1.Text = "";
                    }
                    else
                    {
                        SecondNumber = Convert.ToDouble(textBox1.Text);
                        Izvrsioperaciju();
                        textBox1.Text = "";
                    }
                }
            }
        }
        private void button23_Click(object sender, EventArgs e)
        {
            if (!unesiJednomZazarez)
                textBox1.Text = textBox1.Text + ",";
            unesiJednomZazarez = true;
        }

        private void Izvrsioperaciju()
        {
            if (Operation == "+")
            {
                Result = firstNumber + SecondNumber;
                textBox1.Text = Convert.ToString(Result);
                firstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = firstNumber - SecondNumber;
                textBox1.Text = Convert.ToString(Result);
                firstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = firstNumber * SecondNumber;
                textBox1.Text = Convert.ToString(Result);
                firstNumber = Result;
            }
            if (Operation == "%")
            {
                Result = firstNumber % SecondNumber;
                textBox1.Text = Convert.ToString(Result);
                firstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Ne moze se deliti sa 0! ";
                    textBox1.Font = new Font(SystemFonts.MessageBoxFont.Name, 13f, FontStyle.Bold);//Podesavanje fonta
                }
                else
                {
                    Result = firstNumber / SecondNumber;
                    textBox1.Text = Convert.ToString(Result);
                    firstNumber = Result;
                }
            }
        }

        private string PrintZeroToNine(int Number)
        {
            string value = "";
            switch (Number % 10)
            {
                case 0:
                    if (Number == 0)
                        value += "nula ";
                    break;
                case 1: value += "jedan "; break;
                case 2: value += "dva "; break;
                case 3: value += "tri "; break;
                case 4: value += "četiri "; break;
                case 5: value += "pet "; break;
                case 6: value += "šest "; break;
                case 7: value += "sedam "; break;
                case 8: value += "osam "; break;
                case 9: value += "devet "; break;
            }
            return value;
        }
        private string PrintNinetyToNinetyNine(int Number)
        {
            string value = "";
            switch (Number % 10)
            {
                case 1:
                    value += "deset "; break;
                case 2:
                    value += "dvadeset "; break;
                case 3:
                    value += "trideset "; break;
                case 4:
                    value += "četdeset "; break;
                case 5:
                    value += "petdeset "; break;
                case 6:
                    value += "šezdeset "; break;
                case 7:
                    value += "sedamdeset "; break;
                case 8:
                    value += "osamdeset "; break;
                case 9:
                    value += "devedeset "; break;
            }
            return value;
        }
        private string PrintOneHundredToNineHundred(int Number)
        {
            string value = "";
            switch (Number % 10)
            {
                case 1:
                    value += "sto "; break;
                case 2:
                    value += "dvesta "; break;
                case 3:
                    value += "trista "; break;
                case 4:
                    value += "četristo "; break;
                case 5:
                    value += "petsto "; break;
                case 6:
                    value += "šesto "; break;
                case 7:
                    value += "sedamsto "; break;
                case 8:
                    value += "osamsto "; break;
                case 9:
                    value += "devetsto "; break;
            }
            return value;
        }
        private string PrintThousandToNineThousand(int Number)
        {
            string value = "";
            switch (Number % 10)
            {
                case 1: value += "hiljadu "; break;
                case 2: value += "dve hiljade  "; break;
                case 3: value += "tri hiljade "; break;
                case 4: value += "četiri hiljade "; break;
                case 5: value += "pet hiljada "; break;
                case 6: value += "šest hiljada "; break;
                case 7: value += "sedam hiljada "; break;
                case 8: value += "osam hiljada "; break;
                case 9: value += "devet hiljada "; break;
            }
            return value;
        }

        private void PrintNumberText()
        {
            string ResultText = "";
            int ResultTemp = Int32.Parse(Result.ToString());
            //0-9
            ResultText+=PrintZeroToNine(ResultTemp);
            ResultTemp /= 10;

            //10-90
            ResultText = PrintNinetyToNinetyNine(ResultTemp % 10) + ResultText;
            ResultTemp /= 10;

            //100-900
            ResultText = PrintOneHundredToNineHundred(ResultTemp % 10) + ResultText;
            ResultTemp /= 10;

            //1 000 - 9 000
            bool ThousandIsZero = false;
            if (ResultTemp % 10 == 0)
                ThousandIsZero = true;
            ResultText = PrintThousandToNineThousand(ResultTemp % 10) + ResultText;
            ResultTemp /= 10;

            //10 000 - 90 000
            if (ResultTemp != 0)
            {
                if (ThousandIsZero)
                {
                    if (ResultTemp % 10!=0)
                        ResultText = "hiljada " + ResultText;
                    ResultText = PrintNinetyToNinetyNine(ResultTemp % 10) + ResultText;
                }  
                else
                    ResultText = PrintNinetyToNinetyNine(ResultTemp % 10) + ResultText;
            }
            ResultTemp /= 10;

            //100 000 - 900 000
            if (ResultTemp != 0)
            {
                if (!ResultText.Contains("hiljada") && ResultTemp % 10!=0)
                    ResultText = "hiljada " + ResultText;
                ResultText = PrintOneHundredToNineHundred(ResultTemp % 10) + ResultText;
            }
            ResultTemp /= 10;


            //1 000 000 - 9 000 000
            bool MilionPrint = false;
            if (ResultTemp != 0)
            {
                MilionPrint = true;
                if (PrintZeroToNine(ResultTemp)=="jedan ")
                    ResultText = PrintZeroToNine(ResultTemp) + " milion " + ResultText;
                else
                    ResultText = PrintZeroToNine(ResultTemp) + " miliona " + ResultText;
            }
            ResultTemp /= 10;

            //10 000 000 - 90 000 000
            if (ResultTemp != 0)
            {
                if (!MilionPrint && ResultTemp % 10!=0)
                {
                    MilionPrint = true;
                    ResultText = PrintNinetyToNinetyNine(ResultTemp % 10) + " miliona " + ResultText;
                }
                else
                    ResultText = PrintNinetyToNinetyNine(ResultTemp % 10) + ResultText;
            }
            ResultTemp /= 10;

            //100 000 000 - 900 000 000
            if (ResultTemp != 0)
            {
                if (!MilionPrint && ResultTemp % 10 != 0)
                    ResultText = PrintOneHundredToNineHundred(ResultTemp) + " miliona " + ResultText;
                else
                    ResultText = PrintOneHundredToNineHundred(ResultTemp) + ResultText;
            }
            ResultTemp /= 10;



            if (ResultTemp > 0)
            {
                ResultText = "... " + ResultText;
            }

            LabelRezultat.Text = "";
            LabelRezultat.Text = ResultText;
        }

        //JEDNAKO
        //JEDNAKO
        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                kliknuta_operacija = false;
                unesiJednomZazarez = true;
                if (!daLiJeJednako)
                    SecondNumber = Convert.ToDouble(textBox1.Text);
                daLiJeJednako = true;
                Izvrsioperaciju();

                PrintNumberText();
            }
            catch
            {
                SecondNumber = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SecondNumber = 0;
            firstNumber = 0;
            textBox1.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //daLiJeJednako = false;
            //firstNumber = Convert.ToDouble(textBox1.Text);
            //textBox1.Text = " ";
            //Operation = "%";
            textBox1.Text = (firstNumber * double.Parse(textBox1.Text) / 100).ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            kliknuta_operacija = false;
            daLiJeJednako = false;
            unesiJednom = false;
            textBox1.Text = "0";
            Operation = "";
            firstNumber = 0;
            SecondNumber = 0;
            LabelRezultat.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //textBox1.Clear();
            textBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                string str = textBox1.Text;
                int n = str.Length;
                textBox1.Text = (str.Substring(0, n - 1));
            }
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = "0";

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = (-1.0 * double.Parse(textBox1.Text)).ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text.StartsWith("-"))
            //{
            //    //It's negative now, so strip the `-` sign to make it positive
            //    textBox1.Text = textBox1.Text.Substring(1);
            //}
            if (!string.IsNullOrEmpty(textBox1.Text) && decimal.Parse(textBox1.Text) != 0)
            {
                //It's positive now, so prefix the value with the `-` sign to make it negative
                double staGod = 1 / Convert.ToDouble(textBox1.Text);
                textBox1.Text = staGod.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Sqrt(double.Parse(textBox1.Text))).ToString();
            daLiJeJednako = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemoryStore = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = MemoryStore.ToString();
            kliknuta_operacija = false;
            unesiJednom = false;
            daLiJeJednako = true;
            Operation = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MemoryStore = Decimal.Parse(textBox1.Text);
            button4.Enabled = true;
            button5.Enabled = true;
            //if (textBox1.Text == "MS")
            //{
            //    MemoryStore -= EndResult;
            //    MemoryStore = Decimal.Parse(textBox1.Text);
            //    return;
            //}
            kliknuta_operacija = false;
            daLiJeJednako = true;
            Operation = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
             MemoryStore += Math.Abs(Convert.ToDecimal(textBox1.Text));
        }
        private void button5_Click(object sender, EventArgs e)
        {
            MemoryStore -= Convert.ToDecimal(textBox1.Text) * 1;
            kliknuta_operacija = true;
            unesiJednom = true;
        }
        //KeyDOWN
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.D0))
            {
                button25.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.NumPad0))
            {
                button25.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.D1))
            {
                button30.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.NumPad1))
            {
                button30.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.D2))
            {
                button29.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.NumPad2))
            {
                button29.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.D3))
            {
                button28.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.NumPad3))
            {
                button28.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.D4))
            {
                button15.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.NumPad4))
            {
                button15.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.D5))
            {
                button14.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.NumPad5))
            {
                button14.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.D6))
            {
                button13.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.NumPad6))
            {
                button13.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.D7))
            {
                button20.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.NumPad7))
            {
                button20.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.D8))
            {
                button19.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.NumPad8))
            {
                button19.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.D9))
            {
                button18.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.NumPad9))
            {
                button18.PerformClick();
            }

            //operacije
            if (e.KeyCode.Equals(Keys.Add))
            {
                button21.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Subtract))
            {
                button27.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Multiply))
            {
                button11.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Divide))
            {
                button17.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Back))
            {
                button6.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Decimal))
            {
                button23.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Delete))
            {
                button7.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Escape))
            {
                button8.PerformClick();
            }
        }
      //enter
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button22.PerformClick();
            }
        }
    }
}

