using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WalletService.Dtos
{
    public class TopUpPublishedDto
    {
        [Required]
        public string Username {get;set;}
        [Required]
        public decimal Amount {get;set;}
        [Required]
        public string Event { get; set; } = string.Empty;
    }
}