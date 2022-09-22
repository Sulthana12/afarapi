﻿using Microsoft.AspNetCore.Mvc;
using MileAPI.Interfaces;
using MileDALibrary.Models;

namespace MileAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetUserDetails")]
        public IActionResult GetUserInformation(string PhoneNumber, string Password)
        {
            try
            {
                List<LoginDetails> result = _userService.GetUserInformation(PhoneNumber, Password);
                if (result == null)
                {
                    return Unauthorized("Authentication Failed");
                }
                return Ok(result);
            }
            catch (Exception)
            {
                return NotFound("Not Found");
            }   
        }
    }
}
