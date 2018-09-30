using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDICS
{
    class SdiApplication : WindowsFormsApplicationBase
    {
        private static SdiApplication instance = null;

        public SdiApplication()
        {
            this.IsSingleInstance = true;
            this.ShutdownStyle = ShutdownMode.AfterAllFormsClose;
        }
                                
        public static SdiApplication Instance
        {
            get
            {
                if (instance == null)
                {
                    return instance = new SdiApplication();
                }

                return instance;
            }
        }

        protected override void OnCreateMainForm()
        {
            DocForm.CreateForm();
        }

        protected override void OnStartupNextInstance(StartupNextInstanceEventArgs eventArgs)
        {
            DocForm.CreateForm();
        }
    }
}
