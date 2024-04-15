namespace FilmMoi.Domain.Models.Base
{
    public interface IModifiedBase
    {
        public DateTimeOffset ModifiedTime { get; set; }

        public Guid? ModifiedBy { get; set; }

    }
}
