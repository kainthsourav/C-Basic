using System;

namespace InterfaceDemo
{

    public class Dbmigrator
    {
        private readonly ILogger logger;

        public Dbmigrator(ILogger logger) //depency injecttion
        {
            this.logger = logger;
        }
        public void Migrate()
        {
            logger.LogInfo("Migration Started at: " + DateTime.Now);
           
            logger.LogInfo("Migration Finised at :" +DateTime.Now);
        }

    }
}
