namespace program
{
    public class Pasteles
    {
        public string? name{ get; set; }
        public string? sugar{ get; set; }
        public string? milk{ get; set; }
        public HashSet<Pasteles>? children{ get; set; }
        public Pasteles(){}
    }
}