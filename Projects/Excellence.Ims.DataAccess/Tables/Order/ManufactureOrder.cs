﻿using System;
using System.Collections.Generic;

namespace Excellence.Ims.DataAccess.Tables
{
    public class ManufactureOrder : IOrder
    {
        #region Primitive

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime CompleteDate { get; set; }
        public bool Complete { get; set; }

        public decimal Cost { get; set; }

        #endregion

        #region Foreign - One

        public Employee Employee { get; set; }
        public Project Project { get; set; }

        #endregion

        #region Foreign - Many

        public virtual ICollection<ManufactureOrderLine> Lines { get; set; }

        #endregion

        #region Inverse

        #endregion
    }
}
