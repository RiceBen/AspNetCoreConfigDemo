namespace AspNetCoreConfigDemo.Models
{
    public class MyConfigurationEntity
    {
        public string env { get; set; }
        public int IntegerKey { get; set; }
        public string BookName { get; set; }
        public bool IsEnable { get; set; }
        public InnerClass FeatureOne { get; set; }
    }

    public class InnerClass
    {
        public string Name { get; set; }
        public bool IsEnable { get; set; }
    }
}