using System;
using static System.Console;

namespace code{
    public static class ejercicios2{
        public static void Main(){

            #region Var Type
                var bigChung = 82839230.928309;

                WriteLine($"Data type is {bigChung.GetType()}");
            #endregion

            #region Arrays
                string [] names;
                names = new string[4];

                names[0] = "Pedro";
                names[1] = "Felipe";
                names[2] = "Diego";
                names[3] = "Franco";

                for (int i = 0; i < names.Length; i++)
                {
                    WriteLine(names[i]);
                }

                WriteLine("USING FOREACH");

                foreach (var item in names)
                {
                    WriteLine(item);
                }

            #endregion

            #region Input
            var input = ReadLine();
            

                WriteLine($"Data type is {input.GetType()}");
            #endregion
            }
    }
}