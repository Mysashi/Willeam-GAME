Unity exposes up to four Material layers for you to use in your Layered Material. Use the <strong>Layer Count</strong> slider to set the number of layers that Unity exposes. Every layer shares the same <strong>Surface Inputs</strong> and <strong>Detail Inputs</strong>. The only difference is between the <strong>Main Layer</strong> and the numbered layers (<strong>Layer 1</strong>, <strong>Layer 2</strong>, and <strong>Layer 3</strong>) which have separate <strong>Layering Options</strong>.

#### Layering Options - Main Layer

| <strong>Property</strong>             | <strong>Description</strong>                                              |
| ------------------------ | ------------------------------------------------------------ |
| <strong>Layer Influence Mask</strong> | Specifies a Texture that defines the areas where the <strong>Main Layer</strong> can influence the numbered layers. White pixels mean full influence and black pixels mean no influence.<br/>This property only appears when you enable the <strong>Main Layer Influence</strong> checkbox. |

#### Layering Options - Numbered layers

| <strong>Property</strong>                       | <strong>Description</strong>                                              |
| ---------------------------------- | ------------------------------------------------------------ |
| <strong>Use Opacity map as Density map</strong> | Indicates whether to use the alpha channel of the <strong>Base Map</strong> as the opacity threshold. |
| <strong>BaseColor Influence</strong>            | The strength of the <strong>Main Layer</strong>'s influence on this layer's base color. As you increase this value, the <strong>Main Layer</strong> color becomes more visible, but the Material maintains the other layers' variance.<br/>This property only appears when you enable the <strong>Main Layer Influence</strong> checkbox. |
| <strong>Normal Influence</strong>               | The strength of the <strong>Main Layer</strong>'s influence on this layer's normals. HDRP adds the <strong>Main Layer</strong>'s normal values to the layer's normals.<br/>This property only appears when you enable the <strong>Main Layer Influence</strong> checkbox. |
| <strong>Heightmap Influence</strong>            | The strength of the <strong>Main Layer</strong>'s influence on this layer's heightmap. HDRP adds the <strong>Main Layer</strong>'s heightmap values to the layer's heightmap.<br/>This property only appears when you enable the <strong>Main Layer Influence</strong> checkbox. |

#### Surface Inputs

