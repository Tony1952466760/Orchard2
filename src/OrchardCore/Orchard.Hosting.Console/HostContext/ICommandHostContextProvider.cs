﻿namespace Orchard.Hosting.HostContext
{
    public interface ICommandHostContextProvider
    {
        CommandHostContext CreateContext();
        void Shutdown(CommandHostContext context);
    }
}