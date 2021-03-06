using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// FenxiaoProduct Data Structure.
    /// </summary>
    [Serializable]
    public class FenxiaoProduct : TopObject
    {
        /// <summary>
        /// 警戒库存
        /// </summary>
        [XmlElement("alarm_number")]
        public long AlarmNumber { get; set; }

        /// <summary>
        /// 所在地：市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 采购价格，单位：元。
        /// </summary>
        [XmlElement("cost_price")]
        public string CostPrice { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 产品描述路径，通过http请求获取
        /// </summary>
        [XmlElement("desc_path")]
        public string DescPath { get; set; }

        /// <summary>
        /// 是否有保修，可选值：false（否）、true（是）
        /// </summary>
        [XmlElement("have_guarantee")]
        public bool HaveGuarantee { get; set; }

        /// <summary>
        /// 是否有发票，可选值：false（否）、true（是）
        /// </summary>
        [XmlElement("have_invoice")]
        public bool HaveInvoice { get; set; }

        /// <summary>
        /// 下载人数
        /// </summary>
        [XmlElement("items_count")]
        public long ItemsCount { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 累计采购次数
        /// </summary>
        [XmlElement("orders_count")]
        public long OrdersCount { get; set; }

        /// <summary>
        /// 商家编码
        /// </summary>
        [XmlElement("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// 产品图片路径
        /// </summary>
        [XmlElement("pictures")]
        public string Pictures { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        [XmlElement("pid")]
        public long Pid { get; set; }

        /// <summary>
        /// ems费用，单位：元
        /// </summary>
        [XmlElement("postage_ems")]
        public string PostageEms { get; set; }

        /// <summary>
        /// 快递费用，单位：元
        /// </summary>
        [XmlElement("postage_fast")]
        public string PostageFast { get; set; }

        /// <summary>
        /// 运费模板ID
        /// </summary>
        [XmlElement("postage_id")]
        public long PostageId { get; set; }

        /// <summary>
        /// 平邮费用，单位：元
        /// </summary>
        [XmlElement("postage_ordinary")]
        public string PostageOrdinary { get; set; }

        /// <summary>
        /// 运费类型，可选值：seller（供应商承担运费）、buyer（分销商承担运费）
        /// </summary>
        [XmlElement("postage_type")]
        public string PostageType { get; set; }

        /// <summary>
        /// 产品线ID
        /// </summary>
        [XmlElement("productcat_id")]
        public long ProductcatId { get; set; }

        /// <summary>
        /// 所在地：省
        /// </summary>
        [XmlElement("prov")]
        public string Prov { get; set; }

        /// <summary>
        /// 产品库存
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 最高零售价，单位：分。
        /// </summary>
        [XmlElement("retail_price_high")]
        public string RetailPriceHigh { get; set; }

        /// <summary>
        /// 最低零售价，单位：分。
        /// </summary>
        [XmlElement("retail_price_low")]
        public string RetailPriceLow { get; set; }

        /// <summary>
        /// sku列表
        /// </summary>
        [XmlArray("skus")]
        [XmlArrayItem("fenxiao_sku")]
        public List<FenxiaoSku> Skus { get; set; }

        /// <summary>
        /// 采购价格，单位：元。
        /// </summary>
        [XmlElement("standard_price")]
        public string StandardPrice { get; set; }

        /// <summary>
        /// 发布状态，可选值：up（上架）、down（下架）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
