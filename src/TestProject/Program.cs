using System.Drawing;
using System.Numerics;
using Silk.NET.Windowing;
using Thorn.Graphics;
using Thorns.Graphics.OpenGL;

var options = WindowOptions.Default;
var window = Window.Create(options);

IRenderContext renderContext = null;
ITexture? texture = null;

window.Load += () =>
{
	renderContext = new RenderContext(window);
	texture = renderContext.NewTexture();
};

window.Render += (double dt) =>
{
	renderContext.SetColor(Color.Red);
	renderContext.Draw(texture);
	
	renderContext.SubPass(renderPass =>
	{
		renderPass.SetColor(Color.Blue);
		renderPass.Circle(FillMode.Fill, new Vector2(100, 100), 10);
	});
};

window.Run();

