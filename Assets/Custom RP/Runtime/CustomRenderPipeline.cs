using UnityEngine;
using UnityEngine.Rendering;

public class CustomRenderPipeline :RenderPipeline {

	CameraRenderer renderer = new CameraRenderer();
	protected override void Render(
	ScriptableRenderContext context, Camera[] cameras)
	{
	
	}

}