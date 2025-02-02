using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02C_Adv
{
    internal class FixedSizeList<T>
    {

        private int FixedCapacity { get; set; }
        public List<T> list { get; set; }
        public FixedSizeList(int _capacity)
        {
            if (_capacity < 0)
                throw new Exception("Capacity Must Be Greater Than Zero");
            else
            {
                FixedCapacity = _capacity;
                list = new List<T>(_capacity);
            }    
        }

        public void AddElement(T element)
        {
            if(list.Capacity >list.Count )
            {
                list.Add(element);
            }
            else
                throw new Exception($"This Element Can Not Be Added Becouse The List Is Full");
        }

        public void RetrievesElement( int index)
        {
            
            if(list.Count >index)
            {
                Console.WriteLine(list[0]);
            }
            else
                throw new Exception("Invalid Index. Please Enter A Valid Index.");

        }


    }
}
