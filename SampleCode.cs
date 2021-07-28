using System;

namespace myNameSpace
{
    public class myClass
    {
        public string Method1(int arg1, int arg2)
        {        
            return "test";
        }        

        private string Method2(List<string> list)
        {
            return list.Count > 0 ? list[0] : "";
        }
    }
	
	private class myClass2
    {
        public string Method1(int arg1, int arg2)
        {        
            return "test";
        }        

        private string Method2(List<string> list)
        {
            return list.Count > 0 ? list[0] : "";
        }
    }
}
