#nullable enable
using System;

namespace NullHandling
{
    class Address
{
public string? Building;
public string? Street = string.Empty;
public string City = string.Empty;
public string? Region = string.Empty;
}
    class Program
    {
        static void Main(string[] args)
/*Making a value type nullable
By default, value types like int and DateTime must always have a value, hence their
name. Sometimes, for example, when reading values stored in a database that allows
empty, missing, or null values, it is convenient to allow a value type to be null, we
call this a nullable value type.
You can enable this by adding a question mark as a suffix to the type when declaring
a variable. 
Let's see an example.*/
        {
            var address = new Address();
address.Building = null;
address.Street = null;
address.City = "London";
address.Region = null;   
        }
    }
}
