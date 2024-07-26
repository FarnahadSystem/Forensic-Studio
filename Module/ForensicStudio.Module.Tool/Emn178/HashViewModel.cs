﻿using ForensicStudio.Module.Core.General;
using ForensicStudio.Service.Core.Container;

namespace ForensicStudio.Module.Tool.Emn178;

public class HashViewModel : GeneralViewModel
{
    protected HashViewModel(IContainerService containerService)
        : base(containerService)
    {
    }

    public override void Dispose()
    {
    }
}