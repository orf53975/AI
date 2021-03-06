﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace PointOfInterestSkill
{
    public interface IServiceManager
    {
        IGeoSpatialService InitMapsService(string key, string locale = "en-us");
    }
}
