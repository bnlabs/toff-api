namespace ToffApi.Models;

public class Message
{
    public Message()
    {

    }

    public Guid Id { get; set; }

    public Guid ReceiverId { get; set; }

    public Guid SenderId { get; set; }

    public string Content { get; set; }

    public DateTime TimeStamp { get; set; }

}