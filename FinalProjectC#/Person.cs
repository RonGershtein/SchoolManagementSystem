using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectC_
{
    [Serializable]
    internal class Person
    {
        public string id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
       
        public string gender { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }

        public Person()
        {
            id = string.Empty;
            name = string.Empty;
            age = 0;
            gender = string.Empty;
            address = string.Empty;
        }

        // Get functions
        public string getId() { return id; }
        public string getName() { return name; }   
        public int getAge() { return age; }
        public string getGender() { return gender; }
        public string getAddress() {  return address; }
        public string getPhoneNumber() { return phoneNumber; }

        // Set functions
        public void setId(string id) { this.id = id;}
        public void setName(string name) { this.name = name;}
        public void setAge(int age) { this.age = age;}  
        public void setGender(string gender) {  this.gender = gender;}
        public void setAddrass(string address) {this.address = address;}
        public void setPhoneNumber(string phoneNumber) {  this.phoneNumber = phoneNumber;}

    }
}
