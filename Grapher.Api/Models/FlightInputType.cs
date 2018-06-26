using GraphQL.Types;

namespace Grapher.Api.Models
{
    public class FlightInputType : InputObjectGraphType
    {
        public FlightInputType()
        {
            Name = "FlightInput";
            Field<DateGraphType>("flightStartTime");
            Field<DateGraphType>("flightEndTime");
            Field<ListGraphType<DoubleGraphType>>("recordedSpeed");
            Field<DoubleGraphType>("fuelUsed");
            Field<StringGraphType>("description");
        }
    }
}