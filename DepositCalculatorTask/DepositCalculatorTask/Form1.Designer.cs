
namespace DepositCalculatorTask
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
            this.buttonCalculateDeposit = new System.Windows.Forms.Button();
            this.comboBoxPeriod = new System.Windows.Forms.ComboBox();
            this.textBoxStartSum = new System.Windows.Forms.TextBox();
            this.labelPercent = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonUAH = new System.Windows.Forms.RadioButton();
            this.radioButtonDollar = new System.Windows.Forms.RadioButton();
            this.radioButtonEuro = new System.Windows.Forms.RadioButton();
            this.comboBoxMethod = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonCalculateDeposit
            // 
            this.buttonCalculateDeposit.Location = new System.Drawing.Point(85, 348);
            this.buttonCalculateDeposit.Name = "buttonCalculateDeposit";
            this.buttonCalculateDeposit.Size = new System.Drawing.Size(94, 29);
            this.buttonCalculateDeposit.TabIndex = 0;
            this.buttonCalculateDeposit.Text = "Calculate";
            this.buttonCalculateDeposit.UseVisualStyleBackColor = true;
            this.buttonCalculateDeposit.Click += new System.EventHandler(this.buttonCalculateDeposit_Click);
            // 
            // comboBoxPeriod
            // 
            this.comboBoxPeriod.AllowDrop = true;
            this.comboBoxPeriod.FormattingEnabled = true;
            this.comboBoxPeriod.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36"});
            this.comboBoxPeriod.Location = new System.Drawing.Point(169, 133);
            this.comboBoxPeriod.Name = "comboBoxPeriod";
            this.comboBoxPeriod.Size = new System.Drawing.Size(151, 28);
            this.comboBoxPeriod.TabIndex = 1;
            // 
            // textBoxStartSum
            // 
            this.textBoxStartSum.Location = new System.Drawing.Point(169, 84);
            this.textBoxStartSum.Name = "textBoxStartSum";
            this.textBoxStartSum.Size = new System.Drawing.Size(151, 27);
            this.textBoxStartSum.TabIndex = 3;
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.Location = new System.Drawing.Point(85, 23);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(50, 20);
            this.labelPercent.TabIndex = 4;
            this.labelPercent.Text = "label1";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(439, 348);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(50, 20);
            this.labelResult.TabIndex = 5;
            this.labelResult.Text = "label2";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(211, 348);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(109, 29);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Start sum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Period(month):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Deposit method:";
            // 
            // radioButtonUAH
            // 
            this.radioButtonUAH.AutoSize = true;
            this.radioButtonUAH.Location = new System.Drawing.Point(169, 256);
            this.radioButtonUAH.Name = "radioButtonUAH";
            this.radioButtonUAH.Size = new System.Drawing.Size(61, 24);
            this.radioButtonUAH.TabIndex = 0;
            this.radioButtonUAH.TabStop = true;
            this.radioButtonUAH.Text = "UAH";
            this.radioButtonUAH.UseVisualStyleBackColor = true;
            // 
            // radioButtonDollar
            // 
            this.radioButtonDollar.AutoSize = true;
            this.radioButtonDollar.Location = new System.Drawing.Point(246, 256);
            this.radioButtonDollar.Name = "radioButtonDollar";
            this.radioButtonDollar.Size = new System.Drawing.Size(38, 24);
            this.radioButtonDollar.TabIndex = 13;
            this.radioButtonDollar.TabStop = true;
            this.radioButtonDollar.Text = "$";
            this.radioButtonDollar.UseVisualStyleBackColor = true;
            // 
            // radioButtonEuro
            // 
            this.radioButtonEuro.AutoSize = true;
            this.radioButtonEuro.Location = new System.Drawing.Point(299, 256);
            this.radioButtonEuro.Name = "radioButtonEuro";
            this.radioButtonEuro.Size = new System.Drawing.Size(60, 24);
            this.radioButtonEuro.TabIndex = 14;
            this.radioButtonEuro.TabStop = true;
            this.radioButtonEuro.Text = "Euro";
            this.radioButtonEuro.UseVisualStyleBackColor = true;
            // 
            // comboBoxMethod
            // 
            this.comboBoxMethod.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBoxMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMethod.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBoxMethod.Items.AddRange(new object[] {
            "Capitalization",
            "Month payout"});
            this.comboBoxMethod.Location = new System.Drawing.Point(169, 188);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.Size = new System.Drawing.Size(151, 28);
            this.comboBoxMethod.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxMethod);
            this.Controls.Add(this.radioButtonEuro);
            this.Controls.Add(this.radioButtonDollar);
            this.Controls.Add(this.radioButtonUAH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelPercent);
            this.Controls.Add(this.textBoxStartSum);
            this.Controls.Add(this.comboBoxPeriod);
            this.Controls.Add(this.buttonCalculateDeposit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculateDeposit;
        private System.Windows.Forms.ComboBox comboBoxPeriod;
        private System.Windows.Forms.TextBox textBoxStartSum;
        private System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonUAH;
        private System.Windows.Forms.RadioButton radioButtonDollar;
        private System.Windows.Forms.RadioButton radioButtonEuro;
        private System.Windows.Forms.ComboBox comboBoxMethod;
    }
}

