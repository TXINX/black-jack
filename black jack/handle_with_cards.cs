using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace black_jack
{
    public static class handle_with_cards
    {
        public static string change_card_into_name(int name)
        {
            if (name==1)
            {
                return "A";
            }
            if (name==11)
            {
                return "J";
            }
            if (name==12)
            {
                return "Q";
            }
            if (name==0)
            {
                return "K";
            }
            return name.ToString();
        }
        public static int count_the_number(int name)
        {
            if (name == 11 || name == 12||name==0)
            {
                return 10;
            }
            return name;
        }
    }
}
