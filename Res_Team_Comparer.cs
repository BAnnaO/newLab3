using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLab3
{
    class Res_Team_Comparer:IComparer<ResearchTeam>
    {
         public int Compare(ResearchTeam l_Team, ResearchTeam R_Team)
        {
           return l_Team.ListOfPublication.Count.CompareTo(R_Team.ListOfPublication.Count);
        }

       

        

       
    }
}
