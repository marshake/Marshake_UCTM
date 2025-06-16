using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__project_1.Models
{
    public class Exam
    {
        public int ExamID { get; set; }
        public int SubjectID { get; set; }
        public DateTime ExamDate { get; set; }
        public int RoomID { get; set; }
    }
}
