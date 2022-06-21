using LabelTextUpdate.Server.RHub;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace LabelTextUpdate.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextController : ControllerBase
    {
        private readonly IHubContext<LabelTextHub> _marketHub;
        
        public TextController(IHubContext<LabelTextHub> mktHub)
        {
            _marketHub = mktHub;
        }

        [HttpGet("{textValue}")]
        public ContentResult TextResult(string textValue)
        {
            _marketHub.Clients.All.SendAsync("SendLabelText", textValue);
            return Content(textValue);
        }
    }
}