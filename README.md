# Silk.NET.EGL

[EGL](https://registry.khronos.org/EGL/) bindings for C#, plus prebuilt
[ANGLE](https://chromium.googlesource.com/angle/angle/) binaries to run them on.

EGL is the Khronos API that sits below OpenGL and OpenGL ES: it creates contexts and surfaces
(window, pbuffer, or headless) independently of any windowing toolkit. It is the practical route to
offscreen rendering, and the only portable way to get a GL/GLES context on Linux or Android without
going through a windowing library.

These packages are companions to [Silk.NET](https://github.com/dotnet/Silk.NET) 2.x and target the
same frameworks, so they can be referenced alongside `Silk.NET.OpenGL`, `Silk.NET.OpenGLES` and
friends.

## Packages

| Package | Contents |
|---|---|
| `Silk.NET.EGL` | Core EGL bindings (`EGL.GetApi()`, enums, overloads) |
| `Silk.NET.EGL.Extensions.*` | One package per extension vendor: `EXT`, `NV`, `KHR`, `ANDROID`, `ANGLE`, `ARM`, `HI`, `IMG`, `MESA`, `NOK`, `QNX`, `TIZEN`, `WL` |
| `Silk.NET.OpenGLES.ANGLE.Native` | Prebuilt ANGLE `libEGL` / `libGLESv2` for `win-x64`, `win-x86`, `linux-x64` and `osx` (universal, x86_64 + arm64) |

## Usage

```csharp
using Silk.NET.EGL;

using var egl = EGL.GetApi();

// Extensions resolve through eglGetProcAddress.
if (egl.TryGetExtension<KhrDebug>(out var debug))
{
    // ...
}
```

`Silk.NET.EGL` resolves `libEGL.so.1` on Linux and Android, `libEGL.dll` on Windows, and the
`EGL.framework` path on macOS. To use the bundled ANGLE build instead of a system EGL, reference
`Silk.NET.OpenGLES.ANGLE.Native` — its targets copy the right binaries next to your application, and
ANGLE's `libEGL` is what gets loaded.

Note that ANGLE, like EGL itself, has no macOS system framework; the `osx` binaries are a
self-contained ANGLE build and are what you want on that platform.

## Repository layout

```
src/Silk.NET.EGL/         Core bindings (generated + hand-written)
src/Extensions/           One project per extension vendor
native/                   ANGLE native package and its committed binaries
build/                    Type maps, generator cache, licence header
tools/SilkGenerate/       Runs Silk.NET.BuildTools over generator.json
build/nuke/               NUKE build: the `Angle` target
```

## Regenerating the bindings

The `*.gen.cs` files are generated from the Khronos EGL registry by
[Silk.NET.BuildTools](https://www.nuget.org/packages/Silk.NET.BuildTools), which is consumed as an
ordinary NuGet package — there is no copy of it in this repository.

```bash
dotnet run --project tools/SilkGenerate -- generator.json            # everything
dotnet run --project tools/SilkGenerate -- generator.json --profile=EGL
```

At build time the generated sources are compiled by
[Silk.NET.SilkTouch](https://www.nuget.org/packages/Silk.NET.SilkTouch), which implements the
`partial` methods. Its options live in `.editorconfig` at the repository root.

Files that are **not** generated — `src/Silk.NET.EGL/EGL.cs`, `PfnDebugProcKhr.cs`,
`PfnGetBlobFuncANDROID.cs`, `PfnSetBlobFuncANDROID.cs` and `ClientPixmapHI.cs` — are deliberately
not named `*.gen.cs`, because the generator deletes stale files that match that pattern.

## Building the ANGLE binaries

ANGLE is fetched and built from source by the `Angle` NUKE target, which needs no checkout of ANGLE:

```bash
./build.sh Angle        # Linux / macOS
./build.cmd Angle       # Windows
```

Each platform builds what it can: Windows produces x64 and x86, Linux produces x64, and macOS builds
both architectures and merges them into a universal binary with `lipo`. Results are written to
`native/Silk.NET.OpenGLES.ANGLE.Native/runtimes/<rid>/native/`, where the NuGet package picks them
up.

The `.github/workflows/angle.yml` job runs this on all three platforms and commits the binaries back
onto the branch. Locally the result is left in the working tree for inspection; set
`SILKNET_EGL_PUBLISH=1` to commit and push it from a local run too.

## Licence

The bindings are MIT, matching Silk.NET — see [LICENSE.md](LICENSE.md). The ANGLE binaries in
`Silk.NET.OpenGLES.ANGLE.Native` are BSD-3-Clause, as ANGLE is.
