using Microsoft.AspNetCore.Mvc;

namespace v1370;

public class MyFormControllerMainViewComponent : ViewComponent
{
    public Task<IViewComponentResult> InvokeAsync()
    {
        var model = new MyViewComponentViewModel();
        return Task.FromResult<IViewComponentResult>(View(model)); // Looks for Views/Shared/Components/MyFormControllerMain/Default.cshtml
    }
}

public class MyViewComponentViewModel
{
    public string Test2 { get; set; } = "test2";
}
