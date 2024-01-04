using ForceDNS.API;
using ForceDNS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ForceDNS.Services
{
    internal class DnsAddressItems
    {
        private static List<DnsAddress> _servicesUser = new List<DnsAddress>();

        public static List<DnsAddress> GetServicesUser()
        {
            _servicesUser.Clear();
            _servicesUser.Add(new DnsAddress()
            {
                UniqueID = Service.GenerateUniqueID(6),
                dnsAddress = new string[] { "178.22.122.100", "185.51.200.2" },
                Latency = 170,
                Name = "Shecan",
                Picture = Properties.Resources.shecan
            });
            _servicesUser.Add(new DnsAddress()
            {
                UniqueID = Service.GenerateUniqueID(6),
                dnsAddress = new string[] { "87.109.44.98", "0.0.0.0" },
                Latency = 100,
                Name = "STC",
                Picture = Properties.Resources.stc
            });
            _servicesUser.Add(new DnsAddress()
            {
                UniqueID = Service.GenerateUniqueID(6),
                dnsAddress = new string[] { "86.51.67.53", "0.0.0.0" },
                Latency = 100,
                Name = "Mobily",
                Picture = Properties.Resources.Mobily
            });
            _servicesUser.Add(new DnsAddress()
            {
                UniqueID = Service.GenerateUniqueID(6),
                dnsAddress = new string[] { "8.8.8.8", "8.8.4.4" },
                Latency = 24,
                Name = "Google",
                Picture = Properties.Resources.google
            });
            _servicesUser.Add(new DnsAddress()
            {
                UniqueID = Service.GenerateUniqueID(6),
                dnsAddress = new string[] { "1.1.1.1", "1.0.0.1" },
                Latency = 50,
                Name = "Cloudflare",
                Picture = Properties.Resources.cloudflare
            });
            _servicesUser.Add(new DnsAddress()
            {
                UniqueID = Service.GenerateUniqueID(6),
                dnsAddress = new string[] { "9.9.9.9", "149.112.112.112" },
                Latency = 50,
                Name = "Quad9",
                Picture = Properties.Resources.Quad9
            });
            _servicesUser.Add(new DnsAddress()
            {
                UniqueID = Service.GenerateUniqueID(6),
                dnsAddress = new string[] { "79.170.52.30", "0.0.0.0" },
                Latency = 50,
                Name = "Zain",
                Picture = Properties.Resources.zain
            });
            _servicesUser.Add(new DnsAddress()
            {
                UniqueID = Service.GenerateUniqueID(6),
                dnsAddress = new string[] { "208.67.222.222", "208.67.220.220" },
                Latency = 50,
                Name = "OpenDNS",
                Picture = Properties.Resources.OpenDNS
            });

            string[] services = Service.GetServices();
            if (services == null) return _servicesUser;
            foreach (string service in services)
            {
                string[] servicePart = service.Split(' ');
                string uniqueID = servicePart[0];
                string name = servicePart[1];
                string address1 = servicePart[2];
                string address2 = servicePart[3];
                DnsAddress newAddress = new DnsAddress()
                {
                    UniqueID = uniqueID,
                    Latency = 1,
                    Name = name,
                    Picture = Properties.Resources.dns

                };
                if (address2 != "empty")
                    newAddress.dnsAddress = new string[] { address1, address2 };
                else
                    newAddress.dnsAddress = new string[] { address1 };

                _servicesUser.Add(newAddress);
            }

            return _servicesUser;
        }
    }
}
