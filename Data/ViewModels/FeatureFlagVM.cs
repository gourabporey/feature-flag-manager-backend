namespace feature_flag_manager_backend.Data.ViewModels;

public class FeatureFlagVM
{
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsEnabled { get; set; }
    public string Environment { get; set; }
    public List<string>? Tags { get; set; }
}