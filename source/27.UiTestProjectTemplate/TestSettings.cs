﻿using Microsoft.Dynamics365.UIAutomation.Browser;

namespace $RootNamespace$
{
    public static class TestSettings
    {
        public static BrowserOptions Options = new BrowserOptions
        {
            BrowserType = BrowserType.Chrome,
            PrivateMode = true,
            FireEvents = true
        };
    }
}