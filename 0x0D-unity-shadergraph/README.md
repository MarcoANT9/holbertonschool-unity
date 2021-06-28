# 0x0D. Unity - ShaderGraph

## Tasks:

#### 0. Glow up
Create a new project called 0x0D-unity-shadergraph. In the Package Manager, enable the Universal Render Pipeline. Create a new Universal Render Pipeline Asset and drop it into your project’s Graphics settings. This will enable you to utilize ShaderGraph.

Create a material and shader that makes an untextured 3D GameObject glow around the edges.

You must be able to change the following properties of the shader in the Inspector window:

* Base color
* Glow color
* Glow strength

![Image1](C:\Users\MarcoA\Downloads)

#### 1. Pulse
Based on the previous shader, create a new shader where the glow pulses / fades in and out.

You must be able to change the following properties of the shader in the Inspector window:

* Base color
* Glow color
* Minimum glow strength
* Maximum glow strength
* Pulse frequency

![Image2](https://holbertonintranet.s3.amazonaws.com/uploads/medias/2019/4/356a192b7913b04c5457.gif?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIARDDGGGOUWMNL5ANN%2F20210626%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20210626T013615Z&X-Amz-Expires=86400&X-Amz-SignedHeaders=host&X-Amz-Signature=e70b85c9150e2ad24873cbd3eaa87758e61abd6dd658e93025b48e6915e477f2)

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
