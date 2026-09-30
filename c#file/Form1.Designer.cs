namespace tip___tax_and_total
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
            this.foodone = new System.Windows.Forms.Label();
            this.priceone = new System.Windows.Forms.Label();
            this.foodtwo = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.txtfood1 = new System.Windows.Forms.MaskedTextBox();
            this.txtprice1 = new System.Windows.Forms.MaskedTextBox();
            this.txtfood2 = new System.Windows.Forms.MaskedTextBox();
            this.txtprice2 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.food2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttotalamount = new System.Windows.Forms.MaskedTextBox();
            this.txtsales = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // foodone
            // 
            this.foodone.AutoSize = true;
            this.foodone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodone.Location = new System.Drawing.Point(37, 26);
            this.foodone.Name = "foodone";
            this.foodone.Size = new System.Drawing.Size(104, 18);
            this.foodone.TabIndex = 0;
            this.foodone.Text = "enter food one";
            // 
            // priceone
            // 
            this.priceone.AutoSize = true;
            this.priceone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceone.Location = new System.Drawing.Point(37, 70);
            this.priceone.Name = "priceone";
            this.priceone.Size = new System.Drawing.Size(106, 18);
            this.priceone.TabIndex = 0;
            this.priceone.Text = "enter price one";
            // 
            // foodtwo
            // 
            this.foodtwo.AutoSize = true;
            this.foodtwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodtwo.Location = new System.Drawing.Point(37, 107);
            this.foodtwo.Name = "foodtwo";
            this.foodtwo.Size = new System.Drawing.Size(103, 18);
            this.foodtwo.TabIndex = 0;
            this.foodtwo.Text = "enter food two";
            // 
            // lbloutput
            // 
            this.lbloutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(37, 253);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(566, 51);
            this.lbloutput.TabIndex = 0;
            // 
            // txtfood1
            // 
            this.txtfood1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfood1.Location = new System.Drawing.Point(212, 26);
            this.txtfood1.Name = "txtfood1";
            this.txtfood1.Size = new System.Drawing.Size(254, 22);
            this.txtfood1.TabIndex = 1;
            this.txtfood1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txtprice1
            // 
            this.txtprice1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprice1.Location = new System.Drawing.Point(212, 70);
            this.txtprice1.Name = "txtprice1";
            this.txtprice1.Size = new System.Drawing.Size(254, 22);
            this.txtprice1.TabIndex = 1;
            // 
            // txtfood2
            // 
            this.txtfood2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfood2.Location = new System.Drawing.Point(212, 107);
            this.txtfood2.Name = "txtfood2";
            this.txtfood2.Size = new System.Drawing.Size(254, 22);
            this.txtfood2.TabIndex = 1;
            // 
            // txtprice2
            // 
            this.txtprice2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprice2.Location = new System.Drawing.Point(212, 143);
            this.txtprice2.Name = "txtprice2";
            this.txtprice2.Size = new System.Drawing.Size(254, 22);
            this.txtprice2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(283, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // food2
            // 
            this.food2.AutoSize = true;
            this.food2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.food2.Location = new System.Drawing.Point(34, 143);
            this.food2.Name = "food2";
            this.food2.Size = new System.Drawing.Size(105, 18);
            this.food2.TabIndex = 0;
            this.food2.Text = "enter price two";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "sales :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "total amount:";
            // 
            // txttotalamount
            // 
            this.txttotalamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotalamount.Location = new System.Drawing.Point(283, 393);
            this.txttotalamount.Name = "txttotalamount";
            this.txttotalamount.Size = new System.Drawing.Size(100, 22);
            this.txttotalamount.TabIndex = 4;
            // 
            // txtsales
            // 
            this.txtsales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsales.Location = new System.Drawing.Point(283, 355);
            this.txtsales.Name = "txtsales";
            this.txtsales.Size = new System.Drawing.Size(100, 22);
            this.txtsales.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtsales);
            this.Controls.Add(this.txttotalamount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtprice2);
            this.Controls.Add(this.txtfood2);
            this.Controls.Add(this.txtprice1);
            this.Controls.Add(this.txtfood1);
            this.Controls.Add(this.food2);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.foodtwo);
            this.Controls.Add(this.priceone);
            this.Controls.Add(this.foodone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label foodone;
        private System.Windows.Forms.Label priceone;
        private System.Windows.Forms.Label foodtwo;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.MaskedTextBox txtfood1;
        private System.Windows.Forms.MaskedTextBox txtprice1;
        private System.Windows.Forms.MaskedTextBox txtfood2;
        private System.Windows.Forms.MaskedTextBox txtprice2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label food2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txttotalamount;
        private System.Windows.Forms.MaskedTextBox txtsales;
    }
}

