using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ModIntegratorFinal
{
    class Handler
    {
        public void MainHandler()
        {
            //Thread SecondThread = new Thread(MainProcess);
            //SecondThread.Start();
            var task = Task.Factory.StartNew(MainProcess);
            //MainProcess();
        }
        private void MainProcess()
        {
            var process = new Process();
            Parameters.ProgressMessage = "Deleting previous files and code if exist...";
            process.DeleteMod(Parameters.Path);
            if (Parameters.Integrate)
            {
                Parameters.ProgressMessage = "Parsing continents...";
                if (Parameters.ContinentPath == String.Empty)
                    process.parsingContinents("extra\\continent.txt");
                else
                    process.parsingContinents(Parameters.ContinentPath);
                Parameters.ProgressMessage = "Copying new files and code...";
                process.Copy("mod_files\\" + Parameters.Version, Parameters.Path);
            }
            Parameters.ProgressMessage = "Everything completed";
        }
    }
}
