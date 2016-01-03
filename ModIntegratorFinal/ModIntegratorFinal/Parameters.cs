using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModIntegratorFinal
{
    struct Parameters
    {
        static int _Step = 0;
        public static bool Integrate { get; set; }
        public static string Path { get; set; }
        public static string ContinentPath { get; set; }
        public static string Version { get; set; }
        public static string Localisation { get; set; }

        public static int Step
        {
            get { return _Step; }
            set
            {
                if (value > _Step && value < 4)
                {
                    if (!Integrate && value == 2)
                        _Step = value + 1;
                    else
                        _Step = value;
                    OnStepInc();
                }
                else if (value < _Step && value >= 0)
                {
                    if (!Integrate && value == 2)
                        _Step = value - 1;
                    else
                        _Step = value;
                    OnStepDec();
                }
                if (_Step == 3)
                    FinalStep();
            }
        }
        static string _ProgressMessage = "";
        public static string ProgressMessage
        {
            get { return _ProgressMessage; }
            set
            {
                _ProgressMessage = value;
                OnProgressMessageChange();
            }
        }

        public static event StepDelegate OnStepInc;
        public static event StepDelegate OnStepDec;
        public static event StepDelegate FinalStep;
        public delegate void StepDelegate();

        public static event ProgressDelegate OnProgressMessageChange;
        public delegate void ProgressDelegate();
    }
}
