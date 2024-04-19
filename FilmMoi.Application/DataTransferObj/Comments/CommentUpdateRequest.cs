using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMoi.Application.DataTransferObj.Comments
{
    public class CommentUpdateRequest
    {
        public Guid ID { get; set; }
        public string Comment_text { get; set; }
    }
}
