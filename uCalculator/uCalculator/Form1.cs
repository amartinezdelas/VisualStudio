using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uCalculator
{
    public partial class uCalculator : Form
    {
        public uCalculator()
        {
            InitializeComponent();
            this.mainDisplay.Text = "0";
        }

        private double firstNumber;
        private double secNumber;
        private string opSwitch;

        /*
        private void mainDisplay_TextChanged(object sender, EventArgs e)
        {//campo de texto
            if(!this.isNumber(mainDisplay.Text))//TODO borrar el ultimo caracter si no es num
            {
                this.eraseLast();
            }
        }

        private bool isNumber(object e)//Comprueba si se ha introducido texto en el display
            //si el contenido es un número, retorna true
        {
            bool isNum;
            double retNum;

            isNum = Double.TryParse(Convert.ToString(e),
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);

            return isNum;
        }
        */

        private void button10_Click(object sender, EventArgs e)
        {
            this.eraseZero();
            this.mainDisplay.Text = this.mainDisplay.Text + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.eraseZero();
            this.mainDisplay.Text = this.mainDisplay.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.eraseZero();
            this.mainDisplay.Text = this.mainDisplay.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.eraseZero();
            this.mainDisplay.Text = this.mainDisplay.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.eraseZero();
            this.mainDisplay.Text = this.mainDisplay.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.eraseZero();
            this.mainDisplay.Text = this.mainDisplay.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.eraseZero();
            this.mainDisplay.Text = this.mainDisplay.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.eraseZero();
            this.mainDisplay.Text = this.mainDisplay.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.eraseZero();
            this.mainDisplay.Text = this.mainDisplay.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.eraseZero();
            this.mainDisplay.Text = this.mainDisplay.Text + "9";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if(!mainDisplay.Text.Contains(','))
            {
                this.mainDisplay.Text = this.mainDisplay.Text + ",";
            }
        }

        private void eraseZero() //private method that erase the first zero
        {
            if(this.mainDisplay.Text=="0")
            {
                this.mainDisplay.Text = "";
            }
        }

        private void operationDone()
        {
            this.labelFirstNumber.Text = Convert.ToString(this.firstNumber+" "+this.opSwitch+" "+this.secNumber);
            this.labelOp.Text = "";
        }

        private void operate()
        {
            switch (this.opSwitch)
            {
                case null:
                    //TODO un mensaje o algo
                    break;

                case "+":
                    this.mainDisplay.Text = Convert.ToString(this.firstNumber + this.secNumber);
                    break;

                case "-":
                    this.mainDisplay.Text = Convert.ToString(this.firstNumber - this.secNumber);
                    break;

                case "*":
                    this.mainDisplay.Text = Convert.ToString(this.firstNumber * this.secNumber);
                    break;

                case "/":
                    if (this.firstNumber == 0)
                    {
                        this.mainDisplay.Text = "0";
                    }
                    else
                    {
                        this.mainDisplay.Text = Convert.ToString(this.firstNumber / this.secNumber);
                    }
                    break;
            }
        }

        //guarda el número en pantalla en variable firstNumber, asigna operacion y limpia la pantalla
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.firstNumber = Convert.ToDouble(this.mainDisplay.Text);//pendiente de que si existe, no
            this.labelFirstNumber.Text = this.mainDisplay.Text;
            this.opSwitch = "+";
            this.labelOp.Text = "+";
            this.mainDisplay.Text = "0";
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            this.firstNumber = Convert.ToDouble(this.mainDisplay.Text);//pendiente de que si existe, no
            this.labelFirstNumber.Text = this.mainDisplay.Text;
            this.opSwitch = "-";
            this.labelOp.Text = "-";
            this.mainDisplay.Text = "0";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            this.firstNumber = Convert.ToDouble(this.mainDisplay.Text);//pendiente de que si existe, no
            this.labelFirstNumber.Text = this.mainDisplay.Text;
            this.opSwitch = "*";
            this.labelOp.Text = "*";
            this.mainDisplay.Text = "0";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            this.firstNumber = Convert.ToDouble(this.mainDisplay.Text);//pendiente de que si existe, no
            this.labelFirstNumber.Text = this.mainDisplay.Text;
            this.opSwitch = "/";
            this.labelOp.Text = "/";
            this.mainDisplay.Text = "0";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            this.secNumber = Convert.ToDouble(this.mainDisplay.Text);
            this.operate();
            this.operationDone();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.mainDisplay.Text = "0";
            this.opSwitch = null;
            this.labelFirstNumber.Text = "";
            this.labelOp.Text = "";
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            this.firstNumber = Convert.ToDouble(this.mainDisplay.Text);
            this.mainDisplay.Text = Convert.ToString(this.firstNumber * this.firstNumber);
        }

        private void buttonInverter_Click(object sender, EventArgs e)
        {
            this.firstNumber = Convert.ToDouble(this.mainDisplay.Text);
            this.mainDisplay.Text = Convert.ToString(1 / this.firstNumber);
        }

        private void buttonDel_Click(object sender, EventArgs e)//borra el último caracter escrito
        {
            this.eraseLast();
        }

        private void eraseLast()//metodo que borra el último caracter escrito
        {
            if (this.mainDisplay.Text.Length != 0)
            {
                this.mainDisplay.Text = this.mainDisplay.Text.Remove(this.mainDisplay.Text.Length - 1, 1);
            }
            if (this.mainDisplay.Text.Length == 0)
            {
                this.mainDisplay.Text = "0";
            }
        }

        private void buttonSqt_Click(object sender, EventArgs e) // square root button
        {
            this.firstNumber = Convert.ToDouble(this.mainDisplay.Text);
            if(this.firstNumber>=0)
            {
                this.mainDisplay.Text = Convert.ToString(Math.Sqrt(this.firstNumber));
            } 
            else
            {
                this.mainDisplay.Text = "0";
            }
        }

        private void buttonSign_Click(object sender, EventArgs e) // +/- button
        {
            this.mainDisplay.Text = Convert.ToString(Convert.ToDouble(this.mainDisplay.Text) * (-1));
        }

        private void buttonClearE_Click(object sender, EventArgs e) // CE button
        {
            this.mainDisplay.Text = "0";
        }

        private void buttonPercent_Click(object sender, EventArgs e)//TODO
        {

        }
    }
}
