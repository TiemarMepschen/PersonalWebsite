using Domain.Medias.Enums;

namespace Domain.Medias.Entities
{
    public sealed class Media
    {
        public string Title { get; set; } = string.Empty;
        public decimal Score { get; set; } = 0;
        public MediaType Type { get; set; } = MediaType.None;
    }
}
