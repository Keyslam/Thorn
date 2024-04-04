using Silk.NET.Core.Contexts;
using Silk.NET.OpenGL;
using Thorn.Graphics;

namespace Thorns.Graphics.OpenGL;

public class RenderContext : RenderPass, IRenderContext
{
	private GL _gl;
	
	public RenderContext(IGLContextSource window)
	{
		_gl = window.CreateOpenGL();
	}

	public ITexture NewTexture()
	{
		throw new NotImplementedException();
	}
}