﻿// <summary>  
// Copyright：Sichen International Co. Ltd.
// Author：Devin
// Date：2017-3-20
// Modifyed：selonsy  
// ModifyTime：2017-3-20  
// Desc：
// 基类
// </summary> 

using System.Web;

namespace Devin
{
    /// <summary>
    /// 基类
    /// </summary>
    public class Base
    {
        #region 私有变量

        //private string _connstr;
        //private string _logdefaultpath;
        //private string _inipath;
        //private string _databasetype;
        private static IniConfig config = new IniConfig(HttpRuntime.AppDomainAppPath.ToString() + "\\bin\\ufjnls.dll.ini");

        #endregion

        /// <summary>
        /// 构造函数(初始化配置信息)
        /// </summary>
        public Base()
        {           
            //可以考虑在这个地方初始化 config,根据传递进来的配置文件的路径.防止上面的取路径的不生效.
            //_inipath = HttpRuntime.AppDomainAppPath.ToString() + "\\bin\\ufjnls.dll.ini";
            //config = new IniConfig(_inipath);
        }

        /// <summary>
        /// IsDebug
        /// </summary>
        public static bool IsDebug = config.get("isdebug") == "true" ? true : false;    

        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public static string ConnStr = config.get("connstr");
        //{
        //    get
        //    {
        //        if (!string.IsNullOrEmpty(_connstr)) return _connstr;
        //        _connstr = config.get("connstr");
        //        return _connstr;
        //    }
        //}
     
        /// <summary>
        /// 日志文件路径
        /// </summary>
        public static string LogDefaultPath = HttpRuntime.AppDomainAppPath.ToString() + config.get("logpath");
        //{
        //    get
        //    {
        //        if (!string.IsNullOrEmpty(_logdefaultpath)) return _logdefaultpath;
        //        string logpath = config.get("logpath");
        //        if (!string.IsNullOrEmpty(logpath))
        //        {
        //            _logdefaultpath = HttpRuntime.AppDomainAppPath.ToString() + logpath;
        //        }
        //        else
        //        {
        //            _logdefaultpath = "D:\\MyLog\\";
        //        }
        //        return _logdefaultpath;
        //    }
        //}

        /// <summary>
        /// 数据库类型
        /// </summary>
        public static string DataBaseType = config.get("databasetype");
        //{
        //    get
        //    {
        //        if (!string.IsNullOrEmpty(_databasetype)) return _databasetype;
        //        _databasetype = config.get("databasetype");
        //        return _databasetype;                
        //    }
        //}
    }
}
