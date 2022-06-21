using Microsoft.AspNetCore.SignalR;

namespace LabelTextUpdate.Server.RHub
{
    public class LabelTextHub : Hub
    {
        public async Task ReadCurrentLabelText(string text) => await Clients.All.SendAsync("CommunicateLabelText", text);
    }
}
