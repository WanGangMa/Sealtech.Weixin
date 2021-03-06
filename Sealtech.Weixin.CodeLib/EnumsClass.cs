﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Configuration;
using System.Web;

namespace Sealtech.Weixin.CodeLib
{
    /// <summary>
    /// 枚举独特类
    ///  2016-05-10
    /// </summary>
    public class EnumsClass
    {
        /// <summary>
        /// 枚举value
        /// </summary>
        public int Value { get; set; }
        /// <summary>
        /// 枚举显示值
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 枚举说明
        /// </summary>
        public string Text { get; set; }
    }

    #region 系统管理相关
    /// <summary>
    /// 系统操作枚举
    /// </summary>
    public enum enumOperator
    {
        /// <summary>
        /// 无
        /// </summary>
        [Description("无")]
        None,
        /// <summary>
        /// 查询
        /// </summary>
        [Description("查询")]
        Select,
        /// <summary>
        /// 添加
        /// </summary>
        [Description("添加")]
        Add,
        /// <summary>
        /// 修改
        /// </summary>
        [Description("修改")]
        Edit,
        /// <summary>
        /// 移除
        /// </summary>
        [Description("移除")]
        Remove,
        /// <summary>
        /// 登录
        /// </summary>
        [Description("登录")]
        Login,
        /// <summary>
        /// 登出
        /// </summary>
        [Description("登出")]
        LogOut,
        /// <summary>
        /// 导出
        /// </summary>
        [Description("导出")]
        Export,
        /// <summary>
        /// 导入
        /// </summary>
        [Description("导入")]
        Import,
        /// <summary>
        /// 审核
        /// </summary>
        [Description("审核")]
        Audit,
        /// <summary>
        /// 回复
        /// </summary>
        [Description("回复")]
        Reply,
        /// <summary>
        /// 下载
        /// </summary>
        [Description("下载")]
        Download,
        /// <summary>
        /// 上传
        /// </summary>
        [Description("上传")]
        Upload,
        /// <summary>
        /// 分配
        /// </summary>
        [Description("分配")]
        Allocation,
        /// <summary>
        /// 文件
        /// </summary>
        [Description("文件")]
        Files,
        /// <summary>
        /// 流程
        /// </summary>
        [Description("流程")]
        Flow
    }
    /// <summary>
    /// log4net枚举
    /// </summary>
    public enum enumLog4net
    {
        [Description("普通")]
        INFO,
        [Description("警告")]
        WARN,
        [Description("错误")]
        ERROR,
        [Description("异常")]
        FATAL
    }
    /// <summary>
    /// 模块类别枚举,对应TBSYS_Module表的ModuleType字段
    /// </summary>
    public enum enumModuleType
    {
        无页面 = 1,
        列表页 = 2,
        弹出页 = 3
    }
    /// <summary>
    /// 部门类型
    /// </summary>
    public enum enumDepartmentType
    {
        胜利石油管理局 = 1,
        施工队 = 2,
        工程部 = 3,
        计划科 = 4,
        其他单位 = 5
    }

    #endregion

    #region 流程枚举
    /// <summary>
    /// 流程枚举
    /// </summary>
    public enum FLowEnums
    {
        /// <summary>
        /// 空白
        /// </summary>
        [Description("空白")]
        Blank = 0,
        /// <summary>
        /// 草稿
        /// </summary>
        [Description("草稿")]
        Draft = 1,
        /// <summary>
        /// 运行中
        /// </summary>
        [Description("运行中")]
        Runing = 2,
        /// <summary>
        /// 已完成
        /// </summary>
        [Description("已完成")]
        Complete = 3,
        /// <summary>
        /// 挂起
        /// </summary>
        [Description("挂起")]
        HungUp = 4,
        /// <summary>
        /// 退回
        /// </summary>
        [Description("退回")]
        ReturnSta = 5,
        /// <summary>
        /// 转发(移交)
        /// </summary>
        [Description("移交")]
        Shift = 6,
        /// <summary>
        /// 删除(逻辑删除状态)
        /// </summary>
        [Description("删除")]
        Delete = 7,
        /// <summary>
        /// 加签
        /// </summary>
        [Description("加签")]
        Askfor = 8,
        /// <summary>
        /// 冻结
        /// </summary>
        [Description("冻结")]
        Fix = 9,
        /// <summary>
        /// 批处理
        /// </summary>
        [Description("批处理")]
        Batch = 10,
        /// <summary>
        /// 加签回复状态
        /// </summary>
        [Description("加签回复")]
        AskForReplay = 11
    }
    #endregion

    #region 系统字典

