using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zure_webapp_Learning.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;
    private IConfiguration _Configuration;

    public PrivacyModel(ILogger<PrivacyModel> logger,IConfiguration configuration)
    {
        _logger = logger;
        _Configuration = configuration;
    }

    public void OnGet()
    {
        ViewData["configs"] = _Configuration["Greeting"];
    }
}

