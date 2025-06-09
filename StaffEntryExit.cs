using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace JokiaRegistration.Models
{
    public class StaffEntryExit
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public DateTime Entry { get; set; }
        public DateTime? Exit { get; set; }  // nullable, exit may not be recorded yet

        public Staff Staff { get; set; }

        public string Type { get; set; }         // e.g., "Entry" or "Exit"
        public DateTime Timestamp { get; set; }
    }
}
