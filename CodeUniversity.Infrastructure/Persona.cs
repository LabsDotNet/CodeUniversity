using System;
using System.Collections.Generic;
using System.Text;

namespace CodeUniversity.Infrastructure
{
    public class Persona
    {
        private string _FirstName;

        private string _LastName;

        public string FullName { get { return $"{_FirstName} {_LastName}"; } }


        public void DoSOmething(string value)
        {
            var valueFormatted = string.Format("{0} {1}",_FirstName,_LastName);
        }
    }
}

