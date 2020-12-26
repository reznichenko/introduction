using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_4
{
    class ToDo
    {
        public string Title { get; set; }

        public bool IsDone { get; set; }

        public ToDo(string title)
        {

            Title = title;
            IsDone = false;
        }

        public ToDo()
        {

            Title = "";
            IsDone = false;
        }

    }
}
