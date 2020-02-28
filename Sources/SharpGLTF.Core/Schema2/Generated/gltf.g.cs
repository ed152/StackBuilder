//------------------------------------------------------------------------------------------------
//      This file has been programatically generated; DON´T EDIT!
//------------------------------------------------------------------------------------------------

#pragma warning disable SA1001
#pragma warning disable SA1027
#pragma warning disable SA1028
#pragma warning disable SA1121
#pragma warning disable SA1205
#pragma warning disable SA1309
#pragma warning disable SA1402
#pragma warning disable SA1505
#pragma warning disable SA1507
#pragma warning disable SA1508
#pragma warning disable SA1652

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Text.Json;

namespace SharpGLTF.Schema2
{
	using Collections;

	/// <summary>
	/// The indices data type.
	/// </summary>
	public enum IndexEncodingType
	{
		UNSIGNED_BYTE = 5121,
		UNSIGNED_SHORT = 5123,
		UNSIGNED_INT = 5125,
	}


	/// <summary>
	/// The datatype of components in the attribute.
	/// </summary>
	public enum EncodingType
	{
		BYTE = 5120,
		UNSIGNED_BYTE = 5121,
		SHORT = 5122,
		UNSIGNED_SHORT = 5123,
		UNSIGNED_INT = 5125,
		FLOAT = 5126,
	}


	/// <summary>
	/// Specifies if the attribute is a scalar, vector, or matrix.
	/// </summary>
	public enum DimensionType
	{
		SCALAR,
		VEC2,
		VEC3,
		VEC4,
		MAT2,
		MAT3,
		MAT4,
	}


	/// <summary>
	/// The name of the node's TRS property to modify, or the "weights" of the Morph Targets it instantiates. For the "translation" property, the values that are provided by the sampler are the translation along the x, y, and z axes. For the "rotation" property, the values are a quaternion in the order (x, y, z, w), where w is the scalar. For the "scale" property, the values are the scaling factors along the x, y, and z axes.
	/// </summary>
	public enum PropertyPath
	{
		translation,
		rotation,
		scale,
		weights,
	}


	/// <summary>
	/// Interpolation algorithm.
	/// </summary>
	public enum AnimationInterpolationMode
	{
		LINEAR,
		STEP,
		CUBICSPLINE,
	}


	/// <summary>
	/// The target that the GPU buffer should be bound to.
	/// </summary>
	public enum BufferMode
	{
		ARRAY_BUFFER = 34962,
		ELEMENT_ARRAY_BUFFER = 34963,
	}


	/// <summary>
	/// Specifies if the camera uses a perspective or orthographic projection.
	/// </summary>
	public enum CameraType
	{
		perspective,
		orthographic,
	}


	/// <summary>
	/// The alpha rendering mode of the material.
	/// </summary>
	public enum AlphaMode
	{
		OPAQUE,
		MASK,
		BLEND,
	}


	/// <summary>
	/// The type of primitives to render.
	/// </summary>
	public enum PrimitiveType
	{
		POINTS = 0,
		LINES = 1,
		LINE_LOOP = 2,
		LINE_STRIP = 3,
		TRIANGLES = 4,
		TRIANGLE_STRIP = 5,
		TRIANGLE_FAN = 6,
	}


	/// <summary>
	/// Magnification filter.
	/// </summary>
	public enum TextureInterpolationFilter
	{
		NEAREST = 9728,
		LINEAR = 9729,
		DEFAULT = 0,
	}


	/// <summary>
	/// Minification filter.
	/// </summary>
	public enum TextureMipMapFilter
	{
		NEAREST = 9728,
		LINEAR = 9729,
		NEAREST_MIPMAP_NEAREST = 9984,
		LINEAR_MIPMAP_NEAREST = 9985,
		NEAREST_MIPMAP_LINEAR = 9986,
		LINEAR_MIPMAP_LINEAR = 9987,
		DEFAULT = 0,
	}


	/// <summary>
	/// t wrapping mode.
	/// </summary>
	public enum TextureWrapMode
	{
		CLAMP_TO_EDGE = 33071,
		MIRRORED_REPEAT = 33648,
		REPEAT = 10497,
	}


	partial class LogicalChildOfRoot : ExtraProperties
	{
	
		private String _name;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "name", _name);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "name": _name = DeserializePropertyValue<String>(ref reader); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

	/// <summary>
	/// Indices of those attributes that deviate from their initialization value.
	/// </summary>
	partial class AccessorSparseIndices : ExtraProperties
	{
	
		private Int32 _bufferView;
		
