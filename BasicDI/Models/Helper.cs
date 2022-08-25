using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BasicDI.Models
{
  internal static class Helper
  {
    private static IHttpContextAccessor _httpContextAccessor;

    internal static HttpContext CurrentHttpContext => _httpContextAccessor.HttpContext;

    internal static void UseStaticHttpContextAccessor(IApplicationBuilder appBuilder)
    {
      _httpContextAccessor = appBuilder.ApplicationServices
        .GetRequiredService<IHttpContextAccessor>();
    }

    internal static string UserName()
    {
      return CurrentHttpContext?.User?.Identity?.Name;
    }
  }
}
