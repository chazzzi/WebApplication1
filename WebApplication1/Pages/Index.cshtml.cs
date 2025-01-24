using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class IndexModel(Average average) : PageModel
    {
        private readonly Average _average = average;

        [BindProperty]
        public double NewValue { get; set; }

        public double CurrentAverage { get; private set; } // Display the current average
        public List<double>? EnteredValues { get; private set; } // Display all entered values

        public void OnGet()
        {
            CurrentAverage = _average.GetAverage();
            EnteredValues = _average.GetValues();
        }

        public IActionResult OnPost()
        {
            _average.AddValue(NewValue);

            CurrentAverage = _average.GetAverage();
            EnteredValues = _average.GetValues();

            return Page();
        }
    }
}
