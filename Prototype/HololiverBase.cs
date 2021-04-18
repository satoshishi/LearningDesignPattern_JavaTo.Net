using System.Collections;
using System.Collections.Generic;
using System;

namespace ProtoType.Sample1
{
    public abstract class HololiverBase
    {
        protected string LiveStreamingGameTitle;

        public abstract string Live();

        public HololiverBase Clone() => (HololiverBase)MemberwiseClone();

        public HololiverBase(string liveStreamingGameTitle) => LiveStreamingGameTitle = liveStreamingGameTitle;
    }
}