		private const Int32 _byteOffsetDefault = 0;
		private const Int32 _byteOffsetMinimum = 0;
		private Int32? _byteOffset = _byteOffsetDefault;
		
		private IndexEncodingType _componentType;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "bufferView", _bufferView);
			SerializeProperty(writer, "byteOffset", _byteOffset, _byteOffsetDefault);
			SerializePropertyEnumValue<IndexEncodingType>(writer, "componentType", _componentType);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "bufferView": _bufferView = DeserializePropertyValue<Int32>(ref reader); break;
				case "byteOffset": _byteOffset = DeserializePropertyValue<Int32?>(ref reader); break;
				case "componentType": _componentType = DeserializePropertyValue<IndexEncodingType>(ref reader); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

	/// <summary>
	/// Array of size `accessor.sparse.count` times number of components storing the displaced accessor attributes pointed by `accessor.sparse.indices`.
	/// </summary>
	partial class AccessorSparseValues : ExtraProperties
	{
	
		private Int32 _bufferView;
		
		private const Int32 _byteOffsetDefault = 0;
		private const Int32 _byteOffsetMinimum = 0;
		private Int32? _byteOffset = _byteOffsetDefault;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "bufferView", _bufferView);
			SerializeProperty(writer, "byteOffset", _byteOffset, _byteOffsetDefault);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "bufferView": _bufferView = DeserializePropertyValue<Int32>(ref reader); break;
				case "byteOffset": _byteOffset = DeserializePropertyValue<Int32?>(ref reader); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

	/// <summary>
	/// Sparse storage of attributes that deviate from their initialization value.
	/// </summary>
	partial class AccessorSparse : ExtraProperties
	{
	
		private const Int32 _countMinimum = 1;
		private Int32 _count;
		
		private AccessorSparseIndices _indices;
		
		private AccessorSparseValues _values;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "count", _count);
			SerializePropertyObject(writer, "indices", _indices);
			SerializePropertyObject(writer, "values", _values);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "count": _count = DeserializePropertyValue<Int32>(ref reader); break;
				case "indices": _indices = DeserializePropertyValue<AccessorSparseIndices>(ref reader); break;
				case "values": _values = DeserializePropertyValue<AccessorSparseValues>(ref reader); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

	/// <summary>
	/// A typed view into a bufferView.
	/// A bufferView contains raw binary data.
	/// An accessor provides a typed view into a bufferView or a subset of a bufferView similar to how WebGL's `vertexAttribPointer()` defines an attribute in a buffer.
	/// </summary>
	partial class Accessor : LogicalChildOfRoot
	{
	
		private Int32? _bufferView;
		
		private const Int32 _byteOffsetDefault = 0;
		private const Int32 _byteOffsetMinimum = 0;
		private Int32? _byteOffset = _byteOffsetDefault;
		
		private EncodingType _componentType;
		
		private const Int32 _countMinimum = 1;
		private Int32 _count;
		
		private const int _maxMinItems = 1;
		private const int _maxMaxItems = 16;
		private List<Double> _max;
		
		private const int _minMinItems = 1;
		private const int _minMaxItems = 16;
		private List<Double> _min;
		
		private static readonly Boolean _normalizedDefault = false;
		private Boolean? _normalized = _normalizedDefault;
		
		private AccessorSparse _sparse;
		
		private DimensionType _type;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "bufferView", _bufferView);
			SerializeProperty(writer, "byteOffset", _byteOffset, _byteOffsetDefault);
			SerializePropertyEnumValue<EncodingType>(writer, "componentType", _componentType);
			SerializeProperty(writer, "count", _count);
			SerializeProperty(writer, "max", _max, _maxMinItems);
			SerializeProperty(writer, "min", _min, _minMinItems);
			SerializeProperty(writer, "normalized", _normalized, _normalizedDefault);
			SerializePropertyObject(writer, "sparse", _sparse);
			SerializePropertyEnumSymbol<DimensionType>(writer, "type", _type);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "bufferView": _bufferView = DeserializePropertyValue<Int32?>(ref reader); break;
				case "byteOffset": _byteOffset = DeserializePropertyValue<Int32?>(ref reader); break;
				case "componentType": _componentType = DeserializePropertyValue<EncodingType>(ref reader); break;
				case "count": _count = DeserializePropertyValue<Int32>(ref reader); break;
				case "max": DeserializePropertyList<Double>(ref reader, _max); break;
				case "min": DeserializePropertyList<Double>(ref reader, _min); break;
				case "normalized": _normalized = DeserializePropertyValue<Boolean?>(ref reader); break;
				case "sparse": _sparse = DeserializePropertyValue<AccessorSparse>(ref reader); break;
				case "type": _type = DeserializePropertyValue<DimensionType>(ref reader); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

