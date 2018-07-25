using System;
namespace CSharpLogic.Delegate
{
    public class MyClass
    {
		public  delegate void CallBack(int a);
        public MyClass()
        {
        }

		public void LongRunningMethod(CallBack del){
			for (int i =0; i < 100000;i++){
				del.Invoke(i);
;			}
		}
    }
}
