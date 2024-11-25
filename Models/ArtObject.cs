using System;
using System.Collections.Generic;

namespace KSMWebApi.Models;

public partial class ArtObject
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? Title { get; set; }

    public decimal? Price { get; set; }

    public int? Views { get; set; }

    public DateTime? LastViewed { get; set; }

    public string? FileType { get; set; }

    public string? Location { get; set; }

    public string? FileName { get; set; }
}
