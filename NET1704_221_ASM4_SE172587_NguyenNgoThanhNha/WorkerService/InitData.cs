namespace WorkerService
{
    public class InitData
    {
        public static readonly List<Tutor> Tutors =
           [
                new Tutor
                {
                    Id = 1,
                    TutorId = Guid.NewGuid(),
                    Fullname = "Nguyen Van A",
                    Email = "nguyenvana@example.com",
                    Phone = "+841234567890",
                    Address = "123 Le Loi, District 1, Ho Chi Minh City",
                    Dob = new DateTime(1985, 5, 1),
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    IsDeleted = false
                },
                new Tutor
                {
                    Id = 2,
                    TutorId = Guid.NewGuid(),
                    Fullname = "Tran Thi B",
                    Email = "tranthib@example.com",
                    Phone = "+841234567891",
                    Address = "456 Nguyen Hue, District 1, Ho Chi Minh City",
                    Dob = new DateTime(1990, 6, 15),
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    IsDeleted = true
                },
                new Tutor
                {
                    Id = 3,
                    TutorId = Guid.NewGuid(),
                    Fullname = "Le Van C",
                    Email = "levanc@example.com",
                    Phone = "+841234567892",
                    Address = "789 Hai Ba Trung, District 1, Ho Chi Minh City",
                    Dob = new DateTime(1980, 8, 30),
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    IsDeleted = false
                },
                new Tutor
                {
                    Id = 4,
                    TutorId = Guid.NewGuid(),
                    Fullname = "Pham Thi D",
                    Email = "phamthid@example.com",
                    Phone = "+841234567893",
                    Address = "321 Tran Hung Dao, District 1, Ho Chi Minh City",
                    Dob = new DateTime(1995, 11, 10),
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    IsDeleted = true,
                },
                new Tutor
                {
                    Id = 5,
                    TutorId = Guid.NewGuid(),
                    Fullname = "Hoang Van E",
                    Email = "hoangvane@example.com",
                    Phone = "+841234567894",
                    Address = "654 Pham Ngu Lao, District 1, Ho Chi Minh City",
                    Dob = new DateTime(1988, 3, 22),
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    IsDeleted = false
                }
        ];

    }
}
