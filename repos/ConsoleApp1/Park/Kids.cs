using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Park
{
    internal class Kids
    {
        public Kids(uint money, byte height, string name, Enum gender, int hapiness)
        {
            _money = money;
            _height = height;
            _name = name;
            _hapiness = hapiness;
            //_cry = cry;
            _gender = gender;
        }

        private uint _money;
        private byte _height;
        private string _name;
        private int _hapiness;
        private bool _cry;
        private Enum _gender;
    }
}