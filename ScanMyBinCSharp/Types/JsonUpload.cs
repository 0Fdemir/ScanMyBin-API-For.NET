namespace ScanMyBinCSharp.Types
{
    public class JsonUpload
    {
        public int Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }
        private int _status;

        public string Status_strg
        {
            get
            {
                return _status_strg;
            }
            set
            {
                _status_strg = value;
            }
        }
        private string _status_strg;

        public string scan_id
        {
            get
            {
                return _scan_id;
            }
            set
            {
                _scan_id = value;
            }
        }
        private string _scan_id;
    }

}
