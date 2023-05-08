using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ResoWeb.WebPage.Pages
{
    public class SingleProductModel : PageModel
    {
        public SingleModel Product { get; set; }
        private static readonly IDictionary<string, SingleModel> Products;

        static SingleProductModel()
        {
            Products = new Dictionary<string, SingleModel>();
            Products["pos"] = new SingleModel
            {
                Name = "Reso POS",
                Description = "POS là từ viết tắt của Point-Of-Sale, theo nghĩa tiếng anh là điểm bán hàng. Thuật ngữ này được áp dụng cho một hoặc một hệ thống cửa hàng bán lẻ. Được đặt trong quầy thu ngân hoặc một vị trí trong khu vực nội bộ. Trong thực tế hiện nay, hệ thống máy bán hàng POS đã được ứng dụng rộng khắp các lĩnh vực trong cuộc sống như chính phủ, bệnh viện, nhà hàng, khách sạn",
                Image = "/images/THHH_single/product1.jpg",
                Characteristics = new List<Characteristic>()
                {
                    new Characteristic
                    {
                        Title = "Dễ dàng sử dụng",
                        Detail = "Tiết kiệm thời gian training, giúp nhân viên " +
                        "thao tác nhanh chóng và hiệu quả",
                        Image = "/images/THHH_single/pos.png"
                    },
                    new Characteristic
                    {
                        Title = "Dữ liệu Real time",
                        Detail = "Dữ liệu cập nhật trên hệ thống ngay khi đơn hàng " +
                        "phát sinh giúp cho người quản lí dễ dàng theo dõi",
                        Image = "/images/THHH_single/pos.png"
                    },
                    new Characteristic
                    {
                        Title = "Tiện ích vượt trội",
                        Detail = "Thanh toán, nhập thông tin khách hàng, thẻ thành viên, quản lí bàn..." +
                        " đều có trong Reso POS",
                        Image = "/images/THHH_single/pos.png"
                    }
                },
                Features = new List<Feature>()
                {
                    new Feature
                    {
                        Title = "Order và thanh toán",
                        SmallText = "Tiện lợi, nhanh chóng",
                        Image = "/images/THHH_single/order.jpg",
                        FeatureDetails = new List<FeatureDetail>
                        {
                            new FeatureDetail
                            {
                                Image = "/images/THHH_single/pos.png",
                                Title = "Thao tác dễ dàng",
                                Detail = "Màn hình thể hiện đầy đủ các chức năng"
                            },
                        }
                    },
                    new Feature
                    {
                        Title = "Quản lí đơn hàng",
                        SmallText = "Đơn giản, trực quan",
                        Image = "/images/THHH_single/bill.jpg",
                        FeatureDetails = new List<FeatureDetail>
                        {
                            new FeatureDetail
                            {
                                Image = "/images/THHH_single/pos.png",
                                Title = "Màu sắc trực quan",
                                Detail = "Có các màu sắc tương ứng với tình trạng đơn hàng " +
                                "giúp nhân viên dễ dàng theo dõi"
                            },
                        }
                    }
                },
                Documents = new List<Document>()
                {
                    new Document
                    {
                        Link = "#",
                        Title = "Hướng dẫn sử dụng"
                    },
                    new Document
                    {
                        Link = "#",
                        Title = "Câu hỏi thường gặp"
                    },
                }
            };
        }

        public void OnGet(string id)
        {
            Product = Products[id];
        }
    }
}