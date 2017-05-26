using System;

namespace dotnet_web_api.Libraries {

    //singleton class for increment
    public sealed class Increment {
        //private members
        private static readonly Lazy<Increment> mLazyInstance = new Lazy<Increment>(() => new Increment()); //the single instance of Increment being lazy initialized
        private Object mLOCK;

        //public properties
        public int Count { get; private set; }

        //constructor
        private Increment(){
            Count = 0;
            mLOCK = new Object();
        }

        //public static functions
        public static Increment getInstance(){
            return mLazyInstance.Value;
        }

        //public functions
        public void addCount() {
            lock(mLOCK) {
                Count++;
            }
        }
    }
}