using System;

namespace WarehouseManagementSystem_ASP.NET.Data.Models
{
    public class MainModel
    {
        public MainModel() {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
