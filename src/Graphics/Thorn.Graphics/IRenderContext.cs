namespace Thorn.Graphics;

public interface IRenderContext : IRenderPass
{
	ITexture NewTexture();
}