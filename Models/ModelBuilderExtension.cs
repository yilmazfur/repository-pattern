using System;
using Microsoft.EntityFrameworkCore;
/*
In C#, the extension method concept allows you to add new methods in the existing class or in the structure
    without modifying the source code of the original type and you do not require any
    kind of special permission from the original type and there is no need to re-compile the original type.
*/

namespace BookAPI.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
            //Binding parameters are those parameters which are used to bind the new method with the existing class or structure. 
                                                               //Model builderı extension yapacağı için this var
        {
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Author = "Victor Hugo",
                    Description = "Les Miserables"
                },
                new Book
                {
                    Id = 2,
                    Author = "Cervantes",
                    Description = "Don Kişot"
                }
                );
        }
    }
}
