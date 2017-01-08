using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GA_Example
{
    public class Individual
    {
        public int position { get; set; }
        public string text { get; set; }

        public Individual()
        { }

        public Individual(int pos, string txt)
        {
            this.position = pos;
            this.text = txt;
        }
    }
}
