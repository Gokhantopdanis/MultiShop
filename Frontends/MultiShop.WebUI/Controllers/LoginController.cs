using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUI.Models;
using MultiShop.WebUI.Services.Interfaces;
using MultuShop.DtoLayer.IdentityDtos.LoginDtos;
using NuGet.Protocol;

namespace MultiShop.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILoginService _loginService;
        private readonly IIdentityService _identityService;

        public LoginController(IHttpClientFactory httpClientFactory, ILoginService loginService, IIdentityService identityService)
        {
            _httpClientFactory = httpClientFactory;
            _loginService = loginService;
            _identityService = identityService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateLoginDto createLoginDto)
        {
          
            return View();
        }

        //[HttpPost]
        public async Task<IActionResult> SignIn(SignInDto signInDto )
        {
            signInDto.Username = "gokhantopdanis";
            signInDto.Password = "Bursa123*";
            await _identityService.SignIn(signInDto);
            return RedirectToAction("Index", "User");
        }
    }
}
