namespace AspNetCoreConfigDemo.Models
{
    public class MyConfigurationEntity
    {
        public string env { get; set; }
        public int IntegerKey { get; set; }
        public string BookName { get; set; }
        public bool IsEnable { get; set; }
        public InnerEntity FeatureOne { get; set; }
    }

    public class InnerEntity
    {
        public string Name { get; set; }
        public bool IsEnable { get; set; }
    }
}