using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using BaseProjectTemplate.Application.Authorization;
using BaseProjectTemplate.Core.Authorization;
using BaseProjectTemplate.Web.Core.Extensions;
using BaseProjectTemplate.Web.Core.Models;
using BaseProjectTemplate.Web.Core.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BaseProjectTemplate.Web.RazorPages.Pages.Admin.Profile
{
    public class IndexModel : BaseAdminPageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEmailService _emailService;

        public IndexModel(
            UserManager<ApplicationUser> userManager,
            IEmailService emailService)
        {
            _userManager = userManager;
            _emailService = emailService;
        }

        public string Username { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            Username = user.UserName;

            Input = new InputModel
            {
                Email = user.Email,
                PhoneNumber = user.PhoneNumber
            };

            IsEmailConfirmed = await _userManager.IsEmailConfirmedAsync(user);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (Input.Email != user.Email)
            {
                var setEmailResult = await _userManager.SetEmailAsync(user, Input.Email);
                if (!setEmailResult.Succeeded)
                {
                    throw new ApplicationException($"Unexpected error occurred setting email for user with ID '{user.Id}'.");
                }
            }

            if (Input.PhoneNumber != user.PhoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    throw new ApplicationException($"Unexpected error occurred setting phone number for user with ID '{user.Id}'.");
                }
            }

            SetViewMessage(new ViewMessage
            {
                Message = "Your profile has been updated",
                ViewMessageType = ViewMessageTypes.Success
            });

            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostSendVerificationEmailAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var callbackUrl = Url.EmailConfirmationLink(user.Id.ToString(), code, Request.Scheme);
            await _emailService.SendEmailConfirmationAsync(user.Email, callbackUrl);

            SetViewMessage(new ViewMessage
            {
                Message = "Verification email sent. Please check your email.",
                ViewMessageType = ViewMessageTypes.Success
            });

            return RedirectToPage();
        }
    }
}
