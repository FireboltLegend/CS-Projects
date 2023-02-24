using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo_List
{
    public partial class ToDo_List : Form
    {
        LinkedList<string> todoList = new LinkedList<string>();
        //Creates string Linked List named todoList
        void DisplayList()
        //function Display List checks the list and updates the listbox to the correct items in todoList
        {
            ItemTextBox.Text = "";
            //Clears out any text in the textbox
            ToDoListBox.Items.Clear();
            //Clears out the listbox
            foreach(string item in todoList)
            //Runs through each item in the linked list todoList and add that item to the listbox
            {
                ToDoListBox.Items.Add(item);
                //Adds the item from todoList into the textbox
            }
        }
        public ToDo_List()
        {
            InitializeComponent();
        }

        private void AddFrontButton_Click(object sender, EventArgs e)
        {
            if(ItemTextBox.Text != "")
            //If there is anything in the textbox, the following code will run
            {
                todoList.AddFirst(ItemTextBox.Text);
                //Adds the text in the textbox to the front of the todoList
                DisplayList();
                //Runs the DisplayList() function
            }
        }

        private void AddBackButton_Click(object sender, EventArgs e)
        {
            if (ItemTextBox.Text != "")
            //If there is anything in the textbox, the following code will run
            {
                todoList.AddLast(ItemTextBox.Text);
                //Adds the text in the textbox to the back of the todoList
                DisplayList();
                //Runs the DisplayList() function
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            todoList.Remove(ToDoListBox.Text);
            //Removes the selected item from ToDoListBox from the todoList
            DisplayList();
            //Runs the DisplayList() function
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            todoList.Clear();
            //Clears out all items in the todoList
            DisplayList();
            //Runs the DisplayList() function
        }
    }
}
