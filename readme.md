# Helper to generate CSharp client from NSwag Studio project file (.swag)

This package adds the ability to use a .nswag-file as input to https://github.com/RicoSuter/NSwag/wiki/CSharpClientGenerator

## Usage example

```
using NswagStudioSettingsForCSharpClientGenerator; 

var nswagProjectFile = Path.GetFullPath("../Path/To/projectfile.nswag"); 

await NswagCodeGenerator.GenerateClientAsync(nswagProjectFile);
```

OR

```
using NswagStudioSettingsForCSharpClientGenerator; 

var nswagProjectFile = Path.GetFullPath("../Path/To/projectfile.nswag"); 

await NswagCodeGenerator.GenerateClientAsync(nswagProjectFile, "../OutputDirectory/");
```

OR

The following code from https://github.com/RicoSuter/NSwag/wiki/CSharpClientGenerator can now be simplified
```

System.Net.WebClient wclient = new System.Net.WebClient();         

var document = await OpenApiDocument.FromJsonAsync(wclient.DownloadString("Https://SwaggerSpecificationURL.json"));

wclient.Dispose();

~~var settings = new CSharpClientGeneratorSettings
{
    ClassName = "MyClass", 
    CSharpGeneratorSettings = 
    {
        Namespace = "MyNamespace"
    }
};~~

var nswagProjectFile = Path.GetFullPath("../Path/To/projectfile.nswag"); 
var settings = CreateSettingsFromFile(nswagFilePath);

var generator = new CSharpClientGenerator(document, settings);	
var code = generator.GenerateFile();
```