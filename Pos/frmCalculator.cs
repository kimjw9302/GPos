using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{
    public partial class frmCalculator : Form
    {

        private static frmCalculator fc = null;

        private string buffer;
        private  frmCalculator()
        {
            fc = this;
            InitializeComponent();           
        }
        static public frmCalculator Instance()
        {
            if (fc == null||fc.IsDisposed)
            {
                fc = new frmCalculator();
            }
            return fc;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
   
        private void btnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string type = btn.Text;
            tboxScreen.Text += type;
            buffer += type;

        }

       
        private double MakeExpression(ref string str)
        {
            int index = 0;
            double value = Senetence(ref str,ref index);
            while (index < str.Length)
            {
                switch (str[index])
                {
                    case '+':
                        ++(index);
                        value += Senetence(ref str,ref index);
                        break;
                    case '-':
                        ++(index);
                        value += Senetence(ref str, ref index);
                        break;
                    default:

                            break;
                }
            }
            return value;
        }

        private double Senetence(ref string str, ref int index)
        {
            double value = GetNumber(ref str, ref index);
            while (index < str.Length)
            {
                if (str[index] == '*')
                {
                    ++(index);
                    value *= GetNumber(ref str, ref index);
                }
                else if (str[index] == '/')
                {
                    ++(index);
                    value /= GetNumber(ref str, ref index);
                }
                else break;
            }
            return value;
        }

        private double GetNumber(ref string str, ref int index)
        {
            double value = 0.0;
            if (str[index] == '(')
            {
                ++(index);
                string substr = GetSubstring(ref str, ref index);
                return MakeExpression(ref substr);
            }
            while ((index < str.Length) && Char.IsDigit(str, index))
            {
                value = 10.0 * value + Char.GetNumericValue(str[index]);
                ++(index);
            }
            if ((index == str.Length) || str[index] != '.') return value;
            double factor = 1.0;
            ++index;
            while ((index < str.Length) && Char.IsDigit(str, index))
            {
                factor *= 0.1;
                value = value + Char.GetNumericValue(str[index]) * factor;
                ++index;
            }
            return value;
        }

        private string GetSubstring(ref string str, ref int index)
        {
            string substr = "";
            int numL = 0;
            int bufindex = index;
            while (index < str.Length)
            {
                switch (str[index])
                {
                    case ')':
                        if (numL == 0)
                        {
                            char[] substrChars = new char[index - bufindex];
                            str.CopyTo(bufindex, substrChars, 0, substrChars.Length);
                            substr = new string(substrChars);
                            ++index;
                            return substr;
                        }
                        else numL--;
                        break;
                    case '(':
                        numL++;
                        break;
                }
                ++index;
            }
            MessageBox.Show("잘못된구문");
            return substr;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            buffer = "";
            lblScreen.Text = "";
            tboxScreen.Text = "";
        }

        private void btnOper(object sender, EventArgs e)
        {          
                Button btn = (Button)sender;
                string type = btn.Text;
                tboxScreen.Text += type;
                buffer += type;
                lblScreen.Text = buffer;
  
        }

        private void btnEnter_Click_1(object sender, EventArgs e)
        {

            try
            {
                lblScreen.Text = buffer;
                string temp = lblScreen.Text.Replace(" ", "");
                this.lblScreen.Text += "=\r\n" + MakeExpression(ref temp).ToString();
                tboxScreen.Text = "";
                buffer = "";
            }
            catch (Exception)
            {
                buffer = "";
                lblScreen.Text = "";
                tboxScreen.Text = "";
                MessageBox.Show("계산 오류");
            }
        }
    }
}
