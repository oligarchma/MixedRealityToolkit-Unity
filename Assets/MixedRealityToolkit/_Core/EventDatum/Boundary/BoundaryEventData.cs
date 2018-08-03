﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Microsoft.MixedReality.Toolkit.Internal.Interfaces.BoundarySystem;
using UnityEngine.EventSystems;

namespace Microsoft.MixedReality.Toolkit.Internal.EventDatum.Boundary
{
    /// <summary>
    /// Describes a boundary event.
    /// </summary>
    public class BoundaryEventData : GenericBaseEventData
    {
        /// <summary>
        /// The new state of the Boundary systems platform rendering.
        /// </summary>
        public bool IsPlatformRenderingEnabled { get; private set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="eventSystem"></param>
        public BoundaryEventData(EventSystem eventSystem) : base(eventSystem) { }

        public void Initialize(IMixedRealityBoundarySystem boundarySystem, bool isPlatformRenderingEnabled)
        {
            base.BaseInitialize(boundarySystem);
            IsPlatformRenderingEnabled = isPlatformRenderingEnabled;
        }
    }
}
