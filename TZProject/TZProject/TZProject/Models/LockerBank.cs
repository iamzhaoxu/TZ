using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace TZProject.Models
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class LockerBank
    {
        private LockersColumn[] columnListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("LockersColumn", IsNullable = false)]
        public LockersColumn[] ColumnList
        {
            get
            {
                return this.columnListField;
            }
            set
            {
                this.columnListField = value;
                if (this.columnListField.Length > 0)
                {
                    ColumnWidth = (100 / this.columnListField.Length + "%").ToString();
                }
                else
                {
                    ColumnWidth = "auto";
                }
            }
        }

        [XmlIgnore]
        public string ColumnWidth
        {
            get;
            private set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class LockersColumn
        {
            private LockerInfo[] lockersListField;

            private byte widthField;

            private bool widthFieldSpecified;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("LockerInfo", IsNullable = false)]
            public LockerInfo[] LockersList
            {
                get
                {
                    return this.lockersListField;
                }
                set
                {
                    this.lockersListField = value;
                }
            }

            /// <remarks/>
            public byte Width
            {
                get
                {
                    return this.widthField;
                }
                set
                {
                    this.widthField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool WidthSpecified
            {
                get
                {
                    return this.widthFieldSpecified;
                }
                set
                {
                    this.widthFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class LockerInfo
        {

            private string nameField;

            private string sizeField;

            private bool terminalField;

            /// <remarks/>
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public string Size
            {
                get
                {
                    return this.sizeField;
                }
                set
                {
                    this.sizeField = value;
                }
            }

            /// <remarks/>
            public bool Terminal
            {
                get
                {
                    return this.terminalField;
                }
                set
                {
                    this.terminalField = value;
                }
            }
        }

    }
}