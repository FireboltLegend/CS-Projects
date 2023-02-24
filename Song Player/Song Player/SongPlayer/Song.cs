using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

/* TeenCoder: Windows Programming
   
   Song Player Application

   Copyright 2013 CompuScholar, Inc.
*/

namespace SongPlayer
{

    // This class is provided as part of the Activity Starter program.
    class Note
    {
        // Define common note frequencies
        public static int NOTE_Gb2 = 93;
        public static int NOTE_Bb2 = 117;
        public static int NOTE_Db3 = 139;
        public static int NOTE_A3 = 220;
        public static int NOTE_C4 = 262;
        public static int NOTE_D4 = 294;
        public static int NOTE_E4 = 330;
        public static int NOTE_F4 = 349;
        public static int NOTE_G4 = 392;
        public static int NOTE_A4 = 440;
        public static int NOTE_B4 = 494;
        public static int NOTE_C5 = 523;

        // Define common note durations (in milliseconds)
        public static int DURATION_WHOLE = 1600;
        public static int DURATION_HALF = 800;
        public static int DURATION_QUARTER = 400;
        public static int DURATION_DOTTED_QUARTER = 600;
        public static int DURATION_EIGHTH = 200;
        public static int DURATION_DOTTED_HALF_TIED_HALF = 2000;
        public static int DURATION_WHOLE_TIED_HALF = 2400;

        // Declare the properties for this note
        public int Frequency;
        public int Duration;

        // This constructor requires the Frequency and Duration for this note
        public Note(int frequency, int duration)
        {
            Frequency = frequency;
            Duration = duration;
        }
    }

    // This class code is ADDED FOR ACTIVITY by the student
    class Song
    {
        // student code to implement the Song class goes here
        public string Name;
        public LinkedList<Note> notes;
        public Song(string name)
        {
            Name = name;
            notes = new LinkedList<Note>();
            
        }
        public void AddNote(int frequency, int duration)
        {
            Note myNote = new Note(frequency, duration);
            notes.AddLast(myNote);
        }
        public void Play()
        {
            foreach(Note note in notes)
            {
                int frequency = note.Frequency;
                int duration = note.Duration;
                Console.Beep(frequency, duration);
            }
        }
    }

}
