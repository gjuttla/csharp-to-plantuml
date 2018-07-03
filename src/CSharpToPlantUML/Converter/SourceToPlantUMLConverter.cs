using System.IO;
using Microsoft.CodeAnalysis.CSharp;
using PlantUmlClassDiagramGenerator.Library;

namespace CSharpToPlantUML.Converter
{
    public static class SourceToPlantUMLConverter
    {
        private const string IndentStr = "    ";
        
        public static string GetPlantUml(string cSharpSource)
        {
            var syntaxTree = CSharpSyntaxTree.ParseText(cSharpSource);
            var treeRoot = syntaxTree.GetRoot();
            using (var writer = new StringWriter())
            {
                var pumlGenerator = new ClassDiagramGenerator(writer, IndentStr);
                pumlGenerator.Generate(treeRoot);
                return writer.ToString();
            }
        }
    }
}