using System;

namespace Play.Inventory.Service.Dtos
{
    public record GranItemsDto(Guid UserId, Guid CatalogItemId, int Quantity);

    public record InventoryItemDto(Guid CatalogId, int Quantity, DateTimeOffset AcquiredDate);
}