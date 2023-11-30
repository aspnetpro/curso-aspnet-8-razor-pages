using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace AulaRazorPages.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public ContactFormModel? ContactForm { get; set; }

        [ViewData]
        public string MessageSuccess { get; set; }

        public void OnGet()
        {
            ContactForm = new ContactFormModel();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // send email
            // save on database
            MessageSuccess = "Contact Saved!";

            return Page();
        }
    }
}

public record ContactFormModel
{
    [Required]
    [StringLength(200)]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    [StringLength(200)]
    public string Email { get; set; }

    [Required]
    [StringLength(300)]
    public string Subject { get; set; }

    [Required]
    [StringLength(1000)]
    public string Message { get; set; }
}