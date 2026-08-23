namespace LDNK.Models
{
    public static class ProductRepository
    {
        private static readonly List<Product> _products = new()
        {
            new Product
            {
                Id = 1,
                Name = "FreeFire",
                Price = 0,
                CreatedAt = new DateTime(2017, 11, 1),
                ImageUrl = "/images/game1.png",
                Description = "Free Fire - tựa game bắn súng sinh tồn trên di động nổi tiếng toàn cầu. Mỗi trận đấu kéo dài 10 phút sẽ đưa bạn cùng 49 người chơi khác lên một hoang đảo để chiến đấu sinh tồn. Người chơi có thể tự do chọn điểm hạ cánh và thả dù, đồng thời cố gắng ở trong vùng an toàn càng lâu càng tốt. Lái xe khám phá bản đồ rộng lớn, ẩn nấp nơi hoang dã, hoặc trở nên vô hình bằng cách nằm dưới những bụi rậm hoặc khe đá. Phục kích, bắn tỉa, sinh tồn - tất cả vì một mục tiêu duy nhất: trở thành người sống sót cuối cùng.\nFree Fire, Chiến Đấu Thật Phong Cách!\n",
                Genre = "Action RPG",
                Platform = "Android / iOS / PC"
            },
            new Product
            {
                Id = 2,
                Name = "Roblox",
                Price = 77_777,
                CreatedAt = new DateTime(2014, 7, 16),
                ImageUrl = "/images/game2.png",
                Description = "Roblox là nơi hội tụ mọi loại trò chơi, dành cho đủ loại người chơi. Tham gia tranh tài trong các trò chơi đua xe tốc độ cao, chiến đấu hết mình trong các trò chơi bắn súng chiến thuật gay cấn, hoặc thử thách kỹ năng sinh tồn trong những môi trường thay đổi thất thường. Bắt đầu hành trình phiêu lưu vang danh bốn bể trong các trò chơi nhập vai RPG hấp dẫn, xây dựng đế chế khổng lồ trong các trò chơi quản lý, hoặc đắm chìm vào các trò chơi kinh dị, anime và thể thao cùng bạn bè trên toàn thế giới.",
                Genre = "Action Adventure",
                Platform = "Android / iOS / PC"
            },
            new Product
            {
                Id = 3,
                Name = "PUPG Mobile",
                Price = 99_999,
                CreatedAt = new DateTime(2018, 3, 19),
                ImageUrl = "/images/game3.png",
                Description = "PUBG MOBILE cung cấp các trận chiến nhiều người chơi khốc liệt nhất trên điện thoại di động của bạn. Tham gia trận chiến, trang bị và chơi để giành chiến thắng. Sống sót trong các trận chiến hoành tráng với 100 người chơi ở Chế độ cổ điển, Tải trọng, các trận đấu Đấu trường 4 đấu 4 nhịp độ nhanh và Chế độ lây nhiễm. Sống sót là tất cả những gì quan trọng. Hãy là người sống sót cuối cùng. Nhận nhiệm vụ và bắn theo ý muốn!",
                Genre = "Adventure",
                Platform = "Android & iOS"
            },
            new Product
            {
                Id = 4,
                Name = "Liên Quân Mobile",
                Price = 0,
                CreatedAt = new DateTime(2016, 12, 14),
                ImageUrl = "/images/game4.png",
                Description = "Hãy khẳng định kỹ năng bản thân, sát cánh đồng đội và thách đấu hàng triệu người chơi khác qua vô số những cuộc chiến 5v5 cực hay trên đấu trường huyền thoại MOBA của Garena Liên Quân Mobile!\nTham gia ngay vào những Liên Minh trong trò chơi để cùng chiến đấu và trở thành huyền thoại trong game mobile nổi tiếng thế giới từ Garena hỡi các legend!",
                Genre = "FPS",
                Platform = "Android & iOS"
            }
        };

        public static List<Product> GetAll() => _products;

        public static Product? GetById(int id) => _products.FirstOrDefault(p => p.Id == id);
    }
}
