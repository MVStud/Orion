using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Orion_Pens.Data;
using Orion_Pens.Models;
using Pen.Data;
using System;
using System.Linq;

namespace Pen.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new Orion_PensContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<Orion_PensContext>>()))
        {
            // Look for any movies.
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }
            context.Products.AddRange(
                new Products
                {
                    Name = "Astra",
                    InkType = "Gel",
                    Year = DateTime.Parse("2024-5-22"),

                    Color = "Blue",
                    Material = "Plastic",
                    Retractable = "Yes",
                    Price = 400
                },
                new Products
                {
                    Name = "Kidzee",
                    InkType = "Gel",
                    Year = DateTime.Parse("2024-5-22"),

                    Color = "Black",
                    Material = "Wood",
                    Retractable = "Yes",
                    Price = 400
                },
                new Products
                {
                    Name = "Phoenix",
                    InkType = "Water",
                    Year = DateTime.Parse("2024-5-22"),

                    Color = "Black",
                    Material = "Silicon",
                    Retractable = "Yes",
                    Price = 799
                },
                new Products
                {
                    Name = "Monster",
                    InkType = "Gel",
                    Year = DateTime.Parse("2024-5-22"),

                    Color = "Black",
                    Material = "Wood",
                    Retractable = "Yes",
                    Price = 400
                },
                new Products
                {
                    Name = "Easybee",
                    InkType = "Gel",
                    Year = DateTime.Parse("2024-5-22"),
                    
                    Color = "Black",
                    Material = "Wood",
                    Retractable = "Yes",
                    Price = 200
                },
                new Products
                {
                    Name = "Montec Blanc",
                    InkType = "Ink",
                    Year = DateTime.Parse("1989-5-08"),

                    Color = "Blue",
                    Material = "Stainless Steel",
                    Retractable = "No",
                    Price = 438
                },
                new Products
                {
                    Name = "Glider",
                    InkType = "Gel",
                    Year = DateTime.Parse("2012-5-20"),

                    Color = "Red",
                    Material = "Plastic",
                    Retractable = "Yes",
                    Price = 755
                },
                new Products
                {
                    Name = "Reynolds",
                    InkType = "Water",
                    Year = DateTime.Parse("2015-6-12"),

                    Color = "Blue",
                    Material = "Plastic",
                    Retractable = "Yes",
                    Price = 655
                },
                new Products
                {
                    Name = "Butterflow",
                    InkType = "Gel",
                    Year = DateTime.Parse("2017-3-20"),

                    Color = "Blue",
                    Material = "Recycled Paper",
                    Retractable = "No",
                    Price = 466
                },
                new Products
                {
                    Name = "Montex",
                    InkType = "Water",
                    Year = DateTime.Parse("2020-5-14"),

                    Color = "Orange",
                    Material = "Silicon",
                    Retractable = "Yes",
                    Price = 800
                }
            );
            context.SaveChanges();
        }
    }
}