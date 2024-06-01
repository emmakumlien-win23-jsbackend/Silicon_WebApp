﻿using System.Diagnostics;

namespace Silicon_WebApp.Models;

public class CourseLibraryModel
{
    public string Id { get; set; } = null!;
    public string? ImageUri { get; set; }
    public string? ImageHeaderUri { get; set; }
    public bool IsBestseller { get; set; }
    public bool IsDigital { get; set; }
    public string Title { get; set; } = null!;
    public string? Ingress { get; set; }
    public decimal StarRating { get; set; }
    public string? Reviews { get; set; }
    public string Author { get; set; } = null!;
    public string? Hours { get; set; }
    public string LikesInProcent { get; set; } = null!;
    public string LikesInNumbers { get; set; } = null!;
    public string[]? Categories { get; set; }

    public virtual List<Author>? Authors { get; set; }
    public virtual Prices? Price { get; set; }
    public virtual Content? Content { get; set; }
}
public class Author
{
    public string? Name { get; set; }
}
public class Prices
{
    public string? Currency { get; set; }
    public decimal Price { get; set; }
    public decimal Discount { get; set; }
}
public class Content
{
    public string? Description { get; set; }
    public string[]? Includes { get; set; }
    public virtual List<ProgramDetailItem>? ProgramDetails { get; set; }
}
public class ProgramDetailItem
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
}

