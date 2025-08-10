using System;

namespace CSharpEssentials
{
    public class Counter
    {
        int cnt = 0;
        public void Increment()
        {
            cnt++;
        }
        public void Show()
        {
            Console.WriteLine("Текущее значение счетчика = " + cnt);
        }
        public void Reset()
        {
            cnt = 0;
        }
        public void StartFrom (int a)
        {
            cnt = a;
        }
        int mny = 0;
    }
}
