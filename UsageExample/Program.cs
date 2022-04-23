using NswagStudioSettingsForCSharpClientGenerator;

var nswagProjectFile = Path.GetFullPath("../../../ExampleSpec/NswagStudioProjectFile.nswag");

await NswagCodeGenerator.GenerateClientAsync(nswagProjectFile);


var nswagProjectFile2 = Path.GetFullPath("../../../ExampleSpec/NswagStudioProjectFile.nswag");

await NswagCodeGenerator.GenerateClientAsync(nswagProjectFile2, "../../../AnotherSaveLocation/");
