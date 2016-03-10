using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Classes
{
    class Entry
    {
        public string StrName { get; private set; }
        public string StrTel { get; private set; }

        public Entry(string name, string tel)
        {
            StrName = name;
            StrTel = tel;
        }
        public Entry()
        {
            StrName = null;
            StrTel = null;
        }

    }
}
