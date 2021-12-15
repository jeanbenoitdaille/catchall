    using System;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
            public static void DoStuff(object[] arr, int index, object val)
            { 
                try{
                    arr[index] = val;
                }  catch(ArrayTypeMismatchException){
                    Console.WriteLine("Ce n'est pas le bon type.");
                } catch(IndexOutOfRangeException){
                    Console.WriteLine("En dehors des limites du tableau!");
                }
                catch(Exception ex){
                    Console.WriteLine(ex.Message);
                }
             }
        }
    }