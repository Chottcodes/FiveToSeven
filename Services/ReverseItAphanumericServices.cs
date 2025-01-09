using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveToSeven.Services
{
    public class ReverseItAphanumericServices
    {
        string Emptyword="";
        public string reversestring(string input){

            for (int i = input.Length - 1; i >= 0; i--){
             Emptyword += input[i];
            }
                return Emptyword;
        }
    }
}