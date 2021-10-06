using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task2
{
    class A
    {
        public A(B1 b1, B2 b2, B3 b3)
        {
            GetData(b1);
            GetData(b2);
            GetData(b3);
        }
        public A(B1 b1, B2 b2)
        {
            GetData(b1);
            GetData(b2);
        }
        public void GetData<T>(T obj)
        {
            var myField = obj.GetType().GetFields();
            Console.WriteLine("new object");
            for (var i = 0; i < myField.Length; i++)
            {
                Debug.Write($"{myField[i].Name}:{myField[i].GetValue(obj)}");
            }
        }
    }
    class B
    {
        public int x = 0;
        public int y = 0;
        public B()
        {
            if (new Random().Next(0, 2) == 0)
            {
                SetMin();
            }
            else
            {
                SetMax();
            }
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        public virtual void SetMin()
        {
            x++;
            y++;
        }
        public virtual void SetMax()
        {
            x += 10;
            y += 10;
        }
    }
    class B1 : B
    {
        public override void SetMin()
        {
            x += 2;
            y += 2;
        }
        public override void SetMax()
        {
            x += 20;
            y += 20;
        }
    }
    class B2 : B
    {
        public override void SetMin()
        {
            x += 3;
            y += 3;
        }
        public override void SetMax()
        {
            x += 30;
            y += 30;
        }
    }
    class B3 : B
    {
        public override void SetMin()
        {
            x += 4;
            y += 4;
        }
        public override void SetMax()
        {
            x += 40;
            y += 40;
        }
    }
}
