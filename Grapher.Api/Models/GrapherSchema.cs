using GraphQL;
using GraphQL.Types;

namespace Grapher.Api.Models
{
    public class GrapherSchema : Schema
    {
        public GrapherSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<GrapherQuery>();
            Mutation = resolver.Resolve<GrapherMutation>();
        }
    }
}