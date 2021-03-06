﻿using System;
using Todo.Entities.Interfaces;

namespace Todo.Entities.Concrete
{
    public class Work : ITable
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public DateTime Date { get; set; }


        public int UserId { get; set; }
        public User User { get; set; }
    }
}
