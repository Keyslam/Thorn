using Silk.NET.Core.Contexts;
using Thorn.Graphics;

namespace Thorns.Graphics.OpenGL;

public class RenderContext : RenderPass, IRenderContext
{
	public RenderContext(IGLContextSource window) : base(window)
	{
	}

	public ITexture NewTexture()
	{
		throw new NotImplementedException();
	}
}