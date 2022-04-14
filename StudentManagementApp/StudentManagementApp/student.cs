using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp
{
    internal class student
    {

        private string _id;
        private string _name;
        private string _major;

        public student(string id, string name, string major)
        {
            this._id = id;
            this._name = name;
            this._major = major;
        }
        public string getId() { return _id; }
        public string getName() { return _name; }
        public string getMajor() { return _major;}
    }
}
