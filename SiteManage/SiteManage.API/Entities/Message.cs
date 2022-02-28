using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Message

{
    public Message()
    {

    }

    public int Id { get; set; }
    public string MessageText { get; set; }
    public int SenderId { get; set; }
    public int RecieverId { get; set; }
    public bool IsRead { get; set; }
    public DateTime Idatetime { get; set; }

    public virtual User Reciever { get; set; }
    public virtual User Sender { get; set; }
}
