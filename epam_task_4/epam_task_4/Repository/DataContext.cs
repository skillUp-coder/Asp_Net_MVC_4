using System.Data.Entity;
using epam_task_4_data.Entities;

namespace epam_task_4.Repository
{
    public class DataContext:DbContext
    {
        public DataContext():base("DataContext")
        {}

        public DbSet<FeedBackData> feedBackDatas { get; set; }
        public DbSet<Article> Articles { get; set; }
    }
}