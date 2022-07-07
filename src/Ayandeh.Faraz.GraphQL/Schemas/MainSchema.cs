using Abp.Dependency;
using GraphQL.Types;
using GraphQL.Utilities;
using Ayandeh.Faraz.Queries.Container;
using System;

namespace Ayandeh.Faraz.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IServiceProvider provider) :
            base(provider)
        {
            Query = provider.GetRequiredService<QueryContainer>();
        }
    }
}