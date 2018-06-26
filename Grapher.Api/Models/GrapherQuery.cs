using GraphQL.Types;
using Grapher.Core.Data;

namespace Grapher.Api.Models
{
    public class GrapherQuery : ObjectGraphType
    {
        Field<AircraftType>(
            "aircraft",
            arguments: new QueryArguments(new QueryArgument<IntGraphType> {Name = "id"}),
            resolve: context => aircraftRepository.Get(context.GetArgument<int>("id")));
         
        Field<AircraftType>(
            "name",
            arguments: new QueryArguments(new QueryArgument<StringGraphType> {Name = "name"}),
            resolve: context => aircraftRepository.Get(context.GetArgument<string>("name")));
            
        Field<AircraftType>(
            "all",
            resolve: context => playerRepository.All());
            
        Field<FlightType>(
            "flight",
            arguments: new QueryArguments(new QueryArguments<IntGraphType> {Name = "id"}),
            resolve: context => flightRepository.Get(context.GetArgument<int>("id")));
         
        Field<FlightType>(
            "flightStartTime",
            arguments: new QueryArguments(new QueryArgument<DateGraphType> {Name = "start"}),
            resolve: context => flightRepository.Get(context.GetArgument<DateTime>("start")));
            
        Field<FlightType>(
            "all",
            resolve: context => flightRepository.All());
    }
}