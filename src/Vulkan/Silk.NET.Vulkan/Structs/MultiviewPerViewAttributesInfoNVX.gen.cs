// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkMultiviewPerViewAttributesInfoNVX")]
    public unsafe partial struct MultiviewPerViewAttributesInfoNVX : IExtendsChain<CommandBufferInheritanceInfo>, IExtendsChain<GraphicsPipelineCreateInfo>, IExtendsChain<RenderingInfoKHR>
    {
        public MultiviewPerViewAttributesInfoNVX
        (
            StructureType? sType = StructureType.MultiviewPerViewAttributesInfoNvx,
            void* pNext = null,
            Bool32? perViewAttributes = null,
            Bool32? perViewAttributesPositionXOnly = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (perViewAttributes is not null)
            {
                PerViewAttributes = perViewAttributes.Value;
            }

            if (perViewAttributesPositionXOnly is not null)
            {
                PerViewAttributesPositionXOnly = perViewAttributesPositionXOnly.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "perViewAttributes")]
        public Bool32 PerViewAttributes;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "perViewAttributesPositionXOnly")]
        public Bool32 PerViewAttributesPositionXOnly;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.MultiviewPerViewAttributesInfoNvx;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
