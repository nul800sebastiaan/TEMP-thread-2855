using System.Runtime.Versioning;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;

namespace v1370;

public class SecondaryFormController : SurfaceController
{
    public SecondaryFormController(
        IUmbracoContextAccessor umbracoContextAccessor, 
        IUmbracoDatabaseFactory databaseFactory, 
        ServiceContext services, 
        AppCaches appCaches,
        IProfilingLogger profilingLogger,
        IPublishedUrlProvider publishedUrlProvider) 
        : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
    {
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    [UnsupportedOSPlatform("browser")]
    public Task<IActionResult> MyTest(MyViewComponentViewModel model)
    {
        throw new NotImplementedException("The submitted value for the MyDropDownList property is: " + model.MyDropDownList);
        // Do something! 
        return Task.FromResult<IActionResult>(CurrentUmbracoPage());
    }
}