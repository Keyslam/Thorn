using System.Drawing;
using System.Numerics;
using Silk.NET.Core.Contexts;
using Silk.NET.OpenGL;
using Thorn.Graphics;

namespace Thorns.Graphics.OpenGL;

public class RenderPass : IRenderPass
{
	private GL _gl;
	
	public RenderPass(IGLContextSource window)
	{
		_gl = window.CreateOpenGL();
	}

	public void Clear()
	{
		throw new NotImplementedException();
	}

	public void SetColor(Color color)
	{
		throw new NotImplementedException();
	}

	public void SetBackgroundColor(Color color)
	{
		throw new NotImplementedException();
	}

	public void Arc(FillMode fillMode, Vector2 position, int radius, int beginAngle, int endAngle, int segments = 10)
	{
		throw new NotImplementedException();
	}

	public void Circle(FillMode fillMode, Vector2 position, int radius, int segments = 10)
	{
		throw new NotImplementedException();
	}

	public void Ellipse(FillMode fillMode, Vector2 position, Vector2 radii, int segments = 10)
	{
		throw new NotImplementedException();
	}

	public void Line(params Vector2[] points)
	{
		throw new NotImplementedException();
	}

	public void Points(params Vector2[] points)
	{
		throw new NotImplementedException();
	}

	public void Polygon(FillMode fillMode, params Vector2[] points)
	{
		throw new NotImplementedException();
	}

	public void Rectangle(FillMode fillMode, Vector2 position, Vector2 size)
	{
		throw new NotImplementedException();
	}

	public void Text(string text, Vector2 position)
	{
		throw new NotImplementedException();
	}

	public void Draw(IDrawable drawable)
	{
		throw new NotImplementedException();
	}

	public void SubPass(Action<IRenderPass> subPassFunc)
	{
		throw new NotImplementedException();
	}
}