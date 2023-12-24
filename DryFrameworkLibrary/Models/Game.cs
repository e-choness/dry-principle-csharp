using System;
using DryFrameworkLibrary.Interfaces;

namespace DryFrameworkLibrary.Models
{
    public class Game : IProduct
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public DateTime TransactionDate { get; set; } = DateTime.Today;
    }
}