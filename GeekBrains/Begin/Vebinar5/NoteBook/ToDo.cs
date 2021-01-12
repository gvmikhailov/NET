using System;

namespace NoteBook
{

    class ToDo
    {
        public string Title { get; set; }
        public bool? IsDone { get; set; }

        public ToDo (string title)
        {
            Title = title;
        }
    }
}
