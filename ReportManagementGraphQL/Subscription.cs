using System;
using HotChocolate;
using HotChocolate.Execution;
using HotChocolate.Subscriptions;
using HotChocolate.Types;
using ReportManagementGraphQL.Data.Entity;

namespace ReportManagementGraphQL
{
    public class Subscription
    {
        [SubscribeAndResolve]
        public async ValueTask<ISourceStream<User>> OnUserCreate([Service] ITopicEventReceiver eventReceiver,
            CancellationToken cancellationToken)
        {
            return await eventReceiver.SubscribeAsync<string, User>("UserCreated", cancellationToken);
        }


        [SubscribeAndResolve]
        public async ValueTask<ISourceStream<User>> OnUserGet([Service] ITopicEventReceiver eventReceiver,
            CancellationToken cancellationToken)
        {
            return await eventReceiver.SubscribeAsync<string, User>("ReturnedUser", cancellationToken);
        }
    }
}

