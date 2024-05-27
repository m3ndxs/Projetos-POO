using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCoursePortal.Entities
{
    public class Registration
    {
        public int Code { get; set; }

        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if(!(obj is Registration))
            {
                return false;
            }

            Registration other = obj as Registration;

            return Code.Equals(other.Code);
        }
    }
}
