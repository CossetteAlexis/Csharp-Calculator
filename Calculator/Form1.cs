using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string TypeForm;
        Addition1 Add = new Addition1();
        Subtraction1 Sub = new Subtraction1();
        Multiply1 Mult = new Multiply1();
        Division1 Div = new Division1();
        Memory1 Mem = new Memory1();
        Misc Mis = new Misc();

        public Form1()
        {
            InitializeComponent();
        }

        private void B_Plus_Click(object sender, EventArgs e)
        {
            
            Add.setm_Adden1(int.Parse(TB_PresentBox.Text));
            TB_PresentBox.Text = "";
            TypeForm = "Add";
            TB_AfterBox.Text = Add.getm_Adden1().ToString();
        }

        private void B_Minus_Click(object sender, EventArgs e)
        {
            Sub.setm_Subtrahen1(int.Parse(TB_PresentBox.Text));
            TB_PresentBox.Text = "";
            TypeForm = "Minus";
            TB_AfterBox.Text = Sub.getm_Subtrahen1().ToString();
        }

        private void B_Mult_Click(object sender, EventArgs e)
        {
            Mult.setm_Multiplier1(int.Parse(TB_PresentBox.Text));
            TB_PresentBox.Text = "";
            TypeForm = "Mult";
            TB_AfterBox.Text = Mult.getm_Multiplier1().ToString();
        }

        private void B_Div_Click(object sender, EventArgs e)
        {
            Div.setm_Divisor1(int.Parse(TB_PresentBox.Text));
            TB_PresentBox.Text = "";
            TypeForm = "Div";
            TB_AfterBox.Text = Div.getm_Divisor1().ToString();
        }

        private void B_Equal_Click(object sender, EventArgs e)
        {
            switch (TypeForm)
            {
                case "Add":
                    {
                        Add.setm_Adden2(int.Parse(TB_PresentBox.Text));
                        TB_PresentBox.Text = Add.AddNow().ToString();
                        TB_AfterBox.Text = "";
                        break;
                    }
                case "Minus":
                    {
                        Sub.setm_Subtrahen2(int.Parse(TB_PresentBox.Text));
                        TB_PresentBox.Text = Sub.MinusNow().ToString();
                        TB_AfterBox.Text = "";
                        break;
                    }
                case "Mult":
                    {
                        Mult.setm_Multiplier2(int.Parse(TB_PresentBox.Text));
                        TB_PresentBox.Text = Mult.MultNow().ToString();
                        TB_AfterBox.Text = "";
                        break;
                    }
                case "Div":
                    {
                        Div.setm_Divisor2(int.Parse(TB_PresentBox.Text));
                        TB_PresentBox.Text = Div.DivNow().ToString();
                        TB_AfterBox.Text = "";
                        break;
                    }
                default:
                    break;
            }
        }

        private void B_MemClear_Click(object sender, EventArgs e)
        {
            Mem.MemoryClear();
        }


        private void B_MemRecall_Click(object sender, EventArgs e)
        {
            TB_PresentBox.Text = Mem.getm_Memory().ToString();
        }

        private void B_MemSave_Click(object sender, EventArgs e)
        {
            Mem.setm_Memory(int.Parse(TB_PresentBox.Text));
        }

        private void B_MemAdd_Click(object sender, EventArgs e)
        {
            Mem.setm_Addens(int.Parse(TB_PresentBox.Text));
            Mem.MemoryAdd();
        }

        private void B_MemMinus_Click(object sender, EventArgs e)
        {
            Mem.setm_Subtrahem(int.Parse(TB_PresentBox.Text));
            Mem.MemoryMinus();
        }



        private void B_1_Click(object sender, EventArgs e)
        {
            TB_PresentBox.Text = TB_PresentBox.Text + "1";
        }

        private void B_2_Click(object sender, EventArgs e)
        {
            TB_PresentBox.Text = TB_PresentBox.Text + "2";
        }

        private void B_3_Click(object sender, EventArgs e)
        {
            TB_PresentBox.Text = TB_PresentBox.Text + "3";
        }

        private void B_4_Click(object sender, EventArgs e)
        {
            TB_PresentBox.Text = TB_PresentBox.Text + "4";
        }

        private void B_5_Click(object sender, EventArgs e)
        {
            TB_PresentBox.Text = TB_PresentBox.Text + "5";
        }

        private void B_6_Click(object sender, EventArgs e)
        {
            TB_PresentBox.Text = TB_PresentBox.Text + "6";
        }

        private void B_7_Click(object sender, EventArgs e)
        {
            TB_PresentBox.Text = TB_PresentBox.Text + "7";
        }

        private void B_8_Click(object sender, EventArgs e)
        {
            TB_PresentBox.Text = TB_PresentBox.Text + "8";
        }

        private void B_9_Click(object sender, EventArgs e)
        {
            TB_PresentBox.Text = TB_PresentBox.Text + "9";
        }

        private void B_zero_Click(object sender, EventArgs e)
        {
            TB_PresentBox.Text = TB_PresentBox.Text + "0";
        }


        private void B_Clear_Click(object sender, EventArgs e)
        {
            TB_PresentBox.Text = "0";
            TB_AfterBox.Text = "";
            TypeForm = "None";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (int.Parse(TB_PresentBox.Text) < 0)
            {
                TB_PresentBox.Text = ((int.Parse(TB_PresentBox.Text) - int.Parse(TB_PresentBox.Text)) - (int.Parse(TB_PresentBox.Text))).ToString();
            }

            else
            {
                TB_PresentBox.Text = "-" + TB_PresentBox.Text;
            }

        }

        private void B_Sqrt_Click(object sender, EventArgs e)
        {
            int SquareToRoot = int.Parse(TB_PresentBox.Text);
            TB_PresentBox.Text = Math.Sqrt((double)SquareToRoot).ToString();
            TB_AfterBox.Text = "Sqrt of : " + SquareToRoot.ToString();
        }

        private void B_Reciprocal_Click(object sender, EventArgs e)
        {

        }

        private void B_Reciprocal_Click_1(object sender, EventArgs e)
        {

        }

        private void B_Reciprocal_Click_2(object sender, EventArgs e)
        {
            int NumberToReciprocal = int.Parse(TB_PresentBox.Text);
            double Result = 1 / (double)NumberToReciprocal; 
            TB_PresentBox.Text = Result.ToString();
            TB_AfterBox.Text = "Reciprocal of : " + NumberToReciprocal.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Mis.setm_BaseNumber(int.Parse(TB_AfterBox.Text));
            Mis.setm_Percentage(int.Parse(TB_PresentBox.Text));
            TB_PresentBox.Text = Mis.SolvePercentNow().ToString();
        }

        private void B_Space_Click(object sender, EventArgs e)
        {

        }



















    }
}
