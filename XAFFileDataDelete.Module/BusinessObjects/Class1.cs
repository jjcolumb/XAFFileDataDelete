using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAFFileDataDelete.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class PersistentClass : BaseObject
    {
        public PersistentClass(Session session) : base(session)
        { }


        FileData testFile;
        public FileData TestFile
        {
            get => testFile;
            set => SetPropertyValue(nameof(TestFile), ref testFile, value);
        }
    }
}
