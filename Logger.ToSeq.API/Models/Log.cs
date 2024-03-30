namespace Logger.ToSeq.API.Models;

public sealed class Log
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string MethodName { get; set; } = string.Empty;
    public string MethodType { get; set; } = string.Empty;
    public string TableName { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
    public string UserId { get; set; } = string.Empty;
    public string User { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; } = DateTime.Now;
}
