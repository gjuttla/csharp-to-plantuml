namespace CSharpToPlantUML.Domain
{
    public class Conversion
    {
        public static Conversion FromPlantUML(string plantUmlSource)
        {
            return new Conversion()
            {
                Succeeded = true,
                PlantUML = plantUmlSource
            };
        }
        
        public static Conversion Failure()
        {
            return new Conversion()
            {
                Succeeded = false
            };
        }
        
        public bool Succeeded { get; set; }
        public string PlantUML { get; set; }
    }
}