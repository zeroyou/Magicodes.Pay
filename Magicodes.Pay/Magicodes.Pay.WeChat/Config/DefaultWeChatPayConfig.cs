﻿namespace Magicodes.Pay.WeChat.Config
{
    /// <summary>
    /// 微信支付默认配置信息
    /// </summary>
    public class DefaultWeChatPayConfig : IWeChatPayConfig
    {
        /// <summary>
        /// APPId
        /// </summary>
        public string PayAppId { get; set; }

        /// <summary>
        /// 商户Id
        /// </summary>
        public string MchId { get; set; }

        /// <summary>
        /// 支付回调路径
        /// </summary>
        public string PayNotifyUrl { get; set; }

        /// <summary>
        /// 支付密钥
        /// </summary>
        public string TenPayKey { get; set; }
        /// <summary>
        /// 商户证书相对路径
        /// </summary>
      public  string PayCertPath { get; set; }
        /// <summary>
        /// 证书密钥（商户id）
        /// </summary>
      public  string CertPassword { get; set; }
    }
}
