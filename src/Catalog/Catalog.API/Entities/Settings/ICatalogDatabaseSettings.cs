using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Entities.Settings
{
    public interface ICatalogDatabaseSettings
    {
        String ConnectionString { get; set; }
        String DatabaseName { get; set; }
        String CollectionName { get; set; }
    }
}
