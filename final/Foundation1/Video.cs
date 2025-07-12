public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    public List<Comment> Comments { get; set; }

    public Video(string nameTitle, string nameAuthor, int timeLengthInSeconds)
    {
        this.Title = nameTitle;
        this.Author = nameAuthor;
        this.LengthInSeconds = timeLengthInSeconds;
        this.Comments = new List<Comment>();
    }
}