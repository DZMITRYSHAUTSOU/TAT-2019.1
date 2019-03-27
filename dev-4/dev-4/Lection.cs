using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_4
{
    class Lection : Materials
    {
        public List<Seminar> seminars = new List<Seminar>();
        public List<LaboratoryPractice> labs = new List<LaboratoryPractice>();
        private string[] LecText = new string[10000];
        private string URL;
        private string format;
        private string[] LecFormats= new string[] { "Unknown", "PPT", "PDF" };
        public Lection()
        {
             URL = "example url";
             format = LecFormats[0];
        }
        public void SetFormat(int value)
        {
            format = LecFormats[value];
        }
        public void AddLabs(int n)
        {
            for(int i=0;i<n;i++)
            {
                labs.Add(new LaboratoryPractice());
            }
        }
        public void AddSeminars(int n)
        {
            for (int i = 0; i < n; i++)
            {
                seminars.Add(new Seminar());
            }
        }
        public override string ToString()
        {
            return "Contains lection.";
        }
    }
}
