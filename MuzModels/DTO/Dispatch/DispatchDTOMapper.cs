namespace MiniMUZ.Api.MuzModels.DTO.Dispatch
{
    public class DispatchDTOMapper
    {
        public static DispatchDTO MapToDto(MuzModels.Dispatch dispatch)
        {
            return new DispatchDTO()
            {
              DispatchDateDTO = dispatch.DispatchDate,
              DispatchDetailsDTO = dispatch.DispatchDetails,
              DispatchIdDTO= dispatch.DispatchId,
              ItemIdDTO= dispatch.DispatchId,   
              ShipmentIdDTO= dispatch.DispatchId,
              VehicleIdDTO= dispatch.DispatchId,    
            };
        }
    }
}
