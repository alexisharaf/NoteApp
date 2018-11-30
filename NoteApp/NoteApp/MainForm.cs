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
using System.IO;
using Newtonsoft.Json;

namespace NoteApp
{
    public partial class MainForm : Form
    {
        

        List<Note.Note> noteList = new List<Note.Note>();
        Note.Note currentNote = new Note.Note();


        private void LoadListToScreen()
        {
            notesListBox.Items.Clear();

          

            for (int i = 0; i < noteList.Count; i++)
            {

                notesListBox.Items.Add(noteList[i].Name);
            }


            notesListBox.SetSelected(0, true);

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

            if (newNoteForm.ShowDialog() == DialogResult.OK)
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
            
           
            //Создаём экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();
            //Открываем поток для чтения из файла с указанием пути
            using (StreamReader sr = new StreamReader(@"e:\NoteApp.notes"))
            using (JsonReader reader = new JsonTextReader(sr))

            {
                //Вызываем десериализацию и явно преобразуем результат в целевой тип данных
                noteList = (List<Note.Note>)serializer.Deserialize(reader);
            }
            

        }

        private void saveToDiskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Создаём экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();
            //Открываем поток для записи в файл с указанием пути
            using (StreamWriter sw = new StreamWriter(@"e:\NoteApp.notes"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                //Вызываем сериализацию и передаем объект, который хотим сериализовать
                serializer.Serialize(writer, noteList);
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noteList.Remove(currentNote);
            LoadListToScreen();
        }

        private void notesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentNote = noteList[notesListBox.SelectedIndex];

            NoteNameLabel.Text = currentNote.Name;
            creationDateTimePicker.Value = currentNote.CreationDate;
            modifiactionDateTimePicker.Value = currentNote.EditDate;
            noteTextTextBox.Text = currentNote.Text;

            SelectCategoryComboBox1.Text = currentNote.Category;

        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewEditNoteForm newNoteForm = new NewEditNoteForm(currentNote);

            if (newNoteForm.ShowDialog() == DialogResult.OK)
            {

                currentNote = newNoteForm.note;

                noteList.Add(currentNote);

            }

            LoadListToScreen();


        }
    }
}
