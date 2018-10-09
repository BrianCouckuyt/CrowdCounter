using System;

namespace CrowdCounterAPI.Model
{
    public class CrowdFlow
    {
        public byte Amount
        {
            get;
            private set;
        }
        public FlowDirection Direction
        {
            get;
            private set;
        }

        public CrowdFlow(byte amount, FlowDirection direction)
        {
            this.Amount = amount;
            this.Direction = direction;
        }
    }
}
