namespace MusicMaker
{
    partial class MusicMaker
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
            this.NoteComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TestNoteButton = new System.Windows.Forms.Button();
            this.AddNoteButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SongMakerListBox = new System.Windows.Forms.ListBox();
            this.DeleteNoteButton = new System.Windows.Forms.Button();
            this.TestSongButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SortSongsButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.SongDisplayListBox = new System.Windows.Forms.ListBox();
            this.DeleteSongButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter which note frequency you want to use:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // NoteComboBox
            // 
            this.NoteComboBox.FormattingEnabled = true;
            this.NoteComboBox.IntegralHeight = false;
            this.NoteComboBox.Items.AddRange(new object[] {
            "NOTE_D1",
            "NOTE_Eb1",
            "NOTE_E1",
            "NOTE_F1",
            "NOTE_Gb1",
            "NOTE_G1",
            "NOTE_Ab1",
            "NOTE_A1",
            "NOTE_Bb1",
            "NOTE_B1",
            "NOTE_C2",
            "NOTE_Db2",
            "NOTE_D2",
            "NOTE_Eb2",
            "NOTE_E2",
            "NOTE_F2",
            "NOTE_Gb2",
            "NOTE_G2",
            "NOTE_Ab2",
            "NOTE_A2",
            "NOTE_Bb2",
            "NOTE_B2",
            "NOTE_C3",
            "NOTE_Db3",
            "NOTE_D3",
            "NOTE_Eb3",
            "NOTE_E3",
            "NOTE_F3",
            "NOTE_Gb3",
            "NOTE_G3",
            "NOTE_Ab3",
            "NOTE_A3",
            "NOTE_Bb3",
            "NOTE_B3",
            "NOTE_C4",
            "NOTE_Db4",
            "NOTE_D4",
            "NOTE_Eb4",
            "NOTE_E4",
            "NOTE_F4",
            "NOTE_Gb4",
            "NOTE_G4",
            "NOTE_Ab4",
            "NOTE_A4",
            "NOTE_Bb4",
            "NOTE_B4",
            "NOTE_C5",
            "NOTE_Db5",
            "NOTE_D5",
            "NOTE_Eb5",
            "NOTE_E5",
            "NOTE_F5",
            "NOTE_Gb5",
            "NOTE_G5",
            "NOTE_Ab5",
            "NOTE_A5",
            "NOTE_Bb5",
            "NOTE_B5",
            "NOTE_C6",
            "NOTE_Db6",
            "NOTE_D6",
            "NOTE_Eb6",
            "NOTE_E6",
            "NOTE_F6",
            "NOTE_Gb6",
            "NOTE_G6",
            "NOTE_Ab6",
            "NOTE_A6",
            "NOTE_Bb6",
            "NOTE_B6",
            "NOTE_C7",
            "NOTE_Db7",
            "NOTE_D7",
            "NOTE_Eb7",
            "NOTE_E7",
            "NOTE_F7",
            "NOTE_Gb7",
            "NOTE_G7",
            "NOTE_Ab7",
            "NOTE_A7",
            "NOTE_Bb7",
            "NOTE_B7",
            "NOTE_C8",
            "NOTE_Db8",
            "NOTE_D8",
            "NOTE_Eb8",
            "NOTE_E8",
            "NOTE_F8",
            "NOTE_Gb8",
            "NOTE_G8",
            "NOTE_Ab8",
            "NOTE_A8",
            "NOTE_Bb8",
            "NOTE_B8"});
            this.NoteComboBox.Location = new System.Drawing.Point(238, 4);
            this.NoteComboBox.MaxDropDownItems = 12;
            this.NoteComboBox.Name = "NoteComboBox";
            this.NoteComboBox.Size = new System.Drawing.Size(133, 21);
            this.NoteComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Remember that C4 is middle C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "You can only use quarter notes when creating your song.";
            // 
            // TestNoteButton
            // 
            this.TestNoteButton.Location = new System.Drawing.Point(236, 30);
            this.TestNoteButton.Name = "TestNoteButton";
            this.TestNoteButton.Size = new System.Drawing.Size(75, 23);
            this.TestNoteButton.TabIndex = 5;
            this.TestNoteButton.Text = "Test Note";
            this.TestNoteButton.UseVisualStyleBackColor = true;
            this.TestNoteButton.Click += new System.EventHandler(this.TestNoteButton_Click);
            // 
            // AddNoteButton
            // 
            this.AddNoteButton.Location = new System.Drawing.Point(317, 30);
            this.AddNoteButton.Name = "AddNoteButton";
            this.AddNoteButton.Size = new System.Drawing.Size(75, 23);
            this.AddNoteButton.TabIndex = 6;
            this.AddNoteButton.Text = "Add Note";
            this.AddNoteButton.UseVisualStyleBackColor = true;
            this.AddNoteButton.Click += new System.EventHandler(this.AddNoteButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Edit your song here:";
            // 
            // SongMakerListBox
            // 
            this.SongMakerListBox.FormattingEnabled = true;
            this.SongMakerListBox.Location = new System.Drawing.Point(13, 85);
            this.SongMakerListBox.Name = "SongMakerListBox";
            this.SongMakerListBox.Size = new System.Drawing.Size(217, 303);
            this.SongMakerListBox.TabIndex = 8;
            // 
            // DeleteNoteButton
            // 
            this.DeleteNoteButton.Location = new System.Drawing.Point(236, 85);
            this.DeleteNoteButton.Name = "DeleteNoteButton";
            this.DeleteNoteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteNoteButton.TabIndex = 9;
            this.DeleteNoteButton.Text = "Delete Note";
            this.DeleteNoteButton.UseVisualStyleBackColor = true;
            this.DeleteNoteButton.Click += new System.EventHandler(this.DeleteNoteButton_Click);
            // 
            // TestSongButton
            // 
            this.TestSongButton.Location = new System.Drawing.Point(236, 114);
            this.TestSongButton.Name = "TestSongButton";
            this.TestSongButton.Size = new System.Drawing.Size(75, 23);
            this.TestSongButton.TabIndex = 10;
            this.TestSongButton.Text = "Test Song";
            this.TestSongButton.UseVisualStyleBackColor = true;
            this.TestSongButton.Click += new System.EventHandler(this.TestSongButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name your song:";
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(236, 251);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 12;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(329, 235);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 13;
            this.NameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(489, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Here are your created songs:";
            // 
            // SortSongsButton
            // 
            this.SortSongsButton.Location = new System.Drawing.Point(639, 22);
            this.SortSongsButton.Name = "SortSongsButton";
            this.SortSongsButton.Size = new System.Drawing.Size(75, 23);
            this.SortSongsButton.TabIndex = 17;
            this.SortSongsButton.Text = "Sort Songs";
            this.SortSongsButton.UseVisualStyleBackColor = true;
            this.SortSongsButton.Click += new System.EventHandler(this.SortSongsButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(450, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Click this button to clear the form";
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Location = new System.Drawing.Point(617, 356);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(75, 23);
            this.ClearAllButton.TabIndex = 20;
            this.ClearAllButton.Text = "Clear All";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // SongDisplayListBox
            // 
            this.SongDisplayListBox.FormattingEnabled = true;
            this.SongDisplayListBox.Location = new System.Drawing.Point(492, 22);
            this.SongDisplayListBox.Name = "SongDisplayListBox";
            this.SongDisplayListBox.Size = new System.Drawing.Size(141, 134);
            this.SongDisplayListBox.TabIndex = 22;
            // 
            // DeleteSongButton
            // 
            this.DeleteSongButton.Location = new System.Drawing.Point(640, 45);
            this.DeleteSongButton.Name = "DeleteSongButton";
            this.DeleteSongButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteSongButton.TabIndex = 23;
            this.DeleteSongButton.Text = "Delete Song";
            this.DeleteSongButton.UseVisualStyleBackColor = true;
            this.DeleteSongButton.Click += new System.EventHandler(this.DeleteSongButton_Click);
            // 
            // MusicMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteSongButton);
            this.Controls.Add(this.SongDisplayListBox);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SortSongsButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TestSongButton);
            this.Controls.Add(this.DeleteNoteButton);
            this.Controls.Add(this.SongMakerListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddNoteButton);
            this.Controls.Add(this.TestNoteButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NoteComboBox);
            this.Controls.Add(this.label1);
            this.Name = "MusicMaker";
            this.Text = "Music Maker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox NoteComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button TestNoteButton;
        private System.Windows.Forms.Button AddNoteButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox SongMakerListBox;
        private System.Windows.Forms.Button DeleteNoteButton;
        private System.Windows.Forms.Button TestSongButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SortSongsButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.ListBox SongDisplayListBox;
        private System.Windows.Forms.Button DeleteSongButton;
    }
}

