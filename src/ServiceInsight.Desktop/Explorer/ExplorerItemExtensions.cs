﻿namespace Particular.ServiceInsight.Desktop.Explorer
{
    using EndpointExplorer;
    using QueueExplorer;

    public static class ExplorerItemExtensions
    {
        public static T As<T>(this ExplorerItem explorerItem) where T : ExplorerItem
        {
            return explorerItem as T;
        }

        public static bool IsQueueExplorerSelected(this ExplorerItem explorerItem)
        {
            return explorerItem is QueueExplorerItem ||
                   explorerItem is QueueServerExplorerItem;
        }

        public static bool IsEndpointExplorerSelected(this ExplorerItem explorerItem)
        {
            return explorerItem is EndpointExplorerItem ||
                   explorerItem is ServiceControlExplorerItem;
        }
    }
}