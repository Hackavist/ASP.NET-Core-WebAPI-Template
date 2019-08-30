﻿using Models.DataModels; using Services.DTOs; using System;  namespace BusinessLogic.Interfaces {     public interface IAuth     {         User GenerateToken(int UserId);         User Authenticate(UserAuthenticationRequest request);         bool Register(UserAuthenticationRequest request, UserRole Role);         void Logout(int UserId);         bool Validate(int UserId, DateTime TokenIssuedDate);     } } 