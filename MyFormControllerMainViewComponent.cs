using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace v1370;

public class MyFormControllerMainViewComponent : ViewComponent
{
    public Task<IViewComponentResult> InvokeAsync()
    {
        var model = new MyViewComponentViewModel();
        model.MyDropDownListItems = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Option 1" },
            new SelectListItem { Value = "2", Text = "Option 2" }
        };
        
        var selectedValue = model.MyDropDownList;
        return Task.FromResult<IViewComponentResult>(View(model)); // Looks for Views/Shared/Components/MyFormControllerMain/Default.cshtml
    }
}

public class MyViewComponentViewModel
{
    public string Test2 { get; set; } = "test2";
    public object SomeHiddenField1 { get; set; }
    public object SomeHiddenField2 { get; set; }
    public object SomeHiddenField3 { get; set; }
    public string MyDropDownList { get; set; }
    public List<SelectListItem> MyDropDownListItems { get; set; }
}
