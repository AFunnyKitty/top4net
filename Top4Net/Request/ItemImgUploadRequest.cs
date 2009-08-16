using System;
using System.IO;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.img.upload
    /// </summary>
    public class ItemImgUploadRequest : ITopUploadRequest
    {
        /// <summary>
        /// 商品图片编号。
        /// </summary>
        public string ImgId { get; set; }

        /// <summary>
        /// 商品编号。
        /// </summary>
        public string Iid { get; set; }

        /// <summary>
        /// 商品图片位置。
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// 商品图片内容。
        /// </summary>
        public FileInfo Image { get; set; }

        /// <summary>
        /// 是否将该图片设为主图。
        /// </summary>
        public bool IsPrimary { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.img.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("itemimg_id", this.ImgId);
            parameters.Add("iid", this.Iid);
            parameters.Add("position", this.Position.ToString());
            parameters.Add("is_major", this.IsPrimary.ToString());

            return parameters;
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileInfo> GetFileParameters()
        {
            IDictionary<string, FileInfo> parameters = new Dictionary<string, FileInfo>();
            parameters.Add("image", this.Image);
            return parameters;
        }

        #endregion
    }
}
