﻿using Microsoft.AspNetCore.SignalR;

namespace RealTimeCommunication.SignalRChat.Hubs;

public class ChatHub : Hub
{
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}
