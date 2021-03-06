using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// LogisticsPartner Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsPartner : TopObject
    {
        /// <summary>
        /// 揽收说明信息
        /// </summary>
        [XmlElement("cover_remark")]
        public string CoverRemark { get; set; }

        /// <summary>
        /// 物流公司详细信息
        /// </summary>
        [XmlElement("partner")]
        public Partner Partner { get; set; }

        /// <summary>
        /// 不可送达的说明信息
        /// </summary>
        [XmlElement("uncover_remark")]
        public string UncoverRemark { get; set; }
    }
}
