using GiftBoxNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProgramNamespace.Program;

namespace GiftBoxManagerNamespace
{
    class GiftBoxManager
    {
        public void SetInit()
        {
            GiftBox addressA = AddressNewData("Hello, ", 10500, ITEM_GRADE.NORMAL);
            GiftBox addressB = AddressNewData("New ", 11500, ITEM_GRADE.RARE);
            GiftBox addressC = AddressNewData("World!", 12500, ITEM_GRADE.UNIQUE);
            GiftBox addressD = AddressNewData("Out of bound error", 505, ITEM_GRADE.NORMAL);
        }

        private static GiftBox AddressNewData(string letter, int money, ITEM_GRADE item_grade)
        {
            // Create Instance
            GiftBox result = new GiftBox()
            {
                letter = letter,
                money = money,
                grade = item_grade,
            };

            // Return Result
            return result;
        }
    }
}
