using System.Collections.Generic;

namespace ScanMyBinCSharp.Types
{
    public class JsonResult
    {
        public string filename
        {
            get
            {
                return m_filename;
            }
            set
            {
                m_filename = value;
            }
        }
        private string m_filename;

        public string Size
        {
            get
            {
                return m_filesize;
            }
            set
            {
                m_filesize = value;
            }
        }
        private string m_filesize;

        public string Md5
        {
            get
            {
                return m_md5;
            }
            set
            {
                m_md5 = value;
            }
        }
        private string m_md5;

        public string Detection
        {
            get
            {
                return m_detection;
            }
            set
            {
                m_detection = value;
            }
        }
        private string m_detection;

        public string Total
        {
            get
            {
                return m_total;
            }
            set
            {
                m_total = value;
            }
        }
        private string m_total;

        public string Date
        {
            get
            {
                return m_date;
            }
            set
            {
                m_date = value;
            }
        }
        private string m_date;

        public Dictionary<string, string> Data
        {
            get
            {
                return m_data;
            }
            set
            {
                m_data = value;
            }
        }
        private Dictionary<string, string> m_data;
    }

}
