﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    public class ProfilePageFlyoutMenuItem
    {
        public ProfilePageFlyoutMenuItem()
        {
            TargetType = typeof(ProfilePageFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}