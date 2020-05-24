using Microsoft.EntityFrameworkCore;

namespace RoarcoderUserInfoApi.Models
{
    public class UserInfoContext : DbContext
    {
        public UserInfoContext(DbContextOptions<UserInfoContext> options)
            : base(options)
        {
        }

        public DbSet<UserInfo> UserInfo { get; set; }

    }
}