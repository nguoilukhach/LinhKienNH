using LinhKienNH.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinhKienNH.Data.EF.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public int SortOrder { get; set; }
        public bool IsShowHome { get; set; }
        public int? ParentId { get; set; }
        public Status Status { get; set; }
    }
}
