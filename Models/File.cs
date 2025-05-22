using System;

namespace DigitalLockerSystem.Models;

public class File
{
    public int Id { get; set; }
    public string UserId { get; set; }  // Links file to a user
    public string OriginalFileName { get; set; }
    public string StoredFileName { get; set; }
    public string ContentType { get; set; }
    public DateTime UploadDate { get; set; }
}