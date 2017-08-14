using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestMVC.Models;

namespace TestMVC.DAL
{
    public class AccountInitializer:DropCreateDatabaseIfModelChanges<AccountContext>
    {
        protected override void Seed(AccountContext con)
        { 
            var sysUsers=new List<SysUser>
            {
                new SysUser{UserName="tom",password="1"},
                new SysUser{UserName="jerry",password="2"}
            };
            sysUsers.ForEach(s=>con.SysUser.Add(s));
            con.SaveChanges();
            var sysRoles = new List<SysRole>
            {
                new SysRole {RoleName="admin",RoleDesc="admin have full"}
                ,new SysRole{RoleName="user",RoleDesc="user can access"}
            };
            sysRoles.ForEach(s=>con.SysRole.Add(s));
            con.SaveChanges();
            var sysUserRoles = new List<SysUserRole> { 
            new SysUserRole {SysUserID=1,SysRoleID=2}
            ,new SysUserRole{SysUserID=2,SysRoleID=1}
            };
            sysUserRoles.ForEach(a=>con.SysUserRole.Add(a));
            con.SaveChanges();
        }
    }
}