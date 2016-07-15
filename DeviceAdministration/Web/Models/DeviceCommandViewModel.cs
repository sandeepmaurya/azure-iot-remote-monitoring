using System.Collections.Generic;
using Microsoft.Azure.Devices.Applications.RemoteMonitoring.DeviceAdmin.Web.Security;

namespace Microsoft.Azure.Devices.Applications.RemoteMonitoring.DeviceAdmin.Web.Models
{
    public class DeviceCommandViewModel
    {
        public DeviceCommandHistoryEntryModel[] CommandHistory { get; set; }

        public string DeviceId { get; set; }

        public bool? DeviceIsEnabled { get; set; }

        public DeviceCommandModel[] Commands { get; set; }

        public string CommandsJson { get; set; }

        public bool SupportDeviceCommand
        {
            get
            {
                return PermsChecker.HasPermission(Permission.SendCommandToDevices);
            }
        }

        public SendCommandModel SendCommandModel { get; set; }

        public bool CanSendComamnds
        {
            get { return SupportDeviceCommand & SendCommandModel != null & SendCommandModel.CanSendDeviceCommands; }
        }
    }

}