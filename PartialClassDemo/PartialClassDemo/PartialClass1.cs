namespace PartialClassDemo
{
    /// <summary>
    ///     Partial class
    /// </summary>
    /// <typeparam name="T">Generic type</typeparam>
    public partial class PartialClass<T>
        where T : class
    {
    }
}