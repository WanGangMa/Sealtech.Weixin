﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sealtech.Weixin.Domain.Entities;

namespace Sealtech.Weixin.Domain.Models
{
    /// <summary>
    /// 通用用户登录类，简单信息
    /// </summary>
    public class Account
    {

        #region Attribute
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 登录的用户名
        /// </summary>
        public string LogName { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>
        public string PassWord { get; set; }
        /// <summary>
        /// 是否管理员
        /// </summary>
        public bool IsAdmin { get; set; }
        public string Levels { get; set; }
        /// <summary>
        /// 用户头像
        /// </summary>
        public string Face_Img { get; set; }
        /// <summary>
        /// 用户主部门
        /// </summary>
        public SYS_DEPARTMENT DptInfo { get; set; }
        /// <summary>
        /// 用户所在部门集合
        /// </summary>
        public List<SYS_DEPARTMENT> Dpt { get; set; }
        /// <summary>
        /// 权限集合
        /// </summary>
        public List<SYS_PERMISSION> Permissions { get; set; }
        /// <summary>
        /// 角色的集合
        /// </summary>
        public List<SYS_ROLE> Roles { get; set; }
        /// <summary>
        /// 用户岗位集合
        /// </summary>
        public List<SYS_POST_USER> PostUser { get; set; }
        /// <summary>
        /// 用户可操作的模块集合
        /// </summary>
        public List<SYS_MODULE> Modules { get; set; }

        public string PinYin { get; set; }
        /// <summary>
        /// 为了实现不同角色不同系统的登录，把角色拥有的系统ID 添加到这个List里面
        /// </summary>
        public List<string> System_Id { get; set; }
        #endregion
    }
}
