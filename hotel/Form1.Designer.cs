namespace hotel
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtguestname = new System.Windows.Forms.RichTextBox();
            this.txtroomtype = new System.Windows.Forms.RichTextBox();
            this.txtservicetax = new System.Windows.Forms.RichTextBox();
            this.txtpricepernight = new System.Windows.Forms.RichTextBox();
            this.txtnumberofnights = new System.Windows.Forms.RichTextBox();
            this.txttotalamount = new System.Windows.Forms.RichTextBox();
            this.txtdiscount = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "enter guest name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "enter room type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "enter number of nights :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "enter price per night :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "service tax (10%) :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "discount (5%) :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "total amount :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(196, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "calculat bookinkg";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtguestname
            // 
            this.txtguestname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtguestname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtguestname.Location = new System.Drawing.Point(241, 38);
            this.txtguestname.Name = "txtguestname";
            this.txtguestname.Size = new System.Drawing.Size(235, 26);
            this.txtguestname.TabIndex = 2;
            this.txtguestname.Text = "";
            // 
            // txtroomtype
            // 
            this.txtroomtype.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtroomtype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtroomtype.Location = new System.Drawing.Point(241, 82);
            this.txtroomtype.Name = "txtroomtype";
            this.txtroomtype.Size = new System.Drawing.Size(235, 26);
            this.txtroomtype.TabIndex = 2;
            this.txtroomtype.Text = "";
            // 
            // txtservicetax
            // 
            this.txtservicetax.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtservicetax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtservicetax.Location = new System.Drawing.Point(241, 302);
            this.txtservicetax.Name = "txtservicetax";
            this.txtservicetax.Size = new System.Drawing.Size(245, 26);
            this.txtservicetax.TabIndex = 2;
            this.txtservicetax.Text = "";
            // 
            // txtpricepernight
            // 
            this.txtpricepernight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtpricepernight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpricepernight.Location = new System.Drawing.Point(241, 166);
            this.txtpricepernight.Name = "txtpricepernight";
            this.txtpricepernight.Size = new System.Drawing.Size(235, 26);
            this.txtpricepernight.TabIndex = 2;
            this.txtpricepernight.Text = "";
            // 
            // txtnumberofnights
            // 
            this.txtnumberofnights.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtnumberofnights.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumberofnights.Location = new System.Drawing.Point(241, 124);
            this.txtnumberofnights.Name = "txtnumberofnights";
            this.txtnumberofnights.Size = new System.Drawing.Size(235, 26);
            this.txtnumberofnights.TabIndex = 2;
            this.txtnumberofnights.Text = "";
            // 
            // txttotalamount
            // 
            this.txttotalamount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txttotalamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotalamount.Location = new System.Drawing.Point(241, 404);
            this.txttotalamount.Name = "txttotalamount";
            this.txttotalamount.Size = new System.Drawing.Size(245, 26);
            this.txttotalamount.TabIndex = 2;
            this.txttotalamount.Text = "";
            // 
            // txtdiscount
            // 
            this.txtdiscount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtdiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdiscount.Location = new System.Drawing.Point(241, 349);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(245, 26);
            this.txtdiscount.TabIndex = 2;
            this.txtdiscount.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtnumberofnights);
            this.Controls.Add(this.txtpricepernight);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.txttotalamount);
            this.Controls.Add(this.txtservicetax);
            this.Controls.Add(this.txtroomtype);
            this.Controls.Add(this.txtguestname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtguestname;
        private System.Windows.Forms.RichTextBox txtroomtype;
        private System.Windows.Forms.RichTextBox txtservicetax;
        private System.Windows.Forms.RichTextBox txtpricepernight;
        private System.Windows.Forms.RichTextBox txtnumberofnights;
        private System.Windows.Forms.RichTextBox txttotalamount;
        private System.Windows.Forms.RichTextBox txtdiscount;
    }
}

