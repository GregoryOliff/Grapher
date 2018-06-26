using GraphQL.Types;
using Grapher.Core.Data;
using Grapher.Core.Models;

namespace Grapher.Api.Models
{
    public class FlightType : ObjectGraphType<Flight>
    {
        public FlightType(IFlightRepository flightRepository)
        {
            Field(x => x.Id);
            Field<StringGraphType>("flightStartTime",
                resolve: context => context.Source.FlightStartTime.ToShortDateString());
            Field<StringGraphType>("flightEndTime",
                resolve: context => context.Source.FlightEndTime.ToShortDateString());
            Field<ListGraphType<DoubleGraphType>>("recordedSpeeds",
                resolve: context => context.Source.RecordedSpeeds.ToList());
            Field(x => x.FuelUsed);
            Field(x => x.Description, true);

        }
    }
}