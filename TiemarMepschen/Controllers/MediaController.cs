using Domain.Common.Entities;
using Domain.Medias.Entities;
using Domain.Medias.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TiemarMepschen.Controllers
{
    public sealed class MediaController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MediaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<PagingOverview<Media>>> SearchMedia([FromBody] SearchMediaQuery query)
        {
            PagingOverview<Media> results = await _mediator.Send(query);

            return Ok(results);
        }
    }
}
