namespace ShroomCity.Models.InputModels;
using System.Collections.Generic;

public class Entry
{
    public required string Key { get; set; }
    public required string Value { get; set; }
}

public class ResearchEntryInputModel
{
    public List<Entry>? Entries { get; set; }
}
