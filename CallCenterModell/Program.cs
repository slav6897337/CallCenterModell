namespace CallCenterModell
{
    using System;

    /// <summary>
    /// Class Main.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main.
        /// </summary>
        public static void Main()
        {
            IDispatchCall dispatchCall = new CallCenter();
            for (int i = 0; i < 14; i++)
            {
                dispatchCall.DispatchCall("8029 99659");
            }
        }
    }
}
