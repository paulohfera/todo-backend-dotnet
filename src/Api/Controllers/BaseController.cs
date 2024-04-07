using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Api;

[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiController]
// [Authorize]
[ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
public class BaseController : ControllerBase
{

}
