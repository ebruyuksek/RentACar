using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WEBApi.Controllers
{
    public class BaseController : ControllerBase
    {
        private IMediator? _mediator;
        protected IMediator? Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
        //sadece inherit edenler kullanabilsin diye protected yazıldı. 
    }
}
