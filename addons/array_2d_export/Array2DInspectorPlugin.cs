#if TOOLS
using Godot;

namespace Array2DExport.addons.array_2d_export;

public partial class Array2DInspectorPlugin : EditorInspectorPlugin
{
    public override bool _CanHandle(GodotObject @object) => true;

    public override bool _ParseProperty(GodotObject @object, Variant.Type type, string name, PropertyHint hintType, string hintString,
        PropertyUsageFlags usageFlags, bool wide)
    {
        if (type == Variant.Type.Array && name.Contains("Array2D"))
        {
            AddPropertyEditor(name, new Array2DEditor());
            return true;
        }
        return false;
    }
}
#endif