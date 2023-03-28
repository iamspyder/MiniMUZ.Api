namespace MiniMUZ.Api.MuzModels.DTO.Dispatch
{
    public class DispatchDTO
    {
        public int DispatchIdDTO { get; set; }

        public int? ShipmentIdDTO { get; set; }

        public int? VehicleIdDTO { get; set; }

        public string? DispatchDetailsDTO { get; set; }

        public DateTime? DispatchDateDTO { get; set; }

        public int? ItemIdDTO { get; set; }

    }
}
