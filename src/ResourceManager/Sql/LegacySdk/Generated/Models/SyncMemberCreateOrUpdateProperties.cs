// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.Sql.LegacySdk.Models;

namespace Microsoft.Azure.Management.Sql.LegacySdk.Models
{
    /// <summary>
    /// Properties can be specified when creating or updating a sync member.
    /// </summary>
    public partial class SyncMemberCreateOrUpdateProperties
    {
        private string _databaseName;
        
        /// <summary>
        /// Optional. The Azure SQL Server database name of the member database.
        /// </summary>
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }
        
        private Microsoft.Azure.Management.Sql.LegacySdk.Models.DatabaseTypeEnum? _databaseType;
        
        /// <summary>
        /// Optional. The database type. Possible values: 'SqlServerDatabase',
        /// 'AzureSqlDatabase'. When the type is 'SqlServerDatabase',
        /// SyncAgentId and SqlServerDatabaseId should be specified. When the
        /// type is 'AzureSqlDatabase', MemberServerName, MemberDatabaseName
        /// and Credential should be specified.
        /// </summary>
        public Microsoft.Azure.Management.Sql.LegacySdk.Models.DatabaseTypeEnum? DatabaseType
        {
            get { return this._databaseType; }
            set { this._databaseType = value; }
        }
        
        private string _password;
        
        /// <summary>
        /// Optional. The password of Azure SQL database.
        /// </summary>
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }
        
        private string _serverName;
        
        /// <summary>
        /// Optional. The Azure SQL Server Name of the member database.
        /// </summary>
        public string ServerName
        {
            get { return this._serverName; }
            set { this._serverName = value; }
        }
        
        private string _sqlServerDatabaseId;
        
        /// <summary>
        /// Optional. The id of the SQL server database which is connected by
        /// the sync agent.
        /// </summary>
        public string SqlServerDatabaseId
        {
            get { return this._sqlServerDatabaseId; }
            set { this._sqlServerDatabaseId = value; }
        }
        
        private string _syncAgentId;
        
        /// <summary>
        /// Optional. The resource id of the sync agent
        /// </summary>
        public string SyncAgentId
        {
            get { return this._syncAgentId; }
            set { this._syncAgentId = value; }
        }
        
        private Microsoft.Azure.Management.Sql.LegacySdk.Models.SyncDirectionEnum? _syncDirection;
        
        /// <summary>
        /// Optional. Specifies the sync direction of doing data
        /// synchronization for this sync member. The possible values:
        /// 'Bidirectional', 'OneWayMemberToHub' and 'OneWayHubToMember.
        /// </summary>
        public Microsoft.Azure.Management.Sql.LegacySdk.Models.SyncDirectionEnum? SyncDirection
        {
            get { return this._syncDirection; }
            set { this._syncDirection = value; }
        }
        
        private string _userName;
        
        /// <summary>
        /// Optional. The user name of Azure SQL database.
        /// </summary>
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// SyncMemberCreateOrUpdateProperties class.
        /// </summary>
        public SyncMemberCreateOrUpdateProperties()
        {
        }
    }
}
