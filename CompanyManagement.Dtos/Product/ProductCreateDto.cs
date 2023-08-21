﻿namespace CompanyManagement.Dtos.Product
{
    public class ProductCreateDto
    {
        public string? SerialNo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? Brand { get; set; }
        public double? Height { get; set; }
        public double? Width { get; set; }
        public double? Lenght { get; set; }
        public double Quantity { get; set; }
        public string QuantityUnit { get; set; }
        public double? EstWeight { get; set; }
        public string? WeightUnit { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? QualityGrade { get; set; }
        public decimal? LastBoughtPrice { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
