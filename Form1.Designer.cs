
namespace VendorMachine
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbDes = new System.Windows.Forms.ComboBox();
            this.cbPay = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bBuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Destination";
            // 
            // cbDes
            // 
            this.cbDes.FormattingEnabled = true;
            this.cbDes.Location = new System.Drawing.Point(178, 26);
            this.cbDes.Name = "cbDes";
            this.cbDes.Size = new System.Drawing.Size(259, 28);
            this.cbDes.TabIndex = 1;
            // 
            // cbPay
            // 
            this.cbPay.FormattingEnabled = true;
            this.cbPay.Location = new System.Drawing.Point(178, 74);
            this.cbPay.Name = "cbPay";
            this.cbPay.Size = new System.Drawing.Size(259, 28);
            this.cbPay.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type Of Payment";
            // 
            // bBuy
            // 
            this.bBuy.Location = new System.Drawing.Point(156, 136);
            this.bBuy.Name = "bBuy";
            this.bBuy.Size = new System.Drawing.Size(154, 44);
            this.bBuy.TabIndex = 5;
            this.bBuy.Text = "Buy";
            this.bBuy.UseVisualStyleBackColor = true;
            this.bBuy.Click += new System.EventHandler(this.bBuy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 225);
            this.Controls.Add(this.bBuy);
            this.Controls.Add(this.cbPay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Buy Ticket";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDes;
        private System.Windows.Forms.ComboBox cbPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bBuy;
    }
}

