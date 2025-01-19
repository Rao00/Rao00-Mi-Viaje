namespace SupuestoIntegrado.Static
{
    public class Atributos
    {
        [AttributeUsage(AttributeTargets.Property)]
        public class ExampleAttribute : Attribute
        {
            public string ExampleValue { get; }

            public ExampleAttribute(string exampleValue)
            {
                ExampleValue = exampleValue;
            }
        }
    }
}
