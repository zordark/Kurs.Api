namespace Kurs.Api.Monitoring
{
    public enum AlarmStatus
    {
        /// <summary>
        /// Object status not controlable
        /// </summary>
        NotControlled,
        /// <summary>
        /// Unknown status
        /// </summary>
        Unknown,
        /// <summary>
        /// Normal status
        /// </summary>
        Normal,
        /// <summary>
        /// Normal state with disabling alarm and warning states
        /// </summary>
        Disabled,
        /// <summary>
        /// Normal state with indication about Alarm or Warning is cleared
        /// </summary>
        Cleared,
        /// <summary>
        /// Alarm or Warning state with Acknowledge
        /// </summary>
        Acknowledge,
        /// <summary>
        /// Warning state
        /// </summary>
        Warning,
        /// <summary>
        /// Alarm state
        /// </summary>
        Alarm,
    }
}