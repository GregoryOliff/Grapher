using GraphQL.Types;
using Grapher.Core.Data;
using Grapher.Core.Models;

namespace Grapher.Api.Models
{
    public class AircraftType : ObjectGraphType<Aircraft>
    {
        public AircraftType(IAircraftRepository aircraftRepository)
        {
            Field(x => x.Id);
            Field(x => x.Name, true);
            Field<StringGraphType>("lastServiceDate",
                resolve: context => context.Source.LastServiceDate.ToShortDateString());
            Field<StringGraphType>("lastUsage", resolve: context => context.Source.LastUsage.ToShortDataString());
            Field<ListGraphType<FlightType>>("flights",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> {Name = "id"}),
                resolve: context => aircraftRepository.Get(context.Source.Id), description: "This Aircrafts Flights");     
        }
    }
}