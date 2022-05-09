using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Performance_Management.Model
{
    internal class Marks
    {
        public int student_id;
        public int subject_id;
        public int marks;

        public Marks(int student_id, int subject_id, int marks)
        {
            this.student_id = student_id;
            this.subject_id = subject_id;
            this.marks = marks;
        }
    }
}
