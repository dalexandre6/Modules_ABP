namespace ModuleA.EntityFrameworkCore
{
    public class ModuleAModelBuilderConfigurationOptions
    {
        private string dbTablePrefix;
        private string dbSchema;

        public ModuleAModelBuilderConfigurationOptions(string dbTablePrefix, string dbSchema)
        {
            this.dbTablePrefix = dbTablePrefix;
            this.dbSchema = dbSchema;
        }

        public string TablePrefix { get; internal set; }
        public string Schema { get; internal set;}
        



    }
}