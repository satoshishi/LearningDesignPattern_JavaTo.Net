namespace ProtoType.Sample1
{
    public class Miko : HololiverBase
    {
        public Miko(string liveStreamingGameTitle) : base(liveStreamingGameTitle){}

        public override string Live() => $"{LiveStreamingGameTitle}を配信するにぇ";        
    }
}