using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class Marks
    {
        public Dictionary<string, double> _marks;
        public Dictionary<string, double> MarksOfStudent => _marks;
        public Marks() { }
        public int MaxMarks { get; internal set; }
        public int MinMarks { get; internal set; }

        public Marks(Dictionary<string, double> marks)
        {
            _marks = marks;
        }

    }
}
