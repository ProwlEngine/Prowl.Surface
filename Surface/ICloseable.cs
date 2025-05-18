using System;

namespace Prowl.Surface;

public interface ICloseable
{
    event EventHandler? Closed;
}
