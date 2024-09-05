namespace feature_flag_manager_backend.Data.Models;

class FeatureFlag
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsEnabled { get; set; }
    public string Environment { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}