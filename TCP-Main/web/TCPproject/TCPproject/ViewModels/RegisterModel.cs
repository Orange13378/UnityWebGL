﻿using System.ComponentModel.DataAnnotations;

namespace TCPproject.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Не указан NickName")]
        public string Nickname { get; set; }

        [Required(ErrorMessage = "Не указан Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароль введен неверно")]
        public string ConfirmPassword { get; set; }

    }
}