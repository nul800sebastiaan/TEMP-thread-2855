using Umbraco.Cms.Core.Models.PublishedContent;

namespace v1370;

public class MyFormModel : PublishedContentWrapped 
{
    public MyFormModel(
        IPublishedContent content, 
        IPublishedValueFallback publishedValueFallback) 
        : base(content, publishedValueFallback)
    { }

    // Add properties for your form fields here, for example:
    public string Test { get; set; }
}