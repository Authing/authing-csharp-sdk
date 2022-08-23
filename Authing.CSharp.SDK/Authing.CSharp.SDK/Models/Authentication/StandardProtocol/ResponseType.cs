using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public class ResponseType
    {
        public static string Value { get; set; }

        private ResponseType(string value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }


        public static ResponseType CODE
        {
            get { return new ResponseType("code"); }
            set { }
        }

        public static ResponseType CODE_TOKEN_IDTOKEN
        {
            get { return new ResponseType("code id_token token"); }
            set { }
        }

        public static ResponseType CODE_IDTOKEN
        {
            get { return new ResponseType("code id_token"); }
            set { }
        }

        public static ResponseType CODE_TOKEN
        {
            get { return new ResponseType("code token"); }
            set { }
        }

        public static ResponseType TOKEN_IDTOKEN
        {
            get { return new ResponseType("id_token token"); }
            set { }
        }

        public static ResponseType IDTOKEN
        {
            get { return new ResponseType("id_token"); }
            set { }
        }

        public static ResponseType NONE
        {
            get { return new ResponseType("none"); }
            set { }
        }
    }
}
