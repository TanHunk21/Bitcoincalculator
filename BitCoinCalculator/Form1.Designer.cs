
namespace BitCoinCalculator
{
    partial class BitCoinCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BitCoinCalculator));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Rates = new System.Windows.Forms.Button();
            this.Btcamount = new System.Windows.Forms.TextBox();
            this.Res = new System.Windows.Forms.TextBox();
            this.Reslbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(50, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Select Currency";
            // 
            // Rates
            // 
            this.Rates.Location = new System.Drawing.Point(50, 104);
            this.Rates.Name = "Rates";
            this.Rates.Size = new System.Drawing.Size(121, 23);
            this.Rates.TabIndex = 1;
            this.Rates.Text = "Get Rates";
            this.Rates.UseVisualStyleBackColor = true;
            this.Rates.Click += new System.EventHandler(this.Rates_Click);
            // 
            // Btcamount
            // 
            this.Btcamount.Location = new System.Drawing.Point(201, 62);
            this.Btcamount.Name = "Btcamount";
            this.Btcamount.Size = new System.Drawing.Size(126, 22);
            this.Btcamount.TabIndex = 2;
            // 
            // Res
            // 
            this.Res.Location = new System.Drawing.Point(50, 197);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(121, 22);
            this.Res.TabIndex = 3;
            this.Res.Visible = false;
            // 
            // Reslbl
            // 
            this.Reslbl.AutoSize = true;
            this.Reslbl.Location = new System.Drawing.Point(50, 147);
            this.Reslbl.Name = "Reslbl";
            this.Reslbl.Size = new System.Drawing.Size(43, 17);
            this.Reslbl.TabIndex = 4;
            this.Reslbl.Text = "result";
            // 
            // BitCoinCalculator
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(691, 416);
            this.Controls.Add(this.Reslbl);
            this.Controls.Add(this.Res);
            this.Controls.Add(this.Btcamount);
            this.Controls.Add(this.Rates);
            this.Controls.Add(this.comboBox1);
            this.Name = "BitCoinCalculator";
            this.Text = "BitCoin Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyMenu;
        private System.Windows.Forms.Button getRatesBtn;
        private System.Windows.Forms.TextBox amountOfBtc;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label resultlbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Rates;
        private System.Windows.Forms.TextBox Btcamount;
        private System.Windows.Forms.TextBox Res;
        private System.Windows.Forms.Label Reslbl;
    }
}

