using System;
using System.Collections.Generic;

namespace Microsoft.Azure.Devices.Applications.RemoteMonitoring.DeviceAdmin.Web.Models
{
    public class DeviceCommandHistoryEntryModel
    {
        public string Name { get; set; }

        public string MessageId { get; set; }

        public string Result { get; set; }

        public string ErrorMessage { get; set; }
       
        public DateTime CreatedTime { get; set; }

        public DateTime? UpdatedTime { get; set; }

        public Dictionary<string, string> Parameters { get; set; }
    }
}