| <strong>Property</strong>                    | <strong>Description</strong>                                              |
| ------------------------------- | ------------------------------------------------------------ |
| <strong>Base Map</strong>                    | Assign a Texture that controls both the color and opacity of your Material. To assign a Texture to this field, click the radio button and select your Texture in the Select Texture window. Use the color picker to select the color of the Material. If you do not assign a Texture, this is the absolute color of the Material. If you do assign a Texture, the final color of the Material is a combination of the Texture you assign and the color you select. The alpha value of the color controls the transparency level for the Material if you select <strong>Transparent</strong> from the <strong>Surface Type</strong> drop-down. |
| <strong>Metallic</strong>                    | Use this slider to adjust how "metal-like" the surface of your Material is (between 0 and 1). When a surface is more metallic, it reflects the environment more and its albedo color becomes less visible. At full metallic level, the surface color is entirely driven by reflections from the environment. When a surface is less metallic, its albedo color is clearer and any surface reflections are visible on top of the surface color, rather than obscuring it.<br />This property only appears when you unassign the Texture in the <strong>Mask Map</strong> and set <strong>Material Type</strong> to <strong>Standard</strong>. |
| <strong>Smoothness</strong>                  | Use the slider to adjust the smoothness of your Material. Every light ray that hits a smooth surface bounces off at predictable and consistent angles. For a perfectly smooth surface that reflects light like a mirror, set this to a value of 1. Less smooth surfaces reflect light over a wider range of angles (because the light hits the bumps in the microsurface), so the reflections have less detail and spread across the surface in a more diffused pattern.<br />This property only appears when you unassign the Texture in the <strong>Mask Map</strong>. |
| <strong>Alpha Remapping</strong>             | Use this min-max slider to remap the alpha values from the <strong>Base Map</strong> to the range you specify. Rather than <a href="https://docs.unity3d.com/ScriptReference/Mathf.Clamp.html">clamping</a> values to the new range, Unity condenses the original range down to the new range uniformly.<br />This property only appears when you assign a <strong>Base Map</strong>. |
| <strong>Metallic Remapping</strong>          | Use this min-max slider to remap the metallic values from the <strong>Mask Map</strong> to the range you specify. Rather than <a href="https://docs.unity3d.com/ScriptReference/Mathf.Clamp.html">clamping</a> values to the new range, Unity condenses the original range down to the new range uniformly.<br />This property only appears when you assign a <strong>Mask Map</strong>. |
| <strong>Smoothness Remapping</strong>        | Use this min-max slider to remap the smoothness values from the <strong>Mask Map</strong> to the range you specify. Rather than <a href="https://docs.unity3d.com/ScriptReference/Mathf.Clamp.html">clamping</a> values to the new range, Unity condenses the original range down to the new range uniformly.<br />This property only appears when you assign a <strong>Mask Map</strong>. |
| <strong>Ambient Occlusion Remapping</strong> | Use this min-max slider to remap the ambient occlusion values from the <strong>Mask Map</strong> to the range you specify. Rather than <a href="https://docs.unity3d.com/ScriptReference/Mathf.Clamp.html">clamping</a> values to the new range, Unity condenses the original range down to the new range uniformly.<br />This property only appears when you assign a <strong>Mask Map</strong>. |
| <strong>Mask Map</strong>                    | Assign a <a href="Glossary.md#ChannelPacking">channel-packed Texture</a> with the following Material maps in its RGBA channels.<br />&#8226; <strong>Red</strong>: Stores the metallic map. <br />&#8226; <strong>Green</strong>: Stores the ambient occlusion map.<br />&#8226; <strong>Blue</strong>: Stores the detail mask map.<br />&#8226; <strong>Alpha</strong>: Stores the smoothness map.<br />For more information on channel-packed Textures and the mask map, see <a href="Mask-Map-and-Detail-Map.md#MaskMap">mask map</a>. |
| <strong>Normal Map Space</strong>            | Use this drop-down to select the type of Normal Map space that this Material uses.<br />&#8226; <strong>TangentSpace</strong>: Defines the normal map in UV space; use this to tile a Texture on a Mesh. The normal map Texture must be BC7, BC5, or DXT5nm format.<br />&#8226; <strong>ObjectSpace</strong>: Defines the normal maps in world space. Use this for planar-mapping objects like the terrain. The normal map must be an RGB Texture . |
| <strong>Normal Map</strong>                  | Assign a Texture that defines the normal map for this Material in tangent space. Use the slider to modulate the normal intensity between 0 and 8.<br />This property only appears when you select <strong>TangentSpace</strong> from the <strong>Normal Map Space</strong> drop-down. |
| <strong>Normal Map OS</strong>               | Assign a Texture that defines the object space normal map for this Material. Use the handle to modulate the normal intensity between 0 and 8.<br />This property only appears when you select <strong>ObjectSpace</strong> from the <strong>Normal Map Space</strong> drop-down. |
| <strong>Bent Normal Map</strong>             | Assign a Texture that defines the bent normal map for this Material in tangent space. HDRP uses bent normal maps to simulate more accurate ambient occlusion.  Note: Bent normal maps only work with diffuse lighting.<br />This property only appears when you select <strong>TangentSpace</strong> from the <strong>Normal Map Space</strong> drop-down.. |
| <strong>Bent Normal Map OS</strong>          | Assign a Texture that defines the bent normal map for this Material in object space. HDRP uses bent normal maps to simulate more accurate ambient occlusion. Note: Bent normal maps only work with diffuse lighting.<br />This property only appears when you select <strong>ObjectSpace</strong> from the <strong>Normal Map Space</strong> drop-down. |
| <strong>Height Map</strong>                  | Assign a Texture that defines the heightmap for this Material. Unity uses this map to blend this layer. |
| <strong>- Parametrization</strong>           | Use the drop-down to select the parametrization method for the to use for the <strong>Height Map</strong>.<br />&#8226; <strong>Min/Max</strong>: HDRP compares the <strong>Min</strong> and <strong>Max</strong> value to calculate the peak, trough, and base position of the heightmap. If the <strong>Min</strong> is -1 and the <strong>Max</strong> is 3, then the base is at the Texture value 0.25. This uses the full range of the heightmap.<br />&#8226; <strong>Amplitude</strong>: Allows you to manually set the amplitude and base position of the heightmap. This uses the full range of the heightmap. In this mode, <strong>Amplitude</strong> sets the range of values and <strong>Base</strong> defines how far through the range the zero value (base) is. For example, if <strong>Amplitude</strong> is 100 and <strong>Base</strong> is 0.5 (the default value), the minimum value is -50 and the maximum value if 50. If you then set <strong>Base</strong> to 0, the minimum value becomes 0 and the maximum value becomes 100. |
| <strong>- Min</strong>                       | Set the minimum value in the <strong>Height Map</strong>.<br/>This property only appears if you set <strong>Parametrization</strong> to <strong>Min/Max</strong>. |
| <strong>- Max</strong>                       | Set the maximum value in the <strong>Height Map</strong>.<br/>This property only appears if you set <strong>Parametrization</strong> to <strong>Min/Max</strong>. |
| <strong>- Offset</strong>                    | Set the offset that HDRP applies to the <strong>Height Map</strong>.      |
| <strong>- Amplitude</strong>                 | Set the amplitude of the <strong>Height Map</strong>. This is the range of values the height map represents.<br/>This property only appears if you set <strong>Parametrization</strong> to <strong>Amplitude</strong>. |
| <strong>- Base</strong>                      | Use the slider to set the base for the <strong>Height Map</strong>. This is the value of the level 0 in the height map. If you set this to 0.5 and set <strong>Amplitude</strong> to 100, the minimum value is -50 and the maximum value is 50.<br/>This property only appears if you set <strong>Parametrization</strong> to <strong>Amplitude</strong>. |
| <strong>Diffusion Profile</strong>                 | Assign a <a href="Diffusion-Profile.md">Diffusion Profile</a> to drive the behavior of subsurface scattering. To quickly view the currently selected Diffusion Profile’s Inspector, double click the Diffusion Profile Asset in the assign field. If you do not assign a Diffusion Profile, HDRP does not process the subsurface scattering.<br />This property only appears when you select <strong>Subsurface Scattering</strong> or <strong>Translucent</strong> from the <strong>Material Type</strong> drop-down. |
| <strong>Subsurface Mask Map</strong>               | Assign a grayscale Texture, with values from 0 to 1, that controls the strength of the blur effect across the Material. A texel with a value of 1 corresponds to full strength, while those with a value of 0 disables the Subsurface Scattering blur effect.<br />This property only appears when you select <strong>Subsurface Scattering</strong> from the <strong>Material Type</strong> drop-down. |
| <strong>Subsurface Mask</strong>                   | Use the slider to set the strength of the screen-space blur effect. If you set a <strong>Subsurface Mask Map</strong>, this acts as a multiplier for that map. If you do not set a Subsurface Mask Map, this increases the entire subsurface scattering effect on this Material.<br />This property only appears when you select <strong>Subsurface Scattering</strong> from the <strong>Material Type</strong> drop-down. |
| <strong>Transmission Mask Map</strong>             | Assign a grayscale Texture, with values from 0 to 1, that controls the strength of transmitted light across the Material. A texel with a value of 1 corresponds to full strength, while those with a value of 0 disables the Transmission effect.<br />This property only appears when <strong>Material Type</strong> is set to <strong>Translucent</strong> or if it is set to <strong>Subsurface Scattering</strong> and <strong>translucent</strong> option is enabled. |
| <strong>Transmission Mask</strong>                 | Use the slider to set the strength of the transmission effect. If you set a <strong>Transmission Mask Map</strong>, this acts as a multiplier for that map.<br />This property only appears when <strong>Material Type</strong> is set to <strong>Translucent</strong> or if it is set to <strong>Subsurface Scattering</strong> and <strong>translucent</strong> option is enabled. |
| <strong>Thickness Map</strong>/<strong>Thickness</strong>       | Assign a grayscale Texture, with values from 0 to 1, that correspond to the average thickness of the Mesh at the location of the texel. Higher values mean thicker areas, and thicker areas transmit less light. If you do not assign a Texture to this property, the name is <strong>Thickness</strong> and the slider controls the global thickness of the Mesh.<br />This property only appears when you select <strong>Subsurface Scattering</strong> or <strong>Translucent</strong> from the <strong>Material Type</strong> drop-down. |
| <strong>Thickness Remapping</strong>               | Use the slider to set the strength of the transmission effect. Multiplies the Thickness Map.<br />This property only appears when you select <strong>Subsurface Scattering</strong> or <strong>Translucent</strong> from the <strong>Material Type</strong> drop-down. |
| <strong>Base UV Mapping</strong>             | Use the drop-down to select the type of UV mapping that HDRP uses to map Textures to this Material’s surface.<br />&#8226; Unity manages four UV channels for a vertex: <strong>UV0</strong>, <strong>UV1</strong>, <strong>UV2</strong>, and <strong>UV3</strong>.<br />&#8226; <strong>Planar:</strong> A planar projection from top to bottom.<br />&#8226; <strong>Triplanar</strong>: A planar projection in three directions:X-axis: Left to rightY-axis: Top to bottomZ-axis: Front to back Unity blends these three projections together to produce the final result. |
| <strong>Tiling</strong>                      | Set an <strong>X</strong> and <strong>Y</strong> UV tile rate for all of the Textures in the <strong>Surface Inputs</strong> section. HDRP uses the <strong>X</strong> and <strong>Y</strong> values to tile these Textures across the Material’s surface, in object space. |
| <strong>Offset</strong>                      | Set an <strong>X</strong> and <strong>Y</strong> UV offset for all of the Textures in the <strong>Surface Inputs</strong> section. HDRP uses the <strong>X</strong> and <strong>Y</strong> values to offset these Textures across the Material’s surface, in object. |


#### Detail Inputs

[!include[](detail-inputs.md)]