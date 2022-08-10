using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extentions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        { 
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en", Name = "English", IsDefault = true }
                );
            #region Seed Category
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Áo nam"
                },

                new Category()
                {
                    Id = 2,
                    Name = "Quần nam"
                },

                new Category()
                {
                    Id = 3,
                    Name = "Áo nữ"
                },

                new Category()
                {
                    Id = 4,
                    Name = "Quần nữ"
                },

                new Category()
                {
                    Id = 5,
                    Name = "Tramg phục trẻ em"
                },

                new Category()
                {
                    Id = 6,
                    Name = "Phụ kiện"
                }
              );
            #endregion

            #region Seed Product
            modelBuilder.Entity<Product>().HasData(
                 new Product()
                 {
                     Id = 1,
                     Name = "Áo nam 1",
                     CategoryId = 1,
                     Price = 28890000,
                     Stock = 5,
                     DateCreated = DateTime.Now,
                     Description = "",
                     Details = ""
                 },

                new Product()
                {
                    Id = 2,
                    Name = "Áo nữ 2",
                    CategoryId = 2,
                    Price = 20990000,
                    Stock = 5,
                    DateCreated = DateTime.Now,
                    Description = "",
                    Details = ""
                },

                new Product()
                {
                    Id = 3,
                    Name = "Quần nam 1",
                    CategoryId = 3,
                    Price = 8290000,
                    Stock = 5,
                    DateCreated = DateTime.Now,
                    Description = "",
                    Details = ""
                },

                new Product()
                {
                    Id = 4,
                    Name = "Quần nữ 2",
                    CategoryId = 4,
                    Price = 9990000,
                    Stock = 5,
                    DateCreated = DateTime.Now,
                    Description = "",
                    Details = ""
                },

                new Product()
                {
                    Id = 5,
                    Name = "Trang phục 1",
                    CategoryId = 5,
                    Price = 5090000,
                    Stock = 5,
                    DateCreated = DateTime.Now,
                    Description = "",
                    Details = ""
                },

                new Product()
                {
                    Id = 6,
                    Name = "Balo phói với mọi loại trang phục",
                    CategoryId = 6,
                    Price = 3290000,
                    Stock = 5,
                    DateCreated = DateTime.Now,
                    Description = "",
                    Details = ""
                }
             );
            #endregion

            // tạo data cho user mặc định
            // any guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");

            modelBuilder.Entity<AppRole>().HasData(
            new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            }
            );
            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "hytranluan@gmail.com",
                PhoneNumber = "0765006381",
                Address = "123 An Dương Vương P.8 Q.5",
                NormalizedEmail = "HYTRANLUAN@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                Name = "Luan Hy",
            }); 
            // gán role admin và admin user
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
    }
}
