﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project.Common.Cached
{
    /// <summary>
    /// <para>Copyright (C) 2015 </para>
    /// <para>文 件 名： ProviderCached.cs</para>
    /// <para>文件功能： 通过配置文件读取缓存管理</para>
    /// <para>开发部门： 平台部</para>
    /// <para>创 建 人： ken</para>
    /// <para>创建日期： 2015.9.25</para>
    /// <para>修 改 人： </para>
    /// <para>修改日期： </para>
    /// <para>备    注： </para>
    /// </summary>
    public class ProviderCached
    {
        private static ICached instance;
        private static readonly object LockObj=new object();

        private static readonly string CachedType = ConfigurationManager.AppSettings["CachedType"] ?? "Project.Common.Cached";

        public static ICached Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (LockObj)
                    {
                        if (instance == null)
                        {
                            instance = (ICached)System.Reflection.Assembly.GetExecutingAssembly().CreateInstance(CachedType, false);
                        }
                    }
                }
                return instance;
            }
        }

    }
}
