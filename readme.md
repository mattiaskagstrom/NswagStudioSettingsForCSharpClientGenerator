# Helper to generate CSharp client from NSwag Studio project file (.swag)

This package adds the ability to use a .swag-file as input to https://github.com/RicoSuter/NSwag/wiki/CSharpClientGenerator

## Usage example

```
using NswagStudioSettingsForCSharpClientGenerator; 

var nswagProjectFile = Path.GetFullPath("../Path/To/projectfile.nswag"); 

await NswagCodeGenerator.GenerateClientAsync(nswagProjectFile);
```

OR

```
using NswagStudioSettingsForCSharpClientGenerator; 

var nswagProjectFile = Path.GetFullPath("../Path/To/projectfile.nswag", "../OutputDirectory/"); 

await NswagCodeGenerator.GenerateClientAsync(nswagProjectFile);
```