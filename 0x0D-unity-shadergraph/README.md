# 0x0D. Unity - ShaderGraph

## Tasks:

#### 0. Glow up
Create a new project called 0x0D-unity-shadergraph. In the Package Manager, enable the Universal Render Pipeline. Create a new Universal Render Pipeline Asset and drop it into your project’s Graphics settings. This will enable you to utilize ShaderGraph.

Create a material and shader that makes an untextured 3D GameObject glow around the edges.

You must be able to change the following properties of the shader in the Inspector window:

* Base color
* Glow color
* Glow strength

#### 1. Pulse
Based on the previous shader, create a new shader where the glow pulses / fades in and out.

You must be able to change the following properties of the shader in the Inspector window:

* Base color
* Glow color
* Minimum glow strength
* Maximum glow strength
* Pulse frequency


#### 2. Mr. Stark, I don't feel so good
Create a shader that simulates a disintegrating or dissolving effect.

You must be able to change the following properties of the shader in the Inspector window:

* Base color
* Disintegration / dissolving speed
* Scale of disintegrating fragments

#### 3. Iceman
Create a shader that makes an object look like ice. The object should be partially transparent.

You must be able to change the following properties of the shader in the Inspector window:

* Base color

#### 4. Hey Cortana, what's UV positioning? 
Create a shader that applies a flickering hologram effect to an object. You must use a Texture in this shader.

You must be able to change the following properties of the shader in the Inspector window:

* Base color
* Texture

#### 5. Sine of the sea
Create an animated shader that simulates the appearance of water.

You must be able to change the following properties of the shader in the Inspector window:

* Color(s)
* Wave size
* Wave frequency

#### 6. Same day delivery 
Export all your shaders into an Asset Package.

Your package hierarchy should look like this:

* Materials
    * glow.mat
    * glow_animated.mat
    * etc.
* Shaders
    * glow.shader
    * glow_animated.shader
    * etc.
* Textures
    * <Texture Files>
