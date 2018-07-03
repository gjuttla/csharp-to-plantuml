using Iternity.PlantUML;

namespace CSharpToPlantUML.Converter
{
    public static class PlantUMLToImageUrlConverter
    {
        public static string GetImageUrl(string plantUmlSource)
        {
            return PlantUMLUrl.PNG(plantUmlSource);
        }
    }
}