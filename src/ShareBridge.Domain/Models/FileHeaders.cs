using System;
using System.ComponentModel.DataAnnotations;

namespace ShareBridge.Domain.Models
{
    public class FileHeaders
    {
        [Required]
        public string FileName { get; set; } = default!;

        [Required]
        public int Lenth { get; set; }

        public string Extension { get; set; } = default!;

        [Required]
        public string SecretKey { get; set; } = default!;
    }
}