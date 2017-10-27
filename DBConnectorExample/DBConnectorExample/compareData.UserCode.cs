﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
// 
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace DBConnectorExample
{
    public partial class CompareData
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void compareWholeTable(Ranorex.Adapter repoItem, string filename_ReferenceTableSnapshot, string customLogMessageOverall, string customLogMessageDetail)
        {
		     // check if snapshot file exists   
		    const string fileNotExists = "The given file does not exist: {0}";   
		    if (!System.IO.File.Exists(filename_ReferenceTableSnapshot))   
		    {   
		        throw new Ranorex.ValidationException(string.Format(fileNotExists, filename_ReferenceTableSnapshot));   
		    }   
		   
		    ElementSnapshot snap = null;   
		    try   
		    {   
		        snap = Ranorex.Core.ElementSnapshot.CreateFromFile (filename_ReferenceTableSnapshot); // ElementSnapshot.CreateFromFile is available starting with Ranorex 5.4.2  
		    }   
		    catch   
		    {   
		        throw new Ranorex.ValidationException("Snapshot could not be loaded from file");   
		    }   
		   
		    // restore table from snapshot   
		    Ranorex.Table refTable;   
		    try   
		    {   
		        refTable = snap.Element;   
		    }   
		    catch   
		    {   
		        throw new Ranorex.ValidationException("Table could not be created from snapshot");   
		    }   
		    var tableAdapter = repoItem.As <Ranorex.Table>();   
		    if (tableAdapter==null)   
		    {   
		        throw new Ranorex.ValidationException("Repo-item could not be accessed");   
		    }   
		   
		    // check if rowcount is identical   
		    if (tableAdapter.Rows.Count != refTable.Rows.Count)   
		    {   
		        throw new Ranorex.ValidationException(String.Format ("Tables do not have same number of rows ({0} vs. {1})", tableAdapter.Rows.Count, refTable.Rows.Count));   
		    }   
		   
		    // run through table-rows   
		    for (int iRow = 0; iRow <= tableAdapter.Rows.Count - 1; iRow++)   
		    {   
		        int cellCountCur = tableAdapter.Rows[iRow].Cells.Count;   
		        int cellCountRef = refTable.Rows[iRow].Cells.Count;   
		   
		         // check if number of cells is identical in current row   
		        if (cellCountCur != cellCountRef)   
		        {   
		            throw new Ranorex.ValidationException(String.Format("Table-Rows do not have same number of cells ({0} vs. {1})", cellCountCur, cellCountRef));   
		        }   
		   
		         // run through cells in current row   
		        for (int iCol = 0; iCol <= cellCountCur - 1; iCol++)   
		        {   
		            string aCurText = tableAdapter.Rows[iRow].Cells[iCol].As<Ranorex.Cell>().Text;   
		            string aRefText = refTable.Rows[iRow].Cells[iCol].As<Ranorex.Cell>().Text;   
		               
		            string validationMessage = string.Empty;   
		            if (string.IsNullOrEmpty(customLogMessageDetail))  
		            {   
		                validationMessage = String.Format ("Comparing content of cell ({2}/{3}) (found:'{0}', expected: '{1}')", aCurText, aRefText, iRow,iCol);   
		            }   
		            else   
		            {   
		                validationMessage = customLogMessageDetail;   
		            }   
		   
		            // validate whether current text and expected text are identical   
		            Ranorex.Validate.AreEqual (aCurText, aRefText, validationMessage);   
		        }   
		    }   
		    // Log overall success   
		    if (string.IsNullOrEmpty(customLogMessageOverall))  
		        customLogMessageOverall = "Successfully completed content-validation of table with provided snapshot of table (reference)";   
		    Ranorex.Report.Log (ReportLevel.Success, customLogMessageOverall);   
        	
        }

    }
}