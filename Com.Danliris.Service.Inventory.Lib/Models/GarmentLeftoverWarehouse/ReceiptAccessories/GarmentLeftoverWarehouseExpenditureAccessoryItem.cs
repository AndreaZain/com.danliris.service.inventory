﻿using Com.Moonlay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Com.Danliris.Service.Inventory.Lib.Models.GarmentLeftoverWarehouse.ReceiptAccessories
{
    public class GarmentLeftoverWarehouseExpenditureAccessoryItem: StandardEntity
    {
        public string POSerialNumber { get; set; }
        public long ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductRemark { get; set; }
        public double Quantity { get; set; }
        public long UomUnitId { get; set; }
        public string UomUnit { get; set; }
        public int GarmentLeftOverWarehouseExpenditureAccessoriesId { get; set; }
        [ForeignKey("GarmentLeftOverWarehouseExpenditureAccessoriesId")]
        public virtual GarmentLeftoverWarehouseExpenditureAccessory GarmentLeftoverWarehouseExpenditureAccessories { get; set; }
    }
}
