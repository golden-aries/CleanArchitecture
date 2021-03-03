﻿using BlazorHero.CleanArchitecture.Application.Requests.Identity;
using BlazorHero.CleanArchitecture.Application.Wrapper;
using System.Threading.Tasks;

namespace BlazorHero.CleanArchitecture.Client.Interfaces
{
    public interface IAuthService
    {
        //Task<Result> Register(RegisterRequest model);

        Task<IResult> Login(TokenRequest model);

        Task Logout();
    }
}