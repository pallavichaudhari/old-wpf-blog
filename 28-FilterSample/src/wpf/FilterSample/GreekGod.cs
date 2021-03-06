using System;
using System.Collections.Generic;
using System.Text;

namespace FilterSample
{
    public class GreekGod
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private string romanName;

        public string RomanName
        {
            get { return romanName; }
            set { romanName = value; }
        }

        public GreekGod(string name, string description, string romanName)
        {
            this.name = name;
            this.description = description;
            this.romanName = romanName;
        }
    }
}
