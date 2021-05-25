using System;

namespace _32_delegate03_EsDispense02
{
    public class OverMaxEventArgs : EventArgs
    {
        private int ValoreSoglia { get; }
        public OverMaxEventArgs(int valoreSoglia)
        {
            ValoreSoglia = valoreSoglia;
        }
    }
}
