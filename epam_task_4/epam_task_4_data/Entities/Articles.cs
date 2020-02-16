using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_task_4_data.Entities
{
    public class Article
    {

        public int ArticleId { get; set; }
        
        public string Author { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
