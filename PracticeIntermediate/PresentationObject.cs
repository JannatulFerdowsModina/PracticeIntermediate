namespace PracticeIntermediate
{
    public class PresentationObject
    {
        public int width { get; set; }
        public int height { get; set; }
        public void Copy()
        {
            System.Console.WriteLine("copying...");
        }
        public void Duplicate()
        {
            System.Console.WriteLine("duplicating...");
        }
    }
}
