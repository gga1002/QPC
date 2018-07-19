﻿using System;
using System.ComponentModel.DataAnnotations;

namespace QPC.Core.Models
{
    public abstract class QPCBaseClass
    {
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }
        public User UserCreated { get; set; }

        public User LastModificationUser { get; set; }
        public DateTime LastModificationDate { get; set; }

        internal void SetTraceabilityValues(User user)
        {
            if (UserCreated == null)
            {
                CreateDate = DateTime.Now;
                UserCreated = user;
            }
            LastModificationDate = DateTime.Now;
            LastModificationUser = user;
        }
    }
}