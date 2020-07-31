using System;

namespace Domain
{
    public class Value
    {
        //If a property inside one of our entities is given the name Id it will automatically be the primary key.
        public int Id {get; set;}//Auto implemented properties. No additional logic
        public string Name {get; set;}
    }
}
