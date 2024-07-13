using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.DataTransferObj.Comments
{
    public class CommentDto
    {
        public Guid ID { get; set; }
        public string Comment_text { get; set; }
        public Guid ID_User { get; set; }
        public string UserName { get; set;}
    }     
}
