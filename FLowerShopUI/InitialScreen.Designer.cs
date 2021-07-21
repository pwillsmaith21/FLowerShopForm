
namespace FlowerUI
{
    partial class InitialScreen
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
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.pinTextBox = new System.Windows.Forms.TextBox();
            this.loadCartButton = new System.Windows.Forms.Button();
            this.newCartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pin";
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Location = new System.Drawing.Point(160, 61);
            this.userIdTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(259, 30);
            this.userIdTextBox.TabIndex = 3;
            // 
            // pinTextBox
            // 
            this.pinTextBox.Location = new System.Drawing.Point(160, 141);
            this.pinTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pinTextBox.Name = "pinTextBox";
            this.pinTextBox.Size = new System.Drawing.Size(259, 30);
            this.pinTextBox.TabIndex = 4;
            // 
            // loadCartButton
            // 
            this.loadCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadCartButton.Location = new System.Drawing.Point(176, 211);
            this.loadCartButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loadCartButton.Name = "loadCartButton";
            this.loadCartButton.Size = new System.Drawing.Size(194, 86);
            this.loadCartButton.TabIndex = 5;
            this.loadCartButton.Text = "Load Cart";
            this.loadCartButton.UseVisualStyleBackColor = true;
            this.loadCartButton.Click += new System.EventHandler(this.loadCartButton_Click);
            // 
            // newCartButton
            // 
            this.newCartButton.Location = new System.Drawing.Point(828, 141);
            this.newCartButton.Name = "newCartButton";
            this.newCartButton.Size = new System.Drawing.Size(169, 93);
            this.newCartButton.TabIndex = 6;
            this.newCartButton.Text = "New Cart";
            this.newCartButton.UseVisualStyleBackColor = true;
            this.newCartButton.Click += new System.EventHandler(this.newCartButton_Click);
            // 
            // InitialScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.newCartButton);
            this.Controls.Add(this.loadCartButton);
            this.Controls.Add(this.pinTextBox);
            this.Controls.Add(this.userIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InitialScreen";
            this.Text = "InitialScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.TextBox pinTextBox;
        private System.Windows.Forms.Button loadCartButton;
        private System.Windows.Forms.Button newCartButton;
    }
}