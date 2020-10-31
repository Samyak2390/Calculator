namespace Calculator
{
    partial class calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.screen = new System.Windows.Forms.TextBox();
            this.multiply = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.equalTo = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.Enabled = false;
            this.screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screen.Location = new System.Drawing.Point(0, 1);
            this.screen.Multiline = true;
            this.screen.Name = "screen";
            this.screen.ReadOnly = true;
            this.screen.Size = new System.Drawing.Size(367, 123);
            this.screen.TabIndex = 0;
            this.screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.screen.WordWrap = false;
            // 
            // multiply
            // 
            this.multiply.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(276, 188);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(90, 58);
            this.multiply.TabIndex = 4;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.buttonClick);
            // 
            // nine
            // 
            this.nine.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(185, 188);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(90, 58);
            this.nine.TabIndex = 5;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.buttonClick);
            // 
            // seven
            // 
            this.seven.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(1, 188);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(90, 58);
            this.seven.TabIndex = 6;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.buttonClick);
            // 
            // eight
            // 
            this.eight.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(93, 188);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(90, 58);
            this.eight.TabIndex = 7;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.buttonClick);
            // 
            // clear
            // 
            this.clear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(1, 127);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(182, 58);
            this.clear.TabIndex = 8;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // five
            // 
            this.five.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(93, 248);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(90, 58);
            this.five.TabIndex = 12;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.buttonClick);
            // 
            // four
            // 
            this.four.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(1, 248);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(90, 58);
            this.four.TabIndex = 11;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.buttonClick);
            // 
            // six
            // 
            this.six.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(185, 248);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(90, 58);
            this.six.TabIndex = 10;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.buttonClick);
            // 
            // minus
            // 
            this.minus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(276, 248);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(90, 58);
            this.minus.TabIndex = 9;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.buttonClick);
            // 
            // two
            // 
            this.two.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(93, 308);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(90, 58);
            this.two.TabIndex = 16;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.buttonClick);
            // 
            // one
            // 
            this.one.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(1, 308);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(90, 58);
            this.one.TabIndex = 15;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.buttonClick);
            // 
            // three
            // 
            this.three.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(185, 308);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(90, 58);
            this.three.TabIndex = 14;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.buttonClick);
            // 
            // plus
            // 
            this.plus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(276, 308);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(90, 58);
            this.plus.TabIndex = 13;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.buttonClick);
            // 
            // point
            // 
            this.point.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.point.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.Location = new System.Drawing.Point(93, 368);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(90, 58);
            this.point.TabIndex = 20;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.buttonClick);
            // 
            // zero
            // 
            this.zero.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(1, 368);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(90, 58);
            this.zero.TabIndex = 19;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.buttonClick);
            // 
            // divide
            // 
            this.divide.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(185, 368);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(90, 58);
            this.divide.TabIndex = 18;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.buttonClick);
            // 
            // equalTo
            // 
            this.equalTo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.equalTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalTo.Location = new System.Drawing.Point(276, 368);
            this.equalTo.Name = "equalTo";
            this.equalTo.Size = new System.Drawing.Size(90, 58);
            this.equalTo.TabIndex = 17;
            this.equalTo.Text = "=";
            this.equalTo.UseVisualStyleBackColor = true;
            // 
            // backspace
            // 
            this.backspace.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspace.Location = new System.Drawing.Point(184, 127);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(182, 58);
            this.backspace.TabIndex = 21;
            this.backspace.Text = "←";
            this.backspace.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 430);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.point);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.equalTo);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.three);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.six);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.screen);
            this.Name = "calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox screen;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button equalTo;
        private System.Windows.Forms.Button backspace;
    }
}

