namespace Client.DataTransferObj.Comments
{
    public class CommentCreateRequest
    {
        public string Comment_text { get; set; }

        public Guid ID_User { get; set; }

        public Guid ID_Film { get; set; }
    }
}
