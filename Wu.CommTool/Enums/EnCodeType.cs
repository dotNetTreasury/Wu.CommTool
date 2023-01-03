﻿using System.ComponentModel;
using Wu.Wpf.Converters;

namespace Wu.CommTool.Enums
{
    /// <summary>
    /// 编码类型
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum EnCodeType
    {
        [Description("16进制")]
        Hex = 0,
        Json = 1,
        文本 = 2,

    }
}
