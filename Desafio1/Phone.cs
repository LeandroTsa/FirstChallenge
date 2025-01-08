using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Phone
    {
        private string Model;
        private string Brand;
        private string phoneNumber;
        private int operatorCode;

        public Phone(string model, string brand)
        {
            this.Model = model;
            this.Brand = brand;
        }

        public int opCode{ set { operatorCode = value; } }
        public int OpCode
        
        {

            set
            {

                if (value > 0 && value < 4)
                {
                    operatorCode = value;
                }
                else
                {
                    operatorCode = 0;
                }

            }
            get { return operatorCode; }

        }
        public string phoneNum { get { return phoneNumber; }
            set { 
                phoneNumber = value;
            }
        }
        public string brand { get {
                return Brand;
            } }
        public string model
        {
            get
            {
                return Model;
            }
        }

            public string Call()
        {
            return "calling to: ";
        }
        public string Call(string contact)
        {
            return Call() + contact;
        }

    }

}
