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
    public partial class FormMain : Form
    {
        private struct ButtonStruct
        {
            public char Content;
            public bool IsBold;
            public bool IsNumber;
            public bool IsDecimalSeparator;
            public bool IsPlusMinusSign;
            public bool IsOperator;
            public bool IsEqualSign;
            public ButtonStruct(char content, bool isBold, bool isNumber = true, bool isDecimalSeparator = false, bool isPlusMinusSign=false, bool isOperator=false,bool isEqualSign=false)
            {
                this.Content = content;
                this.IsBold= isBold;
                this.IsNumber = isNumber;
                this.IsDecimalSeparator = isDecimalSeparator;
                this.IsPlusMinusSign = isPlusMinusSign;
                this.IsOperator = isOperator;
                this.IsEqualSign = isEqualSign;
            }
            public override string ToString()
            {
                return Content.ToString();
            }
        }
        //private char[,] buttons = new char[6,4];
        private ButtonStruct[,] buttons = 
        {
            {new ButtonStruct(' ',false), new ButtonStruct(' ',false), new ButtonStruct('C',false), new ButtonStruct('<',false) },
            {new ButtonStruct(' ',false), new ButtonStruct(' ',false), new ButtonStruct(' ',false), new ButtonStruct('/',false,false,false,false,true) },
            {new ButtonStruct('7',true,true), new ButtonStruct('8',true,true), new ButtonStruct('9',true,true), new ButtonStruct('x',false,false,false,false,true) },
            {new ButtonStruct('4',true,true), new ButtonStruct('5',true,true), new ButtonStruct('6',true,true), new ButtonStruct('-',false,false,false,false,true) },
            {new ButtonStruct('1',true,true), new ButtonStruct('2',true,true), new ButtonStruct('3',true,true), new ButtonStruct('+',false,false,false,false,true) },
            {new ButtonStruct('±',false,false,false,true), new ButtonStruct('0',true,true), new ButtonStruct(',',false,false,true), new ButtonStruct('=',false,false,false,false,true,true) },
        };
        private RichTextBox resultBox;
        private const char ASCIIZERO = '\x0000';
        private double operand1, operand2, result;
        private char lastOperator;
        private ButtonStruct lastButtonClicked;
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load_1(object sender, EventArgs e)
        {
            makeResultBox();
            makeButtons(buttons);
        }
        private void makeResultBox()
        {
            resultBox = new RichTextBox();
            resultBox.ReadOnly = true;
            resultBox.SelectionAlignment = HorizontalAlignment.Right;
            resultBox.Font = new Font("Segoe UI", 22);
            resultBox.Width = this.Width-16;
            resultBox.Height = 50;
            resultBox.Top = 20;
            resultBox.Text = "0";
            resultBox.TabStop = false;
            resultBox.TextChanged += resultBox_TextChanged;
            this.Controls.Add(resultBox);
        }
        private void resultBox_TextChanged(object sender, EventArgs e)
        {
            int minSize = 22 - (15 - resultBox.Text.Length);
            if ((minSize > 8) && (minSize < 23))
            {
                int delta = 15 - resultBox.Text.Length;
                resultBox.Font = new Font("Segoe UI", 22 + delta);
            }
            else
            {
                resultBox.Font = new Font("Segoe UI", 22);
            }
        }
        private void makeButtons(ButtonStruct[,] buttons)
        {
            int buttonWidth = 82;
            int buttonHeight = 60;
            int posX = 0;
            int posY =101;
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    Button newButton = new Button();
                    newButton.Font = new Font("Segoe UI", 15);
                    //newButton.Text = buttons[i, j].ToString();  
                    ButtonStruct bs = buttons[i, j];
                    newButton.Text = bs.ToString();
                    if(bs.IsBold)
                    {
                        newButton.Font = new Font(newButton.Font,FontStyle.Bold);
                    }
                    newButton.Width = buttonWidth;
                    newButton.Height = buttonHeight;
                    newButton.Left = posX;
                    newButton.Top = posY;
                    newButton.Tag = bs;
                    newButton.Click += Button_Click;
                    this.Controls.Add(newButton);
                    posX += buttonWidth;
                }
                posX = 0;
                posY += buttonHeight;
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            ButtonStruct bs = (ButtonStruct)clickedButton.Tag;
            if (bs.IsNumber)
            {
                if (lastButtonClicked.IsEqualSign)
                {
                    clearAll();
                }
                if (resultBox.Text=="0" || lastButtonClicked.IsOperator)
                {
                    resultBox.Text = "";
                }
                resultBox.Text += clickedButton.Text;
            }
            else
            {
                if (bs.IsDecimalSeparator)
                {
                    if (!resultBox.Text.Contains(bs.Content))
                    {
                        resultBox.Text += clickedButton.Text;
                    }
                }
                if (bs.IsPlusMinusSign)
                {
                    if (!resultBox.Text.Contains("-"))
                    {
                        resultBox.Text = "-"+ resultBox.Text;
                    }
                    else
                    {
                        resultBox.Text = resultBox.Text.Replace("-","");
                    }
                }
                else
                {
                    switch (bs.Content)
                    {
                        case 'C':
                            clearAll();
                            break;
                        case '<':
                            resultBox.Text = resultBox.Text.Remove(resultBox.Text.Length - 1);
                            if (resultBox.Text.Length == 0 || resultBox.Text == "-0" || resultBox.Text == "-")
                            {
                                resultBox.Text = "0";
                            }
                            break;
                        default:
                            if (bs.IsOperator) manageOperators(bs);
                            break;
                    }
                }
            }
            lastButtonClicked = bs;
        }
        private void clearAll(double numberTowrite=0)
        {
            operand1 = 0;
            operand2 = 0;
            result = 0;
            lastOperator = ASCIIZERO;
            resultBox.Text = numberTowrite.ToString();
        }
        private void manageOperators(ButtonStruct bs)
        {
            if (lastOperator == ASCIIZERO)
            {
                operand1 = double.Parse(resultBox.Text);
                lastOperator = bs.Content;
            }
            else
            {
                if (lastButtonClicked.IsOperator && !lastButtonClicked.IsEqualSign)
                {
                    lastOperator = bs.Content;
                }
                else
                {
                    if(!lastButtonClicked.IsEqualSign) 
                        operand2 = double.Parse(resultBox.Text);
                    switch (lastOperator)
                    {
                        case '+':
                            result = operand1 + operand2;
                            break;
                        case '-':
                            result = operand1 - operand2;
                            break;
                        case 'x':
                            result = operand1 * operand2;
                            break;
                        case '/':
                            result = operand1 / operand2;
                            break;
                        default:                           
                            break;
                    }
                    operand1 = result;
                    if (!bs.IsEqualSign)
                    {
                        lastOperator = bs.Content;
                        operand2 = 0;
                    }              
                    resultBox.Text = result.ToString();
                }               
            }
        }
    }
}