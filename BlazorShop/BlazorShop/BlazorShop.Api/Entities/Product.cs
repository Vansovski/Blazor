﻿namespace BlazorShop.Api.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string MyProperty { get; set; } = string.Empty;
    public int Quantity { get; set; }
}
