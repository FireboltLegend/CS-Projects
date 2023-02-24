using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/* TeenCoder: Windows Programming
   
   Song Player Application

   Copyright 2013 CompuScholar, Inc.
*/

namespace SongPlayer
{
    public partial class SongPlayerForm : Form
    {
        // the form data consists of a list of songs
        LinkedList<Song> songs;

        // the constructor is provided complete as part of the activity starter
        public SongPlayerForm()
        {
            InitializeComponent();

            // fill out our songs array
            initializeSongs();

        }

        // This code is ADDED FOR ACTIVITY by the student
        private void initializeSongs()
        {
            songs = new LinkedList<Song>();
            Song song1 = new Song("Old McDonald");
            song1.AddNote(Note.NOTE_D4, Note.DURATION_QUARTER);
            song1.AddNote(Note.NOTE_B4, Note.DURATION_QUARTER);
            song1.AddNote(Note.NOTE_B4, Note.DURATION_QUARTER);
            song1.AddNote(Note.NOTE_B4, Note.DURATION_QUARTER);
            song1.AddNote(Note.NOTE_E4, Note.DURATION_QUARTER);
            song1.AddNote(Note.NOTE_D4, Note.DURATION_QUARTER);
            song1.AddNote(Note.NOTE_D4, Note.DURATION_QUARTER);
            song1.AddNote(Note.NOTE_E4, Note.DURATION_HALF);
            songs.AddLast(song1);
            SongListBox.Items.Add(song1.Name);
            Song song2 = new Song("Imperial March");
            song2.AddNote(Note.NOTE_Bb2, Note.DURATION_QUARTER);
            song2.AddNote(Note.NOTE_Bb2, Note.DURATION_QUARTER);
            song2.AddNote(Note.NOTE_Bb2, Note.DURATION_QUARTER);
            song2.AddNote(Note.NOTE_Gb2, Note.DURATION_DOTTED_QUARTER);
            song2.AddNote(Note.NOTE_Db3, Note.DURATION_EIGHTH);
            song2.AddNote(Note.NOTE_Bb2, Note.DURATION_QUARTER);
            song2.AddNote(Note.NOTE_Gb2, Note.DURATION_DOTTED_QUARTER);
            song2.AddNote(Note.NOTE_Db3, Note.DURATION_EIGHTH);
            song2.AddNote(Note.NOTE_Bb2, Note.DURATION_QUARTER);
            songs.AddLast(song2);
            SongListBox.Items.Add(song2.Name);
            Song song3 = new Song("Pure Imagination");
            song3.AddNote(Note.NOTE_A3, Note.DURATION_QUARTER);
            song3.AddNote(Note.NOTE_C4, Note.DURATION_QUARTER);
            song3.AddNote(Note.NOTE_G4, Note.DURATION_WHOLE_TIED_HALF);
            song3.AddNote(Note.NOTE_A3, Note.DURATION_QUARTER);
            song3.AddNote(Note.NOTE_C4, Note.DURATION_QUARTER);
            song3.AddNote(Note.NOTE_G4, Note.DURATION_WHOLE_TIED_HALF);
            song3.AddNote(Note.NOTE_A3, Note.DURATION_QUARTER);
            song3.AddNote(Note.NOTE_C4, Note.DURATION_QUARTER);
            song3.AddNote(Note.NOTE_B4, Note.DURATION_DOTTED_QUARTER);
            song3.AddNote(Note.NOTE_C5, Note.DURATION_EIGHTH);
            song3.AddNote(Note.NOTE_B4, Note.DURATION_EIGHTH);
            song3.AddNote(Note.NOTE_C5, Note.DURATION_EIGHTH);
            song3.AddNote(Note.NOTE_B4, Note.DURATION_EIGHTH);
            song3.AddNote(Note.NOTE_C5, Note.DURATION_EIGHTH);
            song3.AddNote(Note.NOTE_B4, Note.DURATION_QUARTER);
            song3.AddNote(Note.NOTE_G4, Note.DURATION_DOTTED_HALF_TIED_HALF);
            songs.AddLast(song3);
            SongListBox.Items.Add(song3.Name);
        }

        // This function is provided as part of the activity starter.
        private void PlayButton_Click(object sender, EventArgs e)
        {
            // get the current selection index
            int selection = SongListBox.SelectedIndex;
            if (selection >= 0)
            {
                // get the selected song from the list
                Song s = songs.ElementAt(selection);

                // play the song
                s.Play();
            }

        }
    }
}
