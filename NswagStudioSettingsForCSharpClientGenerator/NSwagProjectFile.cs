using System.Text.Json.Serialization;

namespace NswagStudioSettingsForCSharpClientGenerator
{
    public class FromDocument
    {
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("output")]
        public string? Output { get; set; }

        [JsonPropertyName("newLineBehavior")]
        public string? NewLineBehavior { get; set; }
    }

    public class DocumentGenerator
    {
        [JsonPropertyName("fromDocument")]
        public FromDocument? FromDocument { get; set; }
    }

    public class OpenApiToCSharpClient
    {
        [JsonPropertyName("clientBaseClass")]
        public string? ClientBaseClass { get; set; }

        [JsonPropertyName("configurationClass")]
        public string? ConfigurationClass { get; set; }

        [JsonPropertyName("generateClientClasses")]
        public bool GenerateClientClasses { get; set; }

        [JsonPropertyName("generateClientInterfaces")]
        public bool GenerateClientInterfaces { get; set; }

        [JsonPropertyName("clientBaseInterface")]
        public string? ClientBaseInterface { get; set; }

        [JsonPropertyName("injectHttpClient")]
        public bool InjectHttpClient { get; set; }

        [JsonPropertyName("disposeHttpClient")]
        public bool DisposeHttpClient { get; set; }

        [JsonPropertyName("protectedMethods")]
        public string[]? ProtectedMethods { get; set; }

        [JsonPropertyName("generateExceptionClasses")]
        public bool GenerateExceptionClasses { get; set; }

        [JsonPropertyName("exceptionClass")]
        public string? ExceptionClass { get; set; }

        [JsonPropertyName("wrapDtoExceptions")]
        public bool WrapDtoExceptions { get; set; }

        [JsonPropertyName("useHttpClientCreationMethod")]
        public bool UseHttpClientCreationMethod { get; set; }

        [JsonPropertyName("httpClientType")]
        public string? HttpClientType { get; set; }

        [JsonPropertyName("useHttpRequestMessageCreationMethod")]
        public bool UseHttpRequestMessageCreationMethod { get; set; }

        [JsonPropertyName("useBaseUrl")]
        public bool UseBaseUrl { get; set; }

        [JsonPropertyName("generateBaseUrlProperty")]
        public bool GenerateBaseUrlProperty { get; set; }

        [JsonPropertyName("generateSyncMethods")]
        public bool GenerateSyncMethods { get; set; }

        [JsonPropertyName("generatePrepareRequestAndProcessResponseAsAsyncMethods")]
        public bool GeneratePrepareRequestAndProcessResponseAsAsyncMethods { get; set; }

        [JsonPropertyName("exposeJsonSerializerSettings")]
        public bool ExposeJsonSerializerSettings { get; set; }

        [JsonPropertyName("clientClassAccessModifier")]
        public string? ClientClassAccessModifier { get; set; }

        [JsonPropertyName("typeAccessModifier")]
        public string? TypeAccessModifier { get; set; }

        [JsonPropertyName("generateContractsOutput")]
        public bool GenerateContractsOutput { get; set; }

        [JsonPropertyName("contractsNamespace")]
        public string? ContractsNamespace { get; set; }

        [JsonPropertyName("contractsOutputFilePath")]
        public string? ContractsOutputFilePath { get; set; }

        [JsonPropertyName("parameterDateTimeFormat")]
        public string? ParameterDateTimeFormat { get; set; }

        [JsonPropertyName("parameterDateFormat")]
        public string? ParameterDateFormat { get; set; }

        [JsonPropertyName("generateUpdateJsonSerializerSettingsMethod")]
        public bool GenerateUpdateJsonSerializerSettingsMethod { get; set; }

        [JsonPropertyName("useRequestAndResponseSerializationSettings")]
        public bool UseRequestAndResponseSerializationSettings { get; set; }

        [JsonPropertyName("serializeTypeInformation")]
        public bool SerializeTypeInformation { get; set; }

        [JsonPropertyName("queryNullValue")]
        public string? QueryNullValue { get; set; }

        [JsonPropertyName("className")]
        public string? ClassName { get; set; }

        [JsonPropertyName("operationGenerationMode")]
        public string? OperationGenerationMode { get; set; }

        [JsonPropertyName("additionalNamespaceUsages")]
        public string[]? AdditionalNamespaceUsages { get; set; }

        [JsonPropertyName("additionalContractNamespaceUsages")]
        public string[]? AdditionalContractNamespaceUsages { get; set; }

        [JsonPropertyName("generateOptionalParameters")]
        public bool GenerateOptionalParameters { get; set; }

        [JsonPropertyName("generateJsonMethods")]
        public bool GenerateJsonMethods { get; set; }

        [JsonPropertyName("enforceFlagEnums")]
        public bool EnforceFlagEnums { get; set; }

        [JsonPropertyName("parameterArrayType")]
        public string? ParameterArrayType { get; set; }

        [JsonPropertyName("parameterDictionaryType")]
        public string? ParameterDictionaryType { get; set; }

        [JsonPropertyName("responseArrayType")]
        public string? ResponseArrayType { get; set; }

        [JsonPropertyName("responseDictionaryType")]
        public string? ResponseDictionaryType { get; set; }

        [JsonPropertyName("wrapResponses")]
        public bool WrapResponses { get; set; }

        [JsonPropertyName("wrapResponseMethods")]
        public string[]? WrapResponseMethods { get; set; }

        [JsonPropertyName("generateResponseClasses")]
        public bool GenerateResponseClasses { get; set; }

        [JsonPropertyName("responseClass")]
        public string? ResponseClass { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("requiredPropertiesMustBeDefined")]
        public bool RequiredPropertiesMustBeDefined { get; set; }

        [JsonPropertyName("dateType")]
        public string? DateType { get; set; }

        [JsonPropertyName("jsonConverters")]
        public string? JsonConverters { get; set; }

        [JsonPropertyName("anyType")]
        public string? AnyType { get; set; }

        [JsonPropertyName("dateTimeType")]
        public string? DateTimeType { get; set; }

        [JsonPropertyName("timeType")]
        public string? TimeType { get; set; }

        [JsonPropertyName("timeSpanType")]
        public string? TimeSpanType { get; set; }

        [JsonPropertyName("arrayType")]
        public string? ArrayType { get; set; }

        [JsonPropertyName("arrayInstanceType")]
        public string? ArrayInstanceType { get; set; }

        [JsonPropertyName("dictionaryType")]
        public string? DictionaryType { get; set; }

        [JsonPropertyName("dictionaryInstanceType")]
        public string? DictionaryInstanceType { get; set; }

        [JsonPropertyName("arrayBaseType")]
        public string? ArrayBaseType { get; set; }

        [JsonPropertyName("dictionaryBaseType")]
        public string? DictionaryBaseType { get; set; }

        [JsonPropertyName("classStyle")]
        public string? ClassStyle { get; set; }

        [JsonPropertyName("jsonLibrary")]
        public string? JsonLibrary { get; set; }

        [JsonPropertyName("generateDefaultValues")]
        public bool GenerateDefaultValues { get; set; }

        [JsonPropertyName("generateDataAnnotations")]
        public bool GenerateDataAnnotations { get; set; }

        [JsonPropertyName("excludedTypeNames")]
        public string[]? ExcludedTypeNames { get; set; }

        [JsonPropertyName("excludedParameterNames")]
        public string[]? ExcludedParameterNames { get; set; }

        [JsonPropertyName("handleReferences")]
        public bool HandleReferences { get; set; }

        [JsonPropertyName("generateImmutableArrayProperties")]
        public bool GenerateImmutableArrayProperties { get; set; }

        [JsonPropertyName("generateImmutableDictionaryProperties")]
        public bool GenerateImmutableDictionaryProperties { get; set; }

        [JsonPropertyName("jsonSerializerSettingsTransformationMethod")]
        public string? JsonSerializerSettingsTransformationMethod { get; set; }

        [JsonPropertyName("inlineNamedArrays")]
        public bool InlineNamedArrays { get; set; }

        [JsonPropertyName("inlineNamedDictionaries")]
        public bool InlineNamedDictionaries { get; set; }

        [JsonPropertyName("inlineNamedTuples")]
        public bool InlineNamedTuples { get; set; }

        [JsonPropertyName("inlineNamedAny")]
        public bool InlineNamedAny { get; set; }

        [JsonPropertyName("generateDtoTypes")]
        public bool GenerateDtoTypes { get; set; }

        [JsonPropertyName("generateOptionalPropertiesAsNullable")]
        public bool GenerateOptionalPropertiesAsNullable { get; set; }

        [JsonPropertyName("generateNullableReferenceTypes")]
        public bool GenerateNullableReferenceTypes { get; set; }

        [JsonPropertyName("templateDirectory")]
        public string? TemplateDirectory { get; set; }

        [JsonPropertyName("typeNameGeneratorType")]
        public string? TypeNameGeneratorType { get; set; }

        [JsonPropertyName("propertyNameGeneratorType")]
        public string? PropertyNameGeneratorType { get; set; }

        [JsonPropertyName("enumNameGeneratorType")]
        public string? EnumNameGeneratorType { get; set; }

        [JsonPropertyName("serviceHost")]
        public string? ServiceHost { get; set; }

        [JsonPropertyName("serviceSchemes")]
        public string? ServiceSchemes { get; set; }

        [JsonPropertyName("output")]
        public string? Output { get; set; }

        [JsonPropertyName("newLineBehavior")]
        public string? NewLineBehavior { get; set; }
    }

    public class CodeGenerators
    {
        [JsonPropertyName("openApiToCSharpClient")]
        public OpenApiToCSharpClient? OpenApiToCSharpClient { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("runtime")]
        public string? Runtime { get; set; }

        [JsonPropertyName("defaultVariables")]
        public string? DefaultVariables { get; set; }

        [JsonPropertyName("documentGenerator")]
        public DocumentGenerator? DocumentGenerator { get; set; }

        [JsonPropertyName("codeGenerators")]
        public CodeGenerators? CodeGenerators { get; set; }
    }


}
