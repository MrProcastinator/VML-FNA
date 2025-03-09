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

extern void** mono_aot_module_FNA_NoTheora_NoSong_info;
extern void VMLFNARegisterCalls();

void VMLFNARegister()
{
    mono_aot_register_module(mono_aot_module_FNA_NoTheora_NoSong_info);
    VMLFNARegisterCalls();
}