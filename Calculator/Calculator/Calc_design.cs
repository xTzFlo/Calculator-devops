using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calc_design : Form
    {
        float op1 = 0;
        float op2 = 0;
        bool signFlag = false;
        string operation;
        float result;

        public Calc_design()
        {
            InitializeComponent();
            // dessine les bords de l'écran
            this.Paint += new PaintEventHandler(Form1_Paint);
            // Ajout des key events
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(Form1_KeyPress);
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 42 && e.KeyChar <= 57) || e.KeyChar == 8 || e.KeyChar == 27)
            {
                switch(e.KeyChar)
                {
                    case (char)8: 
                        del.PerformClick(); break;
                    case (char)27: 
                        clr.PerformClick(); break;
                    case (char)42: 
                        mult.PerformClick(); break;
                    case (char)43: 
                        add.PerformClick(); break;
                    case (char)45: 
                        sub.PerformClick(); break;
                    case (char)46: 
                        virgule.PerformClick(); break;
                    case (char)47: 
                        div.PerformClick(); break;
                    case (char)48: 
                        zero.PerformClick();  break;
                    case (char)49: 
                        un.PerformClick();  break;
                    case (char)50: 
                        deux.PerformClick(); break;
                    case (char)51: 
                        trois.PerformClick(); break;
                    case (char)52: 
                        quatre.PerformClick(); break;
                    case (char)53: 
                        cinq.PerformClick(); break;
                    case (char)54: 
                        six.PerformClick(); break;
                    case (char)55: 
                        sept.PerformClick(); break;
                    case (char)56: 
                        huit.PerformClick(); break;
                    case (char)57: 
                        neuf.PerformClick(); break;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                egal.PerformClick();
            } else if (e.KeyCode == Keys.Delete)
            {
                del.PerformClick();
            }
        }        

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g;
            g = this.CreateGraphics();                                                                                  // Création d'un graphique
            Pen p = new Pen(Color.LightGray, 3);                                                                        // Couleurs des bordures
            Rectangle r = new Rectangle(displayTop.Location.X, displayTop.Location.Y, displayTop.Width-1, 53);          // Position des écrans
            g.DrawRectangle(p, r);                                                                                      // Dessiner le tout
        }

        private void checkDisplay()
        {
            if (signFlag == true)
            {
                displayBottom.Text = "";
                signFlag = false;
            }
            if (displayBottom.Text == "0")
                displayBottom.Text = "";
            
        }        

        private void un_Click(object sender, EventArgs e)
        {
            checkDisplay();
            if (displayBottom.Text.Length > 14)
                System.Media.SystemSounds.Exclamation.Play();
            else
                displayBottom.Text += "1";
        }

        private void deux_Click(object sender, EventArgs e)
        {
            checkDisplay();
            if (displayBottom.Text.Length > 14)
                System.Media.SystemSounds.Exclamation.Play();
            else
                displayBottom.Text += "2";
        }

        private void trois_Click(object sender, EventArgs e)
        {
            checkDisplay();
            if (displayBottom.Text.Length > 14)
                System.Media.SystemSounds.Exclamation.Play();
            else
                displayBottom.Text += "3";
        }

        private void quatre_Click(object sender, EventArgs e)
        {
            checkDisplay();
            if (displayBottom.Text.Length > 14)
                System.Media.SystemSounds.Exclamation.Play();
            else
                displayBottom.Text += "4";
        }

        private void cinq_Click(object sender, EventArgs e)
        {
            checkDisplay();
            if (displayBottom.Text.Length > 14)
                System.Media.SystemSounds.Exclamation.Play();
            else
                displayBottom.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            checkDisplay();
            if (displayBottom.Text.Length > 14)
                System.Media.SystemSounds.Exclamation.Play();
            else
                displayBottom.Text += "6";
        }

        private void sept_Click(object sender, EventArgs e)
        {
            checkDisplay();
            if (displayBottom.Text.Length > 14)
                System.Media.SystemSounds.Exclamation.Play();
            else
                displayBottom.Text += "7";
        }

        private void huit_Click(object sender, EventArgs e)
        {
            checkDisplay();
            if (displayBottom.Text.Length > 14)
                System.Media.SystemSounds.Exclamation.Play();
            else
                displayBottom.Text += "8";
        }

        private void neuf_Click(object sender, EventArgs e)
        {
            checkDisplay();
            if (displayBottom.Text.Length > 14)
                System.Media.SystemSounds.Exclamation.Play();
            else
                displayBottom.Text += "9";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            checkDisplay();
            if (displayBottom.Text.Length > 14)
                System.Media.SystemSounds.Exclamation.Play();
            else
                displayBottom.Text += "0";
        }

        private void virgule_Click(object sender, EventArgs e)
        {
            if (displayBottom.Text.Length > 14 || displayBottom.Text.Contains(","))
                System.Media.SystemSounds.Exclamation.Play();
            else
            {
                if (displayBottom.Text == "" || displayBottom.Text == null)
                    displayBottom.Text += "0,";
                else
                    displayBottom.Text += ",";
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (displayBottom.Text.Length > 0)
                displayBottom.Text = displayBottom.Text.Substring(0,displayBottom.Text.Length-1);
        }

        private void displayHistory(string sign)
        {
            displayTop.Text += " " + displayBottom.Text + " " + sign;
        }        

        private void changeSign(string sign)
        {
            string display = displayTop.Text;
            if (display == null || display == "")
                displayHistory(sign);
            else
                displayTop.Text = display.Substring(0, display.Length-1) + sign;
        }

        private void calculate()
        {            
            if (operation == "+")
            {
                op2 = float.Parse(displayBottom.Text);
                result = op1 + op2;                
                displayBottom.Text = result.ToString();
                op1 = result;

            }
            else if (operation == "-")
            {
                op2 = float.Parse(displayBottom.Text);
                result = op1 - op2;
                displayBottom.Text = result.ToString();
                op1 = result;
            }
            else if (operation == "/")
            {
                op2 = float.Parse(displayBottom.Text);
                if (op2 == 0)
                {
                    System.Media.SystemSounds.Exclamation.Play();
                    displayBottom.Text = "Impossible to divide by 0 !";
                }
                else
                {
                    result = op1 / op2;
                    displayBottom.Text = result.ToString();
                    op1 = result;
                }
            }
            else if (operation == "*")
            {
                op2 = float.Parse(displayBottom.Text);
                result = op1 * op2;
                displayBottom.Text = result.ToString();
                op1 = result;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (signFlag == true)
                changeSign("+");
            else
            {
                if (displayTop.Text == "")
                {
                    op1 = float.Parse(displayBottom.Text);
                    displayHistory("+");
                }
                else
                {
                    op2 = float.Parse(displayBottom.Text);
                    displayHistory("+");
                    calculate();
                }
            }
            operation = "+";
            signFlag = true;
        }

        private void sub_Click(object sender, EventArgs e)
        {
            if (signFlag == true)
                changeSign("-");
            else
            {
                if (displayTop.Text == "")
                {
                    op1 = float.Parse(displayBottom.Text);
                    displayHistory("-");
                }
                else
                {
                    op2 = float.Parse(displayBottom.Text);
                    displayHistory("-");
                    calculate();
                }
            }
            operation = "-";
            signFlag = true;
            
        }

        private void div_Click(object sender, EventArgs e)
        {
            if (operation != "/" && signFlag == true)
                changeSign("/");
            else
            {
                if (displayTop.Text == "")
                {
                    op1 = float.Parse(displayBottom.Text);
                    displayHistory("/");
                }
                else
                {
                    op2 = float.Parse(displayBottom.Text);
                    displayHistory("/");
                    calculate();
                }
            }
            operation = "/";           
            signFlag = true;
        }

        private void mult_Click(object sender, EventArgs e)
        {
            if (operation != "*" && signFlag == true)
                changeSign("*");
            else
            {
                if (displayTop.Text == "")
                {
                    op1 = float.Parse(displayBottom.Text);
                    displayHistory("*");
                }
                else
                {
                    op2 = float.Parse(displayBottom.Text);
                    displayHistory("*");
                    calculate();
                }
            }
            operation = "*";
            signFlag = true;
        }

        private void egal_Click(object sender, EventArgs e)
        {
            if (displayTop.Text != "")
            {
                op2 = float.Parse(displayBottom.Text);
                calculate();
            }
            displayTop.Text = "";            
            signFlag = true;   
        }

        private void clr_Click(object sender, EventArgs e)
        {
            displayTop.Text = "";
            displayBottom.Text = "0";
            op1 = 0;
            op2 = 0;
            
        }        
    }
}
