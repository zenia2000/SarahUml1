using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MammaPizza
{
    public class Customer 
    {
        //instance for customer
        private int _cId;
        private string _name;
        private string _email;
        private string _address;

        public Customer(int cId, string name, string email, string address)
        {
            _cId = cId;
            _name = name;
            _email = email;
            _address = address;
        }
        
        public int Cid 
        {
            get { return _cId; } 
            set { _cId = value; }
        }
        public string Name 
        { 
            get { return _name; } 
            set { _name = value; }
        }
        public string Email 
        {
            get { return _email; } 
            set { _email = value; }
        }
        public string Address 
        {
            get { return _address; } 
            set { _address = value; }
        }

        public override string ToString()
        {
            return $"{_cId} {_name}";
        }

    }
}

