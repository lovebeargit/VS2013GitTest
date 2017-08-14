﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestMVC.Models
{
   
    public class SysUser
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string password { get; set; }
        public virtual ICollection<SysUserRole> SysUserRole { get; set; }

    }
}