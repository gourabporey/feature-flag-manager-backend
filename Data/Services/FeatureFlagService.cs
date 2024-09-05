using feature_flag_manager_backend.Data.Models;
using feature_flag_manager_backend.Data.ViewModels;

namespace feature_flag_manager_backend.Data.Services;
public class FeatureFlagService
{
    private AppDbContext _context;

    public FeatureFlagService(AppDbContext context)
    {
        _context = context;
    }

    public FeatureFlag AddFeatureFlag(FeatureFlagVM featureFlag)
    {
        var lastTimeUpdated = DateTime.Now;

        var _featureFlag = new FeatureFlag()
        {
            Name = featureFlag.Name,
            Description = featureFlag.Description,
            Tags = featureFlag.Tags,
            IsEnabled = featureFlag.IsEnabled,
            Environment = featureFlag.Environment,
            CreatedAt = lastTimeUpdated,
            LastUpdatedAt = lastTimeUpdated
        };

        _context.FeatureFlags.Add(_featureFlag);
        _context.SaveChanges();

        return _featureFlag;
    }
}
