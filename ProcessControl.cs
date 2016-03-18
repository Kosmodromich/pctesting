﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace pctetsting
{
        class ProcessControl
        {
            List<Process> processLastIteration = Process.GetProcesses().ToList();

            List<string> processName = new List<string>();
            List<DateTime> startTime = new List<DateTime>();
            List<DateTime> exitTime = new List<DateTime>();

            List<Process> ExitProcess = new List<Process>();

            public void UpdateProcess()
            {
                Process[] proc = Process.GetProcesses();
                foreach (Process pr in proc)
                {
                    if(processLastIteration.Contains(pr))
                    {
                        ExitProcess.Add(pr);
                    }
                }
                processLastIteration = proc.ToList();
            }
        }

}
