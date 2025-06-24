using GiftBoxManagerNamespace;
using GiftBoxNamespace;

namespace ProgramNamespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GiftBoxManager giftBoxManager = new GiftBoxManager();
            giftBoxManager.SetInit();

            // Data Types - Parse
            int money = 10000;
            float floatMoney = 1000.0f;
            double doubleMoney = 2000.0;

            string letter = "Hello, World!";

            // int to string
            letter = money.ToString();
            letter = money + "";

            // float to double
            doubleMoney = floatMoney;

            // double to float
            floatMoney = (float)doubleMoney; // can cause loss

            // string to int
            letter = "Hello, World!";
            int.TryParse(letter, out money); // cause error if just parse it
            Console.WriteLine(money);

            double value = 30.0 + 10.1f; // convert float to double automatically
            //float value2 = 30.0 + 10.1f; // cannot convert due to result data type range

            // Value Type (Stack)
            int aPersonMoney = 10000;
            int bPersonMoney = aPersonMoney; // Give Value
            aPersonMoney = 20000;
            Console.WriteLine($"{aPersonMoney}, {bPersonMoney}");

            // Reference Type (Heap, Garbage Collection)
            GiftBox aPersonGiftBox = new GiftBox
            {
                letter = "Hello!",
                money = 100000,
            };

            GiftBox bPersonGiftBox = aPersonGiftBox; // Give Address
            bPersonGiftBox.money = 20000;

            Console.WriteLine(aPersonGiftBox.money);

            // String => Reference Type
            string sampleLetter = "Hello, Universe!";
            string sampleLetter2 = sampleLetter; // Here, it returns value

            // Call by Value, Reference
            Console.WriteLine(aPersonGiftBox.grade);
            SetGiftBox(aPersonGiftBox); // Call By Reference
            Console.WriteLine(aPersonGiftBox.grade);

            int sampleMoney = 10000;
            SetMoneyValue(sampleMoney); // Call By Value, Here, the function return type is void, so no changes on here
            Console.WriteLine(sampleMoney);
            SetMoneyRef(ref sampleMoney); // Similar as pointer. Reference
            Console.WriteLine(sampleMoney);

            // Clean Code - Out (needs value)
            SetMoneyOut(out int otherMoney);
            Console.WriteLine(otherMoney);



            /*

            // Array
            GiftBox[] testBoxes = { addressA, addressB, addressC }; // Auto Sizing
            Console.WriteLine(testBoxes.Length);

            GiftBox[] giftBoxes = new GiftBox[3]; // Allocate 3-Length Contagious-Memory Space
            giftBoxes[0] = addressA;
            giftBoxes[1] = addressB;
            giftBoxes[2] = addressC;
            //giftBoxes[3] = addressD; // Out of Bound Error

            // List
            // No space limit. Can add items easily.
            List<GiftBox> giftBoxList = new List<GiftBox>();
            giftBoxList.Add(addressA);
            giftBoxList.Add(addressB);
            giftBoxList.Add(addressC);

            //giftBoxList.Clear(); // Clear Every Items
            giftBoxList.Remove(addressB);
            Console.WriteLine(giftBoxList.Count);
            GiftBox worldGift = giftBoxList.Find(static p => p.letter == "World!"); // Find addressC with letter data
            if(worldGift != null) Console.WriteLine(worldGift.money); // Check if null(Not Found), and then print it

            //giftBoxList[2] = addressD; // Out of range

            giftBoxList[1] = addressA;
            giftBoxList.Add(addressB);

            for (int i = 0; i < giftBoxList.Count; i++) giftBoxList[i].money = 100000;
            Console.WriteLine(giftBoxList[giftBoxList.Count-1].money);

            foreach(GiftBox item in giftBoxList) item.money = 200000;
            //foreach (var item in giftBoxList) item.money = 100000; // var -> guess the data type
            Console.WriteLine(giftBoxList[giftBoxList.Count-2].money);

            */
        }

        static void SetGiftBox(GiftBox info)
        {
            info.grade = ITEM_GRADE.UNIQUE;
        }

        static void SetMoneyValue(int money)
        {
            money = 30000;
        }

        static void SetMoneyRef(ref int money)
        {
            money = 30000;
        }

        static void SetMoneyOut(out int money)
        {
            money = 30000;
        }

        static int SetMoneyInt(int money)
        {
            money = 30000;
            return money;
        }
    }
}
