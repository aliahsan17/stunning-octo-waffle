﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace DBConnectorExample
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the DBConnectorExampleRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.4")]
    [RepositoryFolder("e0de70b5-dc31-4463-b5aa-5fe475e5b518")]
    public partial class DBConnectorExampleRepository : RepoGenBaseFolder
    {
        static DBConnectorExampleRepository instance = new DBConnectorExampleRepository();
        DBConnectorExampleRepositoryFolders.HTMLTableHtmlAppFolder _htmltablehtml;

        /// <summary>
        /// Gets the singleton class instance representing the DBConnectorExampleRepository element repository.
        /// </summary>
        [RepositoryFolder("e0de70b5-dc31-4463-b5aa-5fe475e5b518")]
        public static DBConnectorExampleRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public DBConnectorExampleRepository() 
            : base("DBConnectorExampleRepository", "/", null, 0, false, "e0de70b5-dc31-4463-b5aa-5fe475e5b518", ".\\RepositoryImages\\DBConnectorExampleRepositorye0de70b5.rximgres")
        {
            _htmltablehtml = new DBConnectorExampleRepositoryFolders.HTMLTableHtmlAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("e0de70b5-dc31-4463-b5aa-5fe475e5b518")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The HTMLTableHtml folder.
        /// </summary>
        [RepositoryFolder("5ad26d5c-1d8b-4139-bfe3-6454a8d3da92")]
        public virtual DBConnectorExampleRepositoryFolders.HTMLTableHtmlAppFolder HTMLTableHtml
        {
            get { return _htmltablehtml; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.4")]
    public partial class DBConnectorExampleRepositoryFolders
    {
        /// <summary>
        /// The HTMLTableHtmlAppFolder folder.
        /// </summary>
        [RepositoryFolder("5ad26d5c-1d8b-4139-bfe3-6454a8d3da92")]
        public partial class HTMLTableHtmlAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _sometabletagInfo;

            /// <summary>
            /// Creates a new HTMLTableHtml  folder.
            /// </summary>
            public HTMLTableHtmlAppFolder(RepoGenBaseFolder parentFolder) :
                    base("HTMLTableHtml", "/dom[@page='HTMLTable.html']", parentFolder, 30000, null, false, "5ad26d5c-1d8b-4139-bfe3-6454a8d3da92", "")
            {
                _sometabletagInfo = new RepoItemInfo(this, "SomeTableTag", "?/?/table", 30000, null, "1adbf891-1078-445f-b779-16551d850cc7");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("5ad26d5c-1d8b-4139-bfe3-6454a8d3da92")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("5ad26d5c-1d8b-4139-bfe3-6454a8d3da92")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The SomeTableTag item.
            /// </summary>
            [RepositoryItem("1adbf891-1078-445f-b779-16551d850cc7")]
            public virtual Ranorex.TableTag SomeTableTag
            {
                get
                {
                    return _sometabletagInfo.CreateAdapter<Ranorex.TableTag>(true);
                }
            }

            /// <summary>
            /// The SomeTableTag item info.
            /// </summary>
            [RepositoryItemInfo("1adbf891-1078-445f-b779-16551d850cc7")]
            public virtual RepoItemInfo SomeTableTagInfo
            {
                get
                {
                    return _sometabletagInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}