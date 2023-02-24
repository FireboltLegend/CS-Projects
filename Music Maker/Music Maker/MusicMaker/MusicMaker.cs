using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicMaker
{
    public partial class MusicMaker : Form
    {
        public MusicMaker()
        {
            InitializeComponent();
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }


        private void SortSongsButton_Click(object sender, EventArgs e)
        {
            LinkedList<string> songSorted = new LinkedList<string>(SongListText.OrderBy(x => x).ToList());
            SongDisplayListBox.Items.Clear();
            //Clears out the listbox
            SongListText.Clear();
            foreach (string item in songSorted)
            //Runs through each item in the linked list SongListText and add that item to the textbox
            {
                //Adds the item from SongListText into the textbox and creates a new line in the textbox
                SongListText.AddLast(item);
            }
            DisplaySong();
        }
        static LinkedList<int> song = new LinkedList<int>();
        //Initializes linked list song that will contain the frequencies of the song the user is making
        LinkedList<string> songnotes = new LinkedList<string>();
        //Initializes linked list songnotes that will contain the name of the corresponding notes in song linked list in the SongMakerListBox
        LinkedList<string> SongListText = new LinkedList<string>();
        //Initializes linked list SongListText that will contain the name of the songs created
        void DisplayList()
        //function DisplayList() checks the linked list and updates the listbox to the correct items in songnotes
        {
            NoteComboBox.Text = "";
            //Clears out any text in the textbox
            SongMakerListBox.Items.Clear();
            //Clears out the listbox
            foreach (string item in songnotes)
            //Runs through each item in the linked list songnotes and add that item to the listbox
            {
                SongMakerListBox.Items.Add(item);
                //Adds the item from songnotes into the listbox
            }
        }
        void DisplaySong()
        //function DisplaySong() checks the linked list and updates the listbox to the correct items in songnotes
        {
            SongDisplayListBox.Items.Clear();
            //Clears out the listbox
            foreach (string item in SongListText)
            //Runs through each item in the linked list SongListText and add that item to the textbox
            {
                SongDisplayListBox.Items.Add(item);
                //Adds the item from SongListText into the textbox and creates a new line in the textbox
            }
        }
        class Note
        {
            public static string NoteString;
            //Initializes string named NoteString
            //The code below initializes 8 octaves of frequencies
            public static int NOTE_D1 = 37;
            public static int NOTE_Eb1 = 39;
            public static int NOTE_E1 = 41;
            public static int NOTE_F1 = 44;
            public static int NOTE_Gb1 = 46;
            public static int NOTE_G1 = 49;
            public static int NOTE_Ab1 = 52;
            public static int NOTE_A1 = 55;
            public static int NOTE_Bb1 = 58;
            public static int NOTE_B1 = 62;
            public static int NOTE_C2 = 65;
            public static int NOTE_Db2 = 69;
            public static int NOTE_D2 = 73;
            public static int NOTE_Eb2 = 78;
            public static int NOTE_E2 = 82;
            public static int NOTE_F2 = 87;
            public static int NOTE_Gb2 = 93;
            public static int NOTE_G2 = 98;
            public static int NOTE_Ab2 = 104;
            public static int NOTE_A2 = 110;
            public static int NOTE_Bb2 = 117;
            public static int NOTE_B2 = 123;
            public static int NOTE_C3 = 131;
            public static int NOTE_Db3 = 139;
            public static int NOTE_D3 = 147;
            public static int NOTE_Eb3 = 156;
            public static int NOTE_E3 = 165;
            public static int NOTE_F3 = 175;
            public static int NOTE_Gb3 = 185;
            public static int NOTE_G3 = 196;
            public static int NOTE_Ab3 = 208;
            public static int NOTE_A3 = 220;
            public static int NOTE_Bb3 = 233;
            public static int NOTE_B3 = 247;
            public static int NOTE_C4 = 262;
            public static int NOTE_Db4 = 277;
            public static int NOTE_D4 = 294;
            public static int NOTE_Eb4 = 311;
            public static int NOTE_E4 = 330;
            public static int NOTE_F4 = 349;
            public static int NOTE_Gb4 = 370;
            public static int NOTE_G4 = 392;
            public static int NOTE_Ab4 = 415;
            public static int NOTE_A4 = 440;
            public static int NOTE_Bb4 = 466;
            public static int NOTE_B4 = 494;
            public static int NOTE_C5 = 523;
            public static int NOTE_Db5 = 554;
            public static int NOTE_D5 = 587;
            public static int NOTE_Eb5 = 622;
            public static int NOTE_E5 = 659;
            public static int NOTE_F5 = 698;
            public static int NOTE_Gb5 = 740;
            public static int NOTE_G5 = 784;
            public static int NOTE_Ab5 = 831;
            public static int NOTE_A5 = 880;
            public static int NOTE_Bb5 = 932;
            public static int NOTE_B5 = 988;
            public static int NOTE_C6 = 1047;
            public static int NOTE_Db6 = 1109;
            public static int NOTE_D6 = 1175;
            public static int NOTE_Eb6 = 1245;
            public static int NOTE_E6 = 1319;
            public static int NOTE_F6 = 1397;
            public static int NOTE_Gb6 = 1480;
            public static int NOTE_G6 = 1568;
            public static int NOTE_Ab6 = 1661;
            public static int NOTE_A6 = 1760;
            public static int NOTE_Bb6 = 1865;
            public static int NOTE_B6 = 1976;
            public static int NOTE_C7 = 2093;
            public static int NOTE_Db7 = 2217;
            public static int NOTE_D7 = 2349;
            public static int NOTE_Eb7 = 2489;
            public static int NOTE_E7 = 2637;
            public static int NOTE_F7 = 2794;
            public static int NOTE_Gb7 = 2960;
            public static int NOTE_G7 = 3136;
            public static int NOTE_Ab7 = 3322;
            public static int NOTE_A7 = 3520;
            public static int NOTE_Bb7 = 3729;
            public static int NOTE_B7 = 3951;
            public static int NOTE_C8 = 4186;
            public static int NOTE_Db8 = 4435;
            public static int NOTE_D8 = 4699;
            public static int NOTE_Eb8 = 4978;
            public static int NOTE_E8 = 5274;
            public static int NOTE_F8 = 5588;
            public static int NOTE_Gb8 = 5920;
            public static int NOTE_G8 = 6272;
            public static int NOTE_Ab8 = 6645;
            public static int NOTE_A8 = 7040;
            public static int NOTE_Bb8 = 7459;
            public static int NOTE_B8 = 7902;
            public static int Frequency;
            //Initializes the Frequency variable which will hold the frequency that is to be beeped to the user
            public static int Duration = 400;
            //Duration is set to 400 to make the user only able to play quarter notes
            public static int TestDuration = 1600;
            //When the test note button is pressed, the note will play as a whole note to allow the user to here what the note sounds like
        }
        class Song
        {
            public static void AddNote(int frequency)
            {
                song.AddLast(frequency);
                //Adds a frequency the user chose to the linked list
            }
            public static void DeleteNote(int frequency)
            {
                song.Remove(frequency);
                //Removes a frequency the user chose from the linked list
            }
            public static void Play()
            {
                foreach (int note in song)
                //Iterates through each frequency in the song
                {
                    Console.Beep(note, Note.Duration);
                    //Beeps the note for a quarter note length
                }
            }
        }

        private void TestNoteButton_Click(object sender, EventArgs e)
        //This event handler function checks what the user inputted into the combo box and sets that to Note.Frequency variable
        {
            if (NoteComboBox.Text == "NOTE_D1")
            {
                Note.Frequency = Note.NOTE_D1;
            }
            else if (NoteComboBox.Text == "NOTE_Eb1")
            {
                Note.Frequency = Note.NOTE_Eb1;
            }
            else if (NoteComboBox.Text == "NOTE_E1")
            {
                Note.Frequency = Note.NOTE_E1;
            }
            else if (NoteComboBox.Text == "NOTE_F1")
            {
                Note.Frequency = Note.NOTE_F1;
            }
            else if (NoteComboBox.Text == "NOTE_Gb1")
            {
                Note.Frequency = Note.NOTE_Gb1;
            }
            else if (NoteComboBox.Text == "NOTE_G1")
            {
                Note.Frequency = Note.NOTE_G1;
            }
            else if (NoteComboBox.Text == "NOTE_Ab1")
            {
                Note.Frequency = Note.NOTE_Ab1;
            }
            else if (NoteComboBox.Text == "NOTE_A1")
            {
                Note.Frequency = Note.NOTE_A1;
            }
            else if (NoteComboBox.Text == "NOTE_Bb1")
            {
                Note.Frequency = Note.NOTE_Bb1;
            }
            else if (NoteComboBox.Text == "NOTE_B1")
            {
                Note.Frequency = Note.NOTE_B1;
            }
            else if (NoteComboBox.Text == "NOTE_C2")
            {
                Note.Frequency = Note.NOTE_C2;
            }
            else if (NoteComboBox.Text == "NOTE_Db2")
            {
                Note.Frequency = Note.NOTE_Db2;
            }
            else if (NoteComboBox.Text == "NOTE_D2")
            {
                Note.Frequency = Note.NOTE_D2;
            }
            else if (NoteComboBox.Text == "NOTE_Eb2")
            {
                Note.Frequency = Note.NOTE_Eb2;
            }
            else if (NoteComboBox.Text == "NOTE_E2")
            {
                Note.Frequency = Note.NOTE_E2;
            }
            else if (NoteComboBox.Text == "NOTE_F2")
            {
                Note.Frequency = Note.NOTE_F2;
            }
            else if (NoteComboBox.Text == "NOTE_Gb2")
            {
                Note.Frequency = Note.NOTE_Gb2;
            }
            else if (NoteComboBox.Text == "NOTE_G2")
            {
                Note.Frequency = Note.NOTE_G2;
            }
            else if (NoteComboBox.Text == "NOTE_Ab2")
            {
                Note.Frequency = Note.NOTE_Ab2;
            }
            else if (NoteComboBox.Text == "NOTE_A2")
            {
                Note.Frequency = Note.NOTE_A2;
            }
            else if (NoteComboBox.Text == "NOTE_Bb2")
            {
                Note.Frequency = Note.NOTE_Bb2;
            }
            else if (NoteComboBox.Text == "NOTE_B2")
            {
                Note.Frequency = Note.NOTE_B2;
            }
            else if (NoteComboBox.Text == "NOTE_C3")
            {
                Note.Frequency = Note.NOTE_C3;
            }
            else if (NoteComboBox.Text == "NOTE_Db3")
            {
                Note.Frequency = Note.NOTE_Db3;
            }
            else if (NoteComboBox.Text == "NOTE_D3")
            {
                Note.Frequency = Note.NOTE_D3;
            }
            else if (NoteComboBox.Text == "NOTE_Eb3")
            {
                Note.Frequency = Note.NOTE_Eb3;
            }
            else if (NoteComboBox.Text == "NOTE_E3")
            {
                Note.Frequency = Note.NOTE_E3;
            }
            else if (NoteComboBox.Text == "NOTE_F3")
            {
                Note.Frequency = Note.NOTE_F3;
            }
            else if (NoteComboBox.Text == "NOTE_Gb3")
            {
                Note.Frequency = Note.NOTE_Gb3;
            }
            else if (NoteComboBox.Text == "NOTE_G3")
            {
                Note.Frequency = Note.NOTE_G3;
            }
            else if (NoteComboBox.Text == "NOTE_Ab3")
            {
                Note.Frequency = Note.NOTE_Ab3;
            }
            else if (NoteComboBox.Text == "NOTE_A3")
            {
                Note.Frequency = Note.NOTE_A3;
            }
            else if (NoteComboBox.Text == "NOTE_Bb3")
            {
                Note.Frequency = Note.NOTE_Bb3;
            }
            else if (NoteComboBox.Text == "NOTE_B3")
            {
                Note.Frequency = Note.NOTE_B3;
            }
            else if (NoteComboBox.Text == "NOTE_C4")
            {
                Note.Frequency = Note.NOTE_C4;
            }
            else if (NoteComboBox.Text == "NOTE_Db4")
            {
                Note.Frequency = Note.NOTE_Db4;
            }
            else if (NoteComboBox.Text == "NOTE_D4")
            {
                Note.Frequency = Note.NOTE_D4;
            }
            else if (NoteComboBox.Text == "NOTE_Eb4")
            {
                Note.Frequency = Note.NOTE_Eb4;
            }
            else if (NoteComboBox.Text == "NOTE_E4")
            {
                Note.Frequency = Note.NOTE_E4;
            }
            else if (NoteComboBox.Text == "NOTE_F4")
            {
                Note.Frequency = Note.NOTE_F4;
            }
            else if (NoteComboBox.Text == "NOTE_Gb4")
            {
                Note.Frequency = Note.NOTE_Gb4;
            }
            else if (NoteComboBox.Text == "NOTE_G4")
            {
                Note.Frequency = Note.NOTE_G4;
            }
            else if (NoteComboBox.Text == "NOTE_Ab4")
            {
                Note.Frequency = Note.NOTE_Ab4;
            }
            else if (NoteComboBox.Text == "NOTE_A4")
            {
                Note.Frequency = Note.NOTE_A4;
            }
            else if (NoteComboBox.Text == "NOTE_Bb4")
            {
                Note.Frequency = Note.NOTE_Bb4;
            }
            else if (NoteComboBox.Text == "NOTE_B4")
            {
                Note.Frequency = Note.NOTE_B4;
            }
            else if (NoteComboBox.Text == "NOTE_C5")
            {
                Note.Frequency = Note.NOTE_C5;
            }
            else if (NoteComboBox.Text == "NOTE_Db5")
            {
                Note.Frequency = Note.NOTE_Db5;
            }
            else if (NoteComboBox.Text == "NOTE_D5")
            {
                Note.Frequency = Note.NOTE_D5;
            }
            else if (NoteComboBox.Text == "NOTE_Eb5")
            {
                Note.Frequency = Note.NOTE_Eb5;
            }
            else if (NoteComboBox.Text == "NOTE_E5")
            {
                Note.Frequency = Note.NOTE_E5;
            }
            else if (NoteComboBox.Text == "NOTE_F5")
            {
                Note.Frequency = Note.NOTE_F5;
            }
            else if (NoteComboBox.Text == "NOTE_Gb5")
            {
                Note.Frequency = Note.NOTE_Gb5;
            }
            else if (NoteComboBox.Text == "NOTE_G5")
            {
                Note.Frequency = Note.NOTE_G5;
            }
            else if (NoteComboBox.Text == "NOTE_Ab5")
            {
                Note.Frequency = Note.NOTE_Ab5;
            }
            else if (NoteComboBox.Text == "NOTE_A5")
            {
                Note.Frequency = Note.NOTE_A5;
            }
            else if (NoteComboBox.Text == "NOTE_Bb5")
            {
                Note.Frequency = Note.NOTE_Bb5;
            }
            else if (NoteComboBox.Text == "NOTE_B5")
            {
                Note.Frequency = Note.NOTE_B5;
            }
            else if (NoteComboBox.Text == "NOTE_C6")
            {
                Note.Frequency = Note.NOTE_C6;
            }
            else if (NoteComboBox.Text == "NOTE_Db6")
            {
                Note.Frequency = Note.NOTE_Db6;
            }
            else if (NoteComboBox.Text == "NOTE_D6")
            {
                Note.Frequency = Note.NOTE_D6;
            }
            else if (NoteComboBox.Text == "NOTE_Eb6")
            {
                Note.Frequency = Note.NOTE_Eb6;
            }
            else if (NoteComboBox.Text == "NOTE_E6")
            {
                Note.Frequency = Note.NOTE_E6;
            }
            else if (NoteComboBox.Text == "NOTE_F6")
            {
                Note.Frequency = Note.NOTE_F6;
            }
            else if (NoteComboBox.Text == "NOTE_Gb6")
            {
                Note.Frequency = Note.NOTE_Gb6;
            }
            else if (NoteComboBox.Text == "NOTE_G6")
            {
                Note.Frequency = Note.NOTE_G6;
            }
            else if (NoteComboBox.Text == "NOTE_Ab6")
            {
                Note.Frequency = Note.NOTE_Ab6;
            }
            else if (NoteComboBox.Text == "NOTE_A6")
            {
                Note.Frequency = Note.NOTE_A6;
            }
            else if (NoteComboBox.Text == "NOTE_Bb6")
            {
                Note.Frequency = Note.NOTE_Bb6;
            }
            else if (NoteComboBox.Text == "NOTE_B6")
            {
                Note.Frequency = Note.NOTE_B6;
            }
            else if (NoteComboBox.Text == "NOTE_C7")
            {
                Note.Frequency = Note.NOTE_C7;
            }
            else if (NoteComboBox.Text == "NOTE_Db7")
            {
                Note.Frequency = Note.NOTE_Db7;
            }
            else if (NoteComboBox.Text == "NOTE_D7")
            {
                Note.Frequency = Note.NOTE_D7;
            }
            else if (NoteComboBox.Text == "NOTE_Eb7")
            {
                Note.Frequency = Note.NOTE_Eb7;
            }
            else if (NoteComboBox.Text == "NOTE_E7")
            {
                Note.Frequency = Note.NOTE_E7;
            }
            else if (NoteComboBox.Text == "NOTE_F7")
            {
                Note.Frequency = Note.NOTE_F7;
            }
            else if (NoteComboBox.Text == "NOTE_Gb7")
            {
                Note.Frequency = Note.NOTE_Gb7;
            }
            else if (NoteComboBox.Text == "NOTE_G7")
            {
                Note.Frequency = Note.NOTE_G7;
            }
            else if (NoteComboBox.Text == "NOTE_Ab7")
            {
                Note.Frequency = Note.NOTE_Ab7;
            }
            else if (NoteComboBox.Text == "NOTE_A7")
            {
                Note.Frequency = Note.NOTE_A7;
            }
            else if (NoteComboBox.Text == "NOTE_Bb7")
            {
                Note.Frequency = Note.NOTE_Bb7;
            }
            else if (NoteComboBox.Text == "NOTE_B7")
            {
                Note.Frequency = Note.NOTE_B7;
            }
            else if (NoteComboBox.Text == "NOTE_C8")
            {
                Note.Frequency = Note.NOTE_C8;
            }
            else if (NoteComboBox.Text == "NOTE_Db8")
            {
                Note.Frequency = Note.NOTE_Db8;
            }
            else if (NoteComboBox.Text == "NOTE_D8")
            {
                Note.Frequency = Note.NOTE_D8;
            }
            else if (NoteComboBox.Text == "NOTE_Eb8")
            {
                Note.Frequency = Note.NOTE_Eb8;
            }
            else if (NoteComboBox.Text == "NOTE_E8")
            {
                Note.Frequency = Note.NOTE_E8;
            }
            else if (NoteComboBox.Text == "NOTE_F8")
            {
                Note.Frequency = Note.NOTE_F8;
            }
            else if (NoteComboBox.Text == "NOTE_Gb8")
            {
                Note.Frequency = Note.NOTE_Gb8;
            }
            else if (NoteComboBox.Text == "NOTE_G8")
            {
                Note.Frequency = Note.NOTE_G8;
            }
            else if (NoteComboBox.Text == "NOTE_Ab8")
            {
                Note.Frequency = Note.NOTE_Ab8;
            }
            else if (NoteComboBox.Text == "NOTE_A8")
            {
                Note.Frequency = Note.NOTE_A8;
            }
            else if (NoteComboBox.Text == "NOTE_Bb8")
            {
                Note.Frequency = Note.NOTE_Bb8;
            }
            else if (NoteComboBox.Text == "NOTE_B8")
            {
                Note.Frequency = Note.NOTE_B8;
            }
            else
            //Error checking: if the user did not select a frequency, a message box will appear prompting the user to enter a frequency
            {
                MessageBox.Show("Please select a note.");
            }
            if (NoteComboBox.Text != "")
            //Checks if frequency is selected in NoteComboBox
            {
                Console.Beep(Note.Frequency, Note.TestDuration);
                //Beeps the note the user selected so the user can decide if he wants to add that note into his/her program
            }
        }

        private void AddNoteButton_Click(object sender, EventArgs e)
        //This event handler function checks what the user inputted into the combo box and sets that to Note.Frequency variable
        //It will also set the Note.NoteString variable to the matching string to be displayed in SongMakerListBox
        {
            if (NoteComboBox.Text == "NOTE_D1")
            {
                Note.Frequency = Note.NOTE_D1;
                Note.NoteString = "NOTE_D1";
            }
            else if (NoteComboBox.Text == "NOTE_Eb1")
            {
                Note.Frequency = Note.NOTE_Eb1;
                Note.NoteString = "NOTE_Eb1";
            }
            else if (NoteComboBox.Text == "NOTE_E1")
            {
                Note.Frequency = Note.NOTE_E1;
                Note.NoteString = "NOTE_E1";
            }
            else if (NoteComboBox.Text == "NOTE_F1")
            {
                Note.Frequency = Note.NOTE_F1;
                Note.NoteString = "NOTE_F1";
            }
            else if (NoteComboBox.Text == "NOTE_Gb1")
            {
                Note.Frequency = Note.NOTE_Gb1;
                Note.NoteString = "NOTE_Gb1";
            }
            else if (NoteComboBox.Text == "NOTE_G1")
            {
                Note.Frequency = Note.NOTE_G1;
                Note.NoteString = "NOTE_G1";
            }
            else if (NoteComboBox.Text == "NOTE_Ab1")
            {
                Note.Frequency = Note.NOTE_Ab1;
                Note.NoteString = "NOTE_Ab1";
            }
            else if (NoteComboBox.Text == "NOTE_A1")
            {
                Note.Frequency = Note.NOTE_A1;
                Note.NoteString = "NOTE_A1";
            }
            else if (NoteComboBox.Text == "NOTE_Bb1")
            {
                Note.Frequency = Note.NOTE_Bb1;
                Note.NoteString = "NOTE_Bb1";
            }
            else if (NoteComboBox.Text == "NOTE_B1")
            {
                Note.Frequency = Note.NOTE_B1;
                Note.NoteString = "NOTE_B1";
            }
            else if (NoteComboBox.Text == "NOTE_C2")
            {
                Note.Frequency = Note.NOTE_C2;
                Note.NoteString = "NOTE_C2";
            }
            else if (NoteComboBox.Text == "NOTE_Db2")
            {
                Note.Frequency = Note.NOTE_Db2;
                Note.NoteString = "NOTE_Db2";
            }
            else if (NoteComboBox.Text == "NOTE_D2")
            {
                Note.Frequency = Note.NOTE_D2;
                Note.NoteString = "NOTE_D2";
            }
            else if (NoteComboBox.Text == "NOTE_Eb2")
            {
                Note.Frequency = Note.NOTE_Eb2;
                Note.NoteString = "NOTE_Eb2";
            }
            else if (NoteComboBox.Text == "NOTE_E2")
            {
                Note.Frequency = Note.NOTE_E2;
                Note.NoteString = "NOTE_E2";
            }
            else if (NoteComboBox.Text == "NOTE_F2")
            {
                Note.Frequency = Note.NOTE_F2;
                Note.NoteString = "NOTE_F2";
            }
            else if (NoteComboBox.Text == "NOTE_Gb2")
            {
                Note.Frequency = Note.NOTE_Gb2;
                Note.NoteString = "NOTE_Gb2";
            }
            else if (NoteComboBox.Text == "NOTE_G2")
            {
                Note.Frequency = Note.NOTE_G2;
                Note.NoteString = "NOTE_G2";
            }
            else if (NoteComboBox.Text == "NOTE_Ab2")
            {
                Note.Frequency = Note.NOTE_Ab2;
                Note.NoteString = "NOTE_Ab2";
            }
            else if (NoteComboBox.Text == "NOTE_A2")
            {
                Note.Frequency = Note.NOTE_A2;
                Note.NoteString = "NOTE_A2";
            }
            else if (NoteComboBox.Text == "NOTE_Bb2")
            {
                Note.Frequency = Note.NOTE_Bb2;
                Note.NoteString = "NOTE_Bb2";
            }
            else if (NoteComboBox.Text == "NOTE_B2")
            {
                Note.Frequency = Note.NOTE_B2;
                Note.NoteString = "NOTE_B2";
            }
            else if (NoteComboBox.Text == "NOTE_C3")
            {
                Note.Frequency = Note.NOTE_C3;
                Note.NoteString = "NOTE_C3";
            }
            else if (NoteComboBox.Text == "NOTE_Db3")
            {
                Note.Frequency = Note.NOTE_Db3;
                Note.NoteString = "NOTE_Db3";
            }
            else if (NoteComboBox.Text == "NOTE_D3")
            {
                Note.Frequency = Note.NOTE_D3;
                Note.NoteString = "NOTE_D3";
            }
            else if (NoteComboBox.Text == "NOTE_Eb3")
            {
                Note.Frequency = Note.NOTE_Eb3;
                Note.NoteString = "NOTE_Eb3";
            }
            else if (NoteComboBox.Text == "NOTE_E3")
            {
                Note.Frequency = Note.NOTE_E3;
                Note.NoteString = "NOTE_E3";
            }
            else if (NoteComboBox.Text == "NOTE_F3")
            {
                Note.Frequency = Note.NOTE_F3;
                Note.NoteString = "NOTE_F3";
            }
            else if (NoteComboBox.Text == "NOTE_Gb3")
            {
                Note.Frequency = Note.NOTE_Gb3;
                Note.NoteString = "NOTE_Gb3";
            }
            else if (NoteComboBox.Text == "NOTE_G3")
            {
                Note.Frequency = Note.NOTE_G3;
                Note.NoteString = "NOTE_G3";
            }
            else if (NoteComboBox.Text == "NOTE_Ab3")
            {
                Note.Frequency = Note.NOTE_Ab3;
                Note.NoteString = "NOTE_Ab3";
            }
            else if (NoteComboBox.Text == "NOTE_A3")
            {
                Note.Frequency = Note.NOTE_A3;
                Note.NoteString = "NOTE_A3";
            }
            else if (NoteComboBox.Text == "NOTE_Bb3")
            {
                Note.Frequency = Note.NOTE_Bb3;
                Note.NoteString = "NOTE_Bb3";
            }
            else if (NoteComboBox.Text == "NOTE_B3")
            {
                Note.Frequency = Note.NOTE_B3;
                Note.NoteString = "NOTE_B3";
            }
            else if (NoteComboBox.Text == "NOTE_C4")
            {
                Note.Frequency = Note.NOTE_C4;
                Note.NoteString = "NOTE_C4";
            }
            else if (NoteComboBox.Text == "NOTE_Db4")
            {
                Note.Frequency = Note.NOTE_Db4;
                Note.NoteString = "NOTE_Db4";
            }
            else if (NoteComboBox.Text == "NOTE_D4")
            {
                Note.Frequency = Note.NOTE_D4;
                Note.NoteString = "NOTE_D4";
            }
            else if (NoteComboBox.Text == "NOTE_Eb4")
            {
                Note.Frequency = Note.NOTE_Eb4;
                Note.NoteString = "NOTE_Eb4";
            }
            else if (NoteComboBox.Text == "NOTE_E4")
            {
                Note.Frequency = Note.NOTE_E4;
                Note.NoteString = "NOTE_E4";
            }
            else if (NoteComboBox.Text == "NOTE_F4")
            {
                Note.Frequency = Note.NOTE_F4;
                Note.NoteString = "NOTE_F4";
            }
            else if (NoteComboBox.Text == "NOTE_Gb4")
            {
                Note.Frequency = Note.NOTE_Gb4;
                Note.NoteString = "NOTE_Gb4";
            }
            else if (NoteComboBox.Text == "NOTE_G4")
            {
                Note.Frequency = Note.NOTE_G4;
                Note.NoteString = "NOTE_G4";
            }
            else if (NoteComboBox.Text == "NOTE_Ab4")
            {
                Note.Frequency = Note.NOTE_Ab4;
                Note.NoteString = "NOTE_Ab4";
            }
            else if (NoteComboBox.Text == "NOTE_A4")
            {
                Note.Frequency = Note.NOTE_A4;
                Note.NoteString = "NOTE_A4";
            }
            else if (NoteComboBox.Text == "NOTE_Bb4")
            {
                Note.Frequency = Note.NOTE_Bb4;
                Note.NoteString = "NOTE_Bb4";
            }
            else if (NoteComboBox.Text == "NOTE_B4")
            {
                Note.Frequency = Note.NOTE_B4;
                Note.NoteString = "NOTE_B4";
            }
            else if (NoteComboBox.Text == "NOTE_C5")
            {
                Note.Frequency = Note.NOTE_C5;
                Note.NoteString = "NOTE_C5";
            }
            else if (NoteComboBox.Text == "NOTE_Db5")
            {
                Note.Frequency = Note.NOTE_Db5;
                Note.NoteString = "NOTE_Db5";
            }
            else if (NoteComboBox.Text == "NOTE_D5")
            {
                Note.Frequency = Note.NOTE_D5;
                Note.NoteString = "NOTE_D5";
            }
            else if (NoteComboBox.Text == "NOTE_Eb5")
            {
                Note.Frequency = Note.NOTE_Eb5;
                Note.NoteString = "NOTE_Eb5";
            }
            else if (NoteComboBox.Text == "NOTE_E5")
            {
                Note.Frequency = Note.NOTE_E5;
                Note.NoteString = "NOTE_E5";
            }
            else if (NoteComboBox.Text == "NOTE_F5")
            {
                Note.Frequency = Note.NOTE_F5;
                Note.NoteString = "NOTE_F5";
            }
            else if (NoteComboBox.Text == "NOTE_Gb5")
            {
                Note.Frequency = Note.NOTE_Gb5;
                Note.NoteString = "NOTE_Gb5";
            }
            else if (NoteComboBox.Text == "NOTE_G5")
            {
                Note.Frequency = Note.NOTE_G5;
                Note.NoteString = "NOTE_G5";
            }
            else if (NoteComboBox.Text == "NOTE_Ab5")
            {
                Note.Frequency = Note.NOTE_Ab5;
                Note.NoteString = "NOTE_Ab5";
            }
            else if (NoteComboBox.Text == "NOTE_A5")
            {
                Note.Frequency = Note.NOTE_A5;
                Note.NoteString = "NOTE_A5";
            }
            else if (NoteComboBox.Text == "NOTE_Bb5")
            {
                Note.Frequency = Note.NOTE_Bb5;
                Note.NoteString = "NOTE_Bb5";
            }
            else if (NoteComboBox.Text == "NOTE_B5")
            {
                Note.Frequency = Note.NOTE_B5;
                Note.NoteString = "NOTE_B5";
            }
            else if (NoteComboBox.Text == "NOTE_C6")
            {
                Note.Frequency = Note.NOTE_C6;
                Note.NoteString = "NOTE_C6";
            }
            else if (NoteComboBox.Text == "NOTE_Db6")
            {
                Note.Frequency = Note.NOTE_Db6;
                Note.NoteString = "NOTE_Db6";
            }
            else if (NoteComboBox.Text == "NOTE_D6")
            {
                Note.Frequency = Note.NOTE_D6;
                Note.NoteString = "NOTE_D6";
            }
            else if (NoteComboBox.Text == "NOTE_Eb6")
            {
                Note.Frequency = Note.NOTE_Eb6;
                Note.NoteString = "NOTE_Eb6";
            }
            else if (NoteComboBox.Text == "NOTE_E6")
            {
                Note.Frequency = Note.NOTE_E6;
                Note.NoteString = "NOTE_E6";
            }
            else if (NoteComboBox.Text == "NOTE_F6")
            {
                Note.Frequency = Note.NOTE_F6;
                Note.NoteString = "NOTE_F6";
            }
            else if (NoteComboBox.Text == "NOTE_Gb6")
            {
                Note.Frequency = Note.NOTE_Gb6;
                Note.NoteString = "NOTE_Gb6";
            }
            else if (NoteComboBox.Text == "NOTE_G6")
            {
                Note.Frequency = Note.NOTE_G6;
                Note.NoteString = "NOTE_G6";
            }
            else if (NoteComboBox.Text == "NOTE_Ab6")
            {
                Note.Frequency = Note.NOTE_Ab6;
                Note.NoteString = "NOTE_Ab6";
            }
            else if (NoteComboBox.Text == "NOTE_A6")
            {
                Note.Frequency = Note.NOTE_A6;
                Note.NoteString = "NOTE_A6";
            }
            else if (NoteComboBox.Text == "NOTE_Bb6")
            {
                Note.Frequency = Note.NOTE_Bb6;
                Note.NoteString = "NOTE_Bb6";
            }
            else if (NoteComboBox.Text == "NOTE_B6")
            {
                Note.Frequency = Note.NOTE_B6;
                Note.NoteString = "NOTE_B6";
            }
            else if (NoteComboBox.Text == "NOTE_C7")
            {
                Note.Frequency = Note.NOTE_C7;
                Note.NoteString = "NOTE_C7";
            }
            else if (NoteComboBox.Text == "NOTE_Db7")
            {
                Note.Frequency = Note.NOTE_Db7;
                Note.NoteString = "NOTE_Db7";
            }
            else if (NoteComboBox.Text == "NOTE_D7")
            {
                Note.Frequency = Note.NOTE_D7;
                Note.NoteString = "NOTE_D7";
            }
            else if (NoteComboBox.Text == "NOTE_Eb7")
            {
                Note.Frequency = Note.NOTE_Eb7;
                Note.NoteString = "NOTE_Eb7";
            }
            else if (NoteComboBox.Text == "NOTE_E7")
            {
                Note.Frequency = Note.NOTE_E7;
                Note.NoteString = "NOTE_E7";
            }
            else if (NoteComboBox.Text == "NOTE_F7")
            {
                Note.Frequency = Note.NOTE_F7;
                Note.NoteString = "NOTE_F7";
            }
            else if (NoteComboBox.Text == "NOTE_Gb7")
            {
                Note.Frequency = Note.NOTE_Gb7;
                Note.NoteString = "NOTE_Gb7";
            }
            else if (NoteComboBox.Text == "NOTE_G7")
            {
                Note.Frequency = Note.NOTE_G7;
                Note.NoteString = "NOTE_G7";
            }
            else if (NoteComboBox.Text == "NOTE_Ab7")
            {
                Note.Frequency = Note.NOTE_Ab7;
                Note.NoteString = "NOTE_Ab7";
            }
            else if (NoteComboBox.Text == "NOTE_A7")
            {
                Note.Frequency = Note.NOTE_A7;
                Note.NoteString = "NOTE_A7";
            }
            else if (NoteComboBox.Text == "NOTE_Bb7")
            {
                Note.Frequency = Note.NOTE_Bb7;
                Note.NoteString = "NOTE_Bb7";
            }
            else if (NoteComboBox.Text == "NOTE_B7")
            {
                Note.Frequency = Note.NOTE_B7;
                Note.NoteString = "NOTE_B7";
            }
            else if (NoteComboBox.Text == "NOTE_C8")
            {
                Note.Frequency = Note.NOTE_C8;
                Note.NoteString = "NOTE_C8";
            }
            else if (NoteComboBox.Text == "NOTE_Db8")
            {
                Note.Frequency = Note.NOTE_Db8;
                Note.NoteString = "NOTE_Db8";
            }
            else if (NoteComboBox.Text == "NOTE_D8")
            {
                Note.Frequency = Note.NOTE_D8;
                Note.NoteString = "NOTE_D8";
            }
            else if (NoteComboBox.Text == "NOTE_Eb8")
            {
                Note.Frequency = Note.NOTE_Eb8;
                Note.NoteString = "NOTE_Eb8";
            }
            else if (NoteComboBox.Text == "NOTE_E8")
            {
                Note.Frequency = Note.NOTE_E8;
                Note.NoteString = "NOTE_E8";
            }
            else if (NoteComboBox.Text == "NOTE_F8")
            {
                Note.Frequency = Note.NOTE_F8;
                Note.NoteString = "NOTE_F8";
            }
            else if (NoteComboBox.Text == "NOTE_Gb8")
            {
                Note.Frequency = Note.NOTE_Gb8;
                Note.NoteString = "NOTE_Gb8";
            }
            else if (NoteComboBox.Text == "NOTE_G8")
            {
                Note.Frequency = Note.NOTE_G8;
                Note.NoteString = "NOTE_G8";
            }
            else if (NoteComboBox.Text == "NOTE_Ab8")
            {
                Note.Frequency = Note.NOTE_Ab8;
                Note.NoteString = "NOTE_Ab8";
            }
            else if (NoteComboBox.Text == "NOTE_A8")
            {
                Note.Frequency = Note.NOTE_A8;
                Note.NoteString = "NOTE_A8";
            }
            else if (NoteComboBox.Text == "NOTE_Bb8")
            {
                Note.Frequency = Note.NOTE_Bb8;
                Note.NoteString = "NOTE_Bb8";
            }
            else if (NoteComboBox.Text == "NOTE_B8")
            {
                Note.Frequency = Note.NOTE_B8;
                Note.NoteString = "NOTE_B8";
            }
            else
            //Error checking: if the user did not select a frequency, a message box will appear prompting the user to enter a frequency
            {
                MessageBox.Show("Please select a note.");
            }
            if (NoteComboBox.Text != "")
            //Checks if frequency is selected in NoteComboBox
            {
                Song.AddNote(Note.Frequency);
                //Adds frequency into the song linked list
                songnotes.AddLast(Note.NoteString);
                //Adds the corresponding string into songnotes linked list
                DisplayList();
                //Displays values in songnotes
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteNoteButton_Click(object sender, EventArgs e)
        //This event handler function will check if the selected text in SongMakerListBox contains the name of the note and will remove it from songnotes linked list as well as removing the frequency from the song linked list
        {
            if (SongMakerListBox.Text.Contains("D1") == true)
            {
                Song.DeleteNote(Note.NOTE_D1);
            }
            else if (SongMakerListBox.Text.Contains("Eb1") == true)
            {
                Song.DeleteNote(Note.NOTE_Eb1);
            }
            else if (SongMakerListBox.Text.Contains("E1") == true)
            {
                Song.DeleteNote(Note.NOTE_E1);
            }
            else if (SongMakerListBox.Text.Contains("F1") == true)
            {
                Song.DeleteNote(Note.NOTE_F1);
            }
            else if (SongMakerListBox.Text.Contains("Gb1") == true)
            {
                Song.DeleteNote(Note.NOTE_Gb1);
            }
            else if (SongMakerListBox.Text.Contains("G1") == true)
            {
                Song.DeleteNote(Note.NOTE_G1);
            }
            else if (SongMakerListBox.Text.Contains("Ab1") == true)
            {
                Song.DeleteNote(Note.NOTE_Ab1);
            }
            else if (SongMakerListBox.Text.Contains("A1") == true)
            {
                Song.DeleteNote(Note.NOTE_A1);
            }
            else if (SongMakerListBox.Text.Contains("Bb1") == true)
            {
                Song.DeleteNote(Note.NOTE_Bb1);
            }
            else if (SongMakerListBox.Text.Contains("B1") == true)
            {
                Song.DeleteNote(Note.NOTE_B1);
            }
            else if (SongMakerListBox.Text.Contains("C2") == true)
            {
                Song.DeleteNote(Note.NOTE_C2);
            }
            else if (SongMakerListBox.Text.Contains("Db2") == true)
            {
                Song.DeleteNote(Note.NOTE_Db2);
            }
            else if (SongMakerListBox.Text.Contains("D2") == true)
            {
                Song.DeleteNote(Note.NOTE_D2);
            }
            else if (SongMakerListBox.Text.Contains("Eb2") == true)
            {
                Song.DeleteNote(Note.NOTE_Eb2);
            }
            else if (SongMakerListBox.Text.Contains("E2") == true)
            {
                Song.DeleteNote(Note.NOTE_E2);
            }
            else if (SongMakerListBox.Text.Contains("F2") == true)
            {
                Song.DeleteNote(Note.NOTE_F2);
            }
            else if (SongMakerListBox.Text.Contains("Gb2") == true)
            {
                Song.DeleteNote(Note.NOTE_Gb2);
            }
            else if (SongMakerListBox.Text.Contains("G2") == true)
            {
                Song.DeleteNote(Note.NOTE_G2);
            }
            else if (SongMakerListBox.Text.Contains("Ab2") == true)
            {
                Song.DeleteNote(Note.NOTE_Ab2);
            }
            else if (SongMakerListBox.Text.Contains("A2") == true)
            {
                Song.DeleteNote(Note.NOTE_A2);
            }
            else if (SongMakerListBox.Text.Contains("Bb2") == true)
            {
                Song.DeleteNote(Note.NOTE_Bb2);
            }
            else if (SongMakerListBox.Text.Contains("B2") == true)
            {
                Song.DeleteNote(Note.NOTE_B2);
            }
            else if (SongMakerListBox.Text.Contains("C3") == true)
            {
                Song.DeleteNote(Note.NOTE_C3);
            }
            else if (SongMakerListBox.Text.Contains("Db3") == true)
            {
                Song.DeleteNote(Note.NOTE_Db3);
            }
            else if (SongMakerListBox.Text.Contains("D3") == true)
            {
                Song.DeleteNote(Note.NOTE_D3);
            }
            else if (SongMakerListBox.Text.Contains("Eb3") == true)
            {
                Song.DeleteNote(Note.NOTE_Eb3);
            }
            else if (SongMakerListBox.Text.Contains("E3") == true)
            {
                Song.DeleteNote(Note.NOTE_E3);
            }
            else if (SongMakerListBox.Text.Contains("F3") == true)
            {
                Song.DeleteNote(Note.NOTE_F3);
            }
            else if (SongMakerListBox.Text.Contains("Gb3") == true)
            {
                Song.DeleteNote(Note.NOTE_Gb3);
            }
            else if (SongMakerListBox.Text.Contains("G3") == true)
            {
                Song.DeleteNote(Note.NOTE_G3);
            }
            else if (SongMakerListBox.Text.Contains("Ab3") == true)
            {
                Song.DeleteNote(Note.NOTE_Ab3);
            }
            else if (SongMakerListBox.Text.Contains("A3") == true)
            {
                Song.DeleteNote(Note.NOTE_A3);
            }
            else if (SongMakerListBox.Text.Contains("Bb3") == true)
            {
                Song.DeleteNote(Note.NOTE_Bb3);
            }
            else if (SongMakerListBox.Text.Contains("B3") == true)
            {
                Song.DeleteNote(Note.NOTE_B3);
            }
            else if (SongMakerListBox.Text.Contains("C4") == true)
            {
                Song.DeleteNote(Note.NOTE_C4);
            }
            else if (SongMakerListBox.Text.Contains("Db4") == true)
            {
                Song.DeleteNote(Note.NOTE_Db4);
            }
            else if (SongMakerListBox.Text.Contains("D4") == true)
            {
                Song.DeleteNote(Note.NOTE_D4);
            }
            else if (SongMakerListBox.Text.Contains("Eb4") == true)
            {
                Song.DeleteNote(Note.NOTE_Eb4);
            }
            else if (SongMakerListBox.Text.Contains("E4") == true)
            {
                Song.DeleteNote(Note.NOTE_E4);
            }
            else if (SongMakerListBox.Text.Contains("F4") == true)
            {
                Song.DeleteNote(Note.NOTE_F4);
            }
            else if (SongMakerListBox.Text.Contains("Gb4") == true)
            {
                Song.DeleteNote(Note.NOTE_Gb4);
            }
            else if (SongMakerListBox.Text.Contains("G4") == true)
            {
                Song.DeleteNote(Note.NOTE_G4);
            }
            else if (SongMakerListBox.Text.Contains("Ab4") == true)
            {
                Song.DeleteNote(Note.NOTE_Ab4);
            }
            else if (SongMakerListBox.Text.Contains("A4") == true)
            {
                Song.DeleteNote(Note.NOTE_A4);
            }
            else if (SongMakerListBox.Text.Contains("Bb4") == true)
            {
                Song.DeleteNote(Note.NOTE_Bb4);
            }
            else if (SongMakerListBox.Text.Contains("B4") == true)
            {
                Song.DeleteNote(Note.NOTE_B4);
            }
            else if (SongMakerListBox.Text.Contains("C5") == true)
            {
                Song.DeleteNote(Note.NOTE_C5);
            }
            else if (SongMakerListBox.Text.Contains("Db5") == true)
            {
                Song.DeleteNote(Note.NOTE_Db5);
            }
            else if (SongMakerListBox.Text.Contains("D5") == true)
            {
                Song.DeleteNote(Note.NOTE_D5);
            }
            else if (SongMakerListBox.Text.Contains("Eb5") == true)
            {
                Song.DeleteNote(Note.NOTE_Eb5);
            }
            else if (SongMakerListBox.Text.Contains("E5") == true)
            {
                Song.DeleteNote(Note.NOTE_E5);
            }
            else if (SongMakerListBox.Text.Contains("F5") == true)
            {
                Song.DeleteNote(Note.NOTE_F5);
            }
            else if (SongMakerListBox.Text.Contains("Gb5") == true)
            {
                Song.DeleteNote(Note.NOTE_Gb5);
            }
            else if (SongMakerListBox.Text.Contains("G5") == true)
            {
                Song.DeleteNote(Note.NOTE_G5);
            }
            else if (SongMakerListBox.Text.Contains("Ab5") == true)
            {
                Song.DeleteNote(Note.NOTE_Ab5);
            }
            else if (SongMakerListBox.Text.Contains("A5") == true)
            {
                Song.DeleteNote(Note.NOTE_A5);
            }
            else if (SongMakerListBox.Text.Contains("Bb5") == true)
            {
                Song.DeleteNote(Note.NOTE_Bb5);
            }
            else if (SongMakerListBox.Text.Contains("B5") == true)
            {
                Song.DeleteNote(Note.NOTE_B5);
            }
            else if (SongMakerListBox.Text.Contains("C6") == true)
            {
                Song.DeleteNote(Note.NOTE_C6);
            }
            else if (SongMakerListBox.Text.Contains("Db6") == true)
            {
                Song.DeleteNote(Note.NOTE_Db6);
            }
            else if (SongMakerListBox.Text.Contains("D6") == true)
            {
                Song.DeleteNote(Note.NOTE_D6);
            }
            else if (SongMakerListBox.Text.Contains("Eb6") == true)
            {
                Song.DeleteNote(Note.NOTE_Eb6);
            }
            else if (SongMakerListBox.Text.Contains("E6") == true)
            {
                Song.DeleteNote(Note.NOTE_E6);
            }
            else if (SongMakerListBox.Text.Contains("F6") == true)
            {
                Song.DeleteNote(Note.NOTE_F6);
            }
            else if (SongMakerListBox.Text.Contains("Gb6") == true)
            {
                Song.DeleteNote(Note.NOTE_Gb6);
            }
            else if (SongMakerListBox.Text.Contains("G6") == true)
            {
                Song.DeleteNote(Note.NOTE_G6);
            }
            else if (SongMakerListBox.Text.Contains("Ab6") == true)
            {
                Song.DeleteNote(Note.NOTE_Ab6);
            }
            else if (SongMakerListBox.Text.Contains("A6") == true)
            {
                Song.DeleteNote(Note.NOTE_A6);
            }
            else if (SongMakerListBox.Text.Contains("Bb6") == true)
            {
                Song.DeleteNote(Note.NOTE_Bb6);
            }
            else if (SongMakerListBox.Text.Contains("B6") == true)
            {
                Song.DeleteNote(Note.NOTE_B6);
            }
            else if (SongMakerListBox.Text.Contains("C7") == true)
            {
                Song.DeleteNote(Note.NOTE_C7);
            }
            else if (SongMakerListBox.Text.Contains("Db7") == true)
            {
                Song.DeleteNote(Note.NOTE_Db7);
            }
            else if (SongMakerListBox.Text.Contains("D7") == true)
            {
                Song.DeleteNote(Note.NOTE_D7);
            }
            else if (SongMakerListBox.Text.Contains("Eb7") == true)
            {
                Song.DeleteNote(Note.NOTE_Eb7);
            }
            else if (SongMakerListBox.Text.Contains("E7") == true)
            {
                Song.DeleteNote(Note.NOTE_E7);
            }
            else if (SongMakerListBox.Text.Contains("F7") == true)
            {
                Song.DeleteNote(Note.NOTE_F7);
            }
            else if (SongMakerListBox.Text.Contains("Gb7") == true)
            {
                Song.DeleteNote(Note.NOTE_Gb7);
            }
            else if (SongMakerListBox.Text.Contains("G7") == true)
            {
                Song.DeleteNote(Note.NOTE_G7);
            }
            else if (SongMakerListBox.Text.Contains("Ab7") == true)
            {
                Song.DeleteNote(Note.NOTE_Ab7);
            }
            else if (SongMakerListBox.Text.Contains("A7") == true)
            {
                Song.DeleteNote(Note.NOTE_A7);
            }
            else if (SongMakerListBox.Text.Contains("Bb7") == true)
            {
                Song.DeleteNote(Note.NOTE_Bb7);
            }
            else if (SongMakerListBox.Text.Contains("B7") == true)
            {
                Song.DeleteNote(Note.NOTE_B7);
            }
            else if (SongMakerListBox.Text.Contains("C8") == true)
            {
                Song.DeleteNote(Note.NOTE_C8);
            }
            else if (SongMakerListBox.Text.Contains("Db8") == true)
            {
                Song.DeleteNote(Note.NOTE_Db8);
            }
            else if (SongMakerListBox.Text.Contains("D8") == true)
            {
                Song.DeleteNote(Note.NOTE_D8);
            }
            else if (SongMakerListBox.Text.Contains("Eb8") == true)
            {
                Song.DeleteNote(Note.NOTE_Eb8);
            }
            else if (SongMakerListBox.Text.Contains("E8") == true)
            {
                Song.DeleteNote(Note.NOTE_E8);
            }
            else if (SongMakerListBox.Text.Contains("F8") == true)
            {
                Song.DeleteNote(Note.NOTE_F8);
            }
            else if (SongMakerListBox.Text.Contains("Gb8") == true)
            {
                Song.DeleteNote(Note.NOTE_Gb8);
            }
            else if (SongMakerListBox.Text.Contains("G8") == true)
            {
                Song.DeleteNote(Note.NOTE_G8);
            }
            else if (SongMakerListBox.Text.Contains("Ab8") == true)
            {
                Song.DeleteNote(Note.NOTE_Ab8);
            }
            else if (SongMakerListBox.Text.Contains("A8") == true)
            {
                Song.DeleteNote(Note.NOTE_A8);
            }
            else if (SongMakerListBox.Text.Contains("Bb8") == true)
            {
                Song.DeleteNote(Note.NOTE_Bb8);
            }
            else if (SongMakerListBox.Text.Contains("B8") == true)
            {
                Song.DeleteNote(Note.NOTE_B8);
            }
            songnotes.Remove(SongMakerListBox.Text);
            DisplayList();
        }

        private void TestSongButton_Click(object sender, EventArgs e)
        {
            Song.Play();
        }
        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (song.Count == 0)
            {
                MessageBox.Show("Enter notes into your song. You can't have a song without notes.");
            }
            else
            {
                SongListText.AddLast(NameTextBox.Text);
                DisplaySong();
                song.Clear();
                songnotes.Clear();
                DisplayList();
                NameTextBox.Text = "";
            }
        }




        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            song.Clear();
            NameTextBox.Clear();
            songnotes.Clear();
            SongListText.Clear();
            DisplayList();
            DisplaySong();
        }

        private void DeleteSongButton_Click(object sender, EventArgs e)
        {
            SongListText.Remove(SongDisplayListBox.Text);
            DisplaySong();
        }
    }
}
