namespace maui_poc.Model;
using SQLite;

public class Resource
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    
    [NotNull]
    public string Key { get; set; }
    
    [NotNull]
    public string Value { get; set; }
    
    [NotNull]
    public string Module { get; set; }
    
    [NotNull]
    public string Language { get; set; }
    
}