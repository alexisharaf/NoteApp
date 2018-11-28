using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note
{

    public enum NoteCategory
    {
        Work,
        Home,
        HealtfandSport,
        People,
        Doc,
        Finance,
        Other
    }

    public class Note
    {
        private string name;
        private string category;
        private DateTime creationDate;
        private DateTime editDate;
        private string text;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }

        public DateTime CreationDate
        {
            get
            {
                return creationDate;
            }

            set
            {
                creationDate = value;
            }
        }

        public DateTime EditDate
        {
            get
            {
                return editDate;
            }

            set
            {
                editDate = value;
            }
        }

        public string Text
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
            }
        }
    }
}
