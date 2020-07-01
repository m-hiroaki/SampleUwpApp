using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Enumeration.Pnp;
using Windows.Foundation;

namespace SampleUwpApp.Models.Interfaces
{
    internal interface IPnpDevice
    {
        string Id { get; }
        IReadOnlyDictionary<string, object> Properties { get; }
        PnpObjectType Type { get; }
    }

    public sealed class PnpDevice : IPnpDevice
    {
        public string Id => _id;

        public IReadOnlyDictionary<string, object> Properties => _properties;

        public PnpObjectType Type => _type;

        private string _id;
        private IReadOnlyDictionary<string, object> _properties;
        private PnpObjectType _type;

        internal PnpDevice(string Id, IReadOnlyDictionary<string, object> Properties, PnpObjectType Type)
        {
            _id = Id;
            _properties = Properties;
            _type = Type;
        }
    }
}
