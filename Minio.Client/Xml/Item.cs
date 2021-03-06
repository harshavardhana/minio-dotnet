﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minio.Client.Xml
{
    [Serializable]
    public class Item
    {
        private string etag;

        public string Key { get; set; }
        public string LastModified { get; set; }
        public string ETag
        {
            get
            {
                return etag;
            }
            set
            {
                if (value != null)
                {
                    etag = value.Replace("\"", "");
                }
                else
                {
                    etag = null;
                }
            }
        }
        public UInt64 Size { get; set; }

        public bool IsDir { get; set; }

        public DateTime LastModifiedDateTime
        {
            get
            {
                return DateTime.Parse(this.LastModified);
            }
        }
    }
}
