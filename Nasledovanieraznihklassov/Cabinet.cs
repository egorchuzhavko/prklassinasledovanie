using System;

namespace Nasledovanieraznihklassov
{
    public abstract class Cabinet
    {
        protected bool isComfortable;
        protected string[] itemsincab;

        protected Cabinet(bool isComfortable, string[] itemsincab)
        {
            this.isComfortable = isComfortable;
            this.itemsincab = itemsincab;
        }

        public abstract void OpinionAboutWorkSpace();
    }
}