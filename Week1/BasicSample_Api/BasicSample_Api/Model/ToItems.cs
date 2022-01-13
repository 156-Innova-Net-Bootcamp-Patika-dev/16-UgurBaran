using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicSample_Api.Model
{
    public class ToItems
    {
        private int id;
        private string name;
        private string surName;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Surname
        {
            get { return this.surName; }
            set { this.surName = value; }
        }

        public ToItems()
        {
            this.id = Id;
            this.name = Name;
            this.surName = Surname;
        }



    }
}
