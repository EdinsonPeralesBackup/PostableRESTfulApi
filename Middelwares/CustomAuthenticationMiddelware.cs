namespace PostableRESTfulApi.Middelwares{
    public class CustomAuthenticationMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomAuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await _next(context);

            if (context.Response.StatusCode == 401)
            {
                var errorResponse = new
                {
                    status = 401,
                    error = "Unauthorized",
                    message = "Acceso no autorizado. Por favor, proporcione un token válido.",
                    timestamp = DateTime.UtcNow,
                    path = context.Request.Path
                };

                context.Response.ContentType = "application/json";
                await context.Response.WriteAsJsonAsync(errorResponse);
            }
            else if (context.Response.StatusCode == 403)
            {
                var errorResponse = new
                {
                    status = 403,
                    error = "Forbidden",
                    message = "No tienes permiso para acceder a este recurso.",
                    timestamp = DateTime.UtcNow,
                    path = context.Request.Path
                };

                context.Response.ContentType = "application/json";
                await context.Response.WriteAsJsonAsync(errorResponse);
            }
        }
    }
}