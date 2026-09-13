
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.TextToCadResponse?), TypeInfoPropertyName = "NullableTextToCadResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.MlFeedback?), TypeInfoPropertyName = "NullableMlFeedback2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.TextToCadModel?), TypeInfoPropertyName = "NullableTextToCadModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.FileExportFormat?), TypeInfoPropertyName = "NullableFileExportFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.ApiCallStatus?), TypeInfoPropertyName = "NullableApiCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.TextToCadResponseVariant1Type?), TypeInfoPropertyName = "NullableTextToCadResponseVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.TextToCadResponseVariant2Type?), TypeInfoPropertyName = "NullableTextToCadResponseVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.TextToCadResponseVariant3Type?), TypeInfoPropertyName = "NullableTextToCadResponseVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.ApiCallStatusVariant1?), TypeInfoPropertyName = "NullableApiCallStatusVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.ApiCallStatusVariant2?), TypeInfoPropertyName = "NullableApiCallStatusVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.ApiCallStatusVariant3?), TypeInfoPropertyName = "NullableApiCallStatusVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.ApiCallStatusVariant4?), TypeInfoPropertyName = "NullableApiCallStatusVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.ApiCallStatusVariant5?), TypeInfoPropertyName = "NullableApiCallStatusVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.TextToCadModelVariant1?), TypeInfoPropertyName = "NullableTextToCadModelVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.TextToCadModelVariant2?), TypeInfoPropertyName = "NullableTextToCadModelVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.TextToCadModelVariant3?), TypeInfoPropertyName = "NullableTextToCadModelVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.MlFeedbackVariant1?), TypeInfoPropertyName = "NullableMlFeedbackVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.MlFeedbackVariant2?), TypeInfoPropertyName = "NullableMlFeedbackVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.MlFeedbackVariant3?), TypeInfoPropertyName = "NullableMlFeedbackVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.MlFeedbackVariant4?), TypeInfoPropertyName = "NullableMlFeedbackVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.FileExportFormatVariant1?), TypeInfoPropertyName = "NullableFileExportFormatVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.FileExportFormatVariant2?), TypeInfoPropertyName = "NullableFileExportFormatVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.FileExportFormatVariant3?), TypeInfoPropertyName = "NullableFileExportFormatVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.FileExportFormatVariant4?), TypeInfoPropertyName = "NullableFileExportFormatVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.FileExportFormatVariant5?), TypeInfoPropertyName = "NullableFileExportFormatVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.FileExportFormatVariant6?), TypeInfoPropertyName = "NullableFileExportFormatVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.FileExportFormatVariant7?), TypeInfoPropertyName = "NullableFileExportFormatVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.CreatedAtSortMode?), TypeInfoPropertyName = "NullableCreatedAtSortMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.CreatedAtSortModeVariant1?), TypeInfoPropertyName = "NullableCreatedAtSortModeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Zoo.CreatedAtSortModeVariant2?), TypeInfoPropertyName = "NullableCreatedAtSortModeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Zoo.SourceRangePrompt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Zoo.TextToCadResponse>))]
    internal sealed partial class MlSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MlSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static MlSourceGenerationContext Default { get; } = new(DefaultOptions);

        private MlSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Zoo.JsonConverters.TextToCadResponseJsonConverter());
            options.Converters.Add(new global::Zoo.JsonConverters.ApiCallStatusJsonConverter());
            options.Converters.Add(new global::Zoo.JsonConverters.TextToCadModelJsonConverter());
            options.Converters.Add(new global::Zoo.JsonConverters.MlFeedbackJsonConverter());
            options.Converters.Add(new global::Zoo.JsonConverters.FileExportFormatJsonConverter());
            options.Converters.Add(new global::Zoo.JsonConverters.CreatedAtSortModeJsonConverter());
            options.Converters.Add(new global::Zoo.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Zoo.TextToCadResponseVariant1Type)

                    || typeToConvert == typeof(global::Zoo.TextToCadResponseVariant1Type?)

                    || typeToConvert == typeof(global::Zoo.TextToCadResponseVariant2Type)

                    || typeToConvert == typeof(global::Zoo.TextToCadResponseVariant2Type?)

                    || typeToConvert == typeof(global::Zoo.TextToCadResponseVariant3Type)

                    || typeToConvert == typeof(global::Zoo.TextToCadResponseVariant3Type?)

                    || typeToConvert == typeof(global::Zoo.ApiCallStatusVariant1)

                    || typeToConvert == typeof(global::Zoo.ApiCallStatusVariant1?)

                    || typeToConvert == typeof(global::Zoo.ApiCallStatusVariant2)

                    || typeToConvert == typeof(global::Zoo.ApiCallStatusVariant2?)

                    || typeToConvert == typeof(global::Zoo.ApiCallStatusVariant3)

                    || typeToConvert == typeof(global::Zoo.ApiCallStatusVariant3?)

                    || typeToConvert == typeof(global::Zoo.ApiCallStatusVariant4)

                    || typeToConvert == typeof(global::Zoo.ApiCallStatusVariant4?)

                    || typeToConvert == typeof(global::Zoo.ApiCallStatusVariant5)

                    || typeToConvert == typeof(global::Zoo.ApiCallStatusVariant5?)

                    || typeToConvert == typeof(global::Zoo.TextToCadModelVariant1)

                    || typeToConvert == typeof(global::Zoo.TextToCadModelVariant1?)

                    || typeToConvert == typeof(global::Zoo.TextToCadModelVariant2)

                    || typeToConvert == typeof(global::Zoo.TextToCadModelVariant2?)

                    || typeToConvert == typeof(global::Zoo.TextToCadModelVariant3)

                    || typeToConvert == typeof(global::Zoo.TextToCadModelVariant3?)

                    || typeToConvert == typeof(global::Zoo.MlFeedbackVariant1)

                    || typeToConvert == typeof(global::Zoo.MlFeedbackVariant1?)

                    || typeToConvert == typeof(global::Zoo.MlFeedbackVariant2)

                    || typeToConvert == typeof(global::Zoo.MlFeedbackVariant2?)

                    || typeToConvert == typeof(global::Zoo.MlFeedbackVariant3)

                    || typeToConvert == typeof(global::Zoo.MlFeedbackVariant3?)

                    || typeToConvert == typeof(global::Zoo.MlFeedbackVariant4)

                    || typeToConvert == typeof(global::Zoo.MlFeedbackVariant4?)

                    || typeToConvert == typeof(global::Zoo.FileExportFormatVariant1)

                    || typeToConvert == typeof(global::Zoo.FileExportFormatVariant1?)

                    || typeToConvert == typeof(global::Zoo.FileExportFormatVariant2)

                    || typeToConvert == typeof(global::Zoo.FileExportFormatVariant2?)

                    || typeToConvert == typeof(global::Zoo.FileExportFormatVariant3)

                    || typeToConvert == typeof(global::Zoo.FileExportFormatVariant3?)

                    || typeToConvert == typeof(global::Zoo.FileExportFormatVariant4)

                    || typeToConvert == typeof(global::Zoo.FileExportFormatVariant4?)

                    || typeToConvert == typeof(global::Zoo.FileExportFormatVariant5)

                    || typeToConvert == typeof(global::Zoo.FileExportFormatVariant5?)

                    || typeToConvert == typeof(global::Zoo.FileExportFormatVariant6)

                    || typeToConvert == typeof(global::Zoo.FileExportFormatVariant6?)

                    || typeToConvert == typeof(global::Zoo.FileExportFormatVariant7)

                    || typeToConvert == typeof(global::Zoo.FileExportFormatVariant7?)

                    || typeToConvert == typeof(global::Zoo.CreatedAtSortModeVariant1)

                    || typeToConvert == typeof(global::Zoo.CreatedAtSortModeVariant1?)

                    || typeToConvert == typeof(global::Zoo.CreatedAtSortModeVariant2)

                    || typeToConvert == typeof(global::Zoo.CreatedAtSortModeVariant2?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Zoo.TextToCadResponseVariant1Type))
                {
                    return new global::Zoo.JsonConverters.TextToCadResponseVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.TextToCadResponseVariant1Type?))
                {
                    return new global::Zoo.JsonConverters.TextToCadResponseVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.TextToCadResponseVariant2Type))
                {
                    return new global::Zoo.JsonConverters.TextToCadResponseVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.TextToCadResponseVariant2Type?))
                {
                    return new global::Zoo.JsonConverters.TextToCadResponseVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.TextToCadResponseVariant3Type))
                {
                    return new global::Zoo.JsonConverters.TextToCadResponseVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.TextToCadResponseVariant3Type?))
                {
                    return new global::Zoo.JsonConverters.TextToCadResponseVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.ApiCallStatusVariant1))
                {
                    return new global::Zoo.JsonConverters.ApiCallStatusVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.ApiCallStatusVariant1?))
                {
                    return new global::Zoo.JsonConverters.ApiCallStatusVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.ApiCallStatusVariant2))
                {
                    return new global::Zoo.JsonConverters.ApiCallStatusVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.ApiCallStatusVariant2?))
                {
                    return new global::Zoo.JsonConverters.ApiCallStatusVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.ApiCallStatusVariant3))
                {
                    return new global::Zoo.JsonConverters.ApiCallStatusVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.ApiCallStatusVariant3?))
                {
                    return new global::Zoo.JsonConverters.ApiCallStatusVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.ApiCallStatusVariant4))
                {
                    return new global::Zoo.JsonConverters.ApiCallStatusVariant4JsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.ApiCallStatusVariant4?))
                {
                    return new global::Zoo.JsonConverters.ApiCallStatusVariant4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.ApiCallStatusVariant5))
                {
                    return new global::Zoo.JsonConverters.ApiCallStatusVariant5JsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.ApiCallStatusVariant5?))
                {
                    return new global::Zoo.JsonConverters.ApiCallStatusVariant5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.TextToCadModelVariant1))
                {
                    return new global::Zoo.JsonConverters.TextToCadModelVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.TextToCadModelVariant1?))
                {
                    return new global::Zoo.JsonConverters.TextToCadModelVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.TextToCadModelVariant2))
                {
                    return new global::Zoo.JsonConverters.TextToCadModelVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.TextToCadModelVariant2?))
                {
                    return new global::Zoo.JsonConverters.TextToCadModelVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.TextToCadModelVariant3))
                {
                    return new global::Zoo.JsonConverters.TextToCadModelVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.TextToCadModelVariant3?))
                {
                    return new global::Zoo.JsonConverters.TextToCadModelVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.MlFeedbackVariant1))
                {
                    return new global::Zoo.JsonConverters.MlFeedbackVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.MlFeedbackVariant1?))
                {
                    return new global::Zoo.JsonConverters.MlFeedbackVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.MlFeedbackVariant2))
                {
                    return new global::Zoo.JsonConverters.MlFeedbackVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.MlFeedbackVariant2?))
                {
                    return new global::Zoo.JsonConverters.MlFeedbackVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.MlFeedbackVariant3))
                {
                    return new global::Zoo.JsonConverters.MlFeedbackVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.MlFeedbackVariant3?))
                {
                    return new global::Zoo.JsonConverters.MlFeedbackVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.MlFeedbackVariant4))
                {
                    return new global::Zoo.JsonConverters.MlFeedbackVariant4JsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.MlFeedbackVariant4?))
                {
                    return new global::Zoo.JsonConverters.MlFeedbackVariant4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.FileExportFormatVariant1))
                {
                    return new global::Zoo.JsonConverters.FileExportFormatVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.FileExportFormatVariant1?))
                {
                    return new global::Zoo.JsonConverters.FileExportFormatVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.FileExportFormatVariant2))
                {
                    return new global::Zoo.JsonConverters.FileExportFormatVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.FileExportFormatVariant2?))
                {
                    return new global::Zoo.JsonConverters.FileExportFormatVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.FileExportFormatVariant3))
                {
                    return new global::Zoo.JsonConverters.FileExportFormatVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.FileExportFormatVariant3?))
                {
                    return new global::Zoo.JsonConverters.FileExportFormatVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.FileExportFormatVariant4))
                {
                    return new global::Zoo.JsonConverters.FileExportFormatVariant4JsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.FileExportFormatVariant4?))
                {
                    return new global::Zoo.JsonConverters.FileExportFormatVariant4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.FileExportFormatVariant5))
                {
                    return new global::Zoo.JsonConverters.FileExportFormatVariant5JsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.FileExportFormatVariant5?))
                {
                    return new global::Zoo.JsonConverters.FileExportFormatVariant5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.FileExportFormatVariant6))
                {
                    return new global::Zoo.JsonConverters.FileExportFormatVariant6JsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.FileExportFormatVariant6?))
                {
                    return new global::Zoo.JsonConverters.FileExportFormatVariant6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.FileExportFormatVariant7))
                {
                    return new global::Zoo.JsonConverters.FileExportFormatVariant7JsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.FileExportFormatVariant7?))
                {
                    return new global::Zoo.JsonConverters.FileExportFormatVariant7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.CreatedAtSortModeVariant1))
                {
                    return new global::Zoo.JsonConverters.CreatedAtSortModeVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.CreatedAtSortModeVariant1?))
                {
                    return new global::Zoo.JsonConverters.CreatedAtSortModeVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.CreatedAtSortModeVariant2))
                {
                    return new global::Zoo.JsonConverters.CreatedAtSortModeVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Zoo.CreatedAtSortModeVariant2?))
                {
                    return new global::Zoo.JsonConverters.CreatedAtSortModeVariant2NullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new MlSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}