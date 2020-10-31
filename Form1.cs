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
    public partial class calculator : Form
    {
        private string newLines = string.Concat(Enumerable.Repeat("\r\n", 1));
        private string initialValue = "0";
        private string changedValue = "";
        public calculator()
        {
            InitializeComponent();
            showScreen(initialValue);
        }

        public void showScreen(string value)
        {
            screen.Text = newLines + value;
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
    }
}
