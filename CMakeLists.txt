cmake_minimum_required(VERSION 3.0)

set(CMAKE_MODULE_PATH ${CMAKE_SOURCE_DIR}/cmake)

include(VMLBuild)

if(NOT DEFINED CMAKE_TOOLCHAIN_FILE)
  if(DEFINED ENV{VITASDK})
    set(CMAKE_TOOLCHAIN_FILE "$ENV{VITASDK}/share/vita.toolchain.cmake" CACHE PATH "toolchain file")
  else()
    message(FATAL_ERROR "Please define VITASDK to point to your SDK path!")
  endif()
endif()

project(FNA)

include("${VITASDK}/share/vita.cmake" REQUIRED)

set(USE_XNA_ABI CACHE BOOL "Compile XNA compatibility assemblies")

set(CMAKE_C_FLAGS "${CMAKE_C_FLAGS} -g -marm -mtune=cortex-a9 -mfpu=neon -Wno-incompatible-pointer-types -Wno-stringop-overflow -Wno-deprecated-declarations -Wl,-q -O3 -Wall")

add_custom_target(FNADependencies)

compile_mono_external_import(
    ASSEMBLY SDL2.dll
    TARGET FNADependencies
)

compile_mono_external_import(
    ASSEMBLY SDL2_image.dll
    TARGET FNADependencies
)

compile_mono_external_import(
    ASSEMBLY SDL2_mixer.dll
    TARGET FNADependencies
)

compile_mono_external_import(
    ASSEMBLY FAudio-CS.dll
    TARGET FNADependencies
)

compile_mono_external_import(
    ASSEMBLY Theorafile.dll
    TARGET FNADependencies
)

add_subdirectory(src)

if(USE_XNA_ABI)
    add_subdirectory(abi)
endif()