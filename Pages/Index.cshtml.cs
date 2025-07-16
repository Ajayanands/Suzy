using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Suzy.Pages;

[Authorize] // 🔒 This ensures only logged-in users can access Index.cshtml
public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        // You can log access or user info here
        _logger.LogInformation("User {User} accessed the dashboard.", User.Identity?.Name ?? "Unknown");
    }
}
