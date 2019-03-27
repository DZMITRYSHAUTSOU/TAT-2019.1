using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_4
{
    class Lection : Materials
    {
        public List<Seminar> seminars = new List<Seminar>();//contains seminars 
        public List<LaboratoryPractice> labs = new List<LaboratoryPractice>();//contains lab practice
        public string LecText { get; set; }
        public string URL { get; set; }
        private string format;
        private string[] LecFormats= new string[] { "Unknown", "PPT", "PDF" };//Formats for lecture
        public Lection()
        {
            id = id.GetId();
            URL = "example url";
            format = LecFormats[0];
        }
        public void SetFormat(int value)//sets format where 0-unknown, 1-PPT, 2-PDF.
        {
            format = LecFormats[value];
        }
        public string GetFormat()//Returns current format of lection
        {
            return format;
        }
        public void AddLabs(int n)//Creates "n" new LaboratoryPractice objects and adds it in list
        {
            for(int i=0;i<n;i++)
            {
                labs.Add(new LaboratoryPractice());
            }
        }
        public void AddSeminars(int n)//Creates "n" new Seminar objects and adds it in list
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
