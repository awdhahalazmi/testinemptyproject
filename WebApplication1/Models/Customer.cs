﻿namespace WebApplication1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string FavoriteColor { get; set; }


    }
}