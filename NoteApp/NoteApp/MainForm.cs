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
    public partial class MainForm : Form
    {
        

        List<Note.Note> noteList = new List<Note.Note>();
        Note.Note currentNote = new Note.Note();


        private void LoadListToScreen()
        {
            notesListBox.Items.Clear();

            //noteListTextBox.Clear();

            for (int i = 0; i < noteList.Count; i++)
            {

                notesListBox.Items.Add(noteList[i].Name);
                //noteListTextBox.AppendText(noteList[i].Name + "\r\n");
            }

            currentNote = noteList[0];

        }

        public MainForm()
        {
            InitializeComponent();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();

            aboutForm.ShowDialog();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Сделать выход
            this.Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewEditNoteForm newNoteForm = new NewEditNoteForm();
            if(newNoteForm.ShowDialog() == DialogResult.OK)
            {

                currentNote = newNoteForm.note;

                noteList.Add(currentNote);


               
            }

            LoadListToScreen();

        }

        private void SelectCategoryComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //сделать выбор нужных объектов из списка
        }

        private void loadNotesFromDiskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //сделать загрузку заметок с диска. грузим в noteList

        }

        private void saveToDiskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //сделать запись на диск. пишем noteList
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noteList.Remove(currentNote);
            LoadListToScreen();
        }
    }
}
