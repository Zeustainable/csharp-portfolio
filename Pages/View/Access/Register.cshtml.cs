using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPortfolio.Models;
using MyPortfolio.Repositories;

namespace MyPortfolio.Pages.View.Access
{
    public class Register : PageModel
    {
        [BindProperty]
        public Register_model User { get; set; }
        private Register_repository _registerRepository;

        public Register(Register_repository registerRepository)
        {
            _registerRepository = registerRepository;
        }

        public void OnGet() { }

        public async Task<IActionResult> OnPostRegisterAccountAsync()
        {
            var isSuccess = await _registerRepository.CreateAccountAsync(
                User.FirstName,
                User.LastName,
                User.Email,
                User.Password
            );

            if (isSuccess)
            {
                TempData["ToastType"] = "success";
                TempData["ToastTitle"] = "Success";
                TempData["ToastMessage"] = "Your account was created successfully!";
                
                return RedirectToPage("/View/Access/Login");
            }

            ModelState.AddModelError("", "Registration failed.");
            return Page();
        }
    }
}