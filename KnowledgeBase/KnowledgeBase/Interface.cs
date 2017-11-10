using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeBase
{
    public class Interface
    {
        public Interface()
        {
            //default constructor
        }
        public string error_code
        {
            get
            {
                return this.error_code;
            }
            set
            {
                this.error_code = value;
            }
        }
        public string version
        {
            get
            {
                return this.version;
            }
            set
            {
                this.version = value;
            }
        }
        public string description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }
        public string solution
        {
            get
            {
                return this.solution;
            }
            set
            {
                this.solution = value;
            }
        }
        public string username
        {
            get
            {
                return this.username;
            }
            set
            {
                this.solution = value;
            }
        }
        public string password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }

    }
}
