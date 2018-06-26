using GraphQL.Types;
using Grapher.Core.Data;
using Grapher.Core.Models;

namespace Grapher.Api.Models
{
    public class GrapherMutation : ObjectGraphType
    {
        public GrapherMutation(IAircraftRepository aircraftRepository)
        {
            Name = "CreateAircraftMutation";

            Field<AircraftType>(
                "createAircraft",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<AircraftInputType>> {Name = "aircraft"}
                    ),
                resolve: context =>
                {
                    var aircraft = context.GetArgument<Aircraft>("aircraft");
                    return aircraftRepository.Add(aircraft);
                });
        }
    }
}