    /// <summary>
    /// 类描述:系统字典
    /// 创建标识: 2016-05-10
    /// </summary>
    public class ClsDic
    {
        public static System.Collections.Generic.Dictionary<string, string> DicEntity
        {
            get
            {
                return new System.Collections.Generic.Dictionary<string, string>
                {
                    {
                        "日志",
                        ""
                    },
                    {
                        "用户",
                        "18da4207-3bfc-49ea-90f7-16867721805c"
                    }
                };
            }
        }

        public static System.Collections.Generic.Dictionary<string, int> DicRole
        {
            get
            {
                return new System.Collections.Generic.Dictionary<string, int>
                {
                    {
                        "超级管理员",
                        1
                    }
                };
            }
        }

        public static System.Collections.Generic.Dictionary<string, int> DicStatus
        {
            get
            {
                return new System.Collections.Generic.Dictionary<string, int>
                {
                    {
                        "驳回",
                        0
                    },
                    {
                        "通过",
                        1
                    },
                    {
                        "等待审核",
                        2
                    }
                };
            }
        }

        public static System.Collections.Generic.Dictionary<string, int> DicProject
        {
            get
            {
                return new System.Collections.Generic.Dictionary<string, int>
                {
                    {
                        "准备中",
                        0
                    },
                    {
                        "进行中",
                        1
                    },
                    {
                        "延期",
                        2
                    },
                    {
                        "已超时",
                        3
                    },
                    {
                        "已终止",
                        4
                    },
                    {
                        "已验收",
                        5
                    },
                    {
                        "已完成",
                        6
                    },
                    {
                        "已失败",
                        7
                    },
                    {
                        "已违约",
                        8
                    },
                    {
                        "对方违约",
                        9
                    }
                };
            }
        }

        public static System.Collections.Generic.Dictionary<string, int> DicMailSendStatus
        {
            get
            {
                return new System.Collections.Generic.Dictionary<string, int>
                {
                    {
                        "未发送",
                        0
                    },
                    {
                        "已发送",
                        1
                    },
                    {
                        "发送失败",
                        2
                    }
                };
            }
        }

        public static System.Collections.Generic.Dictionary<string, int> DicMailReadStatus
        {
            get
            {
                return new System.Collections.Generic.Dictionary<string, int>
                {
                    {
                        "未读",
                        0
                    },
                    {
                        "已读",
                        1
                    }
                };
            }
        }

        public static System.Collections.Generic.Dictionary<string, int> DicMailType
        {
            get
            {
                return new System.Collections.Generic.Dictionary<string, int>
                {
                    {
                        "发件箱",
                        0
                    },
                    {
                        "收件箱",
                        1
                    },
                    {
                        "垃圾箱",
                        2
                    },
                    {
                        "草稿箱",
                        3
                    },
                    {
                        "已删除",
                        4
                    }
                };
            }
        }

        public static System.Collections.Generic.Dictionary<string, int> DicMessageType
        {
            get
            {
                return new System.Collections.Generic.Dictionary<string, int>
                {
                    {
                        "广播",
                        0
                    },
                    {
                        "群组",
                        1
                    },
                    {
                        "私聊",
                        2
                    }
                };
            }
        }

        public static System.Collections.Generic.Dictionary<string, string> DicCodeType
        {
            get
            {
                System.Collections.Generic.Dictionary<string, string> dictionary = new System.Collections.Generic.Dictionary<string, string>();
                try
                {
                    string fileContent = Utils.GetFileContent(HttpContext.Current.Server.MapPath("/Models/DicType.txt"), false);
                    System.Collections.Generic.List<string> list = fileContent.TrimEnd(new char[]
                    {
                        ','
                    }).TrimStart(new char[]
                    {
                        ','
                    }).Split(new char[]
                    {
                        ','
                    }).ToList<string>();
                    if (list.Count > 0)
                    {
                        foreach (string current in list)
                        {
                            dictionary.Add(current.Split(new char[]
                            {
                                '-'
                            })[0], current.Split(new char[]
                            {
                                '-'
                            })[1]);
                        }
                    }
                }
                catch
                {
                }
                return dictionary;
            }
        }

        public static System.Collections.Generic.Dictionary<string, string> DicAttachmentPath
        {
            get
            {
                return new System.Collections.Generic.Dictionary<string, string>
                {
                    {
                        "上传路径",
                        ConfigurationManager.AppSettings["upfile"]
                    },
                    {
                        "档案简历",
                        ConfigurationManager.AppSettings["upfile"]
                    },
                    {
                        "手机文件",
                        ConfigurationManager.AppSettings["upphone"]
                    },
                    {
                        "手机照片",
                        ConfigurationManager.AppSettings["photofile"]
                    },
                    {
                        "技术文件",
                        ConfigurationManager.AppSettings["upTsfile"]
                    },
                    {
                        "工程图",
                        ConfigurationManager.AppSettings["UploadFiles"]
                    },
                    {
                        "档案头像",
                        ConfigurationManager.AppSettings["upfile"]
                    }
                };
            }
        }