	/// <summary>
	/// The index of the node and TRS property that an animation channel targets.
	/// </summary>
	partial class AnimationChannelTarget : ExtraProperties
	{
	
		private Int32? _node;
		
		private PropertyPath _path;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "node", _node);
			SerializePropertyEnumSymbol<PropertyPath>(writer, "path", _path);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "node": _node = DeserializePropertyValue<Int32?>(ref reader); break;
				case "path": _path = DeserializePropertyValue<PropertyPath>(ref reader); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

	/// <summary>
	/// Targets an animation's sampler at a node's property.
	/// </summary>
	partial class AnimationChannel : ExtraProperties
	{
	
		private Int32 _sampler;
		
		private AnimationChannelTarget _target;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "sampler", _sampler);
			SerializePropertyObject(writer, "target", _target);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "sampler": _sampler = DeserializePropertyValue<Int32>(ref reader); break;
				case "target": _target = DeserializePropertyValue<AnimationChannelTarget>(ref reader); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

	/// <summary>
	/// Combines input and output accessors with an interpolation algorithm to define a keyframe graph (but not its target).
	/// </summary>
	partial class AnimationSampler : ExtraProperties
	{
	
		private Int32 _input;
		
		private const AnimationInterpolationMode _interpolationDefault = AnimationInterpolationMode.LINEAR;
		private AnimationInterpolationMode? _interpolation = _interpolationDefault;
		
		private Int32 _output;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "input", _input);
			SerializePropertyEnumSymbol<AnimationInterpolationMode>(writer, "interpolation", _interpolation, _interpolationDefault);
			SerializeProperty(writer, "output", _output);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "input": _input = DeserializePropertyValue<Int32>(ref reader); break;
				case "interpolation": _interpolation = DeserializePropertyValue<AnimationInterpolationMode>(ref reader); break;
				case "output": _output = DeserializePropertyValue<Int32>(ref reader); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

	/// <summary>
	/// A keyframe animation.
	/// </summary>
	partial class Animation : LogicalChildOfRoot
	{
	
		private const int _channelsMinItems = 1;
		private ChildrenCollection<AnimationChannel,Animation> _channels;
		
		private const int _samplersMinItems = 1;
		private ChildrenCollection<AnimationSampler,Animation> _samplers;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "channels", _channels, _channelsMinItems);
			SerializeProperty(writer, "samplers", _samplers, _samplersMinItems);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "channels": DeserializePropertyList<AnimationChannel>(ref reader, _channels); break;
				case "samplers": DeserializePropertyList<AnimationSampler>(ref reader, _samplers); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

	/// <summary>
	/// Metadata about the glTF asset.
	/// </summary>
	partial class Asset : ExtraProperties
	{
	
		private String _copyright;
		
		private String _generator;
		
		private String _minVersion;
		
		private String _version;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "copyright", _copyright);
			SerializeProperty(writer, "generator", _generator);
			SerializeProperty(writer, "minVersion", _minVersion);
			SerializeProperty(writer, "version", _version);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "copyright": _copyright = DeserializePropertyValue<String>(ref reader); break;
				case "generator": _generator = DeserializePropertyValue<String>(ref reader); break;
				case "minVersion": _minVersion = DeserializePropertyValue<String>(ref reader); break;
				case "version": _version = DeserializePropertyValue<String>(ref reader); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

	/// <summary>
	/// A buffer points to binary geometry, animation, or skins.
	/// </summary>
	partial class Buffer : LogicalChildOfRoot
	{
	
		private const Int32 _byteLengthMinimum = 1;
		private Int32 _byteLength;
		
		private String _uri;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "byteLength", _byteLength);
			SerializeProperty(writer, "uri", _uri);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "byteLength": _byteLength = DeserializePropertyValue<Int32>(ref reader); break;
				case "uri": _uri = DeserializePropertyValue<String>(ref reader); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

	/// <summary>
	/// A view into a buffer generally representing a subset of the buffer.
	/// </summary>
	partial class BufferView : LogicalChildOfRoot
	{
	
		private Int32 _buffer;
		
		private const Int32 _byteLengthMinimum = 1;
		private Int32 _byteLength;
		
		private const Int32 _byteOffsetDefault = 0;
		private const Int32 _byteOffsetMinimum = 0;
		private Int32? _byteOffset = _byteOffsetDefault;
		
		private const Int32 _byteStrideMinimum = 4;
		private const Int32 _byteStrideMaximum = 252;
		private Int32? _byteStride;
		
