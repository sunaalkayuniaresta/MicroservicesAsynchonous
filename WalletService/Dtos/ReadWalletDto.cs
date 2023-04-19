using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WalletService.Dtos
{
    public class ReadWalletDto
    {
        [Required]
        public string Username {get;set;}
        [Required]
        public decimal Cash {get;set;}
    }
}