namespace CalculatorForm
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
            EqualButton = new Button();
            AddButton = new Button();
            MinusButton = new Button();
            MultiplyButton = new Button();
            DivideButton = new Button();
            NumberButton2 = new Button();
            ClearEntryButton = new Button();
            NumberButton8 = new Button();
            BackspaceButton = new Button();
            NumberButton0 = new Button();
            NumberButton5 = new Button();
            NumberButton9 = new Button();
            NumberButton6 = new Button();
            NumberButton3 = new Button();
            DotButton = new Button();
            ClearButton = new Button();
            NumberButton7 = new Button();
            NumberButton4 = new Button();
            NumberButton1 = new Button();
            ChangeSignButton = new Button();
            SquareButton = new Button();
            OutputLabel = new Label();
            TopLabel = new Label();
            RightButton = new Button();
            LeftButton = new Button();
            preorderLabel = new Label();
            inorderLabel = new Label();
            postorderLabel = new Label();
            preorderString = new Label();
            inorderString = new Label();
            postorderString = new Label();
            SuspendLayout();
            // 
            // EqualButton
            // 
            EqualButton.BackColor = SystemColors.ActiveCaption;
            EqualButton.FlatStyle = FlatStyle.Flat;
            EqualButton.Font = new Font("Brush Script MT", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            EqualButton.Location = new Point(391, 504);
            EqualButton.Margin = new Padding(5, 3, 5, 3);
            EqualButton.Name = "EqualButton";
            EqualButton.Size = new Size(101, 49);
            EqualButton.TabIndex = 0;
            EqualButton.Tag = "equal";
            EqualButton.Text = "=";
            EqualButton.UseVisualStyleBackColor = false;
            EqualButton.Click += ButtonClick;
            // 
            // AddButton
            // 
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Brush Script MT", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            AddButton.Location = new Point(391, 444);
            AddButton.Margin = new Padding(5, 3, 5, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(101, 51);
            AddButton.TabIndex = 1;
            AddButton.Tag = "add";
            AddButton.Text = "+";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += ButtonClick;
            // 
            // MinusButton
            // 
            MinusButton.FlatStyle = FlatStyle.Flat;
            MinusButton.Font = new Font("Brush Script MT", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            MinusButton.Location = new Point(391, 385);
            MinusButton.Margin = new Padding(5, 3, 5, 3);
            MinusButton.Name = "MinusButton";
            MinusButton.Size = new Size(101, 51);
            MinusButton.TabIndex = 2;
            MinusButton.Tag = "minus";
            MinusButton.Text = "–";
            MinusButton.UseVisualStyleBackColor = true;
            MinusButton.Click += ButtonClick;
            // 
            // MultiplyButton
            // 
            MultiplyButton.FlatStyle = FlatStyle.Flat;
            MultiplyButton.Font = new Font("Brush Script MT", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            MultiplyButton.Location = new Point(391, 326);
            MultiplyButton.Margin = new Padding(5, 3, 5, 3);
            MultiplyButton.Name = "MultiplyButton";
            MultiplyButton.Size = new Size(101, 51);
            MultiplyButton.TabIndex = 3;
            MultiplyButton.Tag = "multiply";
            MultiplyButton.Text = "×";
            MultiplyButton.UseVisualStyleBackColor = true;
            MultiplyButton.Click += ButtonClick;
            // 
            // DivideButton
            // 
            DivideButton.FlatStyle = FlatStyle.Flat;
            DivideButton.Font = new Font("Brush Script MT", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            DivideButton.Location = new Point(391, 266);
            DivideButton.Margin = new Padding(5, 3, 5, 3);
            DivideButton.Name = "DivideButton";
            DivideButton.Size = new Size(101, 51);
            DivideButton.TabIndex = 4;
            DivideButton.Tag = "divide";
            DivideButton.Text = "÷";
            DivideButton.UseVisualStyleBackColor = true;
            DivideButton.Click += ButtonClick;
            // 
            // NumberButton2
            // 
            NumberButton2.FlatStyle = FlatStyle.Flat;
            NumberButton2.Font = new Font("Brush Script MT", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            NumberButton2.Location = new Point(175, 444);
            NumberButton2.Margin = new Padding(5, 3, 5, 3);
            NumberButton2.Name = "NumberButton2";
            NumberButton2.Size = new Size(101, 51);
            NumberButton2.TabIndex = 6;
            NumberButton2.Tag = "number";
            NumberButton2.Text = "2";
            NumberButton2.UseVisualStyleBackColor = true;
            NumberButton2.Click += ButtonClick;
            // 
            // ClearEntryButton
            // 
            ClearEntryButton.FlatStyle = FlatStyle.Flat;
            ClearEntryButton.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ClearEntryButton.Location = new Point(175, 265);
            ClearEntryButton.Margin = new Padding(5, 3, 5, 3);
            ClearEntryButton.Name = "ClearEntryButton";
            ClearEntryButton.Size = new Size(101, 51);
            ClearEntryButton.TabIndex = 7;
            ClearEntryButton.Tag = "CE";
            ClearEntryButton.Text = "CE";
            ClearEntryButton.UseVisualStyleBackColor = true;
            ClearEntryButton.Click += ButtonClick;
            // 
            // NumberButton8
            // 
            NumberButton8.FlatStyle = FlatStyle.Flat;
            NumberButton8.Font = new Font("Brush Script MT", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            NumberButton8.Location = new Point(175, 325);
            NumberButton8.Margin = new Padding(5, 3, 5, 3);
            NumberButton8.Name = "NumberButton8";
            NumberButton8.Size = new Size(101, 51);
            NumberButton8.TabIndex = 8;
            NumberButton8.Tag = "number";
            NumberButton8.Text = "8";
            NumberButton8.UseVisualStyleBackColor = true;
            NumberButton8.Click += ButtonClick;
            // 
            // BackspaceButton
            // 
            BackspaceButton.FlatStyle = FlatStyle.Flat;
            BackspaceButton.Font = new Font("Brush Script MT", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BackspaceButton.Location = new Point(281, 266);
            BackspaceButton.Margin = new Padding(5, 3, 5, 3);
            BackspaceButton.Name = "BackspaceButton";
            BackspaceButton.Size = new Size(101, 51);
            BackspaceButton.TabIndex = 9;
            BackspaceButton.Tag = "backspace";
            BackspaceButton.Text = "←";
            BackspaceButton.UseVisualStyleBackColor = true;
            BackspaceButton.Click += ButtonClick;
            // 
            // NumberButton0
            // 
            NumberButton0.FlatStyle = FlatStyle.Flat;
            NumberButton0.Font = new Font("Brush Script MT", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            NumberButton0.Location = new Point(175, 503);
            NumberButton0.Margin = new Padding(5, 3, 5, 3);
            NumberButton0.Name = "NumberButton0";
            NumberButton0.Size = new Size(101, 51);
            NumberButton0.TabIndex = 10;
            NumberButton0.Tag = "number";
            NumberButton0.Text = "0";
            NumberButton0.UseVisualStyleBackColor = true;
            NumberButton0.Click += ButtonClick;
            // 
            // NumberButton5
            // 
            NumberButton5.FlatStyle = FlatStyle.Flat;
            NumberButton5.Font = new Font("Brush Script MT", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            NumberButton5.Location = new Point(175, 384);
            NumberButton5.Margin = new Padding(5, 3, 5, 3);
            NumberButton5.Name = "NumberButton5";
            NumberButton5.Size = new Size(101, 51);
            NumberButton5.TabIndex = 11;
            NumberButton5.Tag = "number";
            NumberButton5.Text = "5";
            NumberButton5.UseVisualStyleBackColor = true;
            NumberButton5.Click += ButtonClick;
            // 
            // NumberButton9
            // 
            NumberButton9.FlatStyle = FlatStyle.Flat;
            NumberButton9.Font = new Font("Brush Script MT", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            NumberButton9.Location = new Point(281, 326);
            NumberButton9.Margin = new Padding(5, 3, 5, 3);
            NumberButton9.Name = "NumberButton9";
            NumberButton9.Size = new Size(101, 51);
            NumberButton9.TabIndex = 12;
            NumberButton9.Tag = "number";
            NumberButton9.Text = "9";
            NumberButton9.UseVisualStyleBackColor = true;
            NumberButton9.Click += ButtonClick;
            // 
            // NumberButton6
            // 
            NumberButton6.FlatStyle = FlatStyle.Flat;
            NumberButton6.Font = new Font("Brush Script MT", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            NumberButton6.Location = new Point(281, 384);
            NumberButton6.Margin = new Padding(5, 3, 5, 3);
            NumberButton6.Name = "NumberButton6";
            NumberButton6.Size = new Size(101, 51);
            NumberButton6.TabIndex = 13;
            NumberButton6.Tag = "number";
            NumberButton6.Text = "6";
            NumberButton6.UseVisualStyleBackColor = true;
            NumberButton6.Click += ButtonClick;
            // 
            // NumberButton3
            // 
            NumberButton3.FlatStyle = FlatStyle.Flat;
            NumberButton3.Font = new Font("Brush Script MT", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            NumberButton3.Location = new Point(281, 444);
            NumberButton3.Margin = new Padding(5, 3, 5, 3);
            NumberButton3.Name = "NumberButton3";
            NumberButton3.Size = new Size(101, 51);
            NumberButton3.TabIndex = 14;
            NumberButton3.Tag = "number";
            NumberButton3.Text = "3";
            NumberButton3.UseVisualStyleBackColor = true;
            NumberButton3.Click += ButtonClick;
            // 
            // DotButton
            // 
            DotButton.FlatStyle = FlatStyle.Flat;
            DotButton.Font = new Font("Brush Script MT", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            DotButton.Location = new Point(281, 503);
            DotButton.Margin = new Padding(5, 3, 5, 3);
            DotButton.Name = "DotButton";
            DotButton.Size = new Size(101, 51);
            DotButton.TabIndex = 15;
            DotButton.Tag = "dot";
            DotButton.Text = ".";
            DotButton.UseVisualStyleBackColor = true;
            DotButton.Click += ButtonClick;
            // 
            // ClearButton
            // 
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ClearButton.Location = new Point(65, 266);
            ClearButton.Margin = new Padding(5, 3, 5, 3);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(101, 51);
            ClearButton.TabIndex = 16;
            ClearButton.Tag = "clear";
            ClearButton.Text = "C";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ButtonClick;
            // 
            // NumberButton7
            // 
            NumberButton7.FlatStyle = FlatStyle.Flat;
            NumberButton7.Font = new Font("Brush Script MT", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            NumberButton7.Location = new Point(65, 325);
            NumberButton7.Margin = new Padding(5, 3, 5, 3);
            NumberButton7.Name = "NumberButton7";
            NumberButton7.Size = new Size(101, 51);
            NumberButton7.TabIndex = 17;
            NumberButton7.Tag = "number";
            NumberButton7.Text = "7";
            NumberButton7.UseVisualStyleBackColor = true;
            NumberButton7.Click += ButtonClick;
            // 
            // NumberButton4
            // 
            NumberButton4.FlatStyle = FlatStyle.Flat;
            NumberButton4.Font = new Font("Brush Script MT", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            NumberButton4.Location = new Point(65, 384);
            NumberButton4.Margin = new Padding(5, 3, 5, 3);
            NumberButton4.Name = "NumberButton4";
            NumberButton4.Size = new Size(101, 51);
            NumberButton4.TabIndex = 18;
            NumberButton4.Tag = "number";
            NumberButton4.Text = "4";
            NumberButton4.UseVisualStyleBackColor = true;
            NumberButton4.Click += ButtonClick;
            // 
            // NumberButton1
            // 
            NumberButton1.FlatStyle = FlatStyle.Flat;
            NumberButton1.Font = new Font("Brush Script MT", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            NumberButton1.Location = new Point(65, 444);
            NumberButton1.Margin = new Padding(5, 3, 5, 3);
            NumberButton1.Name = "NumberButton1";
            NumberButton1.Size = new Size(101, 51);
            NumberButton1.TabIndex = 19;
            NumberButton1.Tag = "number";
            NumberButton1.Text = "1";
            NumberButton1.UseVisualStyleBackColor = true;
            NumberButton1.Click += ButtonClick;
            // 
            // ChangeSignButton
            // 
            ChangeSignButton.FlatStyle = FlatStyle.Flat;
            ChangeSignButton.Font = new Font("Brush Script MT", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ChangeSignButton.Location = new Point(65, 503);
            ChangeSignButton.Margin = new Padding(5, 3, 5, 3);
            ChangeSignButton.Name = "ChangeSignButton";
            ChangeSignButton.Size = new Size(101, 51);
            ChangeSignButton.TabIndex = 20;
            ChangeSignButton.Tag = "negative";
            ChangeSignButton.Text = "±";
            ChangeSignButton.UseVisualStyleBackColor = true;
            ChangeSignButton.Click += ButtonClick;
            // 
            // SquareButton
            // 
            SquareButton.FlatStyle = FlatStyle.Flat;
            SquareButton.Font = new Font("Brush Script MT", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            SquareButton.Location = new Point(65, 204);
            SquareButton.Margin = new Padding(5, 3, 5, 3);
            SquareButton.Name = "SquareButton";
            SquareButton.Size = new Size(208, 51);
            SquareButton.TabIndex = 23;
            SquareButton.Tag = "square";
            SquareButton.Text = "√";
            SquareButton.UseVisualStyleBackColor = true;
            SquareButton.Click += ButtonClick;
            // 
            // OutputLabel
            // 
            OutputLabel.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Italic, GraphicsUnit.Point);
            OutputLabel.Location = new Point(65, 85);
            OutputLabel.Margin = new Padding(5, 0, 5, 0);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(424, 105);
            OutputLabel.TabIndex = 21;
            OutputLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TopLabel
            // 
            TopLabel.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TopLabel.ForeColor = SystemColors.ControlText;
            TopLabel.Location = new Point(65, 23);
            TopLabel.Margin = new Padding(5, 0, 5, 0);
            TopLabel.Name = "TopLabel";
            TopLabel.Size = new Size(424, 49);
            TopLabel.TabIndex = 22;
            TopLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // RightButton
            // 
            RightButton.FlatStyle = FlatStyle.Flat;
            RightButton.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            RightButton.Location = new Point(391, 204);
            RightButton.Margin = new Padding(5, 3, 5, 3);
            RightButton.Name = "RightButton";
            RightButton.Size = new Size(101, 51);
            RightButton.TabIndex = 24;
            RightButton.Tag = "rightBracket";
            RightButton.Text = "）";
            RightButton.UseVisualStyleBackColor = true;
            RightButton.Click += ButtonClick;
            // 
            // LeftButton
            // 
            LeftButton.FlatStyle = FlatStyle.Flat;
            LeftButton.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LeftButton.Location = new Point(281, 204);
            LeftButton.Margin = new Padding(5, 3, 5, 3);
            LeftButton.Name = "LeftButton";
            LeftButton.Size = new Size(101, 51);
            LeftButton.TabIndex = 25;
            LeftButton.Tag = "leftBracket";
            LeftButton.Text = "（";
            LeftButton.UseVisualStyleBackColor = true;
            LeftButton.Click += ButtonClick;
            // 
            // preorderLabel
            // 
            preorderLabel.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            preorderLabel.Location = new Point(527, 25);
            preorderLabel.Name = "preorderLabel";
            preorderLabel.Size = new Size(95, 39);
            preorderLabel.TabIndex = 26;
            preorderLabel.Text = "preorder：";
            // 
            // inorderLabel
            // 
            inorderLabel.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            inorderLabel.Location = new Point(527, 90);
            inorderLabel.Name = "inorderLabel";
            inorderLabel.Size = new Size(95, 39);
            inorderLabel.TabIndex = 27;
            inorderLabel.Text = "inorder：";
            // 
            // postorderLabel
            // 
            postorderLabel.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            postorderLabel.Location = new Point(527, 151);
            postorderLabel.Name = "postorderLabel";
            postorderLabel.Size = new Size(95, 39);
            postorderLabel.TabIndex = 28;
            postorderLabel.Text = "postorder：";
            // 
            // preorderString
            // 
            preorderString.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            preorderString.Location = new Point(628, 25);
            preorderString.Name = "preorderString";
            preorderString.Size = new Size(329, 39);
            preorderString.TabIndex = 29;
            // 
            // inorderString
            // 
            inorderString.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            inorderString.Location = new Point(628, 90);
            inorderString.Name = "inorderString";
            inorderString.Size = new Size(329, 39);
            inorderString.TabIndex = 30;
            // 
            // postorderString
            // 
            postorderString.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            postorderString.Location = new Point(628, 151);
            postorderString.Name = "postorderString";
            postorderString.Size = new Size(329, 39);
            postorderString.TabIndex = 31;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 568);
            Controls.Add(postorderString);
            Controls.Add(inorderString);
            Controls.Add(preorderString);
            Controls.Add(postorderLabel);
            Controls.Add(inorderLabel);
            Controls.Add(preorderLabel);
            Controls.Add(LeftButton);
            Controls.Add(RightButton);
            Controls.Add(TopLabel);
            Controls.Add(OutputLabel);
            Controls.Add(ChangeSignButton);
            Controls.Add(NumberButton1);
            Controls.Add(NumberButton4);
            Controls.Add(NumberButton7);
            Controls.Add(ClearButton);
            Controls.Add(DotButton);
            Controls.Add(NumberButton3);
            Controls.Add(NumberButton6);
            Controls.Add(NumberButton9);
            Controls.Add(NumberButton5);
            Controls.Add(NumberButton0);
            Controls.Add(BackspaceButton);
            Controls.Add(NumberButton8);
            Controls.Add(ClearEntryButton);
            Controls.Add(NumberButton2);
            Controls.Add(DivideButton);
            Controls.Add(MultiplyButton);
            Controls.Add(MinusButton);
            Controls.Add(AddButton);
            Controls.Add(EqualButton);
            Controls.Add(SquareButton);
            Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 3, 5, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button EqualButton;
        private Button AddButton;
        private Button MinusButton;
        private Button MultiplyButton;
        private Button DivideButton;
        private Button NumberButton2;
        private Button ClearEntryButton;
        private Button NumberButton8;
        private Button BackspaceButton;
        private Button NumberButton0;
        private Button NumberButton5;
        private Button NumberButton9;
        private Button NumberButton6;
        private Button NumberButton3;
        private Button DotButton;
        private Button ClearButton;
        private Button NumberButton7;
        private Button NumberButton4;
        private Button NumberButton1;
        private Button ChangeSignButton;
        private Button SquareButton;
        private Label OutputLabel;
        private Label TopLabel;
        private Button RightButton;
        private Button LeftButton;
        private Label preorderLabel;
        private Label inorderLabel;
        private Label postorderLabel;
        private Label preorderString;
        private Label inorderString;
        private Label postorderString;
    }
}
