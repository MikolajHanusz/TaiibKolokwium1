namespace WebApplication1.Model
{
    public class Keyboard
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public KeyboardType Type { get; set; }

    }

    public enum KeyboardType
    {
        Membranowa,Mechaniczna,Nozycowa,Optyczna
    }
}
