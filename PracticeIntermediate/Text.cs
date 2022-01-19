namespace PracticeIntermediate
{
    public class Text : PresentationObject
    {
        public int fontSize { get; set; }
        public string name { get; set; }
        public void Hyperlink(string url)
        {
            System.Console.WriteLine(url + "hyperlink added");
        }
    }
}
