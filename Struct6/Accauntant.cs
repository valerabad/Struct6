using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Struct6
{
    public enum Post { director = 180, manager = 170, secretary = 160 }
    class Accauntant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            bool answer = false;
            if ((int)worker < hours)
            {
                answer = true;
            }
            else
                answer = false;
            return answer;
        }
    }
}
