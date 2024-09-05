namespace feature_flag_manager_backend.Controllers;
using feature_flag_manager_backend.Data.Models;
using feature_flag_manager_backend.Data.Services;
using feature_flag_manager_backend.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/feature-flags")]
public class FeatureFlagController : ControllerBase
{
    private FeatureFlagService _featureFlagService;

    public FeatureFlagController(FeatureFlagService featureFlagService)
    {
        _featureFlagService = featureFlagService;
    }

    [HttpPost]
    public FeatureFlag PostFeatureFlag([FromBody] FeatureFlagVM featureFlag)
    {
        return _featureFlagService.AddFeatureFlag(featureFlag);
    }

    [HttpGet]
    public IActionResult GetFeatureFlags()
    {
        return Ok("All feature flags");
    }
}
