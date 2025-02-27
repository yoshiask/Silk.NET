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
    [NativeName("Name", "VkPipelineCreationFeedbackCreateInfoEXT")]
    public unsafe partial struct PipelineCreationFeedbackCreateInfoEXT : IExtendsChain<GraphicsPipelineCreateInfo>, IExtendsChain<ComputePipelineCreateInfo>, IExtendsChain<RayTracingPipelineCreateInfoNV>, IExtendsChain<RayTracingPipelineCreateInfoKHR>
    {
        public PipelineCreationFeedbackCreateInfoEXT
        (
            StructureType? sType = StructureType.PipelineCreationFeedbackCreateInfoExt,
            void* pNext = null,
            PipelineCreationFeedbackEXT* pPipelineCreationFeedback = null,
            uint? pipelineStageCreationFeedbackCount = null,
            PipelineCreationFeedbackEXT* pPipelineStageCreationFeedbacks = null
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

            if (pPipelineCreationFeedback is not null)
            {
                PPipelineCreationFeedback = pPipelineCreationFeedback;
            }

            if (pipelineStageCreationFeedbackCount is not null)
            {
                PipelineStageCreationFeedbackCount = pipelineStageCreationFeedbackCount.Value;
            }

            if (pPipelineStageCreationFeedbacks is not null)
            {
                PPipelineStageCreationFeedbacks = pPipelineStageCreationFeedbacks;
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
        [NativeName("Type", "VkPipelineCreationFeedbackEXT*")]
        [NativeName("Type.Name", "VkPipelineCreationFeedbackEXT")]
        [NativeName("Name", "pPipelineCreationFeedback")]
        public PipelineCreationFeedbackEXT* PPipelineCreationFeedback;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pipelineStageCreationFeedbackCount")]
        public uint PipelineStageCreationFeedbackCount;
/// <summary></summary>
        [NativeName("Type", "VkPipelineCreationFeedbackEXT*")]
        [NativeName("Type.Name", "VkPipelineCreationFeedbackEXT")]
        [NativeName("Name", "pPipelineStageCreationFeedbacks")]
        public PipelineCreationFeedbackEXT* PPipelineStageCreationFeedbacks;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineCreationFeedbackCreateInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
