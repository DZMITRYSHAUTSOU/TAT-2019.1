using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_4
{
    class Discipline : Materials
    {
        public Lection[] lections;//Discipline object have indexator; index returns lection
        int lectionsnum = 10;//Default number of lections for every Discipline
        public Discipline()
        {
            id = id.GetId();
            lections = new Lection[lectionsnum];
            for(int i=0;i<lectionsnum;i++)
            {
                lections[i] = new Lection();
            }
        }
        public Discipline(int Num)//Constructor for non-default lection number
        {
            lectionsnum = Num;
            id = id.GetId();
            lections = new Lection[lectionsnum];
            for (int i = 0; i < lectionsnum; i++)
            {
                lections[i] = new Lection();
            }
        }
        public Lection this[int index]//indexator
        {
            get
            {
                return lections[index];
            }
        }
        public override string ToString()
        {
            return "Discipline example description";
        }
        public void Clone(Discipline obj)//Clones variable from the other object(including lectures and labs etc.)
        {
            for (int i = 0; i < lectionsnum; i++)
            {
                lections[i] = obj.lections[i];
                id = obj.id;
            }
        }
    }
}
