
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
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            this.totalLabel.Location = new System.Drawing.Point(581, 256);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(40, 17);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Text = "Total";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            this.subtotalLabel.Location = new System.Drawing.Point(581, 224);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(60, 17);
            this.subtotalLabel.TabIndex = 5;
            this.subtotalLabel.Text = "Subtotal";
            this.subtotalLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // subtotalBox
            // 
            this.subtotalBox.Enabled = false;
            this.subtotalBox.Location = new System.Drawing.Point(647, 224);
            this.subtotalBox.Name = "subtotalBox";
            this.subtotalBox.Size = new System.Drawing.Size(84, 22);
            this.subtotalBox.TabIndex = 6;
            // 
            // totalBox
            // 
            this.totalBox.Enabled = false;
            this.totalBox.Location = new System.Drawing.Point(647, 251);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(84, 22);
            this.totalBox.TabIndex = 7;
            // 
            // checkoutButton
            // 
            this.checkoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            this.checkoutButton.Location = new System.Drawing.Point(610, 293);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(147, 49);
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
            this.flowerListBox.ItemHeight = 16;
            this.flowerListBox.Location = new System.Drawing.Point(13, 31);
            this.flowerListBox.Name = "flowerListBox";
            this.flowerListBox.Size = new System.Drawing.Size(282, 292);
            this.flowerListBox.TabIndex = 9;
            this.flowerListBox.DoubleClick += new System.EventHandler(this.flowerListBox_DoubleClick);
            // 
            // cartListBox
            // 
            this.cartListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.ItemHeight = 16;
            this.cartListBox.Location = new System.Drawing.Point(550, 31);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(250, 164);
            this.cartListBox.TabIndex = 10;
            this.cartListBox.DoubleClick += new System.EventHandler(this.cartListBox_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(110)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cartListBox);
            this.Controls.Add(this.flowerListBox);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.subtotalBox);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.totalLabel);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Flower Shop";
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
    }
}

