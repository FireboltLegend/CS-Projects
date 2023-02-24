namespace ToDo_List
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
            this.ItemTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ToDoListBox = new System.Windows.Forms.ListBox();
            this.AddFrontButton = new System.Windows.Forms.Button();
            this.AddBackButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ItemTextBox
            // 
            this.ItemTextBox.Location = new System.Drawing.Point(12, 29);
            this.ItemTextBox.Name = "ItemTextBox";
            this.ItemTextBox.Size = new System.Drawing.Size(166, 20);
            this.ItemTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter a to-do item:";
            // 
            // ToDoListBox
            // 
            this.ToDoListBox.FormattingEnabled = true;
            this.ToDoListBox.Location = new System.Drawing.Point(13, 56);
            this.ToDoListBox.Name = "ToDoListBox";
            this.ToDoListBox.Size = new System.Drawing.Size(165, 121);
            this.ToDoListBox.TabIndex = 2;
            // 
            // AddFrontButton
            // 
            this.AddFrontButton.Location = new System.Drawing.Point(185, 56);
            this.AddFrontButton.Name = "AddFrontButton";
            this.AddFrontButton.Size = new System.Drawing.Size(75, 23);
            this.AddFrontButton.TabIndex = 3;
            this.AddFrontButton.Text = "Add Front";
            this.AddFrontButton.UseVisualStyleBackColor = true;
            // 
            // AddBackButton
            // 
            this.AddBackButton.Location = new System.Drawing.Point(185, 86);
            this.AddBackButton.Name = "AddBackButton";
            this.AddBackButton.Size = new System.Drawing.Size(75, 23);
            this.AddBackButton.TabIndex = 4;
            this.AddBackButton.Text = "Add Back";
            this.AddBackButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(185, 116);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(185, 146);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddBackButton);
            this.Controls.Add(this.AddFrontButton);
            this.Controls.Add(this.ToDoListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemTextBox);
            this.Name = "Form1";
            this.Text = "My To-do List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ItemTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ToDoListBox;
        private System.Windows.Forms.Button AddFrontButton;
        private System.Windows.Forms.Button AddBackButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

