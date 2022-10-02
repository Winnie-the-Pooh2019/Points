namespace Points
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.text1L = new System.Windows.Forms.TextBox();
            this.text2L = new System.Windows.Forms.TextBox();
            this.noneq = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.minusR = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.text2R = new System.Windows.Forms.TextBox();
            this.text1R = new System.Windows.Forms.TextBox();
            this.set1 = new System.Windows.Forms.TreeView();
            this.set2 = new System.Windows.Forms.TreeView();
            this.noneqS = new System.Windows.Forms.Button();
            this.equalS = new System.Windows.Forms.Button();
            this.minusS = new System.Windows.Forms.Button();
            this.plusS = new System.Windows.Forms.Button();
            this.minusL = new System.Windows.Forms.Button();
            this.plusL = new System.Windows.Forms.Button();
            this.plusR = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.resultSet = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text1L
            // 
            this.text1L.Location = new System.Drawing.Point(125, 32);
            this.text1L.Name = "text1L";
            this.text1L.Size = new System.Drawing.Size(54, 27);
            this.text1L.TabIndex = 0;
            this.text1L.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputKeyPressed);
            // 
            // text2L
            // 
            this.text2L.Location = new System.Drawing.Point(210, 32);
            this.text2L.Name = "text2L";
            this.text2L.Size = new System.Drawing.Size(54, 27);
            this.text2L.TabIndex = 1;
            this.text2L.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputKeyPressed);
            // 
            // noneq
            // 
            this.noneq.Location = new System.Drawing.Point(533, 29);
            this.noneq.Name = "noneq";
            this.noneq.Size = new System.Drawing.Size(39, 29);
            this.noneq.TabIndex = 11;
            this.noneq.Text = "!=";
            this.noneq.UseVisualStyleBackColor = true;
            this.noneq.Click += new System.EventHandler(this.onPointsNoneq);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(474, 29);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(39, 29);
            this.equal.TabIndex = 10;
            this.equal.Text = "==";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.onPointsEqual);
            // 
            // minusR
            // 
            this.minusR.Location = new System.Drawing.Point(729, 100);
            this.minusR.Name = "minusR";
            this.minusR.Size = new System.Drawing.Size(29, 29);
            this.minusR.TabIndex = 9;
            this.minusR.Text = "-";
            this.minusR.UseVisualStyleBackColor = true;
            this.minusR.Click += new System.EventHandler(this.onPointAndSetMinusR);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(423, 29);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(29, 29);
            this.plus.TabIndex = 8;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.onPointsPlus);
            // 
            // text2R
            // 
            this.text2R.Location = new System.Drawing.Point(778, 31);
            this.text2R.Name = "text2R";
            this.text2R.Size = new System.Drawing.Size(54, 27);
            this.text2R.TabIndex = 7;
            this.text2R.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputKeyPressed);
            // 
            // text1R
            // 
            this.text1R.Location = new System.Drawing.Point(692, 31);
            this.text1R.Name = "text1R";
            this.text1R.Size = new System.Drawing.Size(54, 27);
            this.text1R.TabIndex = 6;
            this.text1R.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputKeyPressed);
            // 
            // set1
            // 
            this.set1.Location = new System.Drawing.Point(38, 195);
            this.set1.Name = "set1";
            this.set1.Size = new System.Drawing.Size(226, 306);
            this.set1.TabIndex = 12;
            // 
            // set2
            // 
            this.set2.Location = new System.Drawing.Point(692, 195);
            this.set2.Name = "set2";
            this.set2.Size = new System.Drawing.Size(250, 306);
            this.set2.TabIndex = 13;
            // 
            // noneqS
            // 
            this.noneqS.Location = new System.Drawing.Point(543, 472);
            this.noneqS.Name = "noneqS";
            this.noneqS.Size = new System.Drawing.Size(39, 29);
            this.noneqS.TabIndex = 17;
            this.noneqS.Text = "!=";
            this.noneqS.UseVisualStyleBackColor = true;
            this.noneqS.Click += new System.EventHandler(this.onSetNoneq);
            // 
            // equalS
            // 
            this.equalS.Location = new System.Drawing.Point(485, 472);
            this.equalS.Name = "equalS";
            this.equalS.Size = new System.Drawing.Size(39, 29);
            this.equalS.TabIndex = 16;
            this.equalS.Text = "==";
            this.equalS.UseVisualStyleBackColor = true;
            this.equalS.Click += new System.EventHandler(this.onSetEqual);
            // 
            // minusS
            // 
            this.minusS.Location = new System.Drawing.Point(438, 472);
            this.minusS.Name = "minusS";
            this.minusS.Size = new System.Drawing.Size(29, 29);
            this.minusS.TabIndex = 15;
            this.minusS.Text = "-";
            this.minusS.UseVisualStyleBackColor = true;
            this.minusS.Click += new System.EventHandler(this.onMinusSet);
            // 
            // plusS
            // 
            this.plusS.Location = new System.Drawing.Point(393, 472);
            this.plusS.Name = "plusS";
            this.plusS.Size = new System.Drawing.Size(29, 29);
            this.plusS.TabIndex = 14;
            this.plusS.Text = "+";
            this.plusS.UseVisualStyleBackColor = true;
            this.plusS.Click += new System.EventHandler(this.onPlusSet);
            // 
            // minusL
            // 
            this.minusL.Location = new System.Drawing.Point(162, 101);
            this.minusL.Name = "minusL";
            this.minusL.Size = new System.Drawing.Size(29, 29);
            this.minusL.TabIndex = 18;
            this.minusL.Text = "-";
            this.minusL.UseVisualStyleBackColor = true;
            this.minusL.Click += new System.EventHandler(this.onPointAndSetMinusL);
            // 
            // plusL
            // 
            this.plusL.Location = new System.Drawing.Point(197, 100);
            this.plusL.Name = "plusL";
            this.plusL.Size = new System.Drawing.Size(29, 29);
            this.plusL.TabIndex = 19;
            this.plusL.Text = "+";
            this.plusL.UseVisualStyleBackColor = true;
            this.plusL.Click += new System.EventHandler(this.onPointAndSetPlusL);
            // 
            // plusR
            // 
            this.plusR.Location = new System.Drawing.Point(764, 100);
            this.plusR.Name = "plusR";
            this.plusR.Size = new System.Drawing.Size(29, 29);
            this.plusR.TabIndex = 20;
            this.plusR.Text = "+";
            this.plusR.UseVisualStyleBackColor = true;
            this.plusR.Click += new System.EventHandler(this.onPointAndSetPlusR);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(473, 559);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 20);
            this.label.TabIndex = 21;
            // 
            // resultSet
            // 
            this.resultSet.Location = new System.Drawing.Point(359, 195);
            this.resultSet.Name = "resultSet";
            this.resultSet.Size = new System.Drawing.Size(250, 271);
            this.resultSet.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 23;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.onLeftClear);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(848, 507);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 24;
            this.button2.Text = "clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.onClearRight);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 684);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultSet);
            this.Controls.Add(this.label);
            this.Controls.Add(this.plusR);
            this.Controls.Add(this.plusL);
            this.Controls.Add(this.minusL);
            this.Controls.Add(this.noneqS);
            this.Controls.Add(this.equalS);
            this.Controls.Add(this.minusS);
            this.Controls.Add(this.plusS);
            this.Controls.Add(this.set2);
            this.Controls.Add(this.set1);
            this.Controls.Add(this.noneq);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.minusR);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.text2R);
            this.Controls.Add(this.text1R);
            this.Controls.Add(this.text2L);
            this.Controls.Add(this.text1L);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox text1L;
        private TextBox text2L;
        private Button noneq;
        private Button equal;
        private Button minusR;
        private Button plus;
        private TextBox text2R;
        private TextBox text1R;
        private TreeView set1;
        private TreeView set2;
        private Button noneqS;
        private Button equalS;
        private Button minusS;
        private Button plusS;
        private Button minusL;
        private Button plusL;
        private Button plusR;
        private Label label;
        private TreeView resultSet;
        private Button button1;
        private Button button2;
    }
}