		private BufferMode? _target;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "buffer", _buffer);
			SerializeProperty(writer, "byteLength", _byteLength);
			SerializeProperty(writer, "byteOffset", _byteOffset, _byteOffsetDefault);
			SerializeProperty(writer, "byteStride", _byteStride);
			SerializePropertyEnumValue<BufferMode>(writer, "target", _target);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "buffer": _buffer = DeserializePropertyValue<Int32>(ref reader); break;
				case "byteLength": _byteLength = DeserializePropertyValue<Int32>(ref reader); break;
				case "byteOffset": _byteOffset = DeserializePropertyValue<Int32?>(ref reader); break;
				case "byteStride": _byteStride = DeserializePropertyValue<Int32?>(ref reader); break;
				case "target": _target = DeserializePropertyValue<BufferMode>(ref reader); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

	/// <summary>
	/// An orthographic camera containing properties to create an orthographic projection matrix.
	/// </summary>
	partial class CameraOrthographic : ExtraProperties
	{
	
		private Double _xmag;
		
		private Double _ymag;
		
		private const Double _zfarMinimum = 0;
		private Double _zfar;
		
		private const Double _znearMinimum = 0;
		private Double _znear;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "xmag", _xmag);
			SerializeProperty(writer, "ymag", _ymag);
			SerializeProperty(writer, "zfar", _zfar);
			SerializeProperty(writer, "znear", _znear);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "xmag": _xmag = DeserializePropertyValue<Double>(ref reader); break;
				case "ymag": _ymag = DeserializePropertyValue<Double>(ref reader); break;
				case "zfar": _zfar = DeserializePropertyValue<Double>(ref reader); break;
				case "znear": _znear = DeserializePropertyValue<Double>(ref reader); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

	/// <summary>
	/// A perspective camera containing properties to create a perspective projection matrix.
	/// </summary>
	partial class CameraPerspective : ExtraProperties
	{
	
		private const Double _aspectRatioMinimum = 0;
		private Double? _aspectRatio;
		
		private const Double _yfovMinimum = 0;
		private Double _yfov;
		
		private const Double _zfarMinimum = 0;
		private Double? _zfar;
		
		private const Double _znearMinimum = 0;
		private Double _znear;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "aspectRatio", _aspectRatio);
			SerializeProperty(writer, "yfov", _yfov);
			SerializeProperty(writer, "zfar", _zfar);
			SerializeProperty(writer, "znear", _znear);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "aspectRatio": _aspectRatio = DeserializePropertyValue<Double?>(ref reader); break;
				case "yfov": _yfov = DeserializePropertyValue<Double>(ref reader); break;
				case "zfar": _zfar = DeserializePropertyValue<Double?>(ref reader); break;
				case "znear": _znear = DeserializePropertyValue<Double>(ref reader); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

	/// <summary>
	/// A camera's projection.
	/// A node can reference a camera to apply a transform to place the camera in the scene.
	/// </summary>
	partial class Camera : LogicalChildOfRoot
	{
	
		private CameraOrthographic _orthographic;
		
		private CameraPerspective _perspective;
		
		private CameraType _type;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializePropertyObject(writer, "orthographic", _orthographic);
			SerializePropertyObject(writer, "perspective", _perspective);
			SerializePropertyEnumSymbol<CameraType>(writer, "type", _type);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "orthographic": _orthographic = DeserializePropertyValue<CameraOrthographic>(ref reader); break;
				case "perspective": _perspective = DeserializePropertyValue<CameraPerspective>(ref reader); break;
				case "type": _type = DeserializePropertyValue<CameraType>(ref reader); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

	/// <summary>
	/// Reference to a texture.
	/// </summary>
	partial class TextureInfo : ExtraProperties
	{
	
		private Int32 _index;
		
		private const Int32 _texCoordDefault = 0;
		private const Int32 _texCoordMinimum = 0;
		private Int32? _texCoord = _texCoordDefault;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "index", _index);
			SerializeProperty(writer, "texCoord", _texCoord, _texCoordDefault);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "index": _index = DeserializePropertyValue<Int32>(ref reader); break;
				case "texCoord": _texCoord = DeserializePropertyValue<Int32?>(ref reader); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

	/// <summary>
	/// A set of parameter values that are used to define the metallic-roughness material model from Physically-Based Rendering (PBR) methodology.
	/// </summary>
	partial class MaterialPBRMetallicRoughness : ExtraProperties
	{
	