        public static System.Collections.Generic.Dictionary<string, string> DicImageWH
        {
            get
            {
                return new System.Collections.Generic.Dictionary<string, string>
                {
                    {
                        "图片宽度",
                        ConfigurationManager.AppSettings["imgWidth"]
                    },
                    {
                        "图片高度",
                        ConfigurationManager.AppSettings["imgHeight"]
                    },
                    {
                        "手机用户头像高",
                        ConfigurationManager.AppSettings["UserPhotoHeight"]
                    },
                    {
                        "手机用户头像宽",
                        ConfigurationManager.AppSettings["UserPhotoWidth"]
                    },
                    {
                        "用户头像高",
                        ConfigurationManager.AppSettings["PolicePhotoHeight"]
                    },
                    {
                        "用户头像宽",
                        ConfigurationManager.AppSettings["PolicePhotoWidth"]
                    }
                };
            }
        }

        public static System.Collections.Generic.Dictionary<string, string> DicPoliceHouseImageWH
        {
            get
            {
                return new System.Collections.Generic.Dictionary<string, string>
                {
                    {
                        "图片宽度",
                        ConfigurationManager.AppSettings["imgPoliceWidth"]
                    },
                    {
                        "图片高度",
                        ConfigurationManager.AppSettings["imgPoliceHeight"]
                    }
                };
            }
        }

        public static System.Collections.Generic.Dictionary<string, string> OracleReportData
        {
            get
            {
                return new System.Collections.Generic.Dictionary<string, string>
                {
                    {
                        "OrcalReport",
                        ConfigurationManager.AppSettings["connectionString"]
                    }
                };
            }
        }

        public static System.Collections.Generic.Dictionary<string, string> DicPhone
        {
            get
            {
                return new System.Collections.Generic.Dictionary<string, string>
                {
                    {
                        "安卓程序",
                        ConfigurationManager.AppSettings["AndroidName"]
                    },
                    {
                        "苹果程序",
                        ConfigurationManager.AppSettings["IOSName"]
                    }
                };
            }
        }

        public static System.Collections.Generic.Dictionary<string, string> DicCookie
        {
            get
            {
                return new System.Collections.Generic.Dictionary<string, string>
                {
                    {
                        "Session中存储的帐号和CookieID",
                        "AccountCookieID_Session"
                    },
                    {
                        "Cookie中存储的帐号和CookieID",
                        "AccountCookieIDNew"
                    }
                };
            }
        }

        public static System.Collections.Generic.Dictionary<string, string> DicCookieTimeout
        {
            get
            {
                return new System.Collections.Generic.Dictionary<string, string>
                {
                    {
                        "帐号过期时间",
                        "30"
                    }
                };
            }
        }

        public static string GetDicValueByKey(string key, System.Collections.Generic.Dictionary<string, string> p)
        {
            if (p == null || p.Count == 0)
            {
                return "";
            }
            System.Collections.Generic.Dictionary<string, string>.Enumerator enumerator = p.GetEnumerator();
            while (enumerator.MoveNext())
            {
                System.Collections.Generic.KeyValuePair<string, string> current = enumerator.Current;
                if (key == current.Key)
                {
                    return current.Value;
                }
            }
            return "";
        }

        public static string GetDicKeyByValue(string value, System.Collections.Generic.Dictionary<string, string> p)
        {
            if (p == null || p.Count == 0)
            {
                return "";
            }
            System.Collections.Generic.Dictionary<string, string>.Enumerator enumerator = p.GetEnumerator();
            while (enumerator.MoveNext())
            {
                System.Collections.Generic.KeyValuePair<string, string> current = enumerator.Current;
                if (current.Value == value)
                {
                    return current.Key;
                }
            }
            return "";
        }
    }

    #endregion

