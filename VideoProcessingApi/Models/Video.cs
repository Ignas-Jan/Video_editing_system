namespace VideoProcessingApi.Models;

public enum VideoStatus
{
    Uploaded,
    QueuedForProcessing,
    Processing,
    Completed,
    Failed
}

public class Video
{
    public int Id {get; set;}
    public string FileName {get; set;} = string.Empty;
    public VideoStatus Status {get; set;} = VideoStatus.Uploaded;
    public DateTime UploadedAt {get; set;} = DateTime.UtcNow;
    public DateTime? ProcessingStartedAt {get; set;} //? means the record can be null
    public DateTime? ProcessingFinishedAt {get; set;}
    public string? ErrorMessage {get; set;}

    public int UserId {get; set;} //Foreign key to User
    public User User {get; set;} = null!;  //null! means that it can be null at start but it will be handled later
}