/* FNA - XNA4 Reimplementation for Desktop Platforms
 * Copyright 2009-2024 Ethan Lee and the MonoGame Team
 *
 * Released under the Microsoft Public License.
 * See LICENSE for details.
 */

/* Derived from code by the Mono.Xna Team (Copyright 2006).
 * Released under the MIT License. See monoxna.LICENSE for details.
 */
#include <mono/metadata/appdomain.h>
#include <mono/mini/jit.h>

#include "../lib/FNA3D/include/FNA3D.h"
#include "../lib/FNA3D/include/FNA3D_Image.h"
#include "../lib/FNA3D/include/FNA3D_SysRenderer.h"

extern void** mono_aot_module_FNA_info;

void VMLFNARegister()
{
    mono_aot_register_module(mono_aot_module_FNA_info);

    /* FNA3D */
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_HookLogFunctions", FNA3D_HookLogFunctions);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_PrepareWindowAttributes", FNA3D_PrepareWindowAttributes);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_GetDrawableSize", FNA3D_GetDrawableSize);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_CreateDevice", FNA3D_CreateDevice);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_DestroyDevice", FNA3D_DestroyDevice);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_SwapBuffers", FNA3D_SwapBuffers);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_SwapBuffers", FNA3D_SwapBuffers);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_SwapBuffers", FNA3D_SwapBuffers);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_SwapBuffers", FNA3D_SwapBuffers);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_Clear", FNA3D_Clear);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_DrawIndexedPrimitives", FNA3D_DrawIndexedPrimitives);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_DrawInstancedPrimitives", FNA3D_DrawInstancedPrimitives);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_DrawPrimitives", FNA3D_DrawPrimitives);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_SetViewport", FNA3D_SetViewport);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_SetScissorRect", FNA3D_SetScissorRect);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_GetBlendFactor", FNA3D_GetBlendFactor);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_SetBlendFactor", FNA3D_SetBlendFactor);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_GetMultiSampleMask", FNA3D_GetMultiSampleMask);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_SetMultiSampleMask", FNA3D_SetMultiSampleMask);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_GetReferenceStencil", FNA3D_GetReferenceStencil);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_SetReferenceStencil", FNA3D_SetReferenceStencil);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_SetBlendState", FNA3D_SetBlendState);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_SetDepthStencilState", FNA3D_SetDepthStencilState);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_ApplyRasterizerState", FNA3D_ApplyRasterizerState);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_VerifySampler", FNA3D_VerifySampler);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_VerifyVertexSampler", FNA3D_VerifyVertexSampler);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_ApplyVertexBufferBindings", FNA3D_ApplyVertexBufferBindings);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_SetRenderTargets", FNA3D_SetRenderTargets);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_SetRenderTargets", FNA3D_SetRenderTargets);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_ResolveTarget", FNA3D_ResolveTarget);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_ResetBackbuffer", FNA3D_ResetBackbuffer);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_ReadBackbuffer", FNA3D_ReadBackbuffer);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_GetBackbufferSize", FNA3D_GetBackbufferSize);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_GetBackbufferSurfaceFormat", FNA3D_GetBackbufferSurfaceFormat);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_GetBackbufferDepthFormat", FNA3D_GetBackbufferDepthFormat);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_GetBackbufferMultiSampleCount", FNA3D_GetBackbufferMultiSampleCount);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_CreateTexture2D", FNA3D_CreateTexture2D);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_CreateTexture3D", FNA3D_CreateTexture3D);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_CreateTextureCube", FNA3D_CreateTextureCube);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_AddDisposeTexture", FNA3D_AddDisposeTexture);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_SetTextureData2D", FNA3D_SetTextureData2D);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_SetTextureData3D", FNA3D_SetTextureData3D);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_SetTextureDataCube", FNA3D_SetTextureDataCube);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_SetTextureDataYUV", FNA3D_SetTextureDataYUV);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_GetTextureData2D", FNA3D_GetTextureData2D);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_GetTextureData3D", FNA3D_GetTextureData3D);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_GetTextureDataCube", FNA3D_GetTextureDataCube);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_GenColorRenderbuffer", FNA3D_GenColorRenderbuffer);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_GenDepthStencilRenderbuffer", FNA3D_GenDepthStencilRenderbuffer);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_AddDisposeRenderbuffer", FNA3D_AddDisposeRenderbuffer);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_GenVertexBuffer", FNA3D_GenVertexBuffer);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_AddDisposeVertexBuffer", FNA3D_AddDisposeVertexBuffer);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_SetVertexBufferData", FNA3D_SetVertexBufferData);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_GetVertexBufferData", FNA3D_GetVertexBufferData);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_GenIndexBuffer", FNA3D_GenIndexBuffer);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_AddDisposeIndexBuffer", FNA3D_AddDisposeIndexBuffer);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_SetIndexBufferData", FNA3D_SetIndexBufferData);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_GetIndexBufferData", FNA3D_GetIndexBufferData);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_CreateEffect", FNA3D_CreateEffect);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_CloneEffect", FNA3D_CloneEffect);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_AddDisposeEffect", FNA3D_AddDisposeEffect);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_SetEffectTechnique", FNA3D_SetEffectTechnique);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_ApplyEffect", FNA3D_ApplyEffect);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_BeginPassRestore", FNA3D_BeginPassRestore);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_EndPassRestore", FNA3D_EndPassRestore);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_CreateQuery", FNA3D_CreateQuery);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_AddDisposeQuery", FNA3D_AddDisposeQuery);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_QueryBegin", FNA3D_QueryBegin);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_QueryEnd", FNA3D_QueryEnd);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_QueryComplete", FNA3D_QueryComplete);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_QueryPixelCount", FNA3D_QueryPixelCount);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_SupportsDXT1", FNA3D_SupportsDXT1);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_SupportsS3TC", FNA3D_SupportsS3TC);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_SupportsBC7", FNA3D_SupportsBC7);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_SupportsHardwareInstancing", FNA3D_SupportsHardwareInstancing);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_SupportsNoOverwrite", FNA3D_SupportsNoOverwrite);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_SupportsSRGBRenderTargets", FNA3D_SupportsSRGBRenderTargets);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_GetMaxTextureSlots", FNA3D_GetMaxTextureSlots);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_GetMaxMultiSampleCount", FNA3D_GetMaxMultiSampleCount);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_SetStringMarker", FNA3D_SetStringMarker);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_SetTextureName", FNA3D_SetTextureName);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_Image_Load", FNA3D_Image_Load);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_Image_Free", FNA3D_Image_Free);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_Image_SavePNG", FNA3D_Image_SavePNG);
    mono_add_internal_call("Microsoft.Xna.Framework.Graphics.FNA3D::FNA3D_Image_SaveJPG", FNA3D_Image_SaveJPG);
}