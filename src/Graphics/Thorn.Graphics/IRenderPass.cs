using System.Drawing;
using System.Numerics;

namespace Thorn.Graphics;

public interface IRenderPass
{
	void Clear();

	void SetColor(Color color);
	void SetBackgroundColor(Color color);
	
	void Arc(FillMode fillMode, Vector2 position, int radius, int beginAngle, int endAngle, int segments = 10);
	void Circle(FillMode fillMode, Vector2 position, int radius, int segments = 10);
	void Ellipse(FillMode fillMode, Vector2 position, Vector2 radii, int segments = 10);
	void Line(params Vector2[] points);
	void Points(params Vector2[] points);
	void Polygon(FillMode fillMode, params Vector2[] points);
	void Rectangle(FillMode fillMode, Vector2 position, Vector2 size);
	void Text(string text, Vector2 position);
	void Draw(IDrawable drawable);

	void SubPass(Action<IRenderPass> subPassFunc);
}