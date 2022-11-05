using Domain.Common.Entities;
using Domain.Medias.Entities;
using Domain.Medias.Enums;
using MediatR;

namespace Domain.Medias.Queries
{
    public sealed class SearchMediaQuery : IRequest<PagingOverview<Media>>
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public SearchMediaSortField SortField { get; set; } = SearchMediaSortField.Score;
        public bool SortDescending { get; set; } = true;
        public string FilterTitle { get; set; } = string.Empty;
        public MediaType FilterType { get; set; } = MediaType.None;
    }
}