    #region 业务相关
    /// <summary>
    /// 计划流转状态
    /// </summary>
    public enum enumHCA_RecognitionProgramProcessType
    {
        上报 = 1,
        同意 = 2,
        不同意 = 3
    }
    /// <summary>
    /// 上传文件类型
    /// </summary>
    public enum enumFileType
    {
        其他 = 0,
        Word = 1,
        Excel = 2,
        图片 = 3,
        PPT = 4,
        PDF = 5,
        RAR = 6
    }
    /// <summary>
    ///路单状态
    /// </summary>
    public enum enumWAYBILLSTATE
    {
        分派 = 1,
        打印 = 2,
        数据录入 = 3,
        数据填报 = 4,
        车队审核回收 = 5,
        删除 = 6,
        作废 = 7,
        交接 = 8,
        纳入结算 = 9,
        完成结算 = 10


    }
    /// <summary>
    /// 来源
    /// </summary>
    public enum enumORIGIN
    {
        自建 = 1,
        任务 = 2,
        外委申请 = 3
    }

    /// <summary>
    /// 应急物资规格型号
    /// </summary>
    public enum enumReliefGoodsModel
    {
        规格型号1 = 1,
        规格型号2 = 2,
        规格型号3 = 3
    }
    /// <summary>
    /// 应急抢险救援物资类别
    /// </summary>
    public enum enumReliefGoodsType
    {
        溢油 = 1,
        防汛 = 2
    }
    /// <summary>
    /// 业务咨询枚举,对应业务咨询表的bptype字段
    /// </summary>
    public enum enumBptType
    {
        在线咨询 = 401002,
        身份证 = 501001,
        户籍 = 501002,
        治安管理 = 501003,
        出入境 = 501004,
        消防 = 501005,
        其他业务 = 501006,
        交警 = 501007,
        网安 = 501008,
        法制 = 501009
    }

    public enum enumNewsType
    {
        警务信息 = 301001,
        警方公告 = 301002,
        防范提示 = 101501
    }

    /// <summary>
    /// 上传文件类型
    /// </summary>
    public enum enumBusType
    {

        车辆图片上传 = 100001,
        套管图片上传 = 103002,
        三通图片上传 = 103003,
        阀门图片上传 = 103004,
        占压图片上传 = 103005,


    }


    /// <summary>
    /// 管道维修应急预案级别
    /// </summary>
    public enum enumEmergencyPlanLevel
    {
        中石化 = 1,
        油田 = 2,
        总厂 = 3,
        分厂 = 4
    }

    /// <summary>
    /// 阳极材料
    /// </summary>
    public enum enumAnodeMaterial
    {
        未知 = 0,
        镀铂阳极 = 1,
        磁性氧化铁 = 2,
        混合金属氧化物 = 3,
        镁 = 4,
        锌 = 5,
        铂 = 6,
        高硅铸铁 = 7,
        石墨 = 8,
        废钢铁 = 9,
        碳 = 10,
        铝合金 = 11,
        其它 = 99
    }


    /// <summary>
    /// 业务咨询处理状态枚举,对应业务咨询表的requesStatus字段
    /// </summary>
    public enum enumBussinessType
    {
        后台办理本部门业务 = 1,
        手机办理本部门业务 = 2,
        手机业务 = 3,
        社区民警 = 4
    }

    /// <summary>
    /// 业务咨询处理状态枚举,对应业务咨询表的requesStatus字段
    /// </summary>
    public enum enumRequesStatus
    {
        用户提交 = 0,
        指定处理 = 1,
        处理完成 = 2
    }

    public enum enumWorkType
    {
        未指定 = -1,
        手机方式 = 0,
        电脑Web = 1
    }
    public enum enumIsBool
    {
        是 = 1,
        否 = 2
    }

    public enum enumPhoneUserType
    {
        注册用户 = 1,
        匿名用户 = 2
    }

    public enum enumReplyType
    {
        未处理 = 0,
        审核通过 = 1,
        审核不通过 = 2
    }

    public enum enumBlogType
    {
        新浪微博 = 0,
        腾讯微博 = 1,
        东营公安局的腾讯微博 = 2
    }

    public enum enumProjectType
    {
        [Description("准备中")]
        准备中,
        [Description("进行中")]
        进行中,
        [Description("延期")]
        延期,
        [Description("已超时")]
        已超时,
        [Description("已终止")]
        已终止,
        [Description("已验收")]
        已验收,
        [Description("已完成")]
        已完成,
        [Description("已失败")]
        已失败,
        [Description("已违约")]
        已违约,
        [Description("对方违约")]
        对方违约
    }

    public enum enumProjectLevels
    {
        [Description("普通")]
        普通,
        [Description("一般")]
        一般,
        [Description("加急")]
        加急,
        [Description("最高级")]
        最高级
    }

    public enum enumStatusType
    {
        [Description("驳回")]
        驳回,
        [Description("通过")]
        通过,
        [Description("等待审核")]
        等待审核
    }

    #endregion

}