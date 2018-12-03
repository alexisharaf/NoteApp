using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Note;

namespace NoteApp
{
    public partial class NewEditNoteForm : Form
    {

        public Note note ;

        public NewEditNoteForm()
        {
            note = new Note();
            InitializeComponent();
        }

        public NewEditNoteForm(Note notein)
        {
            note = new Note();
            note = notein;


            InitializeComponent();

            noteTitleTextBox.Text = note.Name;
            categoryComboBox.Text = note.Category;
            noteTextTextBox.Text = note.Text;
            creationDateTimePicker.Value = note.CreationDate;
            modifiactionDateTimePicker.Value = note.EditDate;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
             note.Name= noteTitleTextBox.Text;
            note.Category = categoryComboBox.Text;
            note.Text = noteTextTextBox.Text;
            note.CreationDate = creationDateTimePicker.Value;
            note.EditDate = modifiactionDateTimePicker.Value;
        }
    }
}
