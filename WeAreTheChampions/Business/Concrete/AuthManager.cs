using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Entities.Concrete;
using Core.Utilities.Business;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        public AuthManager(IUserService userService)
        {
            _userService = userService;
        }
        [ValidationAspect(typeof(LoginUserValidation))]
        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            if (userToCheck.Data == null)
            {
                return new ErrorDataResult<User>("User not found"); //TODO: write it in static message class
            }
            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.Data.PasswordHash, userToCheck.Data.PasswordSalt))
            {
                return new ErrorDataResult<User>("Password error");
            }
            return new SuccessDataResult<User>(userToCheck.Data, "Successful login");
        }

        [ValidationAspect(typeof(RegisterUserValidation))]
        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            var result = BusinessRules.Run(UserExists(userForRegisterDto.Email));
            if (result != null)
            {
                return new ErrorDataResult<User>(null, result.Message);
            }
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            _userService.Add(user);
            return new SuccessDataResult<User>(user, "User registered"); //TODO: message will take in static class
        }

        public IResult UserExists(string email)
        {
            if (_userService.GetByMail(email).Data != null)
            {
                return new ErrorResult("User already exist");
            }
            return new SuccessResult();
        }
    }
}
