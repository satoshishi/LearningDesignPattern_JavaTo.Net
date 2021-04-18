namespace ProtoType.Sample1
{
    public class Pekora : HololiverBase
    {
        public Pekora(string liveStreamingGameTitle) : base(liveStreamingGameTitle){}

        public override string Live() => $"{LiveStreamingGameTitle}を配信するペコ";
    }
}
