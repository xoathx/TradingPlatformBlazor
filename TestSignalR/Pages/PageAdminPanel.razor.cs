using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingPlatformBlazor.Data.Services;

namespace TradingPlatformBlazor.Pages
{
    public partial class PageAdminPanel
    {
        [Inject] public IUserStatus UserStatus { get; set; }
        
    }
}
