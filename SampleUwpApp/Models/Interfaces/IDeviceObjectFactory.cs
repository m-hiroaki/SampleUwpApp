using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Enumeration;

namespace SampleUwpApp.Models.Interfaces
{
    internal interface IDeviceObjectFactory
    {
        Task<List<DeviceObject>> FindAllAsync(string aqsFilter, IEnumerable<string> additionalProperties);
    }

    public sealed class DeviceObjectFactory : IDeviceObjectFactory
    {
        public async Task<List<DeviceObject>> FindAllAsync(string aqsFilter, IEnumerable<string> additionalProperties)
        {
            var deviceInfos = await DeviceInformation.FindAllAsync(aqsFilter, additionalProperties);

            var list = new List<DeviceObject>();

            foreach (var devInfo in deviceInfos)
            {
                list.Add
                    (
                        new DeviceObject(devInfo.Id, devInfo.IsDefault, devInfo.IsEnabled, devInfo.Name, devInfo.Properties, devInfo.Kind)
                    ); ;
            }

            return list;
        }
    }
}
