﻿using System;
using System.Collections.Generic;

namespace WebApplication14.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Subject { get; set; }
        public string RollNo { get; set; }
        public int? PhoneNum { get; set; }
        public string FatherName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
