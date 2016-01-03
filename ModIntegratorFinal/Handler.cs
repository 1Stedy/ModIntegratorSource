using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModIntegratorFinal
{
    class Handler
    {
        public void MainProcess()
        {
            var process = new Process();
            process.DeleteMod(Parameters.Path);
            if (Parameters.Integrate)
            {
                if (Parameters.ContinentPath == String.Empty)
                    process.parsingContinents("extra\\continent.txt");
                else
                    process.parsingContinents(Parameters.ContinentPath);
                process.Copy("mod_files\\" + Parameters.Version, Parameters.Path);
            }                
        }
    }
}
