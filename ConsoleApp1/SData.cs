using System.Collections.Generic;

namespace ConsoleApp1
{
    public static class SData
    {
        public static List<TestEnt> Test_01()
        {
            return Helper.sqlDataReaderTest();
        }

        public static List<TestEnt> Test_02()
        {
            return Helper.sqlDataAdapterTest();
        }
    }
}