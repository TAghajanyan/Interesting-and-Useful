using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Security;
using System.Runtime.InteropServices;

namespace MyDictionary
{
    [ComVisible(true)]
    abstract class D
    {

    }
    class C : D
    {
        
        void FF()
        {

        }

        void XX()
        {
            AsyncCallback

            Action action = new Action(FF);
            action.BeginInvoke(null, null);
        }
    }

    delegate void FF();

     class FFDelegaet : MulticastDelegate
    {
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }



    class Program
    { 
      
        static void Main(string[] args)
        {
            
        }
    }
}
