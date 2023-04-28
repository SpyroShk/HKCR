﻿using HKCR.Domain.Shared;

namespace HKCR.Domain.Entities
{
    public class Cars
    {
        public Guid CarID { get; set; } = new Guid();
        public string CarName { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string CarColor { get; set; }
        public string CarRentalRate { get; set; }
        public CarStatus CarAvailability { get; set; }
        public string CarNoOfRent { get; set; }
        public DateTime? CarLastRented { get; set; }
        public string? CarImage { get; set; }
    }
}