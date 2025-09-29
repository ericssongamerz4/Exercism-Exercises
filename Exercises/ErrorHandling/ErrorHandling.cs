using System;

namespace Exercism_Exercises.Exercises.ErrorHandling
{
    public static class ErrorHandling
    {
        public static void HandleErrorByThrowingException()
        {
            if (true)
                throw new Exception();
        }

        public static int? HandleErrorByReturningNullableType(string input)
        {
            try
            {
                return Convert.ToInt32(input);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool HandleErrorWithOutParam(string input, out int result)
        {
            try
            {
                result = Convert.ToInt32(input);
                return true;
            }
            catch (Exception)
            {
                result = 0;
                return false;
            }
        }

        public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableObject)
        {
            try
            {
                if(disposableObject != null)
                    throw new Exception();
            }
            catch (Exception)
            {
                disposableObject.Dispose();
                throw;
            }
        }
    }

}//Made by ericssonGamerz4

