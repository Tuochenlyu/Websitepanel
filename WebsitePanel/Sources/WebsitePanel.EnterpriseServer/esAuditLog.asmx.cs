// Copyright (c) 2015, Outercurve Foundation.
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
//
// - Redistributions of source code must  retain  the  above copyright notice, this
//   list of conditions and the following disclaimer.
//
// - Redistributions in binary form  must  reproduce the  above  copyright  notice,
//   this list of conditions  and  the  following  disclaimer in  the documentation
//   and/or other materials provided with the distribution.
//
// - Neither  the  name  of  the  Outercurve Foundation  nor   the   names  of  its
//   contributors may be used to endorse or  promote  products  derived  from  this
//   software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING,  BUT  NOT  LIMITED TO, THE IMPLIED
// WARRANTIES  OF  MERCHANTABILITY   AND  FITNESS  FOR  A  PARTICULAR  PURPOSE  ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR
// ANY DIRECT, INDIRECT, INCIDENTAL,  SPECIAL,  EXEMPLARY, OR CONSEQUENTIAL DAMAGES
// (INCLUDING, BUT NOT LIMITED TO,  PROCUREMENT  OF  SUBSTITUTE  GOODS OR SERVICES;
// LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)  HOWEVER  CAUSED AND ON
// ANY  THEORY  OF  LIABILITY,  WHETHER  IN  CONTRACT,  STRICT  LIABILITY,  OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE)  ARISING  IN  ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

using System;
using System.Data;
using System.Web;
using System.Collections;
using System.Collections.Generic;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

using Microsoft.Web.Services3;

namespace WebsitePanel.EnterpriseServer
{
    /// <summary>
    /// Summary description for esApplicationsInstaller
    /// </summary>
    [WebService(Namespace = "http://smbsaas/websitepanel/enterpriseserver")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [Policy("ServerPolicy")]
    [ToolboxItem(false)]
    public class esAuditLog : System.Web.Services.WebService
    {
        [WebMethod]
        public DataSet GetAuditLogRecordsPaged(int userId, int packageId, int itemId, string itemName, DateTime startDate, DateTime endDate,
            int severityId, string sourceName, string taskName, string sortColumn, int startRow, int maximumRows)
        {
            return AuditLog.GetAuditLogRecordsPaged(userId, packageId, itemId, itemName, startDate, endDate,
                severityId, sourceName, taskName, sortColumn, startRow, maximumRows);
        }

        [WebMethod]
        public DataSet GetAuditLogSources()
        {
            return AuditLog.GetAuditLogSources();
        }

        [WebMethod]
        public DataSet GetAuditLogTasks(string sourceName)
        {
            return AuditLog.GetAuditLogTasks(sourceName);
        }

        [WebMethod]
        public LogRecord GetAuditLogRecord(string recordId)
        {
            return AuditLog.GetAuditLogRecord(recordId);
        }

        [WebMethod]
        public int DeleteAuditLogRecords(int userId, int itemId, string itemName,
            DateTime startDate, DateTime endDate, int severityId, string sourceName, string taskName)
        {
            return AuditLog.DeleteAuditLogRecords(userId, itemId, itemName, startDate, endDate, severityId, sourceName, taskName);
        }

        [WebMethod]
        public int DeleteAuditLogRecordsComplete()
        {
            return AuditLog.DeleteAuditLogRecordsComplete();
        }
    }
}
