using middlewareTest;

namespace Microsoft.AspNetCore.Builder
{
    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class SOAPEndpointExtensions
    {
        public static IApplicationBuilder UseSOAPEndpoint(this IApplicationBuilder builder) {
            return builder.UseMiddleware<SOAPEndpointMiddleware>();
        }
    }
}
