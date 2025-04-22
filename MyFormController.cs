using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;

namespace v1370;

public class MyFormController : RenderController
{
    private readonly IVariationContextAccessor _variationContextAccessor;
    private readonly ServiceContext _serviceContext;

    public MyFormController(
        ILogger<MyFormController> logger, 
        ICompositeViewEngine compositeViewEngine, 
        IUmbracoContextAccessor umbracoContextAccessor,
        IVariationContextAccessor variationContextAccessor, 
        ServiceContext context)
        : base(logger, compositeViewEngine, umbracoContextAccessor)
    {
        _variationContextAccessor = variationContextAccessor;
        _serviceContext = context;
    }

    public override IActionResult Index()
    {
        var publishedValueFallback = new PublishedValueFallback(_serviceContext, _variationContextAccessor);
        var viewModel = new MyFormModel(CurrentPage, publishedValueFallback) { Test = "test" };

        return CurrentTemplate(viewModel);
    }
}