		private static readonly Vector4 _baseColorFactorDefault = Vector4.One;
		private Vector4? _baseColorFactor = _baseColorFactorDefault;
		
		private TextureInfo _baseColorTexture;
		
		private const Double _metallicFactorDefault = 1;
		private const Double _metallicFactorMinimum = 0;
		private const Double _metallicFactorMaximum = 1;
		private Double? _metallicFactor = _metallicFactorDefault;
		
		private TextureInfo _metallicRoughnessTexture;
		
		private const Double _roughnessFactorDefault = 1;
		private const Double _roughnessFactorMinimum = 0;
		private const Double _roughnessFactorMaximum = 1;
		private Double? _roughnessFactor = _roughnessFactorDefault;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "baseColorFactor", _baseColorFactor, _baseColorFactorDefault);
			SerializePropertyObject(writer, "baseColorTexture", _baseColorTexture);
			SerializeProperty(writer, "metallicFactor", _metallicFactor, _metallicFactorDefault);
			SerializePropertyObject(writer, "metallicRoughnessTexture", _metallicRoughnessTexture);
			SerializeProperty(writer, "roughnessFactor", _roughnessFactor, _roughnessFactorDefault);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "baseColorFactor": _baseColorFactor = DeserializePropertyValue<Vector4?>(ref reader); break;
				case "baseColorTexture": _baseColorTexture = DeserializePropertyValue<TextureInfo>(ref reader); break;
				case "metallicFactor": _metallicFactor = DeserializePropertyValue<Double?>(ref reader); break;
				case "metallicRoughnessTexture": _metallicRoughnessTexture = DeserializePropertyValue<TextureInfo>(ref reader); break;
				case "roughnessFactor": _roughnessFactor = DeserializePropertyValue<Double?>(ref reader); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

	partial class MaterialNormalTextureInfo : TextureInfo
	{
	
		private const Double _scaleDefault = 1;
		private Double? _scale = _scaleDefault;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "scale", _scale, _scaleDefault);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "scale": _scale = DeserializePropertyValue<Double?>(ref reader); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

	partial class MaterialOcclusionTextureInfo : TextureInfo
	{
	
		private const Double _strengthDefault = 1;
		private const Double _strengthMinimum = 0;
		private const Double _strengthMaximum = 1;
		private Double? _strength = _strengthDefault;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "strength", _strength, _strengthDefault);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "strength": _strength = DeserializePropertyValue<Double?>(ref reader); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

	/// <summary>
	/// The material appearance of a primitive.
	/// </summary>
	partial class Material : LogicalChildOfRoot
	{
	
		private const Double _alphaCutoffDefault = 0.5;
		private const Double _alphaCutoffMinimum = 0;
		private Double? _alphaCutoff = _alphaCutoffDefault;
		
		private const AlphaMode _alphaModeDefault = AlphaMode.OPAQUE;
		private AlphaMode? _alphaMode = _alphaModeDefault;
		
		private static readonly Boolean _doubleSidedDefault = false;
		private Boolean? _doubleSided = _doubleSidedDefault;
		
		private static readonly Vector3 _emissiveFactorDefault = Vector3.Zero;
		private Vector3? _emissiveFactor = _emissiveFactorDefault;
		
		private TextureInfo _emissiveTexture;
		
		private MaterialNormalTextureInfo _normalTexture;
		
		private MaterialOcclusionTextureInfo _occlusionTexture;
		
		private MaterialPBRMetallicRoughness _pbrMetallicRoughness;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "alphaCutoff", _alphaCutoff, _alphaCutoffDefault);
			SerializePropertyEnumSymbol<AlphaMode>(writer, "alphaMode", _alphaMode, _alphaModeDefault);
			SerializeProperty(writer, "doubleSided", _doubleSided, _doubleSidedDefault);
			SerializeProperty(writer, "emissiveFactor", _emissiveFactor, _emissiveFactorDefault);
			SerializePropertyObject(writer, "emissiveTexture", _emissiveTexture);
			SerializePropertyObject(writer, "normalTexture", _normalTexture);
			SerializePropertyObject(writer, "occlusionTexture", _occlusionTexture);
			SerializePropertyObject(writer, "pbrMetallicRoughness", _pbrMetallicRoughness);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "alphaCutoff": _alphaCutoff = DeserializePropertyValue<Double?>(ref reader); break;
				case "alphaMode": _alphaMode = DeserializePropertyValue<AlphaMode>(ref reader); break;
				case "doubleSided": _doubleSided = DeserializePropertyValue<Boolean?>(ref reader); break;
				case "emissiveFactor": _emissiveFactor = DeserializePropertyValue<Vector3?>(ref reader); break;
				case "emissiveTexture": _emissiveTexture = DeserializePropertyValue<TextureInfo>(ref reader); break;
				case "normalTexture": _normalTexture = DeserializePropertyValue<MaterialNormalTextureInfo>(ref reader); break;
				case "occlusionTexture": _occlusionTexture = DeserializePropertyValue<MaterialOcclusionTextureInfo>(ref reader); break;
				case "pbrMetallicRoughness": _pbrMetallicRoughness = DeserializePropertyValue<MaterialPBRMetallicRoughness>(ref reader); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

