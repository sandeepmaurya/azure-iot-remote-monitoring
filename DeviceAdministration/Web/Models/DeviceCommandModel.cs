namespace Microsoft.Azure.Devices.Applications.RemoteMonitoring.DeviceAdmin.Web.Models
{
    public class DeviceCommandModel
    {
        public string Name { get; set; }

        public DeviceCommandParameterModel[] Parameters { get; set; }
    }

    public class DeviceCommandParameterModel
    {
        public string Name { get; set; }

        public string Type { get; set; }
    }
}