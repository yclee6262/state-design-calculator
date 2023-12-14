using CalculatorLibrary.Buttons;

namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.EqualButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.NumberButton2 = new System.Windows.Forms.Button();
            this.ClearEntryButton = new System.Windows.Forms.Button();
            this.NumberButton8 = new System.Windows.Forms.Button();
            this.BackspaceButton = new System.Windows.Forms.Button();
            this.NumberButton0 = new System.Windows.Forms.Button();
            this.NumberButton5 = new System.Windows.Forms.Button();
            this.NumberButton9 = new System.Windows.Forms.Button();
            this.NumberButton6 = new System.Windows.Forms.Button();
            this.NumberButton3 = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.NumberButton7 = new System.Windows.Forms.Button();
            this.NumberButton4 = new System.Windows.Forms.Button();
            this.NumberButton1 = new System.Windows.Forms.Button();
            this.ChangeSignButton = new System.Windows.Forms.Button();
            this.SquareButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.TopLabel = new System.Windows.Forms.Label();
            this.RightButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EqualButton
            // 
            this.EqualButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EqualButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EqualButton.Font = new System.Drawing.Font("Brush Script MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualButton.Location = new System.Drawing.Point(293, 356);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(75, 35);
            this.EqualButton.TabIndex = 0;
            this.EqualButton.Tag = "equal";
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = false;
            this.EqualButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // AddButton
            // 
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Brush Script MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(293, 314);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 36);
            this.AddButton.TabIndex = 1;
            this.AddButton.Tag = "add";
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // MinusButton
            // 
            this.MinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinusButton.Font = new System.Drawing.Font("Brush Script MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusButton.Location = new System.Drawing.Point(293, 272);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(75, 36);
            this.MinusButton.TabIndex = 2;
            this.MinusButton.Tag = "minus";
            this.MinusButton.Text = "–";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MultiplyButton.Font = new System.Drawing.Font("Brush Script MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyButton.Location = new System.Drawing.Point(293, 230);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(75, 36);
            this.MultiplyButton.TabIndex = 3;
            this.MultiplyButton.Tag = "multiply";
            this.MultiplyButton.Text = "×";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // DivideButton
            // 
            this.DivideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DivideButton.Font = new System.Drawing.Font("Brush Script MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivideButton.Location = new System.Drawing.Point(293, 188);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(75, 36);
            this.DivideButton.TabIndex = 4;
            this.DivideButton.Tag = "divide";
            this.DivideButton.Text = "÷";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // NumberButton2
            // 
            this.NumberButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumberButton2.Font = new System.Drawing.Font("Brush Script MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberButton2.Location = new System.Drawing.Point(131, 314);
            this.NumberButton2.Name = "NumberButton2";
            this.NumberButton2.Size = new System.Drawing.Size(75, 36);
            this.NumberButton2.TabIndex = 6;
            this.NumberButton2.Tag = "number";
            this.NumberButton2.Text = "2";
            this.NumberButton2.UseVisualStyleBackColor = true;
            this.NumberButton2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ClearEntryButton
            // 
            this.ClearEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearEntryButton.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearEntryButton.Location = new System.Drawing.Point(131, 187);
            this.ClearEntryButton.Name = "ClearEntryButton";
            this.ClearEntryButton.Size = new System.Drawing.Size(75, 36);
            this.ClearEntryButton.TabIndex = 7;
            this.ClearEntryButton.Tag = "CE";
            this.ClearEntryButton.Text = "CE";
            this.ClearEntryButton.UseVisualStyleBackColor = true;
            this.ClearEntryButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // NumberButton8
            // 
            this.NumberButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumberButton8.Font = new System.Drawing.Font("Brush Script MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberButton8.Location = new System.Drawing.Point(131, 229);
            this.NumberButton8.Name = "NumberButton8";
            this.NumberButton8.Size = new System.Drawing.Size(75, 36);
            this.NumberButton8.TabIndex = 8;
            this.NumberButton8.Tag = "number";
            this.NumberButton8.Text = "8";
            this.NumberButton8.UseVisualStyleBackColor = true;
            this.NumberButton8.Click += new System.EventHandler(this.ButtonClick);
            // 
            // BackspaceButton
            // 
            this.BackspaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackspaceButton.Font = new System.Drawing.Font("Brush Script MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackspaceButton.Location = new System.Drawing.Point(212, 188);
            this.BackspaceButton.Name = "BackspaceButton";
            this.BackspaceButton.Size = new System.Drawing.Size(75, 36);
            this.BackspaceButton.TabIndex = 9;
            this.BackspaceButton.Tag = "backspace";
            this.BackspaceButton.Text = "←";
            this.BackspaceButton.UseVisualStyleBackColor = true;
            this.BackspaceButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // NumberButton0
            // 
            this.NumberButton0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumberButton0.Font = new System.Drawing.Font("Brush Script MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberButton0.Location = new System.Drawing.Point(131, 355);
            this.NumberButton0.Name = "NumberButton0";
            this.NumberButton0.Size = new System.Drawing.Size(75, 36);
            this.NumberButton0.TabIndex = 10;
            this.NumberButton0.Tag = "number";
            this.NumberButton0.Text = "0";
            this.NumberButton0.UseVisualStyleBackColor = true;
            this.NumberButton0.Click += new System.EventHandler(this.ButtonClick);
            // 
            // NumberButton5
            // 
            this.NumberButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumberButton5.Font = new System.Drawing.Font("Brush Script MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberButton5.Location = new System.Drawing.Point(131, 271);
            this.NumberButton5.Name = "NumberButton5";
            this.NumberButton5.Size = new System.Drawing.Size(75, 36);
            this.NumberButton5.TabIndex = 11;
            this.NumberButton5.Tag = "number";
            this.NumberButton5.Text = "5";
            this.NumberButton5.UseVisualStyleBackColor = true;
            this.NumberButton5.Click += new System.EventHandler(this.ButtonClick);
            // 
            // NumberButton9
            // 
            this.NumberButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumberButton9.Font = new System.Drawing.Font("Brush Script MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberButton9.Location = new System.Drawing.Point(212, 230);
            this.NumberButton9.Name = "NumberButton9";
            this.NumberButton9.Size = new System.Drawing.Size(75, 36);
            this.NumberButton9.TabIndex = 12;
            this.NumberButton9.Tag = "number";
            this.NumberButton9.Text = "9";
            this.NumberButton9.UseVisualStyleBackColor = true;
            this.NumberButton9.Click += new System.EventHandler(this.ButtonClick);
            // 
            // NumberButton6
            // 
            this.NumberButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumberButton6.Font = new System.Drawing.Font("Brush Script MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberButton6.Location = new System.Drawing.Point(212, 271);
            this.NumberButton6.Name = "NumberButton6";
            this.NumberButton6.Size = new System.Drawing.Size(75, 36);
            this.NumberButton6.TabIndex = 13;
            this.NumberButton6.Tag = "number";
            this.NumberButton6.Text = "6";
            this.NumberButton6.UseVisualStyleBackColor = true;
            this.NumberButton6.Click += new System.EventHandler(this.ButtonClick);
            // 
            // NumberButton3
            // 
            this.NumberButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumberButton3.Font = new System.Drawing.Font("Brush Script MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberButton3.Location = new System.Drawing.Point(212, 313);
            this.NumberButton3.Name = "NumberButton3";
            this.NumberButton3.Size = new System.Drawing.Size(75, 36);
            this.NumberButton3.TabIndex = 14;
            this.NumberButton3.Tag = "number";
            this.NumberButton3.Text = "3";
            this.NumberButton3.UseVisualStyleBackColor = true;
            this.NumberButton3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // DotButton
            // 
            this.DotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DotButton.Font = new System.Drawing.Font("Brush Script MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DotButton.Location = new System.Drawing.Point(212, 355);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(75, 36);
            this.DotButton.TabIndex = 15;
            this.DotButton.Tag = "dot";
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = true;
            this.DotButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ClearButton
            // 
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(50, 188);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 36);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Tag = "clear";
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // NumberButton7
            // 
            this.NumberButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumberButton7.Font = new System.Drawing.Font("Brush Script MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberButton7.Location = new System.Drawing.Point(50, 229);
            this.NumberButton7.Name = "NumberButton7";
            this.NumberButton7.Size = new System.Drawing.Size(75, 36);
            this.NumberButton7.TabIndex = 17;
            this.NumberButton7.Tag = "number";
            this.NumberButton7.Text = "7";
            this.NumberButton7.UseVisualStyleBackColor = true;
            this.NumberButton7.Click += new System.EventHandler(this.ButtonClick);
            // 
            // NumberButton4
            // 
            this.NumberButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumberButton4.Font = new System.Drawing.Font("Brush Script MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberButton4.Location = new System.Drawing.Point(50, 271);
            this.NumberButton4.Name = "NumberButton4";
            this.NumberButton4.Size = new System.Drawing.Size(75, 36);
            this.NumberButton4.TabIndex = 18;
            this.NumberButton4.Tag = "number";
            this.NumberButton4.Text = "4";
            this.NumberButton4.UseVisualStyleBackColor = true;
            this.NumberButton4.Click += new System.EventHandler(this.ButtonClick);
            // 
            // NumberButton1
            // 
            this.NumberButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumberButton1.Font = new System.Drawing.Font("Brush Script MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberButton1.Location = new System.Drawing.Point(50, 313);
            this.NumberButton1.Name = "NumberButton1";
            this.NumberButton1.Size = new System.Drawing.Size(75, 36);
            this.NumberButton1.TabIndex = 19;
            this.NumberButton1.Tag = "number";
            this.NumberButton1.Text = "1";
            this.NumberButton1.UseVisualStyleBackColor = true;
            this.NumberButton1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ChangeSignButton
            // 
            this.ChangeSignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeSignButton.Font = new System.Drawing.Font("Brush Script MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeSignButton.Location = new System.Drawing.Point(50, 355);
            this.ChangeSignButton.Name = "ChangeSignButton";
            this.ChangeSignButton.Size = new System.Drawing.Size(75, 36);
            this.ChangeSignButton.TabIndex = 20;
            this.ChangeSignButton.Tag = "negative";
            this.ChangeSignButton.Text = "±";
            this.ChangeSignButton.UseVisualStyleBackColor = true;
            this.ChangeSignButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // SquareButton
            // 
            this.SquareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SquareButton.Font = new System.Drawing.Font("Brush Script MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SquareButton.Location = new System.Drawing.Point(50, 144);
            this.SquareButton.Name = "SquareButton";
            this.SquareButton.Size = new System.Drawing.Size(156, 36);
            this.SquareButton.TabIndex = 23;
            this.SquareButton.Tag = "square";
            this.SquareButton.Text = "√";
            this.SquareButton.UseVisualStyleBackColor = true;
            this.SquareButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // OutputLabel
            // 
            this.OutputLabel.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(50, 60);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(318, 75);
            this.OutputLabel.TabIndex = 21;
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TopLabel
            // 
            this.TopLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TopLabel.Location = new System.Drawing.Point(50, 16);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(318, 35);
            this.TopLabel.TabIndex = 22;
            this.TopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RightButton
            // 
            this.RightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RightButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightButton.Location = new System.Drawing.Point(293, 144);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(75, 36);
            this.RightButton.TabIndex = 24;
            this.RightButton.Tag = "rightBracket";
            this.RightButton.Text = "）";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // LeftButton
            // 
            this.LeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftButton.Location = new System.Drawing.Point(212, 144);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(75, 36);
            this.LeftButton.TabIndex = 25;
            this.LeftButton.Tag = "leftBracket";
            this.LeftButton.Text = "（";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 401);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.TopLabel);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.ChangeSignButton);
            this.Controls.Add(this.NumberButton1);
            this.Controls.Add(this.NumberButton4);
            this.Controls.Add(this.NumberButton7);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DotButton);
            this.Controls.Add(this.NumberButton3);
            this.Controls.Add(this.NumberButton6);
            this.Controls.Add(this.NumberButton9);
            this.Controls.Add(this.NumberButton5);
            this.Controls.Add(this.NumberButton0);
            this.Controls.Add(this.BackspaceButton);
            this.Controls.Add(this.NumberButton8);
            this.Controls.Add(this.ClearEntryButton);
            this.Controls.Add(this.NumberButton2);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EqualButton);
            this.Controls.Add(this.SquareButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button NumberButton2;
        private System.Windows.Forms.Button ClearEntryButton;
        private System.Windows.Forms.Button NumberButton8;
        private System.Windows.Forms.Button BackspaceButton;
        private System.Windows.Forms.Button NumberButton0;
        private System.Windows.Forms.Button NumberButton5;
        private System.Windows.Forms.Button NumberButton9;
        private System.Windows.Forms.Button NumberButton6;
        private System.Windows.Forms.Button NumberButton3;
        private System.Windows.Forms.Button DotButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button NumberButton7;
        private System.Windows.Forms.Button NumberButton4;
        private System.Windows.Forms.Button NumberButton1;
        private System.Windows.Forms.Button ChangeSignButton;
        private System.Windows.Forms.Button SquareButton;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button LeftButton;
    }
}

