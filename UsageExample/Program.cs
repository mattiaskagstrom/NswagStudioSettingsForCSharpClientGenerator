using NswagStudioSettingsForCSharpClientGenerator;

var nswagProjectFile = Path.GetFullPath("../../../ExampleSpec/NswagStudioProjectFile.nswag");

await NswagCodeGenerator.GenerateClientAsync(nswagProjectFile); //Writes PetStore.cs to the same directory as the project file


var nswagProjectFile2 = Path.GetFullPath("../../../ExampleSpec/NswagStudioProjectFile.nswag");

await NswagCodeGenerator.GenerateClientAsync(nswagProjectFile2, "../../../AnotherSaveLocation/"); //Writes PetStore.cs to "AnotherSaveLocation"
