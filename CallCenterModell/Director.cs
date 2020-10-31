namespace CallCenterModell
{
    /// <summary>
    /// Director.
    /// </summary>
    public class Director : Employee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Director"/> class.
        /// </summary>
        public Director()
            : this("No data")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Director"/> class.
        /// </summary>
        /// <param name="name">Name employee.</param>
        public Director(string name)
            : base(name)
        {
            Post = "Director";
        }
    }
}
