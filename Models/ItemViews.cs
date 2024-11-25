using System;
using System.Collections.Generic;

namespace KSMWebApi.Models;

public partial class ItemViews
{
    public int Id { get; set; }
   
    public string? Title { get; set; }

    public int? Views { get; set; }

    public DateTime? ViewedDatetime { get; set; }

    public string? FileType { get; set; }

    public string? FileName { get; set; }
}
