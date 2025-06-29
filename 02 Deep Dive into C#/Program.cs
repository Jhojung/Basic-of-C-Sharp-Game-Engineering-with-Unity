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
        }
    }
}
