﻿using System.ComponentModel;
using Wu.CommTool.Converters;

namespace Wu.CommTool.Models
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum MessageType : int
    {
        [Description("消息")]
        Info = 0,
        [Description("接收")]
        Receive = 1,
        [Description("发送")]
        Send = 2,
        [Description("错误")]
        Error = 3
    }
}
