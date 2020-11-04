using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class calculator : Form
    {
        private string newLines = string.Concat(Enumerable.Repeat("\r\n", 1));
        private string initialValue = "0";
        private string changedValue = "";
        Dictionary<string, int>  precedence = new Dictionary<string, int>
        {
            {"/", 4},
            {"*", 3},
            {"-", 2},
            {"+", 1}
        };
        
        public calculator()
        {
            InitializeComponent();
            showScreen(initialValue);
        }

        public void showScreen(string value)
        {
            screen.Text = "\r\n" + value;
        }

        private void buttonClick(object sender, EventArgs e)
        {
            string value = (sender as Button).Text;
            processButtonClick(value);
        }

        private void processButtonClick(string value)
        {
            changedValue += value;
            showScreen(changedValue);
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (changedValue.Length > 0)
                changedValue = changedValue.Substring(0, changedValue.Length - 1);
            showScreen(String.IsNullOrEmpty(changedValue) ? "0" : changedValue);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            changedValue = "";
            showScreen(initialValue);
        }

        private string compute(string value)
        {
            double result;
            try
            {
                ArrayList tokens = tokenize(value);
                Queue postfix = postfixTokens(tokens);
                result = parsePostfix(postfix);
            }
            catch(Exception e)
            {
                return "Invalid!";
            }
            
            return result.ToString();
        }

        private ArrayList tokenize(string value)
        {
            string buffer = "";
            ArrayList tokens = new ArrayList();

            foreach (char c in value)
            {
                if (Regex.IsMatch(c.ToString(), @"\+|-|\*|\/"))
                {
                    if(buffer.Length > 0) tokens.Add(buffer);
                    buffer = "";
                    tokens.Add(c.ToString());
                }
                else
                {
                    buffer += c.ToString();
                }
            }
            tokens.Add(buffer);
            buffer = "";
            return tokens;
        }

        private Queue postfixTokens(ArrayList tokens)
        {
            Queue myQueue = new Queue();
            Stack myStack = new Stack();
            foreach (var token in tokens)
            {
                if (Regex.IsMatch((string)token, @"\+|-|\*|\/"))
                {
                    if(myStack.Count > 0)
                    {
                        if (precedence[(string)myStack.Peek()] > precedence[(string)token])
                        {
                            myQueue.Enqueue(myStack.Pop());
                        }
                        myStack.Push(token);
                    }
                    else
                    {
                        myStack.Push(token);
                    }
                }
                else
                {
                    myQueue.Enqueue(token);
                }

            }

            while(myStack.Count > 0)
            {
                myQueue.Enqueue(myStack.Pop());
            }

            return myQueue;
        }

        private double parsePostfix(Queue postfix)
        {
            Stack stack = new Stack();

            foreach(string value in postfix)
            {
                if(Regex.IsMatch(value, @"\+|-|\*|\/"))
                {
                    double rightOperand = (double)stack.Pop();
                    double leftOperand = (double)stack.Pop();

                    switch (value)
                    {
                        case "+":
                            stack.Push((leftOperand + rightOperand));
                            continue;
                        case "-":
                            stack.Push((leftOperand - rightOperand));
                            continue;
                        case "*":
                            stack.Push((leftOperand * rightOperand));
                            continue;
                        case "/":
                            stack.Push((leftOperand / rightOperand));
                            continue;
                    }

                }
                else
                {
                    stack.Push(Convert.ToDouble(value));
                }
            }

            return (double)stack.Pop();
        }

        private void equalTo_Click(object sender, EventArgs e)
        {
            string result = compute(changedValue);
            showScreen(result);
            changedValue = "";
        }
    }
}
