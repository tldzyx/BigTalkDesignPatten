using System;

namespace Resume
{
    /// <summary>
    ///     工作经历
    /// </summary>
    public class WorkExperience : ICloneable
    {
        public string WorkData { get; set; }

        public string Company { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}