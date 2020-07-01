using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Enumeration;

namespace SampleUwpApp.Models.Interfaces
{
    internal interface IDeviceObject
    {
        string Id { get; }
        bool IsDefault { get; }
        bool IsEnabled { get; }
        string Name { get; }
        IReadOnlyDictionary<string, object> Properties { get; }
        DeviceInformationKind Kind { get; }
    }

    public sealed class DeviceObject : IDeviceObject
    {
        public string Id => _id;

        public bool IsDefault => _isDefault;

        public bool IsEnabled => _isEnabled;

        public string Name => _name;

        public IReadOnlyDictionary<string, object> Properties => _properties;

        public DeviceInformationKind Kind => _kind;


        private string _id;
        private bool _isDefault;
        private bool _isEnabled;
        private string _name;
        private IReadOnlyDictionary<string, object> _properties;
        private DeviceInformationKind _kind;

        public DeviceObject(string id, bool isDefault, bool isEnabled, string name, IReadOnlyDictionary<string, object> properties, DeviceInformationKind Kind)
        {
            _id = id;
            _isDefault = isDefault;
            _isEnabled = isEnabled;
            _name = name;
            _properties = properties;
            _kind = Kind;
        }
    }
}
