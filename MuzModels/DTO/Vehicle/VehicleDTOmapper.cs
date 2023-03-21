namespace MiniMUZ.Api.MuzModels.DTO.Vehicle
{
    public class VehicleDTOmapper
    {
        public static VehiceDTO MapToDto(MuzModels.Vehicle vehicle)
        {
            return new VehiceDTO()
            {
                VehicleIdDTO = vehicle.VehicleId,
                VehicleNameDTO = vehicle.VehicleName,
                VehicleNoDTO = vehicle.VehicleNo,
                OwnerNameDTO = vehicle.OwnerName

            };
        }
    }
}
