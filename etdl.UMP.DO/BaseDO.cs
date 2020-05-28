using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etdl.UMP.DO
{
    public abstract class BaseDO
    {
        int _Id = 0;
        public int Id    
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private DateTime _CreatedDate = DateTime.MinValue;
        
        public DateTime CreatedDate
        {
            get { return _CreatedDate; }
            set { _CreatedDate = value; }
        }

        private DateTime _ModifiedDate = DateTime.MinValue;

        public DateTime ModifiedDate
        {
            get { return _ModifiedDate; }
            set { _ModifiedDate = value; }
        }

        private int _CreatedBy = 0;
        public int CreatedBy
        {
            get { return _CreatedBy; }
            set { _CreatedBy = value; }
        }

        private int _ModifiedBy = 0;
        public int ModifiedBy
        {
            get { return _ModifiedBy; }
            set { _ModifiedBy = value; }
        }
    }
}
