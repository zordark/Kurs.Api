namespace Kurs.Api.Server.Data
{
    public enum TypeDescriptorKind
    {
        Virtual,

        /// <summary>
        /// System Description
        /// </summary>
        Adapter,

        /// <summary>
        /// Meta information objects (MetaTypes, Instances, Attributes)
        /// </summary>
        Object,

        /// <summary>
        /// Input Message (Commands)
        /// </summary>
        InputMessage,

        /// <summary>
        /// Output Message (Events)
        /// </summary>
        OutputMessage,
    }
}