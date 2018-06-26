using GraphQL.Types;
using Grapher.Core.Data;

namespace Grapher.Api.Models
{
    public class GrapherQuery : ObjectGraphType
    {
        Field<AircraftType>(
            "aircraft",
            arguments: new QueryArguments(new QueryArgument<IntGraphType> {Name = "id" }),
            resolve: context => aircraftRepository.Get(context.GetArgument<int>("id")));
         
        Field<AircraftType>(
            "name",
            arguments: new QueryArguments(new QueryArgument<StringGraphType> {Name = "name"}),
            resolve: context => aircraftRepository.Get(context.GetArgument<string>("name")));
            
        Field<AircraftType>(
            "all",
            resolve: context => playerRepository.All());    
            
    }
}