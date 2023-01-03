﻿using MqttnetServer.Model;
using Prism.Mvvm;

namespace Wu.CommTool.Models
{
    /// <summary>
    /// 订阅的主题
    /// </summary>
    public class MqttSubedTopic : BindableBase
    {
        /// <summary>
        /// 主题
        /// </summary>
        public string Topic { get => _Topic; set => SetProperty(ref _Topic, value); }
        private string _Topic = string.Empty;

        /// <summary>
        /// Parent
        /// </summary>
        public MqttUser Parent { get => _Parent; set => SetProperty(ref _Parent, value); }
        private MqttUser _Parent;
    }
}
