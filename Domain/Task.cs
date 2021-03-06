using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// Task Data Structure.
    /// </summary>
    [Serializable]
    public class Task : TopObject
    {
        /// <summary>
        /// 任务创建时间
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 此任务是由哪个api产生的
        /// </summary>
        [XmlElement("method")]
        public string Method { get; set; }

        /// <summary>
        /// 异步任务处理状态。new（还未开始处理），doing（处理中），done（处理结束）。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 子任务处理结果，如果任务还没有处理完，返回的结果列表为空。如果任务处理完毕，返回子任务结果列表
        /// </summary>
        [XmlArray("subtasks")]
        [XmlArrayItem("subtask")]
        public List<Subtask> Subtasks { get; set; }

        /// <summary>
        /// 异步任务id。创建异步任务时返回的任务id号
        /// </summary>
        [XmlElement("task_id")]
        public long TaskId { get; set; }
    }
}
