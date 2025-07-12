public class Comment
{
    public string CommenterName { get; set; }
    public string CommentText { get; set; }

    public Comment(string usersName, string usersText)
    {
        this.CommenterName = usersName;
        this.CommentText = usersText;
    }
}