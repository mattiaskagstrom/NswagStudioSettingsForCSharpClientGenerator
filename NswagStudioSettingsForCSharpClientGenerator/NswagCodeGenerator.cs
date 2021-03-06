using NJsonSchema.CodeGeneration.CSharp;
using NSwag;
using NSwag.CodeGeneration.CSharp;
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace NswagStudioSettingsForCSharpClientGenerator
{
    public static class NswagCodeGenerator
    {
        /// <summary>
        /// Generates the client specified in the supplied nswagFilePath's settings
        /// </summary>
        /// <param name="nswagFilePath">Path to a valid .nswag project file</param>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="MissingFieldException"></exception>
        public async static Task GenerateClientAsync(string nswagFilePath)
        {
            var (code, className) = GenerateCodeFromNswagFile(nswagFilePath);

            var outputFilename = Path.Combine(Path.GetDirectoryName(nswagFilePath), className + ".cs");

            File.WriteAllText(outputFilename, code);
        }

        /// <summary>
        /// Generates the client specified in the supplied nswagFilePath's settings
        /// </summary>
        /// <param name="nswagFilePath">Path to a valid .nswag project file</param>
        /// <param name="outputPath">The path where to save the generated <client>.cs</param>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="MissingFieldException"></exception>
        public async static Task GenerateClientAsync(string nswagFilePath, string outputPath)
        {

            var (code, className) = GenerateCodeFromNswagFile(nswagFilePath);
            var outputFilename = Path.Combine(Path.GetDirectoryName(outputPath), className + ".cs");

            File.WriteAllText(outputFilename, code);
        }

        /// <summary>
        /// Reads and creates a CSharpClientGeneratorSettings object from a nswag file.
        /// </summary>
        /// <param name="nswagFilePath"></param>
        /// <returns></returns>
        /// <exception cref="DataMisalignedException"></exception>
        public static CSharpClientGeneratorSettings CreateSettingsFromFile(string nswagFilePath)
        {
            JsonDocument jsondoc = LoadJsonDocument(nswagFilePath);
            JsonElement openApiToSharpClient = jsondoc.RootElement.GetProperty("codeGenerators").GetProperty("openApiToCSharpClient");

            var jsonOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            CSharpClientGeneratorSettings generatorSettingsFromJson = JsonSerializer.Deserialize<CSharpClientGeneratorSettings>(openApiToSharpClient.GetRawText(), jsonOptions);

            if (generatorSettingsFromJson == null) throw new DataMisalignedException();

            generatorSettingsFromJson.CSharpGeneratorSettings.JsonLibrary = GetCSHarpJsonLibrary(openApiToSharpClient);
            generatorSettingsFromJson.CSharpGeneratorSettings.Namespace = openApiToSharpClient.GetProperty("namespace").GetString();

            return generatorSettingsFromJson;
        }
        
        private static (string, string) GenerateCodeFromNswagFile(string nswagFilePath)
        {
            OpenApiDocument document = GetSwaggerDocument(nswagFilePath);

            var clientSettings = CreateSettingsFromFile(nswagFilePath);

            var clientGenerator = new CSharpClientGenerator(document, clientSettings);

            var code = clientGenerator.GenerateFile();

            return (code, clientSettings.ClassName);
        }

        private static OpenApiDocument GetSwaggerDocument(string nswagFilePath)
        {
            string jsonstring = File.ReadAllText(nswagFilePath);
            var swaggerDocument = JsonSerializer.Deserialize<Root>(jsonstring);
            if (swaggerDocument == null) throw new FileNotFoundException();
            if (swaggerDocument?.DocumentGenerator?.FromDocument?.Url == null)
            {
                throw new MissingFieldException("Missing url in nswag file");
            }
            var document = OpenApiDocument.FromUrlAsync(swaggerDocument.DocumentGenerator.FromDocument.Url).Result;
            return document;
        }


        private static JsonDocument LoadJsonDocument(string filePath)
        {
            string jsonstring = File.ReadAllText(filePath);
            var jsondoc = JsonDocument.Parse(jsonstring);
            if (jsondoc == null) throw new FileLoadException();
            return jsondoc;
        }

        private static CSharpJsonLibrary GetCSHarpJsonLibrary(JsonElement openApiToSharpClient)
        {
            var jsonLibraryString = openApiToSharpClient.GetProperty("jsonLibrary").GetString();
            if (jsonLibraryString == "SystemTextJson")
            {
                return CSharpJsonLibrary.SystemTextJson;
            }
            else
            {
                return CSharpJsonLibrary.NewtonsoftJson;
            }
        }
    }
}
