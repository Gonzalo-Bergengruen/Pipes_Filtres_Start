using System;
using CognitiveCoreUCU;

namespace CompAndDel
{
    public class FilterFace : IFilter
    {
        public IPicture Filter(IPicture picture)
        {
            CognitiveFace cog = new CognitiveFace(false);
            cog.Recognize(@"../Program/3.png");
            return picture;
        }

    }
}