	/// <summary>
	/// Geometry to be rendered with the given material.
	/// </summary>
	partial class MeshPrimitive : ExtraProperties
	{
	
		private Dictionary<String,Int32> _attributes;
		
		private Int32? _indices;
		
		private Int32? _material;
		
		private const PrimitiveType _modeDefault = (PrimitiveType)4;
		private PrimitiveType? _mode = _modeDefault;
		
		private const int _targetsMinItems = 1;
		private List<Dictionary<String,Int32>> _targets;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "attributes", _attributes);
			SerializeProperty(writer, "indices", _indices);
			SerializeProperty(writer, "material", _material);
			SerializePropertyEnumValue<PrimitiveType>(writer, "mode", _mode, _modeDefault);
			SerializeProperty(writer, "targets", _targets, _targetsMinItems);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "attributes": DeserializePropertyDictionary<Int32>(ref reader, _attributes); break;
				case "indices": _indices = DeserializePropertyValue<Int32?>(ref reader); break;
				case "material": _material = DeserializePropertyValue<Int32?>(ref reader); break;
				case "mode": _mode = DeserializePropertyValue<PrimitiveType>(ref reader); break;
				case "targets": DeserializePropertyList<Dictionary<String,Int32>>(ref reader, _targets); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

	/// <summary>
	/// A set of primitives to be rendered.
	/// A node can contain one mesh.
	/// A node's transform places the mesh in the scene.
	/// </summary>
	partial class Mesh : LogicalChildOfRoot
	{
	
		private const int _primitivesMinItems = 1;
		private ChildrenCollection<MeshPrimitive,Mesh> _primitives;
		
		private const int _weightsMinItems = 1;
		private List<Double> _weights;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "primitives", _primitives, _primitivesMinItems);
			SerializeProperty(writer, "weights", _weights, _weightsMinItems);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "primitives": DeserializePropertyList<MeshPrimitive>(ref reader, _primitives); break;
				case "weights": DeserializePropertyList<Double>(ref reader, _weights); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

	/// <summary>
	/// A node in the node hierarchy.
	/// When the node contains `skin`, all `mesh.primitives` must contain `JOINTS_0` and `WEIGHTS_0` attributes.
	/// A node can have either a `matrix` or any combination of `translation`/`rotation`/`scale` (TRS) properties. TRS properties are converted to matrices and postmultiplied in the `T * R * S` order to compose the transformation matrix; first the scale is applied to the vertices, then the rotation, and then the translation. If none are provided, the transform is the identity. When a node is targeted for animation (referenced by an animation.channel.target), only TRS properties may be present; `matrix` will not be present.
	/// </summary>
	partial class Node : LogicalChildOfRoot
	{
	
		private Int32? _camera;
		
		private const int _childrenMinItems = 1;
		private List<Int32> _children;
		
		private Matrix4x4? _matrix;
		
		private Int32? _mesh;
		
		private Quaternion? _rotation;
		
		private Vector3? _scale;
		
		private Int32? _skin;
		
		private Vector3? _translation;
		
		private const int _weightsMinItems = 1;
		private List<Double> _weights;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "camera", _camera);
			SerializeProperty(writer, "children", _children, _childrenMinItems);
			SerializeProperty(writer, "matrix", _matrix);
			SerializeProperty(writer, "mesh", _mesh);
			SerializeProperty(writer, "rotation", _rotation);
			SerializeProperty(writer, "scale", _scale);
			SerializeProperty(writer, "skin", _skin);
			SerializeProperty(writer, "translation", _translation);
			SerializeProperty(writer, "weights", _weights, _weightsMinItems);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "camera": _camera = DeserializePropertyValue<Int32?>(ref reader); break;
				case "children": DeserializePropertyList<Int32>(ref reader, _children); break;
				case "matrix": _matrix = DeserializePropertyValue<Matrix4x4?>(ref reader); break;
				case "mesh": _mesh = DeserializePropertyValue<Int32?>(ref reader); break;
				case "rotation": _rotation = DeserializePropertyValue<Quaternion?>(ref reader); break;
				case "scale": _scale = DeserializePropertyValue<Vector3?>(ref reader); break;
				case "skin": _skin = DeserializePropertyValue<Int32?>(ref reader); break;
				case "translation": _translation = DeserializePropertyValue<Vector3?>(ref reader); break;
				case "weights": DeserializePropertyList<Double>(ref reader, _weights); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

