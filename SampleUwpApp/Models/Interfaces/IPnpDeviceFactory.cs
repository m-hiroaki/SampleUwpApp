using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Devices.Enumeration.Pnp;

namespace SampleUwpApp.Models.Interfaces
{
    public interface IPnpDeviceFactory
    {
        Task<List<PnpDevice>> FindAllAsync(PnpObjectType type, IEnumerable<string> requestedProperties);
        Task<List<PnpDevice>> FindAllAsync(PnpObjectType type, IEnumerable<string> requestedProperties, string aqsFilter);
    }

    public sealed class PnpDeviceFactory : IPnpDeviceFactory
    {
        public async Task<List<PnpDevice>> FindAllAsync(PnpObjectType type, IEnumerable<string> requestedProperties)
        {
            var pnpObjects = await PnpObject.FindAllAsync(type, requestedProperties);

            var list = new List<PnpDevice>();

            foreach (var pnpObject in pnpObjects)
            {
                list.Add
                    (
                        new PnpDevice(pnpObject.Id, pnpObject.Properties, pnpObject.Type)
                    );
            }

            return list;
        }

        public async Task<List<PnpDevice>> FindAllAsync(PnpObjectType type, IEnumerable<string> requestedProperties, string aqsFilter)
        {
            var pnpObjects = await PnpObject.FindAllAsync(type, requestedProperties, aqsFilter);

            var list = new List<PnpDevice>();

            foreach (var pnpObject in pnpObjects)
            {
                list.Add
                    (
                        new PnpDevice(pnpObject.Id, pnpObject.Properties, pnpObject.Type)
                    );
            }

            return list;
        }
    }
}