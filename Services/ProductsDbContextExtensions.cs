using System.Collections.Generic;
using System.Linq;
using ProductAPI.Entities;

namespace ProductAPI.Services
{
     public static class ProductDbContextExtensions
     {
          public static void CreateSeedData
               (this ProductAPI.Services.ProductDbContext context)
          {
               if (context.Products.Any())
                    return;
               var Products = new List<Product>()
               {
                    new Product()
                    {
                         Name = "Term Life",
                         Type = "Individual Insurance"
                    },
                    new Product()
                    {
                         Name = "Whole Life",
                         Type = "Individual Insurance"
                    },
                    new Product()
                    {
                         Name = "Universal Life",
                         Type = "Individual Insurance"
                    },
                    new Product()
                    {
                         Name = "Critical Illness",
                         Type = "Individual Insurance"
                    },
                    new Product()
                    {
                         Name = "Guaranteed Interest Account",
                         Type = "Savings and Retirement"
                    },
                    new Product()
                    {
                         Name = "Payout Annuities",
                         Type = "Savings and Retirement"
                    },
                    new Product()
                    {
                         Name = "Retirement Savings Plan",
                         Type = "Savings and Retirement"
                    },
                    new Product()
                    {
                         Name = "Segregated Funds",
                         Type = "Savings and Retirement"
                    },
                    new Product()
                    {
                         Name = "Segregated Funds",
                         Type = "Savings and Retirement"
                    },
                    new Product()
                    {
                         Name = "Tax Free Savings",
                         Type = "Savings and Retirement"
                    },
                    new Product()
                    {
                         Name = "Life, Accident and Critical Illness",
                         Type = "Group Benefits"
                    },
                    new Product()
                    {
                         Name = "Health and Dental",
                         Type = "Group Benefits"
                    },
                    new Product()
                    {
                         Name = "Health Care Spending Account",
                         Type = "Group Benefits"
                    },
                    new Product()
                    {
                         Name = "Health Care Spending Account",
                         Type = "Group Benefits"
                    },
                    new Product()
                    {
                         Name = "Disability Management Solutions",
                         Type = "Group Benefits"
                    },
                    new Product()
                    {
                         Name = "Health, Wellness and Online Solutions",
                         Type = "Group Benefits"
                    },
                    new Product()
                    {
                         Name = "Personal Health and Dental Coverage",
                         Type = "Group Benefits"
                    },
                    new Product()
                    {
                         Name = "myFlex Flexible Benefits",
                         Type = "Group Benefits"
                    },
                    new Product()
                    {
                         Name = "Taxable Spending Account",
                         Type = "Group Benefits"
                    },
                    new Product()
                    {
                         Name = "Benefit Abuse",
                         Type = "Group Benefits"
                    },
               };
               context.AddRange(Products);
               context.SaveChanges();
          }
     }
}