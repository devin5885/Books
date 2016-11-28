using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1WF
{
    public class Test : IEquatable<Test>
    {
        public string StudentName { get; set; }

        public int TestNumber { get; set; }

        public bool Equals(Test other)
        {
            return other.StudentName == StudentName && other.TestNumber == TestNumber;
        }
    }
}
