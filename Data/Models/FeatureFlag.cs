namespace feature_flag_manager_backend.Data.Models;

public class FeatureFlag
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsEnabled { get; set; }
    public string Environment { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime LastUpdatedAt { get; set; }
    public List<string>? Tags { get; set; }
    public DateTime? EndDate { get; set; }
}