using MemoryPack;

namespace Totekoya
{
    [MemoryPackable]
    public partial class MemoryPackTestData
    {
        public string Name { get; set; }

        public int age { get; set; }

        public float weight { get; set; }
    }
}