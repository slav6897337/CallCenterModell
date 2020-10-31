namespace CallCenterModell
{
    /// <summary>
    /// Assigns a call to the first available employee.
    /// </summary>
    public interface IDispatchCall
    {
        /// <summary>
        /// Assigns a call to the first available employee.
        /// </summary>
        /// <param name="number">The phone number from which the call is made.</param>
        void DispatchCall(string number);
    }
}
