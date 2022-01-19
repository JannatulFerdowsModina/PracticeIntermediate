namespace PracticeIntermediate
{
    public class Shape
    {
        public int height { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public virtual void Draw()
        {
            System.Console.WriteLine();
        }

    }
}
