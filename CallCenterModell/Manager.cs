namespace CallCenterModell
{
    /// <summary>
    /// Manager.
    /// </summary>
    public class Manager : Employee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Manager"/> class.
        /// </summary>
        public Manager()
            : this("No data")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Manager"/> class.
        /// </summary>
        /// <param name="name">Name employee.</param>
        public Manager(string name)
            : base(name)
        {
            Post = "Manager";
        }
    }
}
