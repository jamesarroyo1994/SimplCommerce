﻿using System.ComponentModel.DataAnnotations;

namespace SimplCommerce.Module.PaymentStripe.ViewModels
{
    public class StripeConfigForm
    {
        [Required]
        public string PublicKey { get; set; }

        [Required]
        public string PrivateKey { get; set; }
    }
}
