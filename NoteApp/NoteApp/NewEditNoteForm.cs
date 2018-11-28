using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Note;

namespace NoteApp
{
    public partial class NewEditNoteForm : Form
    {

        public Note.Note note ;

        public NewEditNoteForm()
        {
            note = new Note.Note();
            InitializeComponent();
        }

        public NewEditNoteForm(Note.Note notein)
        {
            note = new Note.Note();
            note = notein;


            InitializeComponent();

            noteTitleTextBox.Text = note.Name;
            categoryComboBox.Text = note.Category;
            noteTextTextBox.Text = note.Text;
            creationDateTimePicker.Value = note.CreationDate;
            modifiactionDateTimePicker.Value = note.EditDate;
        }
    }
}
