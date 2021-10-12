using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project_4
{
   static class Contacts
    {
        static public string name, middleName, lastName, address, gender, phoneNumber,conText, imagePath = "img\\image_not_available.png";
        static public int numCon = 0;
        static public void setDefault()
        {
            
            name = middleName = lastName = address = gender = conText = phoneNumber = "";
           
        }
        
        static public string inputHandler(string s)
        {
            int doubleIndex = s.LastIndexOf(":");
            string finR = s.Substring(doubleIndex + 1).Trim();
            return finR;
        }
        
    }
}
