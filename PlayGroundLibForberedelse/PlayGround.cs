namespace PlayGroundLibForberedelse
{
    public class PlayGround
    {
        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxChildren { get; set; }
        public int MinAge { get; set; }

        // ToString metode
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, MaxChildren: {MaxChildren}, MinAge: {MinAge}";
        }

    }
}
