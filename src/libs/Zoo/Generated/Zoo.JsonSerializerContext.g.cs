
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Zoo
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Zoo.JsonConverters.TextToCadResponseVariant1TypeJsonConverter),

            typeof(global::Zoo.JsonConverters.TextToCadResponseVariant1TypeNullableJsonConverter),

            typeof(global::Zoo.JsonConverters.TextToCadResponseVariant2TypeJsonConverter),

            typeof(global::Zoo.JsonConverters.TextToCadResponseVariant2TypeNullableJsonConverter),

            typeof(global::Zoo.JsonConverters.TextToCadResponseVariant3TypeJsonConverter),

            typeof(global::Zoo.JsonConverters.TextToCadResponseVariant3TypeNullableJsonConverter),

            typeof(global::Zoo.JsonConverters.ApiCallStatusVariant1JsonConverter),

            typeof(global::Zoo.JsonConverters.ApiCallStatusVariant1NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.ApiCallStatusVariant2JsonConverter),

            typeof(global::Zoo.JsonConverters.ApiCallStatusVariant2NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.ApiCallStatusVariant3JsonConverter),

            typeof(global::Zoo.JsonConverters.ApiCallStatusVariant3NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.ApiCallStatusVariant4JsonConverter),

            typeof(global::Zoo.JsonConverters.ApiCallStatusVariant4NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.ApiCallStatusVariant5JsonConverter),

            typeof(global::Zoo.JsonConverters.ApiCallStatusVariant5NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.TextToCadModelVariant1JsonConverter),

            typeof(global::Zoo.JsonConverters.TextToCadModelVariant1NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.TextToCadModelVariant2JsonConverter),

            typeof(global::Zoo.JsonConverters.TextToCadModelVariant2NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.TextToCadModelVariant3JsonConverter),

            typeof(global::Zoo.JsonConverters.TextToCadModelVariant3NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.MlFeedbackVariant1JsonConverter),

            typeof(global::Zoo.JsonConverters.MlFeedbackVariant1NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.MlFeedbackVariant2JsonConverter),

            typeof(global::Zoo.JsonConverters.MlFeedbackVariant2NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.MlFeedbackVariant3JsonConverter),

            typeof(global::Zoo.JsonConverters.MlFeedbackVariant3NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.MlFeedbackVariant4JsonConverter),

            typeof(global::Zoo.JsonConverters.MlFeedbackVariant4NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.FileExportFormatVariant1JsonConverter),

            typeof(global::Zoo.JsonConverters.FileExportFormatVariant1NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.FileExportFormatVariant2JsonConverter),

            typeof(global::Zoo.JsonConverters.FileExportFormatVariant2NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.FileExportFormatVariant3JsonConverter),

            typeof(global::Zoo.JsonConverters.FileExportFormatVariant3NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.FileExportFormatVariant4JsonConverter),

            typeof(global::Zoo.JsonConverters.FileExportFormatVariant4NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.FileExportFormatVariant5JsonConverter),

            typeof(global::Zoo.JsonConverters.FileExportFormatVariant5NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.FileExportFormatVariant6JsonConverter),

            typeof(global::Zoo.JsonConverters.FileExportFormatVariant6NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.FileExportFormatVariant7JsonConverter),

            typeof(global::Zoo.JsonConverters.FileExportFormatVariant7NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.CreatedAtSortModeVariant1JsonConverter),

            typeof(global::Zoo.JsonConverters.CreatedAtSortModeVariant1NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.CreatedAtSortModeVariant2JsonConverter),

            typeof(global::Zoo.JsonConverters.CreatedAtSortModeVariant2NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.AsyncApiCallOutputVariant1TypeJsonConverter),

            typeof(global::Zoo.JsonConverters.AsyncApiCallOutputVariant1TypeNullableJsonConverter),

            typeof(global::Zoo.JsonConverters.AsyncApiCallOutputVariant2TypeJsonConverter),

            typeof(global::Zoo.JsonConverters.AsyncApiCallOutputVariant2TypeNullableJsonConverter),

            typeof(global::Zoo.JsonConverters.AsyncApiCallOutputVariant3TypeJsonConverter),

            typeof(global::Zoo.JsonConverters.AsyncApiCallOutputVariant3TypeNullableJsonConverter),

            typeof(global::Zoo.JsonConverters.AsyncApiCallOutputVariant4TypeJsonConverter),

            typeof(global::Zoo.JsonConverters.AsyncApiCallOutputVariant4TypeNullableJsonConverter),

            typeof(global::Zoo.JsonConverters.AsyncApiCallOutputVariant5TypeJsonConverter),

            typeof(global::Zoo.JsonConverters.AsyncApiCallOutputVariant5TypeNullableJsonConverter),

            typeof(global::Zoo.JsonConverters.AsyncApiCallOutputVariant6TypeJsonConverter),

            typeof(global::Zoo.JsonConverters.AsyncApiCallOutputVariant6TypeNullableJsonConverter),

            typeof(global::Zoo.JsonConverters.AsyncApiCallOutputVariant7TypeJsonConverter),

            typeof(global::Zoo.JsonConverters.AsyncApiCallOutputVariant7TypeNullableJsonConverter),

            typeof(global::Zoo.JsonConverters.AsyncApiCallOutputVariant8TypeJsonConverter),

            typeof(global::Zoo.JsonConverters.AsyncApiCallOutputVariant8TypeNullableJsonConverter),

            typeof(global::Zoo.JsonConverters.AsyncApiCallOutputVariant9TypeJsonConverter),

            typeof(global::Zoo.JsonConverters.AsyncApiCallOutputVariant9TypeNullableJsonConverter),

            typeof(global::Zoo.JsonConverters.FileImportFormatVariant1JsonConverter),

            typeof(global::Zoo.JsonConverters.FileImportFormatVariant1NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.FileImportFormatVariant2JsonConverter),

            typeof(global::Zoo.JsonConverters.FileImportFormatVariant2NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.FileImportFormatVariant3JsonConverter),

            typeof(global::Zoo.JsonConverters.FileImportFormatVariant3NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.FileImportFormatVariant4JsonConverter),

            typeof(global::Zoo.JsonConverters.FileImportFormatVariant4NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.FileImportFormatVariant5JsonConverter),

            typeof(global::Zoo.JsonConverters.FileImportFormatVariant5NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.FileImportFormatVariant6JsonConverter),

            typeof(global::Zoo.JsonConverters.FileImportFormatVariant6NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.FileImportFormatVariant7JsonConverter),

            typeof(global::Zoo.JsonConverters.FileImportFormatVariant7NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitAreaVariant1JsonConverter),

            typeof(global::Zoo.JsonConverters.UnitAreaVariant1NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitAreaVariant2JsonConverter),

            typeof(global::Zoo.JsonConverters.UnitAreaVariant2NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitAreaVariant3JsonConverter),

            typeof(global::Zoo.JsonConverters.UnitAreaVariant3NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitAreaVariant4JsonConverter),

            typeof(global::Zoo.JsonConverters.UnitAreaVariant4NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitAreaVariant5JsonConverter),

            typeof(global::Zoo.JsonConverters.UnitAreaVariant5NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitAreaVariant6JsonConverter),

            typeof(global::Zoo.JsonConverters.UnitAreaVariant6NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitAreaVariant7JsonConverter),

            typeof(global::Zoo.JsonConverters.UnitAreaVariant7NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitAreaVariant8JsonConverter),

            typeof(global::Zoo.JsonConverters.UnitAreaVariant8NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitDensityVariant1JsonConverter),

            typeof(global::Zoo.JsonConverters.UnitDensityVariant1NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitDensityVariant2JsonConverter),

            typeof(global::Zoo.JsonConverters.UnitDensityVariant2NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitMassVariant1JsonConverter),

            typeof(global::Zoo.JsonConverters.UnitMassVariant1NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitMassVariant2JsonConverter),

            typeof(global::Zoo.JsonConverters.UnitMassVariant2NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitMassVariant3JsonConverter),

            typeof(global::Zoo.JsonConverters.UnitMassVariant3NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitVolumeVariant1JsonConverter),

            typeof(global::Zoo.JsonConverters.UnitVolumeVariant1NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitVolumeVariant2JsonConverter),

            typeof(global::Zoo.JsonConverters.UnitVolumeVariant2NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitVolumeVariant3JsonConverter),

            typeof(global::Zoo.JsonConverters.UnitVolumeVariant3NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitVolumeVariant4JsonConverter),

            typeof(global::Zoo.JsonConverters.UnitVolumeVariant4NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitVolumeVariant5JsonConverter),

            typeof(global::Zoo.JsonConverters.UnitVolumeVariant5NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitVolumeVariant6JsonConverter),

            typeof(global::Zoo.JsonConverters.UnitVolumeVariant6NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitVolumeVariant7JsonConverter),

            typeof(global::Zoo.JsonConverters.UnitVolumeVariant7NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitVolumeVariant8JsonConverter),

            typeof(global::Zoo.JsonConverters.UnitVolumeVariant8NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitVolumeVariant9JsonConverter),

            typeof(global::Zoo.JsonConverters.UnitVolumeVariant9NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitLengthVariant1JsonConverter),

            typeof(global::Zoo.JsonConverters.UnitLengthVariant1NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitLengthVariant2JsonConverter),

            typeof(global::Zoo.JsonConverters.UnitLengthVariant2NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitLengthVariant3JsonConverter),

            typeof(global::Zoo.JsonConverters.UnitLengthVariant3NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitLengthVariant4JsonConverter),

            typeof(global::Zoo.JsonConverters.UnitLengthVariant4NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitLengthVariant5JsonConverter),

            typeof(global::Zoo.JsonConverters.UnitLengthVariant5NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitLengthVariant6JsonConverter),

            typeof(global::Zoo.JsonConverters.UnitLengthVariant6NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.InputFormat3dVariant1TypeJsonConverter),

            typeof(global::Zoo.JsonConverters.InputFormat3dVariant1TypeNullableJsonConverter),

            typeof(global::Zoo.JsonConverters.InputFormat3dVariant2TypeJsonConverter),

            typeof(global::Zoo.JsonConverters.InputFormat3dVariant2TypeNullableJsonConverter),

            typeof(global::Zoo.JsonConverters.InputFormat3dVariant3TypeJsonConverter),

            typeof(global::Zoo.JsonConverters.InputFormat3dVariant3TypeNullableJsonConverter),

            typeof(global::Zoo.JsonConverters.InputFormat3dVariant4TypeJsonConverter),

            typeof(global::Zoo.JsonConverters.InputFormat3dVariant4TypeNullableJsonConverter),

            typeof(global::Zoo.JsonConverters.InputFormat3dVariant5TypeJsonConverter),

            typeof(global::Zoo.JsonConverters.InputFormat3dVariant5TypeNullableJsonConverter),

            typeof(global::Zoo.JsonConverters.InputFormat3dVariant6TypeJsonConverter),

            typeof(global::Zoo.JsonConverters.InputFormat3dVariant6TypeNullableJsonConverter),

            typeof(global::Zoo.JsonConverters.InputFormat3dVariant7TypeJsonConverter),

            typeof(global::Zoo.JsonConverters.InputFormat3dVariant7TypeNullableJsonConverter),

            typeof(global::Zoo.JsonConverters.DirectionVariant1JsonConverter),

            typeof(global::Zoo.JsonConverters.DirectionVariant1NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.DirectionVariant2JsonConverter),

            typeof(global::Zoo.JsonConverters.DirectionVariant2NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.AxisVariant1JsonConverter),

            typeof(global::Zoo.JsonConverters.AxisVariant1NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.AxisVariant2JsonConverter),

            typeof(global::Zoo.JsonConverters.AxisVariant2NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.OutputFormat3dVariant1TypeJsonConverter),

            typeof(global::Zoo.JsonConverters.OutputFormat3dVariant1TypeNullableJsonConverter),

            typeof(global::Zoo.JsonConverters.OutputFormat3dVariant2TypeJsonConverter),

            typeof(global::Zoo.JsonConverters.OutputFormat3dVariant2TypeNullableJsonConverter),

            typeof(global::Zoo.JsonConverters.OutputFormat3dVariant3TypeJsonConverter),

            typeof(global::Zoo.JsonConverters.OutputFormat3dVariant3TypeNullableJsonConverter),

            typeof(global::Zoo.JsonConverters.OutputFormat3dVariant4TypeJsonConverter),

            typeof(global::Zoo.JsonConverters.OutputFormat3dVariant4TypeNullableJsonConverter),

            typeof(global::Zoo.JsonConverters.OutputFormat3dVariant5TypeJsonConverter),

            typeof(global::Zoo.JsonConverters.OutputFormat3dVariant5TypeNullableJsonConverter),

            typeof(global::Zoo.JsonConverters.OutputFormat3dVariant6TypeJsonConverter),

            typeof(global::Zoo.JsonConverters.OutputFormat3dVariant6TypeNullableJsonConverter),

            typeof(global::Zoo.JsonConverters.StlStorageVariant1JsonConverter),

            typeof(global::Zoo.JsonConverters.StlStorageVariant1NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.StlStorageVariant2JsonConverter),

            typeof(global::Zoo.JsonConverters.StlStorageVariant2NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.SelectionVariant1TypeJsonConverter),

            typeof(global::Zoo.JsonConverters.SelectionVariant1TypeNullableJsonConverter),

            typeof(global::Zoo.JsonConverters.SelectionVariant2TypeJsonConverter),

            typeof(global::Zoo.JsonConverters.SelectionVariant2TypeNullableJsonConverter),

            typeof(global::Zoo.JsonConverters.SelectionVariant3TypeJsonConverter),

            typeof(global::Zoo.JsonConverters.SelectionVariant3TypeNullableJsonConverter),

            typeof(global::Zoo.JsonConverters.SelectionVariant4TypeJsonConverter),

            typeof(global::Zoo.JsonConverters.SelectionVariant4TypeNullableJsonConverter),

            typeof(global::Zoo.JsonConverters.SelectionVariant5TypeJsonConverter),

            typeof(global::Zoo.JsonConverters.SelectionVariant5TypeNullableJsonConverter),

            typeof(global::Zoo.JsonConverters.StepPresentationVariant1JsonConverter),

            typeof(global::Zoo.JsonConverters.StepPresentationVariant1NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.StepPresentationVariant2JsonConverter),

            typeof(global::Zoo.JsonConverters.StepPresentationVariant2NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.PlyStorageVariant1JsonConverter),

            typeof(global::Zoo.JsonConverters.PlyStorageVariant1NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.PlyStorageVariant2JsonConverter),

            typeof(global::Zoo.JsonConverters.PlyStorageVariant2NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.PlyStorageVariant3JsonConverter),

            typeof(global::Zoo.JsonConverters.PlyStorageVariant3NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.GltfStorageVariant1JsonConverter),

            typeof(global::Zoo.JsonConverters.GltfStorageVariant1NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.GltfStorageVariant2JsonConverter),

            typeof(global::Zoo.JsonConverters.GltfStorageVariant2NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.GltfStorageVariant3JsonConverter),

            typeof(global::Zoo.JsonConverters.GltfStorageVariant3NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.GltfPresentationVariant1JsonConverter),

            typeof(global::Zoo.JsonConverters.GltfPresentationVariant1NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.GltfPresentationVariant2JsonConverter),

            typeof(global::Zoo.JsonConverters.GltfPresentationVariant2NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.FbxStorageVariant1JsonConverter),

            typeof(global::Zoo.JsonConverters.FbxStorageVariant1NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.FbxStorageVariant2JsonConverter),

            typeof(global::Zoo.JsonConverters.FbxStorageVariant2NullableJsonConverter),

            typeof(global::Zoo.JsonConverters.TextToCadResponseJsonConverter),

            typeof(global::Zoo.JsonConverters.ApiCallStatusJsonConverter),

            typeof(global::Zoo.JsonConverters.TextToCadModelJsonConverter),

            typeof(global::Zoo.JsonConverters.MlFeedbackJsonConverter),

            typeof(global::Zoo.JsonConverters.FileExportFormatJsonConverter),

            typeof(global::Zoo.JsonConverters.CreatedAtSortModeJsonConverter),

            typeof(global::Zoo.JsonConverters.AsyncApiCallOutputJsonConverter),

            typeof(global::Zoo.JsonConverters.FileImportFormatJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitAreaJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitDensityJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitMassJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitVolumeJsonConverter),

            typeof(global::Zoo.JsonConverters.UnitLengthJsonConverter),

            typeof(global::Zoo.JsonConverters.InputFormat3dJsonConverter),

            typeof(global::Zoo.JsonConverters.DirectionJsonConverter),

            typeof(global::Zoo.JsonConverters.AxisJsonConverter),

            typeof(global::Zoo.JsonConverters.OutputFormat3dJsonConverter),

            typeof(global::Zoo.JsonConverters.StlStorageJsonConverter),

            typeof(global::Zoo.JsonConverters.SelectionJsonConverter),

            typeof(global::Zoo.JsonConverters.StepPresentationJsonConverter),

            typeof(global::Zoo.JsonConverters.PlyStorageJsonConverter),

            typeof(global::Zoo.JsonConverters.GltfStorageJsonConverter),

            typeof(global::Zoo.JsonConverters.GltfPresentationJsonConverter),

            typeof(global::Zoo.JsonConverters.FbxStorageJsonConverter),

            typeof(global::Zoo.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.TextToCadResponse), TypeInfoPropertyName = "TextToCadResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.TextToCadResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.MlFeedback), TypeInfoPropertyName = "MlFeedback2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.TextToCadModel), TypeInfoPropertyName = "TextToCadModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.FileExportFormat), TypeInfoPropertyName = "FileExportFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.ApiCallStatus), TypeInfoPropertyName = "ApiCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.TextToCadResponseVariant1Type), TypeInfoPropertyName = "TextToCadResponseVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.TextToCadResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Zoo.SourceRangePrompt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.SourceRangePrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.TextToCadResponseVariant2Type), TypeInfoPropertyName = "TextToCadResponseVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.TextToCadResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.TextToCadResponseVariant3Type), TypeInfoPropertyName = "TextToCadResponseVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.ApiCallStatusVariant1), TypeInfoPropertyName = "ApiCallStatusVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.ApiCallStatusVariant2), TypeInfoPropertyName = "ApiCallStatusVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.ApiCallStatusVariant3), TypeInfoPropertyName = "ApiCallStatusVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.ApiCallStatusVariant4), TypeInfoPropertyName = "ApiCallStatusVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.ApiCallStatusVariant5), TypeInfoPropertyName = "ApiCallStatusVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.SourceRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.SourcePosition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.TextToCadModelVariant1), TypeInfoPropertyName = "TextToCadModelVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.TextToCadModelVariant2), TypeInfoPropertyName = "TextToCadModelVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.TextToCadModelVariant3), TypeInfoPropertyName = "TextToCadModelVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.MlFeedbackVariant1), TypeInfoPropertyName = "MlFeedbackVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.MlFeedbackVariant2), TypeInfoPropertyName = "MlFeedbackVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.MlFeedbackVariant3), TypeInfoPropertyName = "MlFeedbackVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.MlFeedbackVariant4), TypeInfoPropertyName = "MlFeedbackVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.FileExportFormatVariant1), TypeInfoPropertyName = "FileExportFormatVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.FileExportFormatVariant2), TypeInfoPropertyName = "FileExportFormatVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.FileExportFormatVariant3), TypeInfoPropertyName = "FileExportFormatVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.FileExportFormatVariant4), TypeInfoPropertyName = "FileExportFormatVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.FileExportFormatVariant5), TypeInfoPropertyName = "FileExportFormatVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.FileExportFormatVariant6), TypeInfoPropertyName = "FileExportFormatVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.FileExportFormatVariant7), TypeInfoPropertyName = "FileExportFormatVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.TextToCadResponseResultsPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Zoo.TextToCadResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.CreatedAtSortMode), TypeInfoPropertyName = "CreatedAtSortMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.CreatedAtSortModeVariant1), TypeInfoPropertyName = "CreatedAtSortModeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.CreatedAtSortModeVariant2), TypeInfoPropertyName = "CreatedAtSortModeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.AsyncApiCallOutput), TypeInfoPropertyName = "AsyncApiCallOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.AsyncApiCallOutputVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.OutputFormat3d), TypeInfoPropertyName = "OutputFormat3d2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.FileImportFormat), TypeInfoPropertyName = "FileImportFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.InputFormat3d), TypeInfoPropertyName = "InputFormat3d2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.AsyncApiCallOutputVariant1Type), TypeInfoPropertyName = "AsyncApiCallOutputVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.AsyncApiCallOutputVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.Point3d))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitLength), TypeInfoPropertyName = "UnitLength2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.AsyncApiCallOutputVariant2Type), TypeInfoPropertyName = "AsyncApiCallOutputVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.AsyncApiCallOutputVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitDensity), TypeInfoPropertyName = "UnitDensity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitMass), TypeInfoPropertyName = "UnitMass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.AsyncApiCallOutputVariant3Type), TypeInfoPropertyName = "AsyncApiCallOutputVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.AsyncApiCallOutputVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitVolume), TypeInfoPropertyName = "UnitVolume2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.AsyncApiCallOutputVariant4Type), TypeInfoPropertyName = "AsyncApiCallOutputVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.AsyncApiCallOutputVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.AsyncApiCallOutputVariant5Type), TypeInfoPropertyName = "AsyncApiCallOutputVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.AsyncApiCallOutputVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitArea), TypeInfoPropertyName = "UnitArea2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.AsyncApiCallOutputVariant6Type), TypeInfoPropertyName = "AsyncApiCallOutputVariant6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.AsyncApiCallOutputVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.AsyncApiCallOutputVariant7Type), TypeInfoPropertyName = "AsyncApiCallOutputVariant7Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.AsyncApiCallOutputVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.AsyncApiCallOutputVariant8Type), TypeInfoPropertyName = "AsyncApiCallOutputVariant8Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.AsyncApiCallOutputVariant9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.AsyncApiCallOutputVariant9Type), TypeInfoPropertyName = "AsyncApiCallOutputVariant9Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.FileImportFormatVariant1), TypeInfoPropertyName = "FileImportFormatVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.FileImportFormatVariant2), TypeInfoPropertyName = "FileImportFormatVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.FileImportFormatVariant3), TypeInfoPropertyName = "FileImportFormatVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.FileImportFormatVariant4), TypeInfoPropertyName = "FileImportFormatVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.FileImportFormatVariant5), TypeInfoPropertyName = "FileImportFormatVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.FileImportFormatVariant6), TypeInfoPropertyName = "FileImportFormatVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.FileImportFormatVariant7), TypeInfoPropertyName = "FileImportFormatVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitAreaVariant1), TypeInfoPropertyName = "UnitAreaVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitAreaVariant2), TypeInfoPropertyName = "UnitAreaVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitAreaVariant3), TypeInfoPropertyName = "UnitAreaVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitAreaVariant4), TypeInfoPropertyName = "UnitAreaVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitAreaVariant5), TypeInfoPropertyName = "UnitAreaVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitAreaVariant6), TypeInfoPropertyName = "UnitAreaVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitAreaVariant7), TypeInfoPropertyName = "UnitAreaVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitAreaVariant8), TypeInfoPropertyName = "UnitAreaVariant82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitDensityVariant1), TypeInfoPropertyName = "UnitDensityVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitDensityVariant2), TypeInfoPropertyName = "UnitDensityVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitMassVariant1), TypeInfoPropertyName = "UnitMassVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitMassVariant2), TypeInfoPropertyName = "UnitMassVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitMassVariant3), TypeInfoPropertyName = "UnitMassVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitVolumeVariant1), TypeInfoPropertyName = "UnitVolumeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitVolumeVariant2), TypeInfoPropertyName = "UnitVolumeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitVolumeVariant3), TypeInfoPropertyName = "UnitVolumeVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitVolumeVariant4), TypeInfoPropertyName = "UnitVolumeVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitVolumeVariant5), TypeInfoPropertyName = "UnitVolumeVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitVolumeVariant6), TypeInfoPropertyName = "UnitVolumeVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitVolumeVariant7), TypeInfoPropertyName = "UnitVolumeVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitVolumeVariant8), TypeInfoPropertyName = "UnitVolumeVariant82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitVolumeVariant9), TypeInfoPropertyName = "UnitVolumeVariant92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitLengthVariant1), TypeInfoPropertyName = "UnitLengthVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitLengthVariant2), TypeInfoPropertyName = "UnitLengthVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitLengthVariant3), TypeInfoPropertyName = "UnitLengthVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitLengthVariant4), TypeInfoPropertyName = "UnitLengthVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitLengthVariant5), TypeInfoPropertyName = "UnitLengthVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.UnitLengthVariant6), TypeInfoPropertyName = "UnitLengthVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.InputFormat3dVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.InputFormat3dVariant1Type), TypeInfoPropertyName = "InputFormat3dVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.InputFormat3dVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.InputFormat3dVariant2Type), TypeInfoPropertyName = "InputFormat3dVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.InputFormat3dVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.CoordinateSystem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.InputFormat3dVariant3Type), TypeInfoPropertyName = "InputFormat3dVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.InputFormat3dVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.InputFormat3dVariant4Type), TypeInfoPropertyName = "InputFormat3dVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.InputFormat3dVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.InputFormat3dVariant5Type), TypeInfoPropertyName = "InputFormat3dVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.InputFormat3dVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.InputFormat3dVariant6Type), TypeInfoPropertyName = "InputFormat3dVariant6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.InputFormat3dVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.InputFormat3dVariant7Type), TypeInfoPropertyName = "InputFormat3dVariant7Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.AxisDirectionPair))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.Axis), TypeInfoPropertyName = "Axis2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.Direction), TypeInfoPropertyName = "Direction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.DirectionVariant1), TypeInfoPropertyName = "DirectionVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.DirectionVariant2), TypeInfoPropertyName = "DirectionVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.AxisVariant1), TypeInfoPropertyName = "AxisVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.AxisVariant2), TypeInfoPropertyName = "AxisVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.OutputFormat3dVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.FbxStorage), TypeInfoPropertyName = "FbxStorage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.OutputFormat3dVariant1Type), TypeInfoPropertyName = "OutputFormat3dVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.OutputFormat3dVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.GltfPresentation), TypeInfoPropertyName = "GltfPresentation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.GltfStorage), TypeInfoPropertyName = "GltfStorage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.OutputFormat3dVariant2Type), TypeInfoPropertyName = "OutputFormat3dVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.OutputFormat3dVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.OutputFormat3dVariant3Type), TypeInfoPropertyName = "OutputFormat3dVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.OutputFormat3dVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.Selection), TypeInfoPropertyName = "Selection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.PlyStorage), TypeInfoPropertyName = "PlyStorage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.OutputFormat3dVariant4Type), TypeInfoPropertyName = "OutputFormat3dVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.OutputFormat3dVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.StepPresentation), TypeInfoPropertyName = "StepPresentation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.OutputFormat3dVariant5Type), TypeInfoPropertyName = "OutputFormat3dVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.OutputFormat3dVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.StlStorage), TypeInfoPropertyName = "StlStorage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.OutputFormat3dVariant6Type), TypeInfoPropertyName = "OutputFormat3dVariant6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.StlStorageVariant1), TypeInfoPropertyName = "StlStorageVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.StlStorageVariant2), TypeInfoPropertyName = "StlStorageVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.SelectionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.SelectionVariant1Type), TypeInfoPropertyName = "SelectionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.SelectionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.SelectionVariant2Type), TypeInfoPropertyName = "SelectionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.SelectionVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.SelectionVariant3Type), TypeInfoPropertyName = "SelectionVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.SelectionVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.SelectionVariant4Type), TypeInfoPropertyName = "SelectionVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.SelectionVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.SelectionVariant5Type), TypeInfoPropertyName = "SelectionVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.StepPresentationVariant1), TypeInfoPropertyName = "StepPresentationVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.StepPresentationVariant2), TypeInfoPropertyName = "StepPresentationVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.PlyStorageVariant1), TypeInfoPropertyName = "PlyStorageVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.PlyStorageVariant2), TypeInfoPropertyName = "PlyStorageVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.PlyStorageVariant3), TypeInfoPropertyName = "PlyStorageVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.GltfStorageVariant1), TypeInfoPropertyName = "GltfStorageVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.GltfStorageVariant2), TypeInfoPropertyName = "GltfStorageVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.GltfStorageVariant3), TypeInfoPropertyName = "GltfStorageVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.GltfPresentationVariant1), TypeInfoPropertyName = "GltfPresentationVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.GltfPresentationVariant2), TypeInfoPropertyName = "GltfPresentationVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.FbxStorageVariant1), TypeInfoPropertyName = "FbxStorageVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.FbxStorageVariant2), TypeInfoPropertyName = "FbxStorageVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.TextToCadMultiFileIteration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.TextToCadIteration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.TextToCadIterationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.TextToCad))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.TextToCadCreateBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Zoo.SourceRangePrompt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Zoo.TextToCadResponse>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}