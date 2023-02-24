namespace Restraunt_Order
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
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.drinkgroupbox = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.sidegroupbox = new System.Windows.Forms.GroupBox();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.mealcombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ordercreator = new System.Windows.Forms.Button();
            this.completeordertextbox = new System.Windows.Forms.TextBox();
            this.drinkgroupbox.SuspendLayout();
            this.sidegroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What is your name?";
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(120, 10);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(100, 20);
            this.nametextbox.TabIndex = 1;
            this.nametextbox.Text = "Enter Your Name";
            this.nametextbox.TextChanged += new System.EventHandler(this.Nametextbox_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ice Water- $1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Water- $1";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(68, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Coke- $2";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // drinkgroupbox
            // 
            this.drinkgroupbox.Controls.Add(this.radioButton5);
            this.drinkgroupbox.Controls.Add(this.radioButton4);
            this.drinkgroupbox.Controls.Add(this.radioButton1);
            this.drinkgroupbox.Controls.Add(this.radioButton3);
            this.drinkgroupbox.Controls.Add(this.radioButton2);
            this.drinkgroupbox.Location = new System.Drawing.Point(12, 52);
            this.drinkgroupbox.Name = "drinkgroupbox";
            this.drinkgroupbox.Size = new System.Drawing.Size(200, 141);
            this.drinkgroupbox.TabIndex = 6;
            this.drinkgroupbox.TabStop = false;
            this.drinkgroupbox.Text = "What drink would you like to order?";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(7, 113);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(91, 17);
            this.radioButton5.TabIndex = 7;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Dr Pepper- $2";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 89);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(70, 17);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Sprite- $2";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // sidegroupbox
            // 
            this.sidegroupbox.Controls.Add(this.radioButton11);
            this.sidegroupbox.Controls.Add(this.radioButton10);
            this.sidegroupbox.Controls.Add(this.radioButton9);
            this.sidegroupbox.Controls.Add(this.radioButton8);
            this.sidegroupbox.Controls.Add(this.radioButton7);
            this.sidegroupbox.Controls.Add(this.radioButton6);
            this.sidegroupbox.Location = new System.Drawing.Point(420, 52);
            this.sidegroupbox.Name = "sidegroupbox";
            this.sidegroupbox.Size = new System.Drawing.Size(235, 183);
            this.sidegroupbox.TabIndex = 7;
            this.sidegroupbox.TabStop = false;
            this.sidegroupbox.Text = "Select one side option?";
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(7, 136);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(98, 17);
            this.radioButton11.TabIndex = 8;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "Breadsticks- $4";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(7, 113);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(115, 17);
            this.radioButton10.TabIndex = 4;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Chicken Wings- $5";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(7, 89);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(124, 17);
            this.radioButton9.TabIndex = 3;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Mac and Cheese- $4";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(7, 66);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(80, 17);
            this.radioButton8.TabIndex = 2;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Nachos- $2";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(7, 42);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(126, 17);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Mashed Potatoes- $3";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(7, 19);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(65, 17);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Fries- $3";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // mealcombobox
            // 
            this.mealcombobox.FormattingEnabled = true;
            this.mealcombobox.Items.AddRange(new object[] {
            "Burger- $7",
            "Fries- $4",
            "Pasta- $5",
            "Taco- $4",
            "Spaghetti- $5",
            "Pizza- $10"});
            this.mealcombobox.Location = new System.Drawing.Point(218, 70);
            this.mealcombobox.Name = "mealcombobox";
            this.mealcombobox.Size = new System.Drawing.Size(196, 21);
            this.mealcombobox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select One Main Meal:";
            // 
            // ordercreator
            // 
            this.ordercreator.Location = new System.Drawing.Point(237, 267);
            this.ordercreator.Name = "ordercreator";
            this.ordercreator.Size = new System.Drawing.Size(145, 25);
            this.ordercreator.TabIndex = 10;
            this.ordercreator.Text = "Confirm Order";
            this.ordercreator.UseVisualStyleBackColor = true;
            this.ordercreator.Click += new System.EventHandler(this.Ordercreator_Click);
            // 
            // completeordertextbox
            // 
            this.completeordertextbox.Location = new System.Drawing.Point(16, 313);
            this.completeordertextbox.Multiline = true;
            this.completeordertextbox.Name = "completeordertextbox";
            this.completeordertextbox.Size = new System.Drawing.Size(626, 125);
            this.completeordertextbox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.completeordertextbox);
            this.Controls.Add(this.ordercreator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mealcombobox);
            this.Controls.Add(this.sidegroupbox);
            this.Controls.Add(this.drinkgroupbox);
            this.Controls.Add(this.nametextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Restaurant Order";
            this.drinkgroupbox.ResumeLayout(false);
            this.drinkgroupbox.PerformLayout();
            this.sidegroupbox.ResumeLayout(false);
            this.sidegroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox drinkgroupbox;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox sidegroupbox;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.ComboBox mealcombobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ordercreator;
        private System.Windows.Forms.TextBox completeordertextbox;
    }
}

