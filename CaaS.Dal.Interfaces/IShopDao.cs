﻿using CaaS.Domain;


namespace CaaS.Dal.Interfaces;

public interface IShopDao 
{
    Task<IEnumerable<Shop>> FindAllAsync(string table);
    Task<Shop?> FindByIdAsync(string id, string table);

    Task<bool> UpdateAsync(Shop shop, string table);
    Task<bool> DeleteByIdAsync(string id, string table);
    Task<bool> StoreAsync(Shop shop, string table);


}
