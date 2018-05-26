namespace ScanMyBinCSharp.Types
{
    public class JsonStatus
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
    }

}
