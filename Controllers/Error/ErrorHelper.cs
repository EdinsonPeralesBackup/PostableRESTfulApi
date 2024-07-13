using Microsoft.AspNetCore.Mvc;

namespace PostableRESTfulApi.Controllers.Error
{
    public static class ErrorHelper
    {
        public static IActionResult ErrorResponse(ControllerBase controller, int statusCode, string error, string message, string details = "")
        {
            var errorResponse = new
            {
                status = statusCode,
                error,
                message,
                details,
                timestamp = DateTime.UtcNow,
                path = controller.Request?.Path.Value
            };

            return controller.StatusCode(statusCode, errorResponse);
        }
    }
}
