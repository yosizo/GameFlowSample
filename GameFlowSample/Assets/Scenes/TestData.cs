using MessagePack;

[MessagePackObject]
public class TestData
{
    [Key(0)]
    public string str { get; set; }

    [Key(1)]
    public int num { get; set; }

    [Key(2)]
    public float fnum { get; set; }

}
