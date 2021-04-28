using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiators
{
    abstract class Gladiator
    {
        private byte years;
        public byte Years
        {
            get { return years; }
            private set 
            { 
                if (value < 0 || value > 10)
                {
                    throw new IncorrectYearNumberException("Number of years must be between 0 and 10");
                }
                years = value; 
            }
        }

        private OriginType origin;
        public OriginType Origin
        {
            get { return origin; }
        }
        
        private bool isFreed;
        public bool IsFreed
        {
            get { return isFreed; }
            private set 
            { 
                if (Years >= 10 && value == false)
                {
                    throw new EndOfServiceException("Gladiator must be freed after 10 years of service");
                }
                isFreed = value; 
            }
        }

        private bool isAlive;
        public bool IsAlive
        {
            get { return isAlive; }
        }

        private void Die()
        {
            isAlive = false;
        }

        public Gladiator(byte years, OriginType origin)
        {
            Years = years;
            this.origin = origin;
            IsFreed = false;
            this.isAlive = true;
        }
        
        
    }
}
