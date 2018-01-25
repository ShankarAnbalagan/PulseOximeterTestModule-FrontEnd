using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pulse_OM
{
    class frequencyCalc
    {
        private float spo2;
        private float bpm;
        private float pi_ir;
        private float pi_red;
        private float R;
        private float ir_fmax;
        private float ir_fmin=16000;
        private float red_fmax;
        private float red_fmin=25000;
        private float[,] freqency;

        public float[,] frequencyOfWaves(float s, float b, float p)
        {
            spo2 = s;
            bpm = b;
            pi_ir = p;

            R = (float)(Math.Abs(spo2 - 110)) / 25;

            pi_red = (float) R * pi_ir;

            red_fmax = (float)(((pi_red / 100) * red_fmin * Math.Sqrt(2) * 2.0) + red_fmin);
            ir_fmax = (float)(((pi_ir / 100) * ir_fmin * Math.Sqrt(2) * 2.0) + ir_fmin);

            freqency= new float[2,2] { {ir_fmax, ir_fmin} , { red_fmax, red_fmin} };

            return freqency;
        }

    }
}
