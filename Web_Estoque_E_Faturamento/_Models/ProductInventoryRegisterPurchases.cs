using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace Web_Estoque_E_Faturamento._Models
{
    public class ProductInventoryRegisterPurchase
    {
        [Key]
        public int Id {get;set;}
        public Product Product {get;set;}
        public float QuantityBuyed {get;set;}
        public string Provider{get;set;}
        public string DateOfPurchase {get;set;}
        public float PriceOfPurchase {get;set;}
        public float PriceProductUnity {get;set;}
    }
}