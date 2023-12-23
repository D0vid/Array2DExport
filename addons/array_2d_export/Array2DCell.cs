#if TOOLS
using Godot;

namespace Array2DExport.addons.array_2d_export;

[Tool]
public partial class Array2DCell : SpinBox
{
	[Signal]
	public delegate void CellValueChangedEventHandler(Vector2I cell, int value);

	private Vector2I _cell;
	
	public Array2DCell() {} // Add this or random crash i guess ?
	
	public Array2DCell(int x, int y)
	{
		_cell = new Vector2I(x, y);
		SizeFlagsHorizontal = SizeFlags.ShrinkCenter | SizeFlags.Expand;
		SizeFlagsVertical = SizeFlags.ShrinkCenter;
		GetLineEdit().AddThemeConstantOverride("minimum_character_width", 1);
		AddThemeIconOverride("updown", new ImageTexture());
		ValueChanged += OnCellValueChanged;
	}

	private void OnCellValueChanged(double value)
	{
		EmitSignal(SignalName.CellValueChanged, _cell, (int)value);
	}
}
#endif