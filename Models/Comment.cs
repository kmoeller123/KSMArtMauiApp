using System;
using System.Collections.Generic;

namespace KSMWebApi.Models;

public partial class Comment
{
    public int Id { get; set; }

    public string? Title { get; set; }    

    public DateTime? ViewedDatetime { get; set; }

    public string? FileType { get; set; }

    public string? FileName { get; set; }
}
