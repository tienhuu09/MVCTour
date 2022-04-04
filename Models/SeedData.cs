using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCTour.Data;
using System;
using System.Linq;

namespace MVCTour.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCTourContext(
            serviceProvider.GetRequiredService<DbContextOptions<MVCTourContext>>()))
            {
                // Kiểm tra thông tin tour đã tồn tại hay chưa
                if (context.Tour.Any())
                {
                    return; // Không thêm nếu tour đã tồn tại trong DB
                }
                context.Tour.AddRange(
                new Tour
                {
                    Code = "T01",
                    NameTour = "Du Lịch Đà Nẵng",
                    DepartureDate = DateTime.Parse("2022-03-15"),
                    Place = "Đà Nẵng",
                    Note  = "Thời Gian: 4 Ngày 3 Đêm Khởi Hành: 10/03/2022",
                    Price = 5690000
                },
                new Tour
                {
                    Code = "T02",
                    NameTour = "Du Lịch Phú Quốc",
                    DepartureDate = DateTime.Parse("2022-8-3"),
                    Place = "Lâm Đồng",
                    Note = "Thời Gian: 3 Ngày 2 Đêm Khởi Hành: 15/03/2022",
                    Price = 3590000
                }
                );
                context.SaveChanges();//lưu dữ liệu
            }
        }
    }
}