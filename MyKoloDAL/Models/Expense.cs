using System;

namespace MyKoloDAL.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
    }
}