using System;
using System.Collections.Generic;

namespace Taobao.Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.notify.authorizemessages.get
    /// </summary>
    public class NotifyAuthorizemessagesGetRequest : ITopRequest
    {
        public Nullable<int> ExpiredDay { get; set; }
        public string Fields { get; set; }
        public string Nicks { get; set; }
        public Nullable<int> PageNo { get; set; }
        public Nullable<int> PageSize { get; set; }

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.notify.authorizemessages.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("expired_day", this.ExpiredDay);
            parameters.Add("fields", this.Fields);
            parameters.Add("nicks", this.Nicks);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            return parameters;
        }

        #endregion
    }
}
