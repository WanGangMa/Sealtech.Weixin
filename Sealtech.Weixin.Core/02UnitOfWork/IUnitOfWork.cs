﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealtech.Weixin.Core
{
    public interface IUnitOfWork
    {
        /// <summary>
        /// 提交
        /// </summary>
        /// <returns></returns>
        bool Commit();

    }
}
