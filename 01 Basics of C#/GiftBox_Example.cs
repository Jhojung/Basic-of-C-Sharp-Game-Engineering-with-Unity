namespace Basic_C_Sharp
{
    // Class
    class GiftBox()
    {
        public string letter;
        public int money;
    }
    internal class GiftBox_Example
    {
        static void Main(string[] args)
        {
            GiftBox addressA = AddressNewData("Hello, ", 10500);
            GiftBox addressB = AddressNewData("New ", 11500);
            GiftBox addressC = AddressNewData("World!", 12500);
            GiftBox addressD = AddressNewData("Out of bound error", 505);
            //Console.WriteLine($"{addressA.letter} {addressA.money}");

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
        }

        // Method Sample
        private static GiftBox AddressNewData(string letter, int money)
        {
            // Create Instance
            GiftBox result = new GiftBox()
            {
                letter = letter,
                money = money,
            };
            
            // Return Result
            return result;
        }
    }
}
