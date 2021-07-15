
namespace FlowerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.totalLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.subtotalBox = new System.Windows.Forms.TextBox();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.flowerListBox = new System.Windows.Forms.ListBox();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userIdBox = new System.Windows.Forms.TextBox();
            this.userPinBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            this.totalLabel.Location = new System.Drawing.Point(872, 400);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(56, 25);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Text = "Total";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            this.subtotalLabel.Location = new System.Drawing.Point(872, 350);
            this.subtotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(84, 25);
            this.subtotalLabel.TabIndex = 5;
            this.subtotalLabel.Text = "Subtotal";
            this.subtotalLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // subtotalBox
            // 
            this.subtotalBox.Enabled = false;
            this.subtotalBox.Location = new System.Drawing.Point(970, 350);
            this.subtotalBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subtotalBox.Name = "subtotalBox";
            this.subtotalBox.Size = new System.Drawing.Size(124, 30);
            this.subtotalBox.TabIndex = 6;
            // 
            // totalBox
            // 
            this.totalBox.Enabled = false;
            this.totalBox.Location = new System.Drawing.Point(970, 392);
            this.totalBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(124, 30);
            this.totalBox.TabIndex = 7;
            // 
            // checkoutButton
            // 
            this.checkoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            this.checkoutButton.Location = new System.Drawing.Point(915, 458);
            this.checkoutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(220, 77);
            this.checkoutButton.TabIndex = 8;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // flowerListBox
            // 
            this.flowerListBox.BackColor = System.Drawing.Color.White;
            this.flowerListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            this.flowerListBox.FormattingEnabled = true;
            this.flowerListBox.ItemHeight = 25;
            this.flowerListBox.Location = new System.Drawing.Point(20, 48);
            this.flowerListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowerListBox.Name = "flowerListBox";
            this.flowerListBox.Size = new System.Drawing.Size(421, 454);
            this.flowerListBox.TabIndex = 9;
            this.flowerListBox.DoubleClick += new System.EventHandler(this.flowerListBox_DoubleClick);
            // 
            // cartListBox
            // 
            this.cartListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.ItemHeight = 25;
            this.cartListBox.Location = new System.Drawing.Point(825, 48);
            this.cartListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(373, 254);
            this.cartListBox.TabIndex = 10;
            this.cartListBox.DoubleClick += new System.EventHandler(this.cartListBox_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 547);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 86);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save Cart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 397);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "User Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 458);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pin";
            // 
            // userIdBox
            // 
            this.userIdBox.Location = new System.Drawing.Point(533, 400);
            this.userIdBox.Name = "userIdBox";
            this.userIdBox.Size = new System.Drawing.Size(207, 30);
            this.userIdBox.TabIndex = 14;
            // 
            // userPinBox
            // 
            this.userPinBox.Location = new System.Drawing.Point(533, 458);
            this.userPinBox.Name = "userPinBox";
            this.userPinBox.Size = new System.Drawing.Size(207, 30);
            this.userPinBox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(110)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.userPinBox);
            this.Controls.Add(this.userIdBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cartListBox);
            this.Controls.Add(this.flowerListBox);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.subtotalBox);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.totalLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Flower Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.TextBox subtotalBox;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.ListBox flowerListBox;
        private System.Windows.Forms.ListBox cartListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userIdBox;
        private System.Windows.Forms.TextBox userPinBox;
    }
}