	/// <summary>
	/// Texture sampler properties for filtering and wrapping modes.
	/// </summary>
	partial class TextureSampler : LogicalChildOfRoot
	{
	
		private TextureInterpolationFilter? _magFilter;
		
		private TextureMipMapFilter? _minFilter;
		
		private const TextureWrapMode _wrapSDefault = (TextureWrapMode)10497;
		private TextureWrapMode? _wrapS = _wrapSDefault;
		
		private const TextureWrapMode _wrapTDefault = (TextureWrapMode)10497;
		private TextureWrapMode? _wrapT = _wrapTDefault;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializePropertyEnumValue<TextureInterpolationFilter>(writer, "magFilter", _magFilter);
			SerializePropertyEnumValue<TextureMipMapFilter>(writer, "minFilter", _minFilter);
			SerializePropertyEnumValue<TextureWrapMode>(writer, "wrapS", _wrapS, _wrapSDefault);
			SerializePropertyEnumValue<TextureWrapMode>(writer, "wrapT", _wrapT, _wrapTDefault);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "magFilter": _magFilter = DeserializePropertyValue<TextureInterpolationFilter>(ref reader); break;
				case "minFilter": _minFilter = DeserializePropertyValue<TextureMipMapFilter>(ref reader); break;
				case "wrapS": _wrapS = DeserializePropertyValue<TextureWrapMode>(ref reader); break;
				case "wrapT": _wrapT = DeserializePropertyValue<TextureWrapMode>(ref reader); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

	/// <summary>
	/// The root nodes of a scene.
	/// </summary>
	partial class Scene : LogicalChildOfRoot
	{
	
		private const int _nodesMinItems = 1;
		private List<Int32> _nodes;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "nodes", _nodes, _nodesMinItems);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "nodes": DeserializePropertyList<Int32>(ref reader, _nodes); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

	/// <summary>
	/// Joints and matrices defining a skin.
	/// </summary>
	partial class Skin : LogicalChildOfRoot
	{
	
		private Int32? _inverseBindMatrices;
		
		private const int _jointsMinItems = 1;
		private List<Int32> _joints;
		
		private Int32? _skeleton;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "inverseBindMatrices", _inverseBindMatrices);
			SerializeProperty(writer, "joints", _joints, _jointsMinItems);
			SerializeProperty(writer, "skeleton", _skeleton);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "inverseBindMatrices": _inverseBindMatrices = DeserializePropertyValue<Int32?>(ref reader); break;
				case "joints": DeserializePropertyList<Int32>(ref reader, _joints); break;
				case "skeleton": _skeleton = DeserializePropertyValue<Int32?>(ref reader); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

	/// <summary>
	/// A texture and its sampler.
	/// </summary>
	partial class Texture : LogicalChildOfRoot
	{
	
		private Int32? _sampler;
		
		private Int32? _source;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "sampler", _sampler);
			SerializeProperty(writer, "source", _source);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "sampler": _sampler = DeserializePropertyValue<Int32?>(ref reader); break;
				case "source": _source = DeserializePropertyValue<Int32?>(ref reader); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

	/// <summary>
	/// The root object for a glTF asset.
	/// </summary>
	partial class ModelRoot : ExtraProperties
	{
	
		private Asset _asset;
		
		private const int _extensionsRequiredMinItems = 1;
		private List<String> _extensionsRequired;
		
		private const int _extensionsUsedMinItems = 1;
		private List<String> _extensionsUsed;
		
		private const int _accessorsMinItems = 1;
		private ChildrenCollection<Accessor,ModelRoot> _accessors;
		
		private const int _animationsMinItems = 1;
		private ChildrenCollection<Animation,ModelRoot> _animations;
		
		private const int _bufferViewsMinItems = 1;
		private ChildrenCollection<BufferView,ModelRoot> _bufferViews;
		
		private const int _buffersMinItems = 1;
		private ChildrenCollection<Buffer,ModelRoot> _buffers;
		
		private const int _camerasMinItems = 1;
		private ChildrenCollection<Camera,ModelRoot> _cameras;
		
		private const int _imagesMinItems = 1;
		private ChildrenCollection<Image,ModelRoot> _images;
		
