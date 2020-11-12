using System.ComponentModel.DataAnnotations;

namespace AspNetCoreConfigDemo.Models
{
    public class MyConfigurationEntity
    {
        [Required]
        public string env { get; set; }
        [Required]
        public int IntegerKey { get; set; }
        [Required]
        public string BookName { get; set; }
        [Required]
        public bool IsEnable { get; set; }
        [Required]
        public InnerEntity FeatureOne { get; set; }
    }

    public class InnerEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public bool IsEnable { get; set; }
    }
}