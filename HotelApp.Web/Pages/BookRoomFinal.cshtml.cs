using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HotelApp.Web.Pages
{
    public class BookRoomFinalModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int RoomTypeId { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime StartDate { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime EndDate { get; set; }

        [BindProperty]
        public string FirstName { get; set; }

        [BindProperty]
        public string LastName { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            return RedirectToPage("/index");
        }
    }
}
