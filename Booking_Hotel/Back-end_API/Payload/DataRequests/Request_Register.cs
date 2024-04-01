﻿using Back_end_API.Entites;
using Back_end_API.Enumerates;

namespace Back_end_API.Payload.DataRequests
{
    public class Request_Register
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
    }
}