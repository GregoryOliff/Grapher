using GraphQL.Types;

namespace Grapher.Api.Models
{
    public class AircraftInputType : InputObjectGraphType
    {
        public AircraftInputType()
        {
            Name = "AircraftInput";
            Field<NonNullGraphType<StringGraphType>>("name");
            Field<DateGraphType>("lastServiceDate");
            Field<DateGraphType>("lastUsage");
            Field<ListGraphType<FlightType>>("flights");
        }
    }
}