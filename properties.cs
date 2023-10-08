using System;
namespace MCA_CSharp
{
    class PropertiesExample
    {
        char _data1;
        public char Data1
        {
            get
            {
                return this._data1;
            }

            set
            {
                this._data1 = value;
            }
        }


        public int Data2 { get; set; }
        /* The syntax shown above is the auto property syntax. 
         * The compiler generates the storage location for the field that backs up the property. 
         * The compiler also implements the body of the get and set accessors.*/

        public int Data3 { get; set; } = 1000;
        /* Sometimes, you need to initialize a property to a value other than the default for its type.*/

        int _data4;
        public int Data4
        {
            get
            {
                if (_data4 > 0)
                    return _data4;
                else
                    throw new ArgumentException("Value must be greater than 0");
            }
            set
            {
                if (value > 0)
                    this._data4 = value;
                else throw new ArgumentException("Value must be greater than 0");

            }
        }

    }

    class Properties
    {
        static void Main()
        {
            PropertiesExample obj = new PropertiesExample();
            obj.Data1 = 'A';
            obj.Data2 = 100;
            obj.Data4 = 10;
            Console.WriteLine("Implementing Properties in C#");
            Console.WriteLine("The _data1 value is: {0}", obj.Data1);
            Console.WriteLine("The Data2 value is: {0}", obj.Data2);
            Console.WriteLine("The Data3 value is: {0}", obj.Data3);
            Console.WriteLine("The Data4 value is: {0}", obj.Data4);
            Console.Read();

        }
    }
}