﻿namespace HotelProject.EntityLayer.Concrete
{
    public class Testimonial: BaseEntity
    {
        public required string Name { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string Image { get; set; }
    }
}
