using System;

namespace Nasledovanieraznihklassov
{
    public class WorkSpace : Cabinet
    {
        private bool isBeautiful;

        public WorkSpace(bool isComf, string[] items, bool isBeaut) : base(isComf, items)
        {
            isBeautiful = isBeaut;
        }

        public override void OpinionAboutWorkSpace()
        {
            Console.WriteLine(isComfortable ? "This work space is comfortable" : "This work space is not comfortable");
        }

        public void OpinionAboutBeauty()
        {
            Console.WriteLine(isBeautiful ? "Beautiful work space" : "Ugly work space");
        }
    }
}