using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;

namespace IncursionHelper
{
    public class IncursionHelperSettings : ISettings
    {
        public ToggleNode Enable { get; set; } = new(false);
    }
}