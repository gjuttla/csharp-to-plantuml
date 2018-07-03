using System;
using System.Net.Http;
using System.Threading.Tasks;
using Iternity.PlantUML;

namespace CSharpToPlantUML.Converter
{
    public static class PlantUMLToSvgConverter
    {
        private static readonly HttpClient HttpClient = new HttpClient();

        public static async Task<string> GetSvgContent(string plantUmlSource)
        {
            try
            {
                return await HttpClient.GetStringAsync(PlantUMLUrl.SVG(plantUmlSource));
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}