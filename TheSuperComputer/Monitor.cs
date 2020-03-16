using System;
using System.Collections.Generic;
using System.Text;

namespace TheSuperComputer
{
    class Monitor
    {
        //resolution, supporthdmi, size
        private string resolution;
        private Boolean supportHdmi;
        private double size;

        public Monitor(string resolution, Boolean supportHdmi, double size)
        {
            this.resolution = resolution;
            this.supportHdmi = supportHdmi;
            this.size = size;
        }
        private string getResolution()
        {
            return this.resolution;
        }
        private Boolean isSupportHdmi()
        {
            return this.supportHdmi;
        }
        private double getSize()
        {
            return this.size;
        }
        public override string ToString()
        {
            return $"Monitor resolution : {resolution} ; Monitor support hdmi :{supportHdmi}; Monitor dimensi : {size} inch ";
        }
    }
}