		private const int _materialsMinItems = 1;
		private ChildrenCollection<Material,ModelRoot> _materials;
		
		private const int _meshesMinItems = 1;
		private ChildrenCollection<Mesh,ModelRoot> _meshes;
		
		private const int _nodesMinItems = 1;
		private ChildrenCollection<Node,ModelRoot> _nodes;
		
		private const int _samplersMinItems = 1;
		private ChildrenCollection<TextureSampler,ModelRoot> _samplers;
		
		private Int32? _scene;
		
		private const int _scenesMinItems = 1;
		private ChildrenCollection<Scene,ModelRoot> _scenes;
		
		private const int _skinsMinItems = 1;
		private ChildrenCollection<Skin,ModelRoot> _skins;
		
		private const int _texturesMinItems = 1;
		private ChildrenCollection<Texture,ModelRoot> _textures;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializePropertyObject(writer, "asset", _asset);
			SerializeProperty(writer, "extensionsRequired", _extensionsRequired, _extensionsRequiredMinItems);
			SerializeProperty(writer, "extensionsUsed", _extensionsUsed, _extensionsUsedMinItems);
			SerializeProperty(writer, "accessors", _accessors, _accessorsMinItems);
			SerializeProperty(writer, "animations", _animations, _animationsMinItems);
			SerializeProperty(writer, "bufferViews", _bufferViews, _bufferViewsMinItems);
			SerializeProperty(writer, "buffers", _buffers, _buffersMinItems);
			SerializeProperty(writer, "cameras", _cameras, _camerasMinItems);
			SerializeProperty(writer, "images", _images, _imagesMinItems);
			SerializeProperty(writer, "materials", _materials, _materialsMinItems);
			SerializeProperty(writer, "meshes", _meshes, _meshesMinItems);
			SerializeProperty(writer, "nodes", _nodes, _nodesMinItems);
			SerializeProperty(writer, "samplers", _samplers, _samplersMinItems);
			SerializeProperty(writer, "scene", _scene);
			SerializeProperty(writer, "scenes", _scenes, _scenesMinItems);
			SerializeProperty(writer, "skins", _skins, _skinsMinItems);
			SerializeProperty(writer, "textures", _textures, _texturesMinItems);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "asset": _asset = DeserializePropertyValue<Asset>(ref reader); break;
				case "extensionsRequired": DeserializePropertyList<String>(ref reader, _extensionsRequired); break;
				case "extensionsUsed": DeserializePropertyList<String>(ref reader, _extensionsUsed); break;
				case "accessors": DeserializePropertyList<Accessor>(ref reader, _accessors); break;
				case "animations": DeserializePropertyList<Animation>(ref reader, _animations); break;
				case "bufferViews": DeserializePropertyList<BufferView>(ref reader, _bufferViews); break;
				case "buffers": DeserializePropertyList<Buffer>(ref reader, _buffers); break;
				case "cameras": DeserializePropertyList<Camera>(ref reader, _cameras); break;
				case "images": DeserializePropertyList<Image>(ref reader, _images); break;
				case "materials": DeserializePropertyList<Material>(ref reader, _materials); break;
				case "meshes": DeserializePropertyList<Mesh>(ref reader, _meshes); break;
				case "nodes": DeserializePropertyList<Node>(ref reader, _nodes); break;
				case "samplers": DeserializePropertyList<TextureSampler>(ref reader, _samplers); break;
				case "scene": _scene = DeserializePropertyValue<Int32?>(ref reader); break;
				case "scenes": DeserializePropertyList<Scene>(ref reader, _scenes); break;
				case "skins": DeserializePropertyList<Skin>(ref reader, _skins); break;
				case "textures": DeserializePropertyList<Texture>(ref reader, _textures); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

	/// <summary>
	/// Image data used to create a texture. Image can be referenced by URI or `bufferView` index. `mimeType` is required in the latter case.
	/// </summary>
	partial class Image : LogicalChildOfRoot
	{
	
		private Int32? _bufferView;
		
		private String _mimeType;
		
		private String _uri;
		
	
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "bufferView", _bufferView);
			SerializeProperty(writer, "mimeType", _mimeType);
			SerializeProperty(writer, "uri", _uri);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref Utf8JsonReader reader)
		{
			switch (jsonPropertyName)
			{
				case "bufferView": _bufferView = DeserializePropertyValue<Int32?>(ref reader); break;
				case "mimeType": _mimeType = DeserializePropertyValue<String>(ref reader); break;
				case "uri": _uri = DeserializePropertyValue<String>(ref reader); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
	}

}
