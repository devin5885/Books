using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1WF
{
    public class Test
    {
        public string StudentName { get; set; }

        public int TestNumber { get; set; }

        public override bool Equals(object obj)
        {
            var test = obj as Test;

            if (test != null)
            {
                return (obj as Test).StudentName == StudentName && (obj as Test).TestNumber == TestNumber;
            }

            return base.Equals(obj);
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Test Number: {1}", StudentName, TestNumber);
        